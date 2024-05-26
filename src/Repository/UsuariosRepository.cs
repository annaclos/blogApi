using BLOGAPI.Model.Data;
using BLOGAPI.src.Base.Db;
using BLOGAPI.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BLOGAPI.src.Repository
{
    public class UsuariosRepository : IUsuariosRepository
    {

        private readonly DataContext _context;

        public UsuariosRepository(DataContext context)
        {
            _context = context;
            
        }

        public async Task<Usuario> Create(Usuario usuario)
        {
           _context.usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;

        }

        public async Task<bool> Delete(int Id)
        {
            var getUser = await this.Get(Id);
            _context.usuarios.Remove(getUser);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Usuario> Get(int Id)
        {
            var getUser = await _context.usuarios.FirstOrDefaultAsync(x => x.Id == Id);
            if (getUser == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            return getUser;
        }

        public async Task<List<Usuario>> List()
        {
            return await _context.usuarios.ToListAsync();
        }

        public async Task<Usuario> Update(int Id, Usuario usuario)
        {
            _context.usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
    }
}
