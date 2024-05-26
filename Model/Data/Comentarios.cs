using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BLOGAPI.Model.Data
{
    public class Comentarios : DefaultProps
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Comentario { get; set; }

        public int? PostId { get; set; }

        [XmlIgnore, JsonIgnore]
        public Post? Post  { get; set; }
    }
}
