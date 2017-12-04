# Decorator Pattern in .NET core 2.

## Shape Implementation.

This is made with a shape interface, which has implemented classes Circle and
Rectangle. These classes are then the "concrete implementation of the IShape
Interface.

Lets say we now want to make it so our Shapes also has a color. What we want, is
a way to achieve this without making changes to the Interface or concrete
implementations.

What we do is make a new abtract class that implements the same IShape
interface. This however has some implementaion to it. It needs a IShape field.
This will hold the field of the concrete implementation it is decorating, which
it gets from its constructor. In the draw function which it implements from the
IShape interface, is only used to call the IShape field it has. See
ShapeDecorator.cs for more info.
