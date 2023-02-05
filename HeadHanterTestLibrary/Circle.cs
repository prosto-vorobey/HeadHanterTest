namespace HeadHanterTestLibrary
{
    public class Circle : Shape //Наследуемый класс круг
    {
        public Circle()
        {
        }
        public override double GetArea(params double[] side) //Расширяем родительский абстрактный метод
        {
            double per = side[0];
            double ar = 3.1415926535 * Math.Pow(per, 2); //Формула подсчёта площади круга
            return ar; //Возвращаем искомое значение
        }
    }
}
