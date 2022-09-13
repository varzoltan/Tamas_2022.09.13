using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//.NET kollekciók halmaza

namespace Tamas_2022._09._13//névtér: alapesetben tartalmazza a project nevét.
{
    internal class Program
    {
        static void Main(string[] args)
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
            int kulonbseg = szam * szam3;
            double hanyadosa = szam / (double)szam3;//Típuskényszerítés, cascadolás
            double hanyadosa2 = szam / 14.0;   

            Console.WriteLine("A két szám hányadosa: " + hanyadosa);
            Console.WriteLine("A két szám hányadosa: " + hanyadosa2);
            
            //Karaktertípus

            Console.ReadKey();
        }
    }
}
