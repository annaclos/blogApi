using BLOGAPI.Model.Data;

namespace BLOGAPI.src.Contracts.Repository
{
    public interface IUsuariosRepository
    {
        Task<Usuario> Create(Usuario usuario);
        Task<Usuario> Update(int Id, Usuario usuario);
        Task<bool> Delete(int Id);
        Task<Usuario> Get(int Id);
        Task<List<Usuario>> List();

    }
}
