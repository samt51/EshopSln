using Eshop.Domain.Common;

namespace Eshop.Domain.Entites
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
