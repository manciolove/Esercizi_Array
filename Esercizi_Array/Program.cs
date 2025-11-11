using System.Xml.Schema;

namespace Esercizi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esercizio 1

            int[] numContrario = { 4, 7, 8, 2, 9 };

            for (int i = numContrario.Length - 1; i >= 0; i--)
            {
                Console.Write("[" + numContrario[i] + "]");
            }

            //esercizio 2
            int[] indiceP = { 2, 5, 8, 9, 12 };
            for (int i = 0; i < indiceP.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("[" + indiceP[i] + "]");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("----------------");

            //esercizio 3
            int[] numDisparo = { 3, 9, 4, 5, 6 };
            for (int i = 0; i < numDisparo.Length; i++)
            {
                if (numDisparo[i] % 2 != 0)
                {
                    Console.Write("[" + numDisparo[i] + "]");
                }
            }

            //esercizio 6
            int[] vet1 = { 3, 8, 6, 2, 9, 7 };
            int x = 5, min = 0, max = 0;
            for (int i = 0; i < vet1.Length; i++)
            {
                if (vet1[i] < x)
                {
                    min++;
                }
                else
                {
                    max++;
                }
            }
            int[] vet2 = new int[min];
            int[] vet3 = new int[max];
            int iMin = 0, iMax = 0;
            for (int i = 0; i < vet1.Length; i++)
            {
                if (vet1[i] < x)
                {
                    vet2[iMin] = vet1[i];
                    iMin++;
                }
                else
                {
                    vet3[iMax] = vet1[i];
                    iMax++;
                }
            }
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write("[" + vet2[i] + "]");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------");
            for (int i = 0; i < vet3.Length; i++)
            {
                Console.Write("[" + vet3[i] + "]");
            }

            //esercizio 7
            static void Main(string[] args)
            {
                int[] vet = { 1, 2, 5, 10, 7, 6, 13 };

                int a, b, cont = 0;

                Console.WriteLine("Inserisci il primo estremo");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo estremo");
                b = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < vet.Length; i++)
                {

                    if (vet[i] >= a && vet[i] <= b)
                    {

                        cont = cont + 1;

                    }

                }

                Console.WriteLine("Numeri compresi: " + cont);

                Console.WriteLine();

                // esercizio 8

                int[] vet1 = { 1, 2, 5, 10, 7, 6, 13 };

                int cont1 = 0;

                Console.WriteLine("Inserisci il primo estremo");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo estremo");
                b = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < vet1.Length; i++)
                {

                    if (vet1[i] <= a || vet1[i] >= b)
                    {

                        cont1 = cont1 + 1;

                    }

                }

                Console.WriteLine("Numeri non compresi: " + cont1);

                Console.WriteLine();

                //esercizio 9

                int[] vet3 = { 3, 8, 5, 9, 12, 1 };

                int c, d, cont2 = 0;

                Console.WriteLine("Dimmi il primo estremo del primo intervallo");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dimmi il secondo estremo del primo intervallo");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dimmi il primo estremo del secondo intervallo");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dimmi il secondo estremo del secondo intervallo");
                d = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < vet3.Length; i++)
                {

                    if (vet3[i] >= a && vet3[i] <= b || vet3[i] >= c && vet3[i] <= d)
                    {
                        cont2 = cont2 + 1;
                    }

                }

                Console.WriteLine("Numeri tra a-b oppure c-d: " + cont2);

                Console.WriteLine();

                //esercizio 10

                int[] vet4 = { 3, 8, 5, 9, 12, 1 };

                int cont3 = 0; 

                Console.WriteLine("Dimmi il primo estremo del primo intervallo");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dimmi il secondo estremo del primo intervallo");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dimmi il primo estremo del secondo intervallo");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dimmi il secondo estremo del secondo intervallo");
                d = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < vet4.Length; i++)
                {

                    if (vet3[i] >= a && vet3[i] <= b || vet3[i] >= c && vet3[i] <= d)
                    {
                    }
                    else
                    {
                        cont3 = cont3 + 1;
                    }

                }

                Console.WriteLine("Numeri non compresi tra a-b oppure c-d: " + cont3);
                
            }
        }
    }
}
