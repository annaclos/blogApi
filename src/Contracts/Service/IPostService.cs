using BLOGAPI.Model.Data;

namespace BLOGAPI.src.Contracts.Service
{
    public interface IPostService
    {
        Task<Post> Create(Post post);
        Task<Post> Update(int Id, Post post);
        Task<bool> Delete(int Id);
        Task<Post> Get(int Id);
        Task<List<Post>> List();
    }
}
