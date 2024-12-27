using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace skilo553
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Programer();
            
            Console.ReadKey();
           
        }
       
        static void /*(string Name, int Age, string LastName, bool Pet,string[] SomePet,  string [] ShowColor)*/ Programer()
        {
            //var anketa = (name: Console.ReadLine(), age: int.Parse(Console.ReadLine()));
            //Console.ReadLine();
            (string Name, int Age, string LastName, bool Pet, string[] SomePet, string[] ShowColor) user;
            Console.WriteLine("Введите ваше  имя ,пользователь");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");

            user.Age = Eror(Console.ReadLine());
            Console.WriteLine("Введите  вашу фамилию");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Есть ли у вас питомцы.Да или Нет");
            string pet = Console.ReadLine();
            user.Pet = false;
            user.SomePet = null;//два начальных значения для полей чтобы избежать путей в ни куда
            if (pet == "Да")
            {
                user.Pet = true;
                Console.WriteLine("Сколько у вас питомцев?");
                int SomePet = Eror(Console.ReadLine());
                user.SomePet = Pet(SomePet);
            }
            else if (pet == "Нет")
                user.Pet = false;
            else
            {
                Console.WriteLine("Введите Да или Нет с большой буквы.Пример=Нет.Да.");
                pet = Console.ReadLine();
                if (pet == "Да")
                { 
                    user.Pet = true;
                    Console.WriteLine("Сколько у вас питомцев?");
                    int SomePet = Eror(Console.ReadLine());
                    user.SomePet = Pet(SomePet);

                }
                else if (pet == "Нет")
                    user.Pet = false;
            }
            
           
            Console.WriteLine("Сколько У вас любимых цветов?");
            int some  = Eror(Console.ReadLine());
            user.ShowColor= ShowColor(some);


            //return ( user.Name,  user.Age,  user.LastName,  user.Pet,  user.SomePet,  user.ShowColor) ;
            OutPut(user.Name, user.Age, user.LastName, user.Pet, user.SomePet, user.ShowColor);
        }
        static string [] Pet(int SomePet)
         {
            if (SomePet == 0)
                Console.WriteLine("Питомцы приносят счастье!!!Никогда не поздно завести их");
            string[] array = new string[SomePet];
                if (SomePet==1) 
                Console.WriteLine("Как зовут вашего любичика ");
                else
                    Console.WriteLine("Как зовут ваших животных");
            for (int i = 0; i < SomePet; i++)
            {
               array[i] = Console.ReadLine();
            }
            return array;
         }
        static string [] ShowColor(int color )
        {
            if (color == 0)
            {
                Console.WriteLine("Как же так у вас не любимых цветов ???Может вы стесняетесь ?Да раслабься ,это останется между нами ");
                color = int.Parse(Console.ReadLine());
            }
            string[] array = new string[color];
            Console.WriteLine("Введите ваши люмые цвета");
            for (int i = 0;i < color; i++)
            {
                array [i] = Console.ReadLine();
             
            }

            return array;

        }

       static int Eror(string number)
        {
             int count=0;
           
          if (count > 10)
            {
             Console.WriteLine("Ошибка.Может что-то не так?");
              return 0;
           }
              
          if (int.TryParse(number,out int intnum) )
             return int.Parse(number);
          else 
           {
           Console.WriteLine("Вы ввели неправильно.Введите число от 0 и больше ");
            number = Console.ReadLine();
            count++;
           return Eror(number);
           }
               
                    
            

        }
        static void OutPut(string Name, int Age, string LastName,  bool Pet, string [] SomePet, string [] ShowColor)
        {
            
            Console.WriteLine($"Данные пользователя:\t{Name}\t{Age}\t{LastName}");
            Console.Write("Имеются питомцы:");
            if (Pet == true) {
                for(int i = 0; i < SomePet.Length; i++) 
                    Console.Write(SomePet[i] + " ");  
            }
            else Console.Write("Нет");
            Console.WriteLine();
            Console.Write("Имеются любимые цвета:");
            for(int i = 0;i < ShowColor.Length ; i++)
                Console.Write(ShowColor[i] + " ");
        }


    }
    
}
 