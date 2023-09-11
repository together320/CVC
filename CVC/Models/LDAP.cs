using CVC.Configuration.Scripts;
//using Serenity.ComponentModel;
using Serenity.Services;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace CVC.Models
{
    public class LDAP
    {

        ////[Required(true)]
        ////[StringEditor]
        ////[DisplayName("LDAPUrl")]
        ////public string LDAPUrl { get; set; }


        ////[Required(true)]
        ////[StringEditor]
        ////[DisplayName("Username")]
        ////public string Username { get; set; }

        ////[PasswordEditor]
        ////[Required(true)]
        ////public string Password { get; set; }


        ////[Required(true)]
        ////[StringEditor]
        ////[DisplayName("Domain")]
        ////public string Domain { get; set; }




        [Required(ErrorMessage = "LDAPUrl is Required")]
        public string LDAPUrl { get; set; }


        [Required(ErrorMessage = "Name is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Domain is Required")]
        public string Domain { get; set; }


        public string Error { get; set; }



    }
}