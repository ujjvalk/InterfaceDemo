using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IODD obj1 = new ODDEVEN();
            obj1.Odd();
            obj1.One();
            obj1.Three();
            obj1.Five();

            var obj2 = new ODDEVEN();
            obj2.Even();

            //IFive notuseOdd = new ODDEVEN();
            //notuseOdd.Odd();//Error on .Odd
            Console.ReadLine();
        }
    }
}
