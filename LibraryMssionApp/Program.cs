using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMssionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayNames();

            //ArrayRandNum();

            //BooksArray();
            //ShortNameWrites();
            LastChar();

        }

        //mission 1

        static void ArrayNames()
        {
            string[] names = new string[] { "amir", "tikva", "eden", "shai", "lior", "matan", "armias"}; 
            var NameFilter = from item in names
                             where item.ToLower()[0]=='e'
                             select item;
            foreach (string name in NameFilter)
            {
                Console.WriteLine(name);
            }

        }

        //mission 2

        static void ArrayRandNum()
        {
            Random rand = new Random();
            rand.Next(30);
            int[] numArr = new int[10];

            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = rand.Next(30);
                Console.Write($"| {numArr[i]} ");
            }
            Console.WriteLine();


            var AgeOver20 = from item in numArr
                            where item >20
                            select item;
            foreach(int item in AgeOver20)
            {
                Console.WriteLine($"the number over 20 is: {item}");
            }



        }

        //mission 4+5
        static void BooksArray( )
        {
            Random random = new Random();

            Books[] books = new Books[]
            {
                new Books("lost time","marcel",random.Next(500)),
                new Books("ulysses","james",random.Next(500)),
                new Books("don quixote","miguel",random.Next(500)),
                new Books("the great","F.scott",random.Next(500)),
                new Books("the magic","eyal",random.Next(500)),
                new Books("moby","herman",random.Next(500)),

            };

            List<Books> Bookslist = books.Where(item=> item.Pages > 200).ToList();


            foreach (Books item in Bookslist)
            {
                Console.WriteLine($"Name Book: {item.NameBook} | Name Writes: {item.NameWrites} | Numer Pages: {item.Pages}");
            }

        }
    
        //mission 6+7
        static void ShortNameWrites()
        {
            Random random = new Random();

            Books[] books = new Books[]
            {
                new Books("lost time","marcel",random.Next(500)),
                new Books("ulysses","james",random.Next(500)),
                new Books("don quixote","miguel",random.Next(500)),
                new Books("the great","F.scott",random.Next(500)),
                new Books("the magic","eyal",random.Next(500)),
                new Books("moby","herman",random.Next(500)),
            };

            List<Books> Bookslist = books.Where(item => item.NameWrites.Length > 4).ToList();

            foreach (Books item in Bookslist)
            {
                Console.WriteLine($"Name Book: {item.NameBook} | Name Writes: {item.NameWrites} | Numer Pages: {item.Pages}");
            }



            Books Lastpages = Bookslist.Find(item => item.Pages < 150);
            Console.WriteLine($" Lastpages |Name Book: {Lastpages.NameBook} | Name Writes: {Lastpages.NameWrites} | Numer Pages: {Lastpages.Pages}");

        }

        //mission 8-11
        static void LastChar()
        {
            Random random = new Random();

            Books[] books = new Books[]
            {
                new Books("lost time","marcey",random.Next(500)),
                new Books("ulysses","jamesy",random.Next(500)),
                new Books("don quixote","eyaly",random.Next(500)),
                new Books("the great","eyaly",random.Next(500)),
                new Books("the magic","eyaly",random.Next(500)),
                new Books("moby","eyaly",random.Next(500)),
            };

            List<Books> Bookslist = books.Where(item => item.NameWrites[item.NameWrites.Length-1] == 'y').ToList();

            //foreach (Books item in Bookslist)
            //{
            //    Console.WriteLine($"Name Book: {item.NameBook} | Name Writes: {item.NameWrites} | Numer Pages: {item.Pages}");
            //}

            Console.WriteLine("________________________________");


            var filterbooks = from item in Bookslist
                              group item by item.NameWrites;

            foreach (var group in filterbooks)
            {
                Console.WriteLine($"group name: {group.Key}");

                foreach (var item in group)
                {
                    Console.WriteLine($"Name Book: {item.NameBook} | Name Writes: {item.NameWrites} | Numer Pages: {item.Pages}");

                }
                Console.WriteLine("________________________________");

            }
            Console.WriteLine("________________________________");


            var filterbooks2 = from item in Bookslist
                              group item by item.NameWrites;

            foreach (var group in filterbooks2)
            {
                Console.WriteLine($"group name: {group.Key}");

                foreach (var item in group)
                {
                    Console.WriteLine($"Name Book: {item.NameBook} ");

                }
                Console.WriteLine("________________________________");

            }

        }


    }
}
