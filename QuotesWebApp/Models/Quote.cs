namespace QuotesWebApp.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public required string QuoteText { get; set; }

        public required string QuoteAuthor { get; set; }

        public Quote()
        {

        }

    }

    
}
