using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//.NET kollekciók halmaza

namespace Tamas_2022._09._13//névtér: alapesetben tartalmazza a project nevét.
{
    internal class Program//osztály
    {
        static void Main(string[] args)//Főprogram: csak az fut le, amit ide írok!
        {
            //Egysoros megjegyzés

            //Többsoros megjegyzés
            /*
             * 
             * 
             * Készítette: Varga Zoltán
             * 
             * 
             * 
             */
            //Egyszerű típusok
            int szam = 15;//Egész szám
            int szam3 = 30;
            float szam1 = 14.21f;//Egyszeres lebegőpontos szám (Valós szám)
            double szam2 = 123.12;//Dupla lebegőpontos, valós szam.
            int osszeg = szam + szam3;
            int szorzata = szam * szam3;
            int kulonbseg = szam - szam3;
            double hanyadosa = szam / (double)szam3;//Típuskényszerítés, cascadolás
            double hanyadosa2 = szam / 14.0;//Az egész számot valós értékre cserélem
            float lebegopontos = 14.2f;

            Console.WriteLine("A két szám hányadosa: " + hanyadosa);
            Console.WriteLine("A két szám hányadosa: " + hanyadosa2);

            //Karaktertípus
            char karakter = 'a';

            //Szöveges típus
            string szam5 = "12345";
            string szoveg = "alma";
            string szoveg2 = "fa";
            string osszefuz = szoveg + szoveg2;
            int hossz = szam5.Length;
            char[] karaktertomb = szam5.ToCharArray();
            Console.WriteLine(szoveg.Replace('a', 'e')+"\n"+osszefuz + " " + karaktertomb[2]);

            //Logikai
            //Két értéket vehet fel: True, False
            bool igaz = true;
            Console.WriteLine(igaz);

            Console.ReadKey();//Megállítja a program futását. Vár egy billentyű leütésre
        }
    }
}
