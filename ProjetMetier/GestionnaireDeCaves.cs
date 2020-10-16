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

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            // A vous de jouer
            LesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            // A vous de jouer
            int nbBouteilles = 0;
            foreach(Bouteille bou in lesCaves[unNomDeCave])
            {
                nbBouteilles = nbBouteilles + 1;
            }
            
            return nbBouteilles;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            // A vous de jouer
            return 0;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            // A vous de jouer
            return 0;
        }
    }
}
