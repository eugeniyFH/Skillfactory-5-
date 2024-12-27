using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skill552
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var array = GetArrayFromConsole();
            Console.WriteLine("Массив нуждается в сортировке?Да или Нет");
            var count = Console.ReadLine();
            if (count == "Да")
                ShowArray(array, true);

            //int[] array = { 6, 23, 7, 98, 12, 56 };
            //Console.WriteLine("Напишите слово для эха");
            //var modif = Console.ReadLine();
            //int deep = modif.Length;
            //Console.WriteLine(modif);

            //Echo(modif, deep);
            //Console.WriteLine("Введите чилсо для возведения вв степень ");
            //var n = int.Parse(Console.ReadLine());
            //int count = n;
            //Console.WriteLine(n * PowerUp(n, ref count));
            //SortArray( array);
            //var sortedarray = SortArray(array);
        }
        //static void Echo(string saidword, int deep)
        //{
        //    if (saidword.Length > 2) {
        //        saidword = saidword.Remove(0, 2);
        //        deep = saidword.Length; }
        //    Console.BackgroundColor = (ConsoleColor)deep;
        //    Console.WriteLine("..." + saidword);
        //    if (deep > 2)
        //        Echo(saidword, deep);

        //}
        //static int PowerUp(int N, ref int count)
        //{

        //    count--;
        //    if (count == 1)
        //        return N;

        //    return N * PowerUp(N, ref count);
        //}
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


        static int [] GetArrayFromConsole (int num = 10)
        {
            //Console.WriteLine("Введите количество цифр");
            //int smurf = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите цифру");
                array[i] = int.Parse(Console.ReadLine());
            }
           foreach (int i in array)
                Console.Write(array[i]+"\t");
            return array;
        }
        static int[] SortArray(int[] array)
        {
           
            int count = 0;
            for (int j = 0; j < array.Length; j++)
                for (int i = j+1; i < array.Length; i++)
                {
                    if (array[j] > array[i]) { 
                    count = array[j];
                    array[j] = array[i];
                    array[i] = count;
                     }

                    

                }
            
            return array;
        }   
        static void ShowArray(int[] array,bool show = false)
        {
            var temp = array;
            if (show)
                temp = SortArray(array);
            for (int i = 0;i<array.Length;i++)
                Console.WriteLine($"\t {array[i]}");
            
        }


    }
}
