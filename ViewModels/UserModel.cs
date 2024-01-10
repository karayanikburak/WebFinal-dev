using WebFinal.Models;

namespace WebFinal.ViewModels
{
    public class UserModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string? PhotoUrl { get; set; }
        public string Role { get; set; }


        public List<User> Users { get; set; }

    }
}
