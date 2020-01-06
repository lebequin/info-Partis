using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AppLib;
using PersLib;
using StubLib;
using static System.Console;


namespace InfoPartiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "XML"));

            Manager mng = new Manager(new Xml());
            mng.ChargeClass();
             
            foreach(var c in mng.LeMaster)
            {
                WriteLine(c.Categ);
            }

            WriteLine("\n******************\n");

            mng.ChargePartis();
            WriteLine("partis politiques :");
            foreach (var p in mng.LesPartis)
            {
                WriteLine(p);
            }
            WriteLine("\n******************\n");

            mng.ChargeRepublique();
            WriteLine(" Republiques :");
            foreach (var rep in mng.LesRep)
            {
                WriteLine(rep);
            }


            WriteLine("\n******************\n");
            mng.ChargeRegion();
            WriteLine(" Régions :");
            foreach (var reg in mng.LesRegions)
            {
                WriteLine(reg);
            }

            mng.ChargeDocuments();
            WriteLine("\n******************\n");
            WriteLine(" Documents :");
            foreach (var doc in mng.LesDocuments)
            {
                WriteLine(doc);
            }

        }
    }
}
