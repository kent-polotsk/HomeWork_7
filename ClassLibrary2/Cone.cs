namespace ClassLibrary2
{
    public class Cone
    {
        private double radius;
        private double height;

        public Cone() { radius = 0; height = 0; }
        public Cone(double radius, double height) { this.radius = radius; this.height = height; }
        

        /// <summary>
        /// Вычисление площади основания
        /// </summary>
        /// <param name="radius радиус основания конуса"></param>
        /// <returns>Рассчитывает и выводит на консоль площадь основания конуса</returns>
        public double BottomSquare(in double radius) 
        {
            Console.WriteLine($"Площадь основания конуса: {Math.Round(Math.PI * Math.Pow(radius, 2),3)}");
            return Math.PI * Math.Pow(radius, 2) ;
        }
        /// <summary>
        /// Вычисление полной площади поверхности конуса вместе с основанием
        /// </summary>
        /// <param name="radius радиус основания конуса"></param>
        /// <param name="height высота образующей"></param>
        /// <returns>Рассчитывает и выводит на консоль полную площадь поверхности конуса вместе с основанием</returns>
        public void SideSurfaceSquare(in double radius, in double height)
        {
            Console.WriteLine($"Площадей боковой поверхности конуса: {Math.Round(Math.PI * radius * height,3)}");
            return ;
        }

        /// <summary>
        /// Вычисление площади боковой поверхности конуса
        /// </summary>
        /// <param name="radius радиус основания конуса"></param>
        /// <param name="height высота образующей"></param>
        /// <returns>Рассчитывает и выводит на консоль полную площадь поверхности конуса вместе с основанием</returns>
        public void TotalSquare(in double radius, in double height)
        {
            Console.WriteLine($"Площадь всех поверхностей конуса: {Math.Round(Math.PI * radius * (radius + height),3)}");
        }
    }
}
