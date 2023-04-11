namespace Troshka.Blazor.Domain.Entities.User
{
    public class UserCommentsEntity : BaseEntity
    {
        public string Text { get; set; }
        public string AuthorId { get; set; }
        public virtual UserEntity Author { get; set; }
        public string RecipientId { get; set; }
        public virtual UserEntity Recipient { get; set; }
    }
}
