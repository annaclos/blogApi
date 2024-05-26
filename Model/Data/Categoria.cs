using BLOGAPI.src.Service;
using System.ComponentModel.DataAnnotations;

namespace BLOGAPI.Model.Data
{
    public class Categoria : DefaultProps
    {
        public string? Nome { get; set; }

        public IEnumerable<Post>? Posts { get; set; }
    }
}
