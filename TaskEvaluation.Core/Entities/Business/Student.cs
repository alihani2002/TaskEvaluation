using TaskEvaluation.Web.Common;

namespace TaskEvaluation.Web.Models
{
    public class Student : BaseModel
    {
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string ProfilePic { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Solution> Solutions { get; set; }


    }
}
