namespace TaskEvaluation.Web.Common
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsDeleted { get; set; }

    }
}
