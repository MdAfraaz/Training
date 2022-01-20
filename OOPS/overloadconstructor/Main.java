class Test {
Test(double d){
System.out.println("double-argument constructor");
}
Test(int i) {
this(10.5);
System.out.println("int-argument constructor");
}
Test() {
this(10);
System.out.println("no-argument constructor");
}
}
class Main{
public static void main(String[] args) {
Test t1=new Test(); //no-argument constructor/int-argument
//constructor/double-argument constructor
Test t2=new Test(10);
//int-argument constructor/double-argument constructor
Test t3=new Test(10.5);//double-argument constructor
}
}
