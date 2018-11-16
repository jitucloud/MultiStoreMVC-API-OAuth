using System.ComponentModel.DataAnnotations;

namespace demo.tt.domain.jobs.model
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobLocation { get; set; }
        public int AssigneeId { get; set; }

    }
}
