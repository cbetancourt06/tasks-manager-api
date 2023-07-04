using System.ComponentModel;

namespace TaskManager.Models
{
    public enum Status
    {
        New = 1,
        [Description("In Progress")]
        InProgress = 2,
        Completed = 3,

    }
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }

    }
}
