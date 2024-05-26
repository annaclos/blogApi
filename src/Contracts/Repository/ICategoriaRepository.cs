using BLOGAPI.Model.Data;

namespace BLOGAPI.src.Contracts.Repository
{
    public interface ICategoriaRepository
    {
        Task<Categoria> Create(Categoria categoria);
        Task<Categoria> Update(int Id, Categoria categoria);
        Task<bool> Delete(int Id);
        Task<Categoria> Get(int Id);
        Task<List<Categoria>> List();
    }
}
