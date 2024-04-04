using Eshop.Domain.Common;

namespace Eshop.Domain.Entites
{
    public class UserRole : BaseEntity
    {
        public string Name { get; set; }
        public IList<User> Users { get; set; }
    }
}
