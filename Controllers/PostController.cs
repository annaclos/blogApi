using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace BLOGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _posts;

        public PostController(IPostService posts)
        {
            _posts = posts;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Post post)
        {

            try
            {
                return Ok(await _posts.Create(post));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get(int Id)
        {

            try
            {
                return Ok(_posts.Get(Id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("List")]
        public async Task<ActionResult> List()
        {

            try
            {
                return Ok(await _posts.List());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {

            try
            {
                return Ok(await _posts.Delete(Id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Post post)
        {
            try
            {
                var user = await _posts.Update(0, post);
                return Ok(user);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);

            }
        }
    }
}
