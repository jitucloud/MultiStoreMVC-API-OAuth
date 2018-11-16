using System.ComponentModel.DataAnnotations;

namespace demo.tt.domain.users.model
{
    /// <summary>
    /// User Object
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
