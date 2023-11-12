using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle
    {
        /// Attributs
        private int longueur;
        private int largeur;

        /// <summary>
        /// Obtient ou définit longueur
        /// </summary>
        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        /// <summary>
        /// Obtient ou définit largeur
        /// </summary>
        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        /// <summary>
        /// Initialise un objet de type rectangle
        /// </summary>
        /// <param name="longueur"></param>
        /// <param name="largeur"></param>
        public Rectangle(int longueur, int largeur)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        /// <summary>
        /// Calcule le perimetre du rectangle
        /// </summary>
        /// <returns>Le perimetre calculé</returns>
        public int Perimetre ()
        {
            return 2*(longueur+largeur);
        }

        /// <summary>
        /// Calcule l'aire du rectangle
        /// </summary>
        /// <returns>L'aire calculée</returns>
        public int Aire()
        {
            return longueur * largeur;
        }

        /// <summary>
        /// Détermine si le rectangle est un carré
        /// </summary>
        /// <returns>true si le rectangle est un carré</returns>
        public bool EstCarre()
        {
            return longueur == largeur;
        }

        public void AfficherRectangle()
        {
            Console.WriteLine("Longueur: {0} - Largeur: {1} - Perimetre: {2} - Aire: {3} - {4}", longueur, largeur, Perimetre(), Aire(), EstCarre() ? "C'est un carré" : "Ce n'est pas un carré");
        }
    }
}
