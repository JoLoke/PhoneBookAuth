using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneBookAuth.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is a required field!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "The {0} must between {2} and {1} chars.")]
        public string Name { get; set; }

        [StringLength(20)]
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Only numbers and white-space are allowed.")]
        public string Phone { get; set; }

        [StringLength(40)]
        [EmailAddress(ErrorMessage = "Email address is not valid!")]
        public string Email { get; set; }

        [DataType(DataType.Date)] // DateType tells "Html.EditorFor" in create & edit view to render a DatePicker input box
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] // DisplayFormat tells 
        public DateTime? DateOfBirth { get; set; } // DataTime?, "?" means that it is a nullable variable, which make this field a optional in database.
    }

    public class ContactsDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}