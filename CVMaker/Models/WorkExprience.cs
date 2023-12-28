namespace CVMaker.Models
{
    public class WorkExprience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
