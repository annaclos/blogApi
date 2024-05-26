using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Repository;
using BLOGAPI.src.Contracts.Service;

namespace BLOGAPI.src.Service
{
    public class UsuarioService : IUsuariosService
    {
        private readonly IUsuariosRepository _repository;
        public UsuarioService(IUsuariosRepository repository)
        {
            _repository = repository;
        }

        public async Task<Usuario> Create(Usuario usuario)
        {
            return await _repository.Create(usuario);
        }

        public async Task<bool> Delete(int Id)
        {
            return await _repository.Delete(Id);
        }

        public async Task<Usuario> Get(int Id)
        {
           return await _repository.Get(Id);
        }

        public async Task<List<Usuario>> List()
        {
            return await _repository.List();
        }

        public async Task<Usuario> Update(int Id, Usuario usuario)
        {
            return await _repository.Update(Id, usuario);
        }
    }
}
