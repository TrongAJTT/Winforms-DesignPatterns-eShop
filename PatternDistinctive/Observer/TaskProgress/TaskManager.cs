using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace _3S_eShop.Utilities
{
    // Lớp này được hiểu như một Interface ngầm định cho Subject.
    public class TaskManager : IDisposable
    {
        private readonly List<TaskInfo> _tasks = new List<TaskInfo>();
        private readonly object _lock = new object(); 
        // For thread safety if tasks are manipulated from multiple threads
        private System.Timers.Timer _progressTimer;
        private int _currentOverallProgress = 0;
        private TaskInfo _currentlyRunningTask = null;
        private int _timerTickProgressTarget = 0; 
        // Progress target for the timer tick within the current task

        // --- Observer Pattern Events ---
        // Use Action delegates for simplicity, could define custom EventArgs if needed
        public event Action<TaskInfo> TaskAdded;            
        // Thông báo khi task được thêm (để UI cập nhật ListView ban đầu)
        public event Action<TaskInfo> TaskStatusChanged;    
        // Thông báo khi trạng thái task thay đổi
        public event Action<int> ProgressUpdated;           
        // Thông báo khi % tổng thể thay đổi
        public event Action<int, string> LogAdded;          
        // Thông báo khi có log mới0
        public event Action AllTasksCompleted;              
        // Thông báo khi tất cả tasks hoàn thành

        public string ProgressTaskName { get; set; }

        public TaskManager(string taskName = "")
        {
            _progressTimer = new Timer(1000); // 1 giây interval
            _progressTimer.Elapsed += ProgressTimer_Tick;
            _progressTimer.AutoReset = true;
            _progressTimer.Enabled = false; // Start disabled
            ProgressTaskName = taskName;
        }

        public void RegisterTask(int id, string name)
        {
            lock (_lock)
            {
                if (_tasks.Any(t => t.Id == id))
                {
                    // Optional: Handle duplicate ID error
                    Console.WriteLine($"Warning: Task with ID {id} already registered.");
                    return;
                }
                var newTask = new TaskInfo(id, name);
                _tasks.Add(newTask);
                RecalculateTaskPercentages();
                OnTaskAdded(newTask); // Notify observers about the new task
            }
        }

        private void RecalculateTaskPercentages()
        {
            if (!_tasks.Any()) return;

            int taskCount = _tasks.Count;
            int basePercentagePerTask = 100 / taskCount;
            int remainder = 100 % taskCount;
            int currentStart = 0;

            for (int i = 0; i < taskCount; i++)
            {
                _tasks[i].StartPercentage = currentStart;
                int taskShare = basePercentagePerTask + (i < remainder ? 1 : 0); // Distribute remainder
                _tasks[i].EndPercentage = currentStart + taskShare;
                currentStart = _tasks[i].EndPercentage;
                // Ensure the last task ends exactly at 100
                if (i == taskCount - 1)
                {
                    _tasks[i].EndPercentage = 100;
                }
            }
        }

        public void StartTask(int id)
        {
            lock (_lock)
            {
                var taskToStart = _tasks.FirstOrDefault(t => t.Id == id);
                if (taskToStart != null && taskToStart.Status == TaskStatus.Waiting)
                {
                    // Stop previous task's timer progress if any was running implicitly
                    _progressTimer.Stop();
                    // Ensure previous task's progress visually completed if needed (optional, handled by CompleteTask normally)
                    // CompleteTask(taskToStart.Id) should ideally be called before starting the next one.
                    // However, if we jump, we need to set the progress correctly.
                    if (_currentlyRunningTask != null)
                    {
                        // Jump progress to the end of the *previous* task before starting new one
                        SetOverallProgress(_currentlyRunningTask.EndPercentage);
                    }
                    else
                    {
                        // If it's the very first task starting
                        SetOverallProgress(taskToStart.StartPercentage);
                    }


                    taskToStart.Status = TaskStatus.Running;
                    _currentlyRunningTask = taskToStart;
                    _timerTickProgressTarget = taskToStart.EndPercentage; // Target for timer ticks

                    // Start the timer only if the task hasn't reached its end % yet
                    if (_currentOverallProgress < _timerTickProgressTarget)
                    {
                        _progressTimer.Start();
                    }

                    OnTaskStatusChanged(taskToStart); // Notify UI
                    // No immediate progress update here, timer will handle incremental, or completion will jump.
                }
                // Optional: Handle cases where task not found or already running/completed
            }
        }

        public void CompleteTask(int id)
        {
            lock (_lock)
            {
                var taskToComplete = _tasks.FirstOrDefault(t => t.Id == id);
                if (taskToComplete != null && taskToComplete.Status == TaskStatus.Running)
                {
                    _progressTimer.Stop(); // Stop timer increments for this task
                    taskToComplete.Status = TaskStatus.Completed;

                    // Jump progress to the exact end percentage for this task
                    SetOverallProgress(taskToComplete.EndPercentage);

                    OnTaskStatusChanged(taskToComplete); // Notify UI about status change AFTER setting progress

                    _currentlyRunningTask = null; // No task is actively running for the timer

                    // Check if all tasks are completed
                    if (_tasks.All(t => t.Status == TaskStatus.Completed))
                    {
                        SetOverallProgress(100); // Ensure it's exactly 100
                        OnAllTasksCompleted();   // Notify UI
                    }
                }
                // Optional: Handle cases where task not found or not running
                // or already completed
            }
        }

        public void AddLog(int taskId, string message)
        {
            // No lock needed if just raising event, unless accessing shared task data
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            string prefix = task != null ? $"[Task {task.Id} - {task.Name}]: " : $"[Task {taskId}]: ";
            OnLogAdded(taskId, prefix + message); // Notify UI
        }

        private void ProgressTimer_Tick(object sender, ElapsedEventArgs e)
        {
            lock (_lock) // Lock needed as timer runs on a separate thread pool thread
            {
                if (_currentlyRunningTask != null && _currentlyRunningTask.Status == TaskStatus.Running)
                {
                    // Increment progress, but don't exceed the *target for the timer tick*
                    // which is one less than the task's EndPercentage. The final jump happens on CompleteTask.
                    int nextProgress = _currentOverallProgress + 1;
                    int tickTarget = _currentlyRunningTask.EndPercentage; // The absolute ceiling for this task

                    // Don't let timer go OVER the task's final percentage
                    if (nextProgress < tickTarget)
                    {
                        SetOverallProgress(nextProgress);
                    }
                    else
                    {
                        // Reached the max for this task via timer, stop ticking until CompleteTask is called
                        _progressTimer.Stop();
                        // Optional: Set progress exactly to tickTarget - 1? Or just stop.
                        // Setting it exactly might feel smoother if CompleteTask is delayed.
                        // SetOverallProgress(tickTarget - 1); // Or keep current progress
                    }
                }
                else
                {
                    // Should not happen if timer is managed correctly, but stop just in case
                    _progressTimer.Stop();
                }
            }
        }

        private void SetOverallProgress(int value)
        {
            // Ensure progress doesn't go backward or exceed 100
            value = Math.Max(0, Math.Min(100, value));
            // Only update and notify if the value actually changes
            if (_currentOverallProgress != value)
            {
                _currentOverallProgress = value;
                OnProgressUpdated(_currentOverallProgress); // Notify UI
            }
        }

        // --- Event Invoker Methods (Best practice to wrap event invocations) ---
        protected virtual void OnTaskAdded(TaskInfo task)
        {
            TaskAdded?.Invoke(task);
        }

        protected virtual void OnTaskStatusChanged(TaskInfo task)
        {
            TaskStatusChanged?.Invoke(task);
        }

        protected virtual void OnProgressUpdated(int progress)
        {
            ProgressUpdated?.Invoke(progress);
        }

        protected virtual void OnLogAdded(int taskId, string message)
        {
            LogAdded?.Invoke(taskId, message);
        }

        protected virtual void OnAllTasksCompleted()
        {
            AllTasksCompleted?.Invoke();
        }

        // --- IDisposable Implementation ---
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_progressTimer != null)
                {
                    _progressTimer.Stop();
                    _progressTimer.Elapsed -= ProgressTimer_Tick;
                    _progressTimer.Dispose();
                    _progressTimer = null;
                }
                // Release other managed resources if any
            }
            // Release unmanaged resources if any
        }

        ~TaskManager() // Finalizer
        {
            Dispose(false);
        }
    }

}
