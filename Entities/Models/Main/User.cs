using Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models.Main
{
    public class User : IdentityUser<Guid>
    {
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        public Partner Partner { get; set; }
        public Role Role { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
