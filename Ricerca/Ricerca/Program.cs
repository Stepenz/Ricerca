namespace Ricerca
{
    internal class Program
    {
        static int[] array = { 4, 6, 2, 7, 5, 9, 12 };
        static void Main(string[] args)
        {
            int scelta;
            do
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1. Visualizzare l'array");
                Console.WriteLine("2. Ricerca un numero");
                Console.WriteLine("3. Esci");

                scelta = int.Parse(Console.ReadLine());
                
                switch (scelta)
                {
                    case 1:
                        // DONE: Visualizzazione dell'array
                        Stampa();
                        break;

                    case 2:
                        break;

                    case 3:
                        Console.WriteLine("Alla prossima volta");
                        break;

                    default:
                        Console.WriteLine("scelta non valida");
                            break;
                }
            } while (scelta < 3);
        }

        static void Stampa ()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
