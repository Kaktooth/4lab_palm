using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        { 
            int  n= 0;
            Console.WriteLine("Введіть рядок") ;
            string str = Convert.ToString(Console.ReadLine());
            
            char[] b = str.ToCharArray();
            char sym = '*';
            string symb = "*";
            Console.WriteLine("Перше входженя *: {0} місце в рядку",str.IndexOf(sym));

            for (int i =0;i<str.Length;i++)
            {   
                if (b[i]==sym)
                { 
                     n +=1;
                }
            }
            Console.WriteLine("Кількість входжень {0}: {1}",sym,n);
            int c = n;
            while(c!=0){
                str = str.Insert(str.Length,symb);
                c--;
            }
            Console.WriteLine("Додані символи в кінець рядка: {0}",str);
            Console.ReadLine();

        }
    }
}
