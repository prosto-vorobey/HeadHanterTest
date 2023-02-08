namespace HeadHanterTestLibrary
{
    public class NoTypeShape
    {
        List <double> sside = new List<double>();
        public NoTypeShape( List<double> side)
        {
            for (int i = 0; i < side.Count; i++)
            {
                sside.Add(side[i]);
            }
        }
        public double GetArea()
        {
            Shape sh;
            switch (sside.Count)
            {
                case 1:
                    sh = new Circle(sside);
                    return sh.GetArea();
                case 3:
                    sh = new Triangle(sside);
                    return sh.GetArea();
                default:
                    return 0;
            }
        }
    }
}
