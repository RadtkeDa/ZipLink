using System.ComponentModel.DataAnnotations;

namespace ZipLink.Domain.DTOs.Authentication;

public class AuthenticateRequest
{
    [Required] public string Username { get; set; } = string.Empty;

    [Required] public string Password { get; set; } = string.Empty;
}