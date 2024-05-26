using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BLOGAPI.Model.Data
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Ativo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Relacionamento
        [XmlIgnore, JsonIgnore]
        public IEnumerable<Post>? Post { get; set; }
    }
}
