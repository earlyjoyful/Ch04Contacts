﻿using System.ComponentModel.DataAnnotations;

namespace Ch04Contacts.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        //name, phonenum, address, note

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PhoneNum { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a note.")]
        public string Note { get; set; } = string.Empty;









    }
}
