using BLOGAPI.Model.Data;
using BLOGAPI.src.Base.Db;
using BLOGAPI.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BLOGAPI.src.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext _context;
        public CategoriaRepository(DataContext context)
        {
            _context = context;
            
        }
        public async Task<Categoria> Create(Categoria Categoria)
        {
            _context.Categoria.Add(Categoria);
            await _context.SaveChangesAsync();
            return Categoria;
        }

        public async Task<bool> Delete(int Id)
        {
            var getCategoria = await this.Get(Id);
            _context.Categoria.Remove(getCategoria);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Categoria> Get(int Id)
        {
            var getCategoria = await _context.Categoria.FirstOrDefaultAsync(x => x.Id == Id);
            if (getCategoria != null)
            {
                return getCategoria;
            }
            throw new Exception("Categoria não encontrada");
        }

        public Task<List<Categoria>> List()
        {
            return _context.Categoria.ToListAsync();
        }

        public async Task<Categoria> Update(int Id, Categoria Categoria)
        {
            _context.Categoria.Update(Categoria);
            await _context.SaveChangesAsync();
            return Categoria;
        }
    }
}

