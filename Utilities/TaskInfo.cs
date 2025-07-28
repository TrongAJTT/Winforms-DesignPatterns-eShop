using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.Utilities
{
    public class TaskInfo
    {
        public int Id { get; }
        public string Name { get; }
        public TaskStatus Status { get; set; }
        public int StartPercentage { get; internal set; } // % bắt đầu (inclusive)
        public int EndPercentage { get; internal set; }   // % kết thúc (exclusive for running, inclusive for completed)

        public TaskInfo(int id, string name)
        {
            Id = id;
            Name = name;
            Status = TaskStatus.Waiting; // Mặc định là đang chờ
        }
    }


}
