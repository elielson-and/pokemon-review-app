namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Reviewer Reviewer { get; set; } // A Review belongs to a Reviewer
        public Pokemon Pokemon { get; set; } // A Review belongs to a Pokemon

    }
}
