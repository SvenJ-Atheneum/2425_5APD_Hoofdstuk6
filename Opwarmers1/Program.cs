namespace Opwarmers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printSom();
            posEnNegGetallen();
            posEnNegGetallenEind();

        }

        private static void posEnNegGetallenEind()
        {
            Console.WriteLine("Geef een getal. Stop bij -32678.");
            int getal = Convert.ToInt32(Console.ReadLine());
            int pos = 0;
            int neg = 0;
            int nul = 0;
            while (getal != -32768)
            {
                if (getal > 0) { pos++; }
                else if (getal <0) { neg++; }
                else { nul++; }
                getal = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Er zijn {pos} positieve getallen, {neg} negatieve getallen en {nul} keer 0 ingegeven.");
        }

        private static void posEnNegGetallen()
        {
            Console.WriteLine("Geef een getal. Stop bij 0.");
            int getal = Convert.ToInt32(Console.ReadLine());
            int pos = 0;
            int neg = 0;
            while (getal != 0)
            {
                if (getal > 0) { pos++; }
                else { neg++; }
                getal = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Er zijn {pos} positieve getallen en {neg} negatieve getallen ingegeven.");
        }

        static void printSom() {
            Console.WriteLine("Geef een getal. Stop bij 0.");
            int getal = Convert.ToInt32(Console.ReadLine());
            int som = 0;
            while (getal != 0)
            {
                som += getal;
                getal = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("De som is " + som);
        }
    }
}
