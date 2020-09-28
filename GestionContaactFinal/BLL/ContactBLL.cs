using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
  public  class ContactBLL
    {
        public ContactDal cdal;
       // public List<Contact> contacts;
        public void AjouterContact(Contact c) {
            //contacts = new List<Contact>();
            //contacts.Add(c);
            string[] lines = { c.FirstName + "," + c.LastName + "," + c.PhoneNumber + "," + c.EmailAdress };
            cdal.AddContact(lines);

        }
        public void ModifierContact( ) { }
        
    }
}
