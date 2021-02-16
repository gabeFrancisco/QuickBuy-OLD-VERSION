using System;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ContentResult() { Content = "Olá Mundo! Eu te amo Jesus!" };
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public IActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.Email == "gabeasmprogrammer@gmail.com" && usuario.Senha == "12345678")
                {
                    return Ok(usuario);
                }

                return new ContentResult() { Content = "Usuário ou senha incorretos!" };
            }

            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}