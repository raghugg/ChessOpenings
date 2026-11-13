namespace ChessOpenings.Models
{
    public class Opening
    {
        public int Id { get; set; }
        public string OpeningName { get; set; }
        public string OpeningPGN { get; set; }

        public Opening()
        {
        }
    }
}