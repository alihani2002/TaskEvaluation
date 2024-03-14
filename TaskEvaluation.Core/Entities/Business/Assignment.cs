using TaskEvaluation.Web.Common;

namespace TaskEvaluation.Web.Models
{
    public class Assignment : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; }
        public Solution Solution { get; set; }


    }
}
