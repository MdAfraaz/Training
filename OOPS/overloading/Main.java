class Test{
  public void methodOne (String s){
    System.out.println ("String version");
  }
  public void methodOne (StringBuffer s){
    System.out.println ("StringBuffer version");
  }
}

public class Main{
  public static void main (String[]args){
      Test t = new Test ();
      t.methodOne ("arun");	
      t.methodOne (new StringBuffer ("sai"));
      t.methodOne (null);
  }
}
