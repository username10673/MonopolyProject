namespace MonopolyProject.Classes
{
    public class Pallet
    {
        public int Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Depth { get; set; }

        public int Weight { get; set; }

        public int Volume { get; set; }

        public DateTime ExpirationDate { get; set; }

        public List<Box>? Boxes { get; set; }   
    }
}
