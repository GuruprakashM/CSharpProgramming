using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class BookDetails
    {
        private static int s_bookID=100;
        public string BookID;
        public string BookName;
        public string AuthorName;
        public int BooKStock;

        public BookDetails(string bookName,string authorname, int booKStock)
        {
             s_bookID++;
             BookID="BID"+s_bookID;
             BookName=bookName;
             AuthorName=authorname;
             BooKStock=booKStock;
        }

    }
}