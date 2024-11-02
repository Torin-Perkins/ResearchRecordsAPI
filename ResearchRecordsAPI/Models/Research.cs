namespace ResearchRecordsAPI.Models
{
    public class Research
    {
        //Id, Title, Author, Description, PublishDate (DateTime)
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
