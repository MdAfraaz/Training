using System;
public interface StateBase{
    void Change(Context1 context);
}

public class StateA : StateBase{
    public void Change(Context1 context){
        //Change state of context from A to B.
        context.State1 = new StateB();
        Console.WriteLine("Change state from A to B.");
    }
}

public class StateB : StateBase{
    public void Change(Context1 context){
        //Change state of context from B to C.
        context.State1 = new StateC();
        Console.WriteLine("Change state from B to C.");
    }
}

public class StateC : StateBase{
    public void Change(Context1 context){
        //Change state of context from C to A.
        context.State1 = new StateA();
        Console.WriteLine("Change state from C to A.");
    }
}

public class Context1{
    public Context1(StateBase state){
        State1 = state;
        Console.WriteLine("Create object of context class with initial State.");
    }
    public StateBase State1 { get; set; }
    public void Request1(){
        State1.Change(this);
    }
}

class Program {
    static void Main() {
        Context1 context = new Context1(new StateA());
         //Change state request from A to B.
         context.Request1();
        //Change state request from B to C.
         context.Request1();
        //Change state request from C to A.
         context.Request1();
    }
}