using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonTP;
using MonTP.Entities;

namespace MesTests
{
    [TestClass]
    public class MonTest
    {
        [TestMethod]
        public void TestAddEleve()
        {
            //ARRANGE
            Eleve newEleve = new Eleve { Nom = "DEAT", Prenom = "Vincent" };

            //ACT
            MonContexte contexte = new MonContexte();
            contexte.Eleves.Add(newEleve);//ça l'ajoute dans le contexte mais pas en base
            contexte.SaveChanges();//ça l'ajoute en base

            //ASSERT
            Eleve unEleve = contexte.Eleves.FirstOrDefault(e => e.Nom.Equals("DEAT"));
            Assert.IsTrue(unEleve.Prenom == newEleve.Prenom);

        }
    }
}
