using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            string k,parol="";

            
            do
            {
                Console.WriteLine("tasdiqlash parolini kiriting:");
                parol = Console.ReadLine();
            } while (parol != "@3333");
            List<string> hodim = new List<string>();
            string maneger="Nargiza";
            Console.WriteLine("Yangi ishchimisiz?");
            string n= Console.ReadLine();
            if (n == "ha")
            {

                Console.WriteLine("\n Bizning hodimlarimiz");
                hodim.Add($"maneger {maneger}");
                hodim.Add("Alisher");
                hodim.Add("Bibixonim");
                hodim.Add("Umarxon");
                hodim.Add("SaidAhmad");
                Console.WriteLine("\n Ismingiz nima?");
                string name = Console.ReadLine();
                Console.WriteLine($"Jamoamizga xush kelibsiz  {name}");
            }

            foreach (string h in hodim)
            {
                Console.WriteLine(h);
            }
            List<string> vazifa = new List<string>();
            Console.WriteLine("2-List ro'yhatga vazifa kiriting");
            string r, l, s;
            r = Console.ReadLine();
            vazifa.Add($"1-vazifa-{r}");
            l = Console.ReadLine();

            vazifa.Add($"2-vazifa-{l}");
            s = Console.ReadLine();

            vazifa.Add($"3-vazifa-{s}");

            Print(vazifa);
            Console.WriteLine("vazifaga o'zgartirish kiritishni hohlaysizmi?");
            string test;
            test = Console.ReadLine();
            int p;string changtasks;
            analysis:
           switch(test)
            {
                case "ha":
                    
                    Console.WriteLine("qo'shish ,Vazifa joylashish o'rnini kiriting");

                    p = Convert.ToInt32(Console.ReadLine());
                    switch(p)
                    {
                        case 1:
                            vazifa[0] = Console.ReadLine(); Console.WriteLine($"1-vazifa-{vazifa[0]}"); break;
                        case 2:
                            vazifa[1]= Console.ReadLine(); Console.WriteLine($"2-vazifa-{vazifa[0]}"); break;
                        case 3:
                            vazifa[2] = Console.ReadLine(); Console.WriteLine($"3-vazifa-{vazifa[0]}");
                            break; 
                    }
                    break;
                case "yo'q":
                    Console.WriteLine("continue ");break;
            }
            
            if(test=="ha")
            {
                Print(vazifa);
            }
            Console.WriteLine("vazifalarning bajarilgan qismini belgilang tartib raqamini.");
            int bajarilganv = Convert.ToInt32(Console.ReadLine());
           switch(bajarilganv)
            {
                case 1:
                   
                    Console.WriteLine("1-Vazifa bajarildi");
                    break;
                case 2:
                    Console.WriteLine("2-Vazifa bajarildi");
                    break;
                case 3:
                    Console.WriteLine("3-Vazifa bajarildi");
                    break;
            }
        }
        public static void Print(List<string> list)
        {
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }


    }
}
