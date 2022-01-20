abstract class Parent
{
Parent()
{
System.out.println("Parent"+this.hashCode());

}
}
class Child extends Parent
{
Child()
{
System.out.println("Child"+this.hashCode());
}}
class Main
{
public static void main(String[] args)
{
Child c=new Child();
System.out.println(c.hashCode());
}
}