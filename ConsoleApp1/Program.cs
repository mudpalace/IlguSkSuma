using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Eil
    {
        public string pavad;
        public string kodas;

    }

    class Pasalinis
    {
        public void Darbas()
        {
            //List<Eil> duom = new List<Eil>();
            //Eil e = new Eil();
            //e.kodas = 

            Pvz p1 = new Pvz();
            //p1.sk = 1;
            p1.Darbas();

            Pvz p2 = new Pvz(1);
            //p2.sk = 21;
            p2.Darbas();

            Pvz.MainFja();
        }
    }

    class Pvz
    {
        int _sk;
        private int sk
        {
            get
            {
                return _sk;
            }
            set
            {

                _sk = value;
            }
        }

        private int sk2;

        void InitValues()
        {
            sk = -1;
            sk2 = -1;
        }

        public Pvz(int _sk)
        {

            //InitValues();
            sk = _sk;
        }

        public Pvz()
        {

        }

        public void Darbas()
        {
            if (sk > 10)
                Console.WriteLine(sk * sk);

            MainFja();
            sk2 *= sk;
        }

        public static void MainFja()
        {
            Console.WriteLine("main");
        }
    }





    class Program
    {
        public static void Main(string[] args)
        {
            Pasalinis p = new Pasalinis();
            p.Darbas();
        }
    }
}
