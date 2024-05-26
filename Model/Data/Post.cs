using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BLOGAPI.Model.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string? Titulo { get; set; }
        public string? Conteudo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //Relacionamento
        public int? UsuarioId { get; set; }
        [XmlIgnore, JsonIgnore]
        public Usuario? Usuario { get; set; }
        public int? CategoriaId { get; set; }
        [XmlIgnore, JsonIgnore] public Categoria? Categoria { get; set; }

        [XmlIgnore, JsonIgnore] public IEnumerable<Comentarios>? Comentarios { get; set;}

    }
}
