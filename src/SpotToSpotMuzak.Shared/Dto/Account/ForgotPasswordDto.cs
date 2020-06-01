using System.ComponentModel.DataAnnotations;

namespace SpotToSpotMuzak.Shared.Dto.Account
{
    public class ForgotPasswordDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
