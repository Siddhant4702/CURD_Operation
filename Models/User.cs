using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CURD_using_SDSclient.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Enter Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Email is Reqiured")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
