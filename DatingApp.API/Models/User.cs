namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }     
        public string Username { get; set; }    
        public byte[] PawwordHash { get; set; } 
        public byte[] PasswordSalt { get; set; }    
        
    }
}