using Entities.Concrete.BaseEntities;
using System;

namespace Entities.Dtos.UserDtos
{
    /// <summary>
    /// Bu dto Müşteriye göstermek için oluşturuyoruz.
    /// </summary>
    public class UserDetailDto:AuditableEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
