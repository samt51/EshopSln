using Eshop.Domain.Common;

namespace Eshop.Domain.Entites
{
    public class Category : BaseEntity
    {
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public string Name { get; }
        public IList<Product> Products { get; }
        public Category()
        {

        }
    }
}
