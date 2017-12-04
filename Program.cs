using System;

namespace Shape_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(new Circle());
            IShape redRectangle = new RedShapeDecorator(new Rectangle());

            circle.draw();
            redCircle.draw();
            redRectangle.draw();
        }
    }
}
