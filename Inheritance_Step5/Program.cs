using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Step5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Father father = new Father();
            father.GetlastName();
            Boy boy = new Boy();
            boy.GetEyeColor();
        }
    }
    class Grandpa
    {
        public string lastName;
        public string EyeColor;
    }
    class Father : Grandpa
    {
        public void GetlastName()
        {
            lastName = "Seza";
            Console.WriteLine(lastName);
        }
    }
    class Boy : Grandpa
    {
        public void GetEyeColor()
        {
            EyeColor = "Green";
            Console.WriteLine(EyeColor);
        }
    }
}
