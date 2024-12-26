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
            
            
                
            //var sortedarray = SortArray(array);
        }
        
        
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
