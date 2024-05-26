using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace BLOGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComentariosController : ControllerBase
    {
        private readonly IComentariosService _comentarios;
        public ComentariosController(IComentariosService comentarios)
        {
            _comentarios = comentarios;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Comentarios comentarios)
        {
            try
            {
                return Ok(await _comentarios.Create(comentarios));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("List/{Id}")]
        public async Task<ActionResult> List(int Id)
        {

            try
            {
                return Ok(await _comentarios.List(Id));
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
                return Ok(await _comentarios.Delete(Id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}

