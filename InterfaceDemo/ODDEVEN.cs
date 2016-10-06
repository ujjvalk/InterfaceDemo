using System;

namespace InterfaceDemo
{
    interface IOne
    {
        void One();
    }

    interface ITwo
    {
        void Two();
    }
    interface IThree : IOne
    {
        void Three();
    }
    interface IFour : ITwo
    {
        void Four();
    }
    interface IFive : IThree
    {
        void Five();
    }
    interface IEVEN : ITwo, IFour
    {
        void Even();
    }
    interface IODD:IFive
    {
      void Odd();
    }

    public class ODDEVEN : IEVEN, IODD
{
        public void Even()
        {
            Console.WriteLine("\n\nThis is Even.\n");
            var j = new ODDEVEN();
            j.Two();
            j.Four();
        }

        public void Five()
        {
            Console.WriteLine("This is five.");
        }

        public void Four()
        {
            Console.WriteLine("This is four.");
        }

        public void Odd()
        {
            Console.WriteLine("This is Odd.\n");
        }

        public void One()
        {
            Console.WriteLine("This is One.");
        }

        public void Three()
        {
            Console.WriteLine("This is Three.");
        }

        public void Two()
        {
            Console.WriteLine("This is Two.");
        }
    }
}
