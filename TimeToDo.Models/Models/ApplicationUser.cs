using Microsoft.AspNetCore.Identity;

namespace TimeToDo.Models.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}