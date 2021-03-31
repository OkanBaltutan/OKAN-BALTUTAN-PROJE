using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOB.Core.Model
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
    }
}
