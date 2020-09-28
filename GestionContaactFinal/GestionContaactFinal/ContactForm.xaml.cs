using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DAL;
using Model;

namespace GestionContaactFinal
{
    /// <summary>
    /// Interaction logic for ContactForm.xaml
    /// </summary>
    public partial class ContactForm : Window
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LvContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void Test_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("Hello, world!");
           ContactDal cdal= new ContactDal();
             List<Contact> contacts = cdal.ReadInfos();
            
           // MessageBox.Show(contacts.ToString());

            foreach (Contact c in contacts)
             {
                lvContacts.ItemsSource = contacts;
                //MessageBox.Show(c.ToString());
               // Console.WriteLine(c.FirstName);
            }
        }
    }
}
