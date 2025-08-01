namespace ApplicationNandu.Models
{
    public class Registration
    {
        public int Id { get; set; } // Primary key

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; } // Store hashed password, not plain text

        public string ConfirmPassword { get; set; } // Use only for validation, not stored in DB

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

        public bool IsEmailVerified { get; set; } = false;
    }

}
