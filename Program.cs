
namespace Rectangle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int longueur, largeur;
            Console.WriteLine("Programme Rectangle");

            Console.WriteLine("Saisir longueur : ");
            longueur = int.Parse(Console.ReadLine() ?? "1");

            Console.WriteLine("Saisir largeur : ");
            largeur = int.Parse(Console.ReadLine() ?? "1");

            Rectangle rectangle = new Rectangle(longueur, largeur);

            Console.WriteLine("La longueur est: {0}", rectangle.Longueur);
            Console.WriteLine("La largeur est: {0}", rectangle.Largeur);
            Console.WriteLine("Le périmètre calculé est: {0}", rectangle.Perimetre());
            Console.WriteLine("L'aire calculée est: {0}", rectangle.Aire());
            Console.WriteLine("Le rectangle est un carré: {0}", rectangle.EstCarre() ? "Vrai" : "Faux");

            rectangle.AfficherRectangle();

            Console.Read();
        }
    }
}