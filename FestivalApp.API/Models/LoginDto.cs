
namespace SampleApp.API.Models;

public class LoginDto
{
    public required string Login { get; set; } = string.Empty;
    public required string Password { get; set; } = string.Empty;
}
