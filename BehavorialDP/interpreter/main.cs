using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class RomanContext
    {
        public RomanContext(int input)
        {
            Input = input;
        }

        public int Input { get; set; }

        public string Output { get; set; }
    }

    public abstract class Expression
    {
        public abstract void Interpret(RomanContext value);
    }

    public class RomanOneExpression : Expression
    {
        public override void Interpret(RomanContext value)
        {
            while ((value.Input - 9) >= 0)
            {
                value.Output += "IX";

                value.Input -= 9;
            }

            while ((value.Input - 5) >= 0)
            {
                value.Output += "V";

                value.Input -= 5;
            }

            while ((value.Input - 4) >= 0)
            {
                value.Output += "IV";

                value.Input -= 4;
            }

            while ((value.Input - 3) >= 0)
            {
                value.Output += "III";

                value.Input -= 3;
            }

            while ((value.Input - 2) >= 0)
            {
                value.Output += "II";

                value.Input -= 2;
            }

            while ((value.Input - 1) >= 0)
            {
                value.Output += "I";

                value.Input -= 1;
            }
        }
    }

    public class RomanTenExpression : Expression
    {
        public override void Interpret(RomanContext value)
        {
            while ((value.Input - 90) >= 0)
            {
                value.Output += "XC";

                value.Input -= 90;
            }

            while ((value.Input - 50) >= 0)
            {
                value.Output += "L";

                value.Input -= 50;
            }

            while ((value.Input - 40) >= 0)
            {
                value.Output += "XL";

                value.Input -= 40;
            }

            while ((value.Input - 30) >= 0)
            {
                value.Output += "XXX";

                value.Input -= 30;
            }

            while ((value.Input - 20) >= 0)
            {
                value.Output += "XX";

                value.Input -= 20;
            }

            while ((value.Input - 10) >= 0)
            {
                value.Output += "X";

                value.Input -= 10;
            }
        }
    }


class Program {
  static void Main() {
        Expression[] expressions = new Expression[]
          {
             new RomanTenExpression(),
             new RomanOneExpression(),
          };

        var context = new RomanContext(100);

        foreach (var expression in expressions)
        {
            expression.Interpret(context);
        }

        Console.WriteLine(context.Output);
  }
}