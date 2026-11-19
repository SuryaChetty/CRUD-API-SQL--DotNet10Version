
using System.ComponentModel.DataAnnotations;


namespace CRUD_Operations.Models
{
    
    public class UserInfo
    {
        [Key]
        public int UserID { get; set; }
        
        public   string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }



    }
}
