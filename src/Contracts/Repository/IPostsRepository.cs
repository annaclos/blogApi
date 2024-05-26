using BLOGAPI.Model.Data;

namespace BLOGAPI.src.Contracts.Repository
{
    public interface IPostsRepository
    {
        Task<Post> Create(Post post);
        Task<Post> Update(int Id, Post post);
        Task<bool> Delete(int Id);
        Task<Post> Get(int Id);
        Task<List<Post>> List();
    }
}
