using static System.Math;

namespace ExamplesOOP
{
    class Square
    {
        private double sideLenght = 0;
        private double area;
        private double perimeter;

        public Square() { }

        public Square(double sideLenght)
        {
            this.sideLenght = sideLenght;
            CalculateArea();
            CalculatePerimeter();
        }

        public double CalculateArea()
        {
            return area = Round(area = sideLenght * sideLenght, 3);
        }

        public double CalculatePerimeter()
        {
            return perimeter = Round(sideLenght * 4, 3);
        }

    }
}
