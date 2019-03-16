using System;

namespace Amaryllis.Models.Users
{
    public class User
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DlNumber { get; set; }
    }
}