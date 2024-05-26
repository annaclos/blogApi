using BLOGAPI.Model.Data;

namespace BLOGAPI.src.Contracts.Service
{
    public interface ICategoriaService
    {
        Task<Categoria> Create(Categoria categoria);
        Task<Categoria> Update(int Id, Categoria categoria);
        Task<bool> Delete(int Id);
        Task<Categoria> Get(int Id);
        Task<List<Categoria>> List();
    }
}
