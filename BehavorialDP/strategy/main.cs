using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Client1
    {
        public IStrategy Strategy { get; set; }

        public void CallAlgorithm()
        {
            Console.WriteLine(Strategy.Algorithm());
        }
    }

    public interface IStrategy
    {
        string Algorithm();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public string Algorithm()
        {
            return "Concrete Strategy A";
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public string Algorithm()
        {
            return "Concrete Strategy B";
        }
    }



class Program {
  static void Main() {
        Client1 client = new Client1();
        ConcreteStrategyA concreteStrategyA = new ConcreteStrategyA();
        ConcreteStrategyB concreteStrategyB = new ConcreteStrategyB();
        client.Strategy = concreteStrategyA;
        client.Strategy = concreteStrategyB;
        client.CallAlgorithm();
  }
}