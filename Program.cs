using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //שאלה 1
            void OrderedList()
            {
                string[] namesFromClass = new string[] { "keren", "yafit", "eden", "tikva", "shay", "oshri", "eliyahu" };
                List<string> listOfnames = namesFromClass.Where(item => item[0] == 'e').ToList();
                for (int i = 0; i < listOfnames.Count; i++)
                {
                    Console.WriteLine(listOfnames[i]);
                }
            }
            //OrderedList();


            //שאלה 2
            void OlderThen20()
            {
                int[] arrayOfAges = new int[10];
                Random random = new Random();
                for (int i = 0; i < arrayOfAges.Length; i++)
                {
                    arrayOfAges[i] = random.Next(1, 30);

                }
                List<int> listOfAges = arrayOfAges.Where(item => item > 20).ToList();
                for (int i = 0; i < listOfAges.Count; i++)
                {
                    Console.WriteLine(listOfAges[i]);
                }


            }
            //OlderThen20();

            //שאלה 3+4

            
            Random randomnum = new Random();
  
            Book[] books = new Book[] { new Book("Harry Potter", "J.K. Rowling", randomnum.Next(10, 500)) ,
                                        new Book ("Lord of the Rings","J.R.R. Tolkien",randomnum.Next(10, 500)),
                                        new Book ("Alice's in Wonderland","Lewis Carroll",randomnum.Next(10, 500)),
                                        new Book("Narnia","C.S. Lewis",randomnum.Next(10, 500)),
                                        new Book("Pinocchio","Carlo Collodi",randomnum.Next(10, 500)),
                                        new Book("Anney","L. M. Montgomery",randomnum.Next(10, 500))};

            //שאלה 5
            List<Book> books200 = books.Where(item => item.pages > 200).ToList();
            //for (int i = 0; i < books200.Count; i++)
            //{
            //    Console.WriteLine($"name: {books200[i].name}  author: {books200[i].author}  pages: {books200[i].pages}");
            //}


            //שאלה 6

            void AuthorAbove4(Book[] array, List<Book> list)
            {
               
                List<Book> books4 = array.Where(item => item.author.Length > 4).ToList();
                for (int i = 0; i < books4.Count; i++)
                {
                    Console.WriteLine($"name: {books4[i].name}  author: {books4[i].author}  pages: {books4[i].pages}");
                }


            }
            //AuthorAbove4(books, books200);



            //שאלה 7

            void Boookabove150(List<Book> list)
            {
                Book lessThen150Pages = books200.Find(item => item.pages < 150);
                Console.WriteLine($"{lessThen150Pages.name}");
            }
            //Boookabove150(books200);

            //שאלה 8

            void nameswithY(Book[] array, List<Book> list)
            {
                List<Book> booksY = array.Where(item => item.name[item.name.Length - 1] == 'y').ToList();
                for (int i = 0; i < booksY.Count; i++)
                {
                    Console.WriteLine($"name: {booksY[i].name}  author: {booksY[i].author}  pages: {booksY[i].pages}");
                }
            }
            nameswithY(books, books200);

            //שאלה 9

            Random randomnum1 = new Random();

            Book[] bookss = new Book[] { new Book("Harry Potter", "J.K. Rowling", randomnum1.Next(10, 500)) ,
                                        new Book ("Lord of the Rings","J.R.R. Tolkien",randomnum1.Next(10, 500)),
                                        new Book ("Harry Potter","Lewis Carroll",randomnum1.Next(10, 500)),
                                        new Book("Narnia","C.S. Lewis",randomnum1.Next(10, 500)),
                                        new Book("Harry Potter","Carlo Collodi",randomnum1.Next(10, 500)),
                                        new Book("Anney","L. M. Montgomery",randomnum1.Next(10, 500))};

            //שאלה 10
            var filteredList = (from item in bookss
                                group item by item.name);

            foreach (var book in filteredList)
            {
                Console.WriteLine($"Book name: {book.Key}");
                foreach (Book bookitem in book)
                {
                    Console.WriteLine(bookitem.name);
                }
            }












        }
    }
}
