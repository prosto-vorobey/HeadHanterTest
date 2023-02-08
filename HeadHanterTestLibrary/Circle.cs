namespace HeadHanterTestLibrary
{
    public class Circle : Shape //Наследуемый класс круг
    {
        List<double> sside = new List<double>();
        public Circle(List<double> side)
        {
            sside.Add(side[0]);
        }
        public override double GetArea() //Расширяем родительский абстрактный метод
        {
            double per = sside[0];
            double ar = 3.1415926535 * Math.Pow(per, 2); //Формула подсчёта площади круга
            return ar; //Возвращаем искомое значение
        }
    }
}
