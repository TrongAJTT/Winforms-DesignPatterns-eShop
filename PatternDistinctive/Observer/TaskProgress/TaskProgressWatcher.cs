using _3S_eShop.Utilities;
using System;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class TaskProgressWatcher: Form
    {
        private readonly TaskManager _taskManager;

        // Constructor accepting the TaskManager (Dependency Injection)
        public TaskProgressWatcher(TaskManager taskManager, bool autoExit = false)
        {
            InitializeComponent();
            _taskManager = taskManager ?? throw new ArgumentNullException(nameof(taskManager));

            // Set the form title to the task name
            lblName.Text = taskManager.ProgressTaskName;
            chkAutoExit.Checked = autoExit;

            // Subscribe to TaskManager events
            SubscribeToEvents();

            // Initial UI setup
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Configure ListView
            listViewProgress.View = View.Details;
            listViewProgress.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listViewProgress.Columns.Add("Tên tiến trình", 500, HorizontalAlignment.Left);
            listViewProgress.Columns.Add("Trạng thái", 120, HorizontalAlignment.Left);
            listViewProgress.FullRowSelect = true;
            listViewProgress.GridLines = true;

            // Initial state
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            lblPercent.Text = "0%";
            btnExit.Enabled = false; // Disabled initially
            txtLog.ReadOnly = true;
        }

        private void SubscribeToEvents()
        {
            _taskManager.TaskAdded += TaskManager_TaskAdded;
            _taskManager.TaskStatusChanged += TaskManager_TaskStatusChanged;
            _taskManager.ProgressUpdated += TaskManager_ProgressUpdated;
            _taskManager.LogAdded += TaskManager_LogAdded;
            _taskManager.AllTasksCompleted += TaskManager_AllTasksCompleted;
        }

        private void UnsubscribeFromEvents()
        {
            // IMPORTANT: Unsubscribe to prevent memory leaks when the form closes
            _taskManager.TaskAdded -= TaskManager_TaskAdded;
            _taskManager.TaskStatusChanged -= TaskManager_TaskStatusChanged;
            _taskManager.ProgressUpdated -= TaskManager_ProgressUpdated;
            _taskManager.LogAdded -= TaskManager_LogAdded;
            _taskManager.AllTasksCompleted -= TaskManager_AllTasksCompleted;
        }

        // --- Event Handlers (called by TaskManager) ---

        // Use Control.Invoke/BeginInvoke to update UI safely from potentially different threads
        // (especially needed because System.Timers.Timer callback is on a ThreadPool thread)

        private void TaskManager_TaskAdded(TaskInfo task)
        {
            listViewProgress.SafeInvoke(() => AddTaskToListView(task));
        }

        private void TaskManager_TaskStatusChanged(TaskInfo task)
        {
            // Update both ListView and potentially other UI elements based on status
            this.SafeInvoke(() => UpdateTaskInUI(task));
        }


        private void TaskManager_ProgressUpdated(int progress)
        {
            // Check one control, assume others need it too
            progressBar.SafeInvoke(() => UpdateProgressBar(progress));
        }

        private void TaskManager_LogAdded(int taskId, string message)
        {
            txtLog.SafeInvoke(() => AppendLog(message));
        }

        private void TaskManager_AllTasksCompleted()
        {
            // Ensure final progress is 100% visually
            UpdateProgressBar(100);
            if (chkAutoExit.Checked)
            {
                // Auto exit after a delay
                System.Threading.Thread.Sleep(2000);
                this.SafeInvoke(() => this.Close());
            }
            btnExit.SafeInvoke(() =>
            {
                EnableExitButton();
            });
        }

        // --- UI Update Helper Methods (executed on UI thread) ---

        private void AddTaskToListView(TaskInfo task)
        {
            var item = new ListViewItem(task.Id.ToString());
            item.SubItems.Add(task.Name);
            item.SubItems.Add(task.Status.ToFriendlyString());
            item.Tag = task.Id; // Store ID for easy lookup
            listViewProgress.Items.Add(item);
        }

        private void UpdateTaskInUI(TaskInfo task)
        {
            // Find item by Tag (ID)
            ListViewItem itemToUpdate = null;
            foreach (ListViewItem item in listViewProgress.Items)
            {
                if (item.Tag != null && (int)item.Tag == task.Id)
                {
                    itemToUpdate = item;
                    break;
                }
            }

            if (itemToUpdate != null)
            {
                // Update Status column (index 2)
                if (itemToUpdate.SubItems.Count > 2)
                    itemToUpdate.SubItems[2].Text = task.Status.ToFriendlyString();
                else // Should not happen if initialized correctly
                    itemToUpdate.SubItems.Add(task.Status.ToFriendlyString());

                // Optional: Change row color based on status?
                // switch(task.Status) { ... }
            }

            // No direct progress bar update here based *only* on status change.
            // Progress is handled by ProgressUpdated or CompleteTask jump.
        }

        public void ShowLess()
        {
            this.Size = MinimumSize;
        }

        public void ShowMore()
        {
            this.Size = MaximumSize;
        }

        public void EnableExit()
        {
            btnExit.Enabled = true;
            _taskManager.Dispose();
            if (chkAutoExit.Checked )
            {
                System.Threading.Thread.Sleep(1500);
                this.Close();
                this.Dispose();
            }
        }

        private void UpdateProgressBar(int progress)
        {
            // Clamp value just in case
            progress = Math.Max(progressBar.Minimum, Math.Min(progressBar.Maximum, progress));

            progressBar.Value = progress;
            lblPercent.Text = $"{progress}%";
        }

        private void AppendLog(string message)
        {
            if (txtLog.TextLength > 0)
            {
                txtLog.AppendText(Environment.NewLine);
            }
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}");
            txtLog.ScrollToCaret(); // Auto scroll to bottom
        }

        private void EnableExitButton()
        {
            btnExit.Enabled = true;
            _taskManager.Dispose();
        }

        // --- Form Events ---

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskProgressWatcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            // IMPORTANT: Unsubscribe and dispose the manager IF this form owns it.
            // If the manager is shared, only unsubscribe.
            UnsubscribeFromEvents();
            if (_taskManager != null)
            {
                _taskManager.Dispose();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnToggleShow_Click(object sender, EventArgs e)
        {
            Size = Size == MaximumSize ? MinimumSize : MaximumSize;
        }
    }
}