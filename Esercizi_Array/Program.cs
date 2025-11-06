using System.Xml.Schema;

namespace Esercizi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esercizio 1

            int[] numContrario = {4,7,8,2,9};
            
            for (int i = numContrario.Length-1; i >= 0;  i--)
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

            //esercizio 6
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
        }
}
