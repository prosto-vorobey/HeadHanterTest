using System.Runtime.ConstrainedExecution;

namespace HeadHanterTestLibrary
{
    public class Triangle : Shape
    {
        public Triangle()
        {
        }
        public override double GetArea(params double[] side) //Расширяем родительский абстрактный метод
        {
            double per = 0;
            for (int i = 0; i < 3; i++)
            {
                per += side[i]; //Высчитываем периметр
            }
            double pper = per / 2; //Вычисляем полупериметр
            double ar = Math.Sqrt(pper * (pper - side[0]) * (pper - side[1]) * (pper - side[2])); //Формула подсчёта площади треугольника по сторонам и полупериметру
            return ar; //Возвращаем искомое значение
        }
        public void CheckSquareness(params double[] side) //Объявляем метод проверки треугольника на прямоугольность
        {
            double gip = side[0]; //Принимаем за потенциальную гипотенузу первую из сторон
            for (int i =1; i < 3; i++)
            {
                if (side[i] > gip) gip = side[i]; //Находим наибольшую из сторон и принимаем её за потенциальную гипотенузу
            }
            if (2 * Math.Pow(gip, 2) == Math.Pow(side[0], 2) + Math.Pow(side[1], 2) + Math.Pow(side[2], 2)) 
                Console.WriteLine("This triangle is squareness"); //Проверяем треугольник на прямоугольность по формуле и выводим сообщение, если он прямоугольный
            else Console.WriteLine("This triangle is not squareness");
        }
    }
}
