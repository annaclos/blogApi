using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace BLOGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoria;

        public CategoriaController(ICategoriaService categoria)
        {
            _categoria = categoria;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Categoria categoria)
        {

            try
            {
                return Ok(await _categoria.Create(categoria));
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
                return Ok(await _categoria.Get(Id));
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
                return Ok(await _categoria.List());
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
                return Ok(await _categoria.Delete(Id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult> Update([FromBody] Categoria categoria)
        {
            try
            {
                var user = await _categoria.Update(0, categoria);
                return Ok(user);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);

            }
        }
    }
}
