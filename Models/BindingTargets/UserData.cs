using System;
using System.ComponentModel.DataAnnotations;
using Amaryllis.Models.Users;

namespace Amaryllis.Models.BindingTargets
{
    public class UserData
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string DlNumber { get; set; }

        public User GetUser() => new User
        {
            FirstName = FirstName,
            LastName = LastName,
            DateOfBirth = DateOfBirth,
            DlNumber = DlNumber
        };
    }
}