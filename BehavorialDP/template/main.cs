using System;
public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }
        public abstract void Step1();

        public abstract void Step2();

        public abstract void Step3();
    }
    public class ConcreteClassA : AbstractClass
    {
        public override void Step1()
        {
            Console.WriteLine("Concrete Class A, Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Concrete Class A, Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Concrete Class A, Step 3");
        }
    }
    public class ConcreteClassB : AbstractClass
    {
        public override void Step1()
        {
            Console.WriteLine("Concrete Class B, Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Concrete Class B, Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Concrete Class B, Step 3");
        }
    }
class HelloWorld {
  static void Main() {
        AbstractClass aA = new ConcreteClassA();
        aA.TemplateMethod();
        AbstractClass aB = new ConcreteClassB();
        aB.TemplateMethod();
        // Wait for user
        Console.ReadKey();
  }
}