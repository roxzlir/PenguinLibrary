using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinLibrary
{
    public class Bok
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        public Bok(string title, string author, int iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}");

        } 

    }
}
