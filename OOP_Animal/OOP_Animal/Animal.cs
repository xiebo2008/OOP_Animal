using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animal
{
    /// <summary>
    /// 猫鸟鱼..的父类，拥有共同的属性和方法
    /// </summary>
  public  class Animal
    {
       
        /// <summary>
        /// 生日
        /// </summary>
        private DateTime _birthday;

        public Animal() { Console.WriteLine("构造一个动物内存"); }
        /// <summary>
        /// 实例构造函数
        /// </summary>
        public Animal( DateTime birthday):this()
        {
           
            _birthday = DateTime.Now;
            
        }

        public bool Grow()
        {
            //可以增加Animal 其他技能或者属性
            return false;
        }
        public int Age
        {
            get
            {
                //时间片段
                int age = (DateTime.Now - this._birthday).Seconds;
                if (age > 10)
                {
                    Console.WriteLine("Dead..............");
                    return -1;
                     
                }
                else
                {
                   
                    return age;
                }
                
            }

            
        }
    }
}
