using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public enum Status {Default,Issued,Returned}
    public class BorrowBooks
    {
        private static int s_borrowID=300;
        public string BorrowID;
        public string BookID;
        public string RegisterNumberID;
        public DateTime BorrowedDate { get; set; }
        public Status Status { get; set; }
        public BorrowBooks(string bookID,string registerNumber,DateTime borrowDate,Status status)
        {
           s_borrowID++;
           BorrowID="LB"+s_borrowID;
           BookID=bookID;
           RegisterNumberID=registerNumber;
           BorrowedDate=borrowDate;
           Status=status;

        }
        
        
    }
}