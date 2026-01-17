using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.LibraryFineCalculation
{
    // class for IssueRecord
    public class IssueRecord
    {
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public IssueRecord(DateTime due, DateTime returned)
        {
            DueDate = due.Date;
            ReturnDate = returned.Date;
        }
    }
}