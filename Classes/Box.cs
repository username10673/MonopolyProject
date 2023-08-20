namespace MonopolyProject.Classes
{
    /// <summary>
    /// Класс для создания таблицы Box с помощью CodeFirst
    /// </summary>
    public class Box
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

        //Дата произоводства
        public DateTime ManufactureDate { get; set; }

        //Внешний ключ
        public int? PalletId { get; set; }

        /// <summary>
        /// Вычисляем объем коробки
        /// - Объем коробки вычисляется как произведение ширины, высоты и глубины.
        /// </summary>
        /// <param name="Width">  Ширина  </param>
        /// <param name="Height"> Высота  </param>
        /// <param name="Depth">  Глубина </param>
        public void CalculationVolume(int Width, int Height, int Depth)
        {
            Volume = Width * Height * Depth;
        }

        /// <summary>
        /// Вычисляем срок годности
        /// - Если указана дата производства, то срок годности вычисляется из даты производства плюс 100 дней.
        /// </summary>
        /// <param name="ManufactureDate"> Срок годности </param>
        public void CalculationExpirationDate(DateTime ManufactureDate)
        {
            ExpirationDate = ManufactureDate.AddDays(100);
        }
    }
}
