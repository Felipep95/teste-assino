using task_control_api.Enums;

namespace task_control_api.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public TimeSpan SLA { get; set; }
        public FormFile? File { get; set; }
        public ETaskStatus Status { get; set; }
    }
}
