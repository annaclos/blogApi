using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Repository;
using BLOGAPI.src.Contracts.Service;

namespace BLOGAPI.src.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }
        public async Task<Categoria> Create(Categoria categoria)
        {
            return await _repository.Create(categoria);

        }

        public async Task<bool> Delete(int Id)
        {
            return await _repository.Delete(Id);
        }

        public async Task<Categoria> Get(int Id)
        {
            return await _repository.Get(Id);
        }

        public async Task<List<Categoria>> List()
        {
            return await _repository.List();
        }

        public async Task<Categoria> Update(int Id, Categoria categoria)
        {
            return await _repository.Update(Id, categoria);
        }
    }
}
