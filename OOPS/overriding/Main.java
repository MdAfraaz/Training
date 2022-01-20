class Parent{
  public void method1 (){
    System.out.println ("first method");
  } 
  public void method2 (){
    System.out.println ("second method");
  } 
} 

class Child extends Parent{			
  public void method2 (){
    System.out.println ("new method 2");
  } 
} 

class Main{
    public static void main (String[]args){
        Parent p = new Parent ();
        p.method2 ();	
        
        Child c = new Child ();
        c.method2 ();		
        
        Parent p1 = new Child ();
        p1.method2 ();		
    } 
} 
