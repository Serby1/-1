using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract public class Software
    {
        protected string name;
        protected string manufct;
        protected string dataSetting;
        abstract public void showInf();
        abstract public void relevance();
    }

    public class Free : Software 
    {
       
       
        public Free(string n, string m)
        {
            this.name = n;
            this.manufct = m;
        }

        public override void relevance()
        {
            Console.WriteLine("Неограниченное использование");
        }

        public override void showInf()
        {
            Console.WriteLine("{0}{1}", name, manufct);
        }

    }

    public class Shareware : Software
    {
        protected string dataUsing;
        public Shareware(string n, string m, string dataSetting, string dataUsing)
        {
            this.name = n;
            this.manufct = m;
            this.dataSetting = dataSetting;
            this.dataUsing = dataUsing;
        }
        public override void showInf()
        {
            Console.WriteLine("{0}{1}{2}{3}", name, manufct, dataSetting, dataUsing);
        }

        public override void relevance()
        {
            throw new NotImplementedException();
        }
    }
    



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
