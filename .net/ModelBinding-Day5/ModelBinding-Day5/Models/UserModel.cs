namespace ModelBinding_Day5.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        // Add other properties as needed

        public IFormFile ProfilePicture { get; set; }
    }
}
