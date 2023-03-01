using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] a = new Book[5];
            a[0] = new Book();
            a[0].Author = "Винсе́нт Ви́ллем Ван Гог";
            a[0].Title = "Звёздная ночь (1889 г.)";
            a[1] = new Book();
            a[1].Author = "Леонардо да Винчи";
            a[1].Title = "Джоконда” (“Мона Лиза”)";
            a[2] = new Book();
            a[2].Author = "ПАБЛО ПИКАССО";
            a[2].Title = "Девушка перед зеркалом ";
            a[3] = new Book();
            a[3].Author = "САЛЬВАДОР ДАЛИ";
            a[3].Title = "Постоянство памяти";
            a[4] = new Book();
            a[4].Author = "КЛОД МОНЕ";
            a[4].Title = "Стог сена в Живерни";

            Array.Sort(a, new Book.SortByTitle());
            foreach (Book b in a)
            {
                Console.WriteLine(b.ToString());
            }

            Library lib = new Library(a);
            foreach (Book temp in lib)
            {
                Console.WriteLine(temp.ToString());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
