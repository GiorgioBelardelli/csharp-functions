using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //1
            void StampaVirgola()
            {
                Console.Write(", ");
            }

            int[] ArrayNumeri = [1, 2, 3, 4];

            void StampaArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"elemento {array[i]}");
                    if (i < array.Length - 1)
                        StampaVirgola();
                }
                Console.Write("]");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }

            StampaArray(ArrayNumeri);






            //2
            int Quadrato(int numero)
            {
                numero *= numero;
                return numero;
            }

            int NumeroAlQuadrato = Quadrato(20);
            Console.WriteLine(NumeroAlQuadrato);
            Console.WriteLine(" ");
            Console.WriteLine(" ");








            //3
            int[] ArrayNumeri2 = { 5, 6, 7 };

            void ModificaArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] *= array[i];
            }


            int[] ClonaArray(int[] numeri)
            {
                int[] ArrayClone = new int[numeri.Length];
                for (int i = 0; i < numeri.Length; i++)
                    ArrayClone[i] = numeri[i];

                return ArrayClone;
            }

            int[] ArrayNumeri3 = ArrayNumeri2;
            int[] ArrayNumeri4 = ClonaArray(ArrayNumeri3);

            ModificaArray(ArrayNumeri4);
            StampaArray(ArrayNumeri);









            //PROVA
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                foreach (var elemento in array)
                {
                    int numero = elemento;
                    numero *= numero;
                }

                return array;
            }

            int[] ArrayAlQuadrato = ElevaArrayAlQuadrato(ArrayNumeri2);

            StampaArray(ArrayAlQuadrato);
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            //4
            int SommaElementiArray(int[] array)
            {
                int somma = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    somma += array[i];
                }
                return somma;
            }

            int ArraySommato = SommaElementiArray(ArrayNumeri);
            Console.WriteLine(ArraySommato);
            Console.WriteLine(" ");
            Console.WriteLine(" ");







            //5

            int[] Array = [2, 6, 7, 5, 3, 9];
            StampaArray(Array);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //6
            int[] ArrayClone = ClonaArray(Array);
            ModificaArray(ArrayClone);
            StampaArray(Array);
            StampaArray(ArrayClone);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //7
            int SommaArray = SommaElementiArray(Array);
            Console.WriteLine(SommaArray);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //8
            int SommaArrayAlQuadrato = SommaElementiArray(ArrayClone);
            Console.WriteLine(SommaArrayAlQuadrato);
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            //**BONUS:** 
            //Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi **di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
            //A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.

            int UserInput;

            Console.WriteLine("Inserisci un numero di elementi di un array su cui vuoi lavorare: ");

            while (int.TryParse(Console.ReadLine(), out UserInput) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci numero");
            }
            UserInput = Convert.ToInt32(Console.ReadLine());
            int[] UserArray = new int[UserInput];

            Console.WriteLine("Adesso inserisci il primo numero:");
            for (int i = 0; i < UserInput; i++)
            {
                while (int.TryParse(Console.ReadLine(), out UserInput) == false)
                {
                    Console.WriteLine("Sintassi errata. Inserisci numero");
                }

                Console.WriteLine("Continua: ");

                UserArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ecco l'Array: ");
            StampaArray(UserArray);
            Console.WriteLine("-----");
            int[] UserArrayClone = ClonaArray(UserArray);
            ModificaArray(UserArrayClone);
            Console.WriteLine("Ecco l'Array elevato al quadrato: ");
            StampaArray(UserArrayClone);
            Console.WriteLine("-----");
            int SommaArrayUser = SommaElementiArray(UserArray);
            Console.WriteLine("Ecco la somma degli elementi dell'array: ");
            Console.WriteLine(SommaArrayUser);
            Console.WriteLine("-----");
            int SommaUserArrayClone = SommaElementiArray(UserArrayClone);
            Console.WriteLine(SommaUserArrayClone);
            Console.WriteLine("-----");











        }
    }
}
