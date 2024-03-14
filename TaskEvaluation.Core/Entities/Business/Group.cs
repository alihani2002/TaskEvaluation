using TaskEvaluation.Web.Common;

namespace TaskEvaluation.Web.Models
{
    public class Group : BaseModel
    {
        public string Title { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
