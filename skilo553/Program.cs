using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skilo553
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 23, 7, 98, 12, 56 };

            Console.WriteLine("Напишите слово для эха");
            var modif = Console.ReadLine();
            int deep = modif.Length;
            Console.WriteLine(modif);

            Echo(modif, deep);
             Console.WriteLine("Введите чилсо для возведения вв степень ");
            var n = int.Parse(Console.ReadLine());
            int count = n;
            Console.WriteLine(n * PowerUp(n,ref count));
            //SortArray( array);
            Console.ReadKey();
            
        }
        static void Echo(string saidword, int deep)
        {
            if (saidword.Length > 2) { 
            saidword = saidword.Remove(0, 2);
            deep = saidword.Length; }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..."+ saidword );
            if (deep > 2 )
                Echo(saidword, deep);
           
        }
        static int PowerUp(int N,ref int count)
        {
            
            count--;
            if (count == 1)
                return N;
             
            return N * PowerUp(N ,ref count);
        }
        //static void SortArray( in int[] array,out int[] sorteddesc,out int[] sortedasc)
        //{
        //    sorteddesc = SortArrayDesc(array);
        //    sortedasc = SortArrayAsc(array);
        //    foreach(int i in sorteddesc)
        //        Console.WriteLine(i);
        //    foreach(int i in sortedasc) Console.WriteLine(i);
        //}
        //static int[] SortArrayDesc(int [] sortarray)
        //{
        //    int[] sorteddesc = new int [sortarray.Length];
        //    for (int i = 0; i < sortarray.Length; i++)
        //        sorteddesc[i] = sortarray[i];


        //    int count;
        //    for (int i = 0; i < sorteddesc.Length; i++)
        //        for (int j = i + 1; j < sorteddesc.Length; j++)
        //        {
        //            if (sorteddesc[i] > sorteddesc[j])
        //            {
        //                count = sorteddesc[j];
        //                sorteddesc[j] = sorteddesc[i];
        //                sorteddesc[i] = count;
        //            }



        //        }
        //    return sorteddesc;

        //}

        //static int[] SortArrayAsc(int [] sortarray)
        //{
        //    int[] sortedasc = new int[sortarray.Length];
        //    for (int i = 0; i < sortarray.Length; i++)
        //        sortedasc[i] = sortarray[i];
        //    int count;
        //    //for(int k =  0; k < sortedasc.Length; k++)
        //    for (int i = sortedasc.Length-1; i >= 0; i--)
        //        for (int j = i-1; j >= 0; j--)
        //        {
        //            if (sortedasc[i]  > sortedasc[j])
        //            {
        //                count = sortedasc[j];
        //                sortedasc[j] = sortedasc[i];
        //                sortedasc[i] = count;
        //            }



        //        }
        //    return sortedasc;
        //}
    }
}
 