using Laboratory.Domain.Abstracts;
using Laboratory.Domain.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Domain.Models;
public class User : IDbSetEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }

    [EmailAddress]
    public string Email { get; set; }
    public string CellPhoneNumber { get; set; }

}