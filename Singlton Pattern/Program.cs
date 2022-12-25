using System;

namespace Singlton_Pattern
{
    class Person
    {
      private static bool flag =false;
        private Person()
        {
        }
         public void Speak()
        {
            Console.WriteLine("Hello World");
        }
        public static Person obj()
        {
            if (flag == false) {
                flag = true;
                return new Person();            
            }
            else
            {
                return null;
            }
        }
        
           
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = Person.obj();
            p.Speak();
            Person s = Person.obj();
            s.Speak();




        }
    }
}
