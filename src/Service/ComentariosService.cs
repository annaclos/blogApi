using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Repository;
using BLOGAPI.src.Contracts.Service;

namespace BLOGAPI.src.Service
{
    public class ComentariosService : IComentariosService
    {
        private readonly IComentariosRepository _repository;
        public ComentariosService(IComentariosRepository repository)
        {
            _repository = repository;
        }

        public async Task<Comentarios> Create(Comentarios comentarios)
        {
            return await _repository.Create(comentarios);
        }

        public async Task<bool> Delete(int Id)
        {
            return await _repository.Delete(Id);
        }

        public async Task<List<Comentarios>> List(int Id)
        {
            return await _repository.List(Id);
        }
    }
}
