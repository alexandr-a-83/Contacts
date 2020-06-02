using Contacts.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePage : ContentPage
    {
        public DeletePage()
        {
            InitializeComponent();
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {


                Contact contact = (from tab in conn.Table<Contact>()
                                   where tab.Lastname == lastnameEntry.Text
                                   select tab).FirstOrDefault();

                if (contact != null)
                {
                    conn.Delete(contact);
                } 

            }

            lastnameEntry.Text = "";
            Navigation.PushAsync(new ContactsPage());
        }

        private void SearchButton_Clicked(object sender, EventArgs e)
        {
            string Lastname = lastnameEntry.Text;

        }

        
    }
}