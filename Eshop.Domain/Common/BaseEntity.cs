namespace Eshop.Domain.Common
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifyDate { get; set; } = null;
        public bool IsDeleted { get; set; } = false;
    }
}
