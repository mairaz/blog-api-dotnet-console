

using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[USER]")]
    public class User
    {
        public User () => Roles = new List<Role>();
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public string? Image { get; set; }
        public string? PasswordHash { get; set; }
        public string? Slug { get; set; }
        public string? Email { get; set;}
        [Write(false)]
        public List<Role>? Roles { get; set; }


    }
}