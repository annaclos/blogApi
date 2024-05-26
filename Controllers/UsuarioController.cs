using BLOGAPI.Model.Data;
using BLOGAPI.src.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace BLOGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosService _services;

        public UsuarioController(IUsuariosService services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Usuario usuario) {

            try
            {
                var user = await _services.Create(usuario);
                return Ok(user);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get (int Id)
        {

            try
            {
                var user = await _services.Get(Id);
                return Ok(user);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [HttpGet ("List")]
        public async Task<ActionResult> List()
        {

            try
            {
                var user = await _services.List();
                return Ok(user);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {

            try
            {
                var user = await _services.Delete(Id);
                return Ok(user);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Usuario usuario)
        {
            try
            {
                var user = await _services.Update(0, usuario);
                return Ok(user);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
    }

}

