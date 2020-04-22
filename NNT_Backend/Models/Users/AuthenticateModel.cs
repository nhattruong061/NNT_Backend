using System.ComponentModel.DataAnnotations;

namespace NNT_Backend.Models.Users
{
    public class AuthenticateModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}