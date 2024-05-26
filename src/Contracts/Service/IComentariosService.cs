using BLOGAPI.Model.Data;

namespace BLOGAPI.src.Contracts.Service
{
    public interface IComentariosService
    {
        Task<Comentarios> Create(Comentarios comentarios);
        Task<bool> Delete(int Id);
        Task<List<Comentarios>> List(int Id);
    }
}
