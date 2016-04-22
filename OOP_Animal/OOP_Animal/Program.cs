using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace OOP_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat an = new Cat( DateTime.Now);           
            Console.WriteLine("按任意键，动物开始生长");
            Console.Read(); 
            //动物生长         
            while (true)
            {
                Thread.Sleep(1000);
                an.Grow();
               Console.WriteLine("动物年龄{0}",an.Age);
                if (an.Age<0)
                    break;
            }
            //Cat cat = new Cat();
           // Cat blackCat = new Cat("Black");
            // Fish fish = new Fish();
        }
    }
}
