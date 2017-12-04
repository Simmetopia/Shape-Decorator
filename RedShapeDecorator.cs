using System;

public class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(IShape shape) : base(shape)
    {
    }
    public override void draw()
    {
        this.Shape.draw();
        this.setRedBorder(Shape);
    }

    private void setRedBorder(IShape shape)
    {
        Console.WriteLine("Los borders is reddosh");
    }
}