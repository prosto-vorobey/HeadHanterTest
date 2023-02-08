namespace HeadHanterTestLibrary
{
    public abstract class Shape //Объявляем абстрактный родительский класс фигур
    {
        List <double> sside;
        public abstract double GetArea(); //Объявляем абстрактный метод подсчёта площади по изменяемому количеству передаваемых параметров
    }

}