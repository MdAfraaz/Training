class Parent {
public static void methodOne() {
System.out.println("parent class");
}
}
class Child extends Parent{ public static void
methodOne(){
System.out.println("child class");
}
}
class Main{
public static void main(String[] args) {
Parent p=new Parent();
p.methodOne();//parent class 
Child c=new Child();
c.methodOne();//child 
Parent p1=new Child();
p1.methodOne();//parent class
}
}
