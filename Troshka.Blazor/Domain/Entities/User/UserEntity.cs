namespace Troshka.Blazor.Domain.Entities.User
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Rating { get; set; }
        public virtual ICollection<UserCommentsEntity> Comments { get; set; }
    }
}
