namespace _3S_eShop.Utilities
{
    public enum TaskStatus
    {
        Waiting,    // Đang chờ
        Running,    // Đang hoạt động
        Completed   // Đã hoàn thành
    }

    // Helper extension method to get display names (optional but nice)
    public static class TaskStatusExtensions
    {
        public static string ToFriendlyString(this TaskStatus status)
        {
            switch (status)
            {
                case TaskStatus.Waiting: return "Đang chờ";
                case TaskStatus.Running: return "Đang hoạt động";
                case TaskStatus.Completed: return "Đã hoàn thành";
                default: return status.ToString();
            }
        }
    }

}
