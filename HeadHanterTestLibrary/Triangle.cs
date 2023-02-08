using System.Runtime.ConstrainedExecution;

namespace HeadHanterTestLibrary
{
    public class Triangle : Shape
    {
        List <double> sside = new List<double>();
        public Triangle(params double[] side)
        {
            for (int i = 0; i < 3; i++)
            {
                sside.Add(side[i]);
            }
        }
        public override double GetArea() //Расширяем родительский абстрактный метод
        {
            double per = 0;
            for (int i = 0; i < 3; i++)
            {
                per += sside[i]; //Высчитываем периметр
            }
            double pper = per / 2; //Вычисляем полупериметр
            double ar = Math.Sqrt(pper * (pper - sside[0]) * (pper - sside[1]) * (pper - sside[2])); //Формула подсчёта площади треугольника по сторонам и полупериметру
            return ar; //Возвращаем искомое значение
        }
        public void CheckSquareness() //Объявляем метод проверки треугольника на прямоугольность
        {
            double gip = sside[0]; //Принимаем за потенциальную гипотенузу первую из сторон
            for (int i =1; i < 3; i++)
            {
                if (sside[i] > gip) gip = sside[i]; //Находим наибольшую из сторон и принимаем её за потенциальную гипотенузу
            }
            if (2 * Math.Pow(gip, 2) == Math.Pow(sside[0], 2) + Math.Pow(sside[1], 2) + Math.Pow(sside[2], 2)) 
                Console.WriteLine("This triangle is squareness"); //Проверяем треугольник на прямоугольность по формуле и выводим сообщение, если он прямоугольный
            else Console.WriteLine("This triangle is not squareness");
        }
    }
}
