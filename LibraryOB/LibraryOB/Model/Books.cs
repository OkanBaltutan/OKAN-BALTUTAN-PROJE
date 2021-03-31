using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOB.Core.Model
{
    public class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookWriter { get; set; }
        public string BookPublished { get; set; }
        public int BookPages { get; set; }
        public string BookLanguage { get; set; }
        public string BookGenre { get; set; }
    }
}
