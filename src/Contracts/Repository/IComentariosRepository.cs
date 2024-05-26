using BLOGAPI.Model.Data;

namespace BLOGAPI.src.Contracts.Repository
{
    public interface IComentariosRepository
    {
        Task<Comentarios> Create(Comentarios comentarios);
        Task<bool> Delete(int Id);
        Task<List<Comentarios>> List(int Id);
    }
}
