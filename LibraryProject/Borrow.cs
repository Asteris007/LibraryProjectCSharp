using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
  public class Borrow
    {
        public int BorrowID { get; set; }
        public int ReaderID { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookID { get; set; }
        public bool ReturnBook { get; set; }
    }

}
