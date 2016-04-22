using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animal
{
    public class Cat: Animal
    {
        string _color;
        public Cat():base()
        {
            Console.WriteLine("构造一个猫的内存");
        }

        public Cat(string color)
        {
            this._color = color;
            Console.WriteLine("构造一个{0}猫",color);
        }
        public Cat(DateTime birthday) : base(birthday)
        { }
    }
}
