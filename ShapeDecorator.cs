public abstract class ShapeDecorator : IShape
{
    public IShape Shape;

    public ShapeDecorator(IShape shape)
    {
        this.Shape = shape;
    }

    public virtual void draw()
    {
        Shape.draw();
    }
}