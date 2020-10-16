using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave, List<Bouteille> lesBouteillesDeLaCave)
        {
            LesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            return LesCaves[unNomDeCave].Count;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            //int nb = 0;
            //foreach (Bouteille b in LesCaves[unNomDeCave])
            //{
            //    if (b.LeVin.LaCouleur.NomCouleur.CompareTo("Rouge") == 0)
            //    {
                    //nb++;
            //    }
            //}
            //return nb;

            return LesCaves[unNomDeCave].FindAll(b => b.LeVin.LaCouleur.NomCouleur.CompareTo("Rouge") == 0).Count;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            double prix = 0;
            foreach (Bouteille b in LesCaves[unNomDeCave])
            {
                prix += b.QuantiteBouteille * b.LeVin.PrixDuVin;
            }
            return prix;

            // faut tester une autre arnaque que celle d'au dessus
        }
    }
}
