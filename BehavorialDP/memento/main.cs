using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Person1
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        MomentoPerson objMPerson = null;
        public Person1()
        {
            Name = "ABC";
            Surname = "DEF";
            objMPerson = new MomentoPerson(Name, Surname);
        }
        public void Update(String name, string Surname)
        {
            this.Name = name;
            this.Surname = Surname;
        }
        public void Revert()
        {
            Name = objMPerson.Name;
            Surname = objMPerson.Surname;
        }
    }
    public class MomentoPerson
    {
        public String Name { get; set; }
        public string Surname { get; set; }
        public MomentoPerson(String Name, String Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
    }

class Program {
  static void Main() {
        Person1 person1 = new Person1();
        person1.Update("Mohammed", "Afraaz");
        Console.WriteLine(person1.Name+ " "+person1.Surname);
        person1.Revert();
        Console.WriteLine(person1.Name+" "+person1.Surname);
  }
}