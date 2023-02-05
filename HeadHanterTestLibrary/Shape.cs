namespace HeadHanterTestLibrary
{
    public abstract class Shape //Объявляем абстрактный родительский класс фигур
    {
        public abstract double GetArea(params double[] side); //Объявляем абстрактный метод подсчёта площади по изменяемому количеству передаваемых параметров
    }

}