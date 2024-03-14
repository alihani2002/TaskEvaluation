using TaskEvaluation.Web.Common;

namespace TaskEvaluation.Web.Models
{
    public class Solution : BaseModel
    {
        public string SolutionFile { get; set; }
        public string Notes { get; set; }
        public int? GradeId { get; set; }
        public EvaluationGrade Grade { get; set; }
        public int? StudentId { get; set; }
        public Student Student { get; set; }
        public int? AssignmentId { get; set; }
        public Assignment Assignment { get; set; }



    }
}
