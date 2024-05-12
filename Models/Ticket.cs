namespace ExtendedUserApp.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public ApplicationUser UserId {get; set;}
    }
}
