namespace MovieManagement.Models
{
   public class Movie
    {
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public double LenghtInMin { get; set; }

    }
}