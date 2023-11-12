using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle
    {
        // Attributs
        private int longueur;
        private int largeur;

        /// <summary>
        /// Obtient ou définit longueur
        /// </summary>
        public int Longueur 
        {  
            get { return longueur; } 
            set {  longueur = value; } 
        }

        /// <summary>
        /// Obtient ou définit largeur
        /// </summary>
        public int Largeur
        {
            get {  return largeur; }
            set { largeur = value; }
        }
    }
}
