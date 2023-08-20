namespace MonopolyProject.Classes
{
    /// <summary>
    /// Класс для создания таблицы Pallet с помощью CodeFirst
    /// </summary>
    public class Pallet
    {
        //ID
        public int Id { get; set; }

        //Ширина
        public int Width { get; set; }

        //Высота
        public int Height { get; set; }

        //Глубина
        public int Depth { get; set; }

        //Вес
        public int Weight { get; set; }

        //Объем
        public int Volume { get; set; }

        //Срок годности
        public DateTime ExpirationDate { get; set; }

        public List<Box>? Boxes { get; set; }   
    }
}
