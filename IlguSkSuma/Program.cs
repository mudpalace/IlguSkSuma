using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlguSkSuma
{
    static class Toolboxas
    {
          public static string Papildinys2(int kiek)
          {
              return "0";
          }

      }

    class Pasalinis
    {
        public void Darbas()
        {
            //p1 ir p2 objektai
			Program p1 = new Program();
            Program p2 = new Program();
            
			p1.PaprastaFja();

            Toolboxas.Papildinys2(1);
            Program.Papildinys(1);
        }
    }

    class Program
    {
        public void PaprastaFja()
        {

        }

        //Kodel cia aprasyta funkcija butinai turi buti static, kad ja pasiekti?
        public static string Papildinys(int kiek)
        {
            string papildinys = "";

            for (int i1 = 0; i1 < kiek; i1++)
            {
                papildinys += "0";
            }

            return papildinys;
        }


        //**** MAIN ****
        public static void Main(string[] args)
        {
            //Pasalinis p1 = new Pasalinis();
            //p1.Darbas();

            int skKiekis, xx = 0, maxilgis = 0;
            string[,] array;
            string eilute;


            if (System.IO.File.Exists("duomenysin.txt"))
            {
                //Console.WriteLine("Yra");

                System.IO.StreamReader file = new System.IO.StreamReader("duomenysin.txt"); // kam @ pries failo varda?

                //nuskaito kiek skaiciu reiks sudet
                skKiekis = Convert.ToInt16(file.ReadLine());

                //pagal skaiciu kieki sukuria masyva
                array = new string[skKiekis, 2];

                while ((eilute = file.ReadLine()) != null)
                {
                    // skaiciaus ilgio reiksme iraso i pirma lastele 
                    array[xx, 0] = eilute.Substring(0, eilute.IndexOf(' '));

                    // iesko ilgiausio skaiciaus ilgio ir priskiria ji maxilgis
                    if (Convert.ToInt16(array[xx, 0]) > maxilgis) maxilgis = Convert.ToInt16(array[xx, 0]);

                    //iraso i masyvo antra lastele skaiciaus reiksme
                    array[xx, 1] = eilute.Substring(eilute.IndexOf(' ') + 1);
                    xx++;
                }

                //papildo visas skaiciu eilutes nuliais, kad jos butu vienodo ilgio
                for (int i = 0; i < skKiekis; i++)
                {
                    //nuskaito skaiciaus ilgi
                    int kiek = Convert.ToInt16(array[i, 0]);

                    if (maxilgis > kiek)
                    {
                        array[i, 1] = Papildinys(maxilgis - kiek) + array[i, 1];

                    }
                }
                //****************

                //Praeina per masyvus ir sudeda po viena elementa
                string rezultatas = "";
                int suma, minty = 0, lieka;

                for (int a2 = maxilgis - 1; a2 > -1; a2--)
                {
                    suma = 0;

                    for (int aa2 = 0; aa2 < skKiekis; aa2++)
                    {
                        suma += Convert.ToInt16(array[aa2, 1].Substring(a2, 1));
                    }

                    lieka = (suma + minty) % 10; //paskutinis skaicius
                    minty = (minty + suma) / 10; // kas lieka minty
                    rezultatas = lieka.ToString() + rezultatas;
                }
                Console.WriteLine(rezultatas);

            }

            Console.ReadLine();
        }

    }
}
