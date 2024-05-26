using BLOGAPI.Model.Data;
using BLOGAPI.src.Base.Db;
using BLOGAPI.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BLOGAPI.src.Repository
{
    public class PostRepository : IPostsRepository
    {
        private readonly DataContext _context;
        public PostRepository(DataContext context)
        {
            _context = context;
            
        }
        public async Task<Post> Create(Post post)
        {
            _context.posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<bool> Delete(int Id)
        {
            var getPost = await this.Get(Id);
            _context.posts.Remove(getPost);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Post> Get(int Id)
        {
            var getPost = await _context.posts.FirstOrDefaultAsync(x => x.Id == Id);
            if (getPost != null)
            {
                return getPost;
            }
            throw new Exception("Post não encontrado");
        }

        public Task<List<Post>> List()
        {
            return _context.posts.ToListAsync();
        }

        public async Task<Post> Update(int Id, Post post)
        {
            _context.posts.Update(post);
            await _context.SaveChangesAsync();
            return post;
        }
    }
}

