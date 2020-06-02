using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Classes
{

    [Table("Contact")]
    class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column("Lastname")]
        public string Lastname { get; set; }
        public string Email { get; set; }
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }





    }
}
