using System.Xml.Schema;

namespace Esercizi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numero al cotrario

            int[] numContrario = {4,7,8,2,9};
            
            for (int i = numContrario.Length-1; i >= 0;  i--)
            {
                Console.Write("[" + numContrario[i] + "]");
            }
           
        }
    }
}
