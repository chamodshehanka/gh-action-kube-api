using System;
using System.ComponentModel.DataAnnotations;

namespace CashflowAPI.Dto
{
    public record UserDto
    {
        public Guid Id { get; init; }
        
        public string Username { get; init; }
        
        public string FirstName { get; init; }
        
        public string LastName { get; init; }

        public string Email { get; init; }
        
        public DateTimeOffset CreatedDate { get; init; } 
        
    }
}