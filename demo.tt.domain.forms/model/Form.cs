using System.ComponentModel.DataAnnotations;

namespace demo.tt.domain.forms.model
{
    public class Form
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }     

        public string Title { get; set; }

    }
}
