interface Shape{
    void draw();
}
class Circle implements Shape{
    @Override
    public void draw(){
        System.out.println("Circle drawn");
    }
}
class Square implements Shape{
    @Override
    public void draw(){
        System.out.println("Square drawn");
    }
}
class Factory{
    public Shape createShape(String shapeType){
        switch (shapeType) {
            case "Circle": return (new Circle());
            case "Square": return (new Square());
            default: throw new IllegalArgumentException("Shape type unknown");
        }
    }
}
public class Main
{
	public static void main(String[] args) {
		Factory shapeFactory = new Factory();
		shapeFactory.createShape("Circle").draw();
	}
}
