using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Repository;
using BLOGAPI.src.Contracts.Service;

namespace BLOGAPI.src.Service
{
    public class PostService : IPostService
    {
        private readonly IPostsRepository _repository;
        public PostService(IPostsRepository repository)
        {
            _repository = repository;
        }
        public async Task<Post> Create(Post post)
        {
            if (string.IsNullOrEmpty(post.Titulo))
                throw new Exception("O Título é obrigatório.");

            if (string.IsNullOrEmpty(post.Conteudo))
                throw new Exception("O Conteúdo é obrigatório.");

            return await _repository.Create(post);

        }

        public async Task<bool> Delete(int Id)
        {
            return await _repository.Delete(Id);
        }

        public async Task<Post> Get(int Id)
        {
            return await _repository.Get(Id);
        }

        public async Task<List<Post>> List()
        {
            return await _repository.List();
        }

        public async Task<Post> Update(int Id, Post post)
        {
            return await _repository.Update(Id, post);
        }
    }
}
