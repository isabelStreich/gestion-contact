using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class ContactDal
    {
        public void AddContact(String[] c ) {
           
            File.AppendAllLines(@"C:/Users/ybenhail/Desktop/Test/contact.txt", c);

        }
     
        public   List<Contact> ReadInfos()
        {
            string line;
            List<Contact> contacts = new List<Contact>();
            //Chemin du fichier
            StreamReader file = new StreamReader(@"C:/Users/ybenhail/Desktop/Test/contact.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                contacts.Add(new Contact(words[0], words[1], words[2], words[3]));
            }

            file.Close();
            return contacts;
        }
    }
}
