namespace Troshka.Blazor.Domain.Entities.User
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public double? Rating { get; set; }
        public virtual ICollection<UserCommentsEntity> Comments { get; set; }
    }
}
