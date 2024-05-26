using BLOGAPI.Model.Data;
using BLOGAPI.src.Base.Db;
using BLOGAPI.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace BLOGAPI.src.Repository
{
    public class ComentariosRepository : IComentariosRepository
    {
        private readonly DataContext _context;

        public ComentariosRepository(DataContext context)
        {
            _context = context;

        }

        public async Task<Comentarios> Create(Comentarios comentarios)
        {
            _context.comentarios.Add(comentarios);
            await _context.SaveChangesAsync();
            return comentarios;
        }

        public async Task<bool> Delete(int Id)
        {
           var getComentarios = await _context.comentarios.FirstOrDefaultAsync(x=>x.Id == Id);
            _context.comentarios.Remove(getComentarios);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Comentarios>> List(int Id)
        {
            return await _context.comentarios.Where(x=>x.PostId == Id).ToListAsync();
        }
    }
}
