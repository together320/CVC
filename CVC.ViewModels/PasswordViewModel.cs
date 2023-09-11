using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class PasswordViewModel
    {
        public int UserId { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public System.DateTime CreatedOn { get; set; }
    }
}
