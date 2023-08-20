namespace MonopolyProject.Classes
{
    public class Box
    {
        public int Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Depth { get; set; }

        public int Weight { get; set; }

        public int Volume { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime ManufactureDate { get; set; }

        public int? PalletId { get; set; }   //Внешний ключ

        //public Pallet? Pallet { get; set; } //Навигационное свойство

        public void CalculationVolume(int Width, int Height, int Depth)
        {
            Volume = Width * Height * Depth;
        }

        public void CalculationExpirationDate(DateTime ManufactureDate)
        {
            ExpirationDate = ManufactureDate.AddDays(100);
        }
    }
}
