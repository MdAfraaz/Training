using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Approver{
    protected Approver successor;
    public void SetSuccessor(Approver successor){
        this.successor = successor;
    }
    public abstract void ProcessRequest(Project Project);
}


//ConcreteHandler  class 
class Manager : Approver{
    public override void ProcessRequest(Project Project){
        if (Project.Amount < 10000.0){
            Console.WriteLine("{0} approved request# {1}",
            this.GetType().Name, Project.Number);
        }
        else if (successor != null){
            successor.ProcessRequest(Project);
        }
    }
}

class President : Approver{
    public override void ProcessRequest(Project Project){
        if (Project.Amount < 25000.0){
            Console.WriteLine("{0} approved request# {1}",
            this.GetType().Name, Project.Number);
        }
        else if (successor != null){
            successor.ProcessRequest(Project);
        }
    }
}

class CEO1 : Approver{
    public override void ProcessRequest(Project Project){
        if (Project.Amount < 100000.0){
            Console.WriteLine("{0} approved request# {1}",
            this.GetType().Name, Project.Number);
        }
        else{
            Console.WriteLine(
            "Request# {0} requires an executive meeting!",
            Project.Number);
        }
    }
}

class Project{
    private int _number;
    private double _amount;
    private string _purpose;

    // Constructor 
    public Project(int number, double amount, string purpose){
        this._number = number;
        this._amount = amount;
        this._purpose = purpose;
    }
    public int Number{
        get { return _number; }
        set { _number = value; }
    }
    public double Amount{
        get { return _amount; }
        set { _amount = value; }
    }
    public string Purpose{
        get { return _purpose; }
        set { _purpose = value; }
    }
}


public class Program{
    public static void Main(String[] args){
        Approver Sameer = new President();
        Approver Abhi = new CEO1();
        Approver Rahul = new Manager();

        Rahul.SetSuccessor(Sameer);
        Sameer.SetSuccessor(Abhi);

        Project p = new Project(3333, 350.00, "Test Postponed");
        Rahul.ProcessRequest(p);
        p = new Project(5353, 32590.10, "Annual Function");
        Rahul.ProcessRequest(p);
        p = new Project(2036, 122100.00, "Renovation of Classes");
        Rahul.ProcessRequest(p);
        Console.ReadKey();
    }
}