using TaskEvaluation.Web.Common;

namespace TaskEvaluation.Web.Models
{
    public class EvaluationGrade : BaseModel
    {
        public string Grade { get; set; }
        public Solution Solution { get; set; }

    }
}
