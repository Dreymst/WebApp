using BusinessLayer;
using MonTP;
using MonTP.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Eleve> lesEleve = new List<Eleve>();
            lesEleve.Add(new Eleve());


            try
            {
                BusinessManager bm = BusinessManager.GetInstance();
                List<Eleve> eleves = bm.GetEleves();
            }
            catch(Exception ex)
            {    
                throw ex;
            }
            //Console.WriteLine("Coucou");

            /*System.Console.WriteLine("---- LISTE DES CATEGORIES -----");
            foreach (Eleve e in eleves)
            {
                System.Console.WriteLine("Eleve ID {0} : {1}", e.EleveId, e.EleveId);
            }*/
        }
    }
}
