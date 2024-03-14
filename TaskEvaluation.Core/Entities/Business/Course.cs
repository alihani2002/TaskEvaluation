using TaskEvaluation.Web.Common;

namespace TaskEvaluation.Web.Models
{
    public class Course : BaseModel
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
        public ICollection<Group> Groups { get; set; }


    }
}
