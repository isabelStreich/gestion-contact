using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAdress { get; set; }

        public Contact(string fname, string lname, string tel, string email)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.PhoneNumber = tel;
            this.EmailAdress = email;
        }

    }
}
