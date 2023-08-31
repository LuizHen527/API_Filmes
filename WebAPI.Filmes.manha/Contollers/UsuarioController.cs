using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebAPI.Filmes.manha.Domains;
using WebAPI.Filmes.manha.Interfaces;
using WebAPI.Filmes.manha.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebAPI.Filmes.manha.Contollers
{

    [Route("api/[controller]")]

    [ApiController]

    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository= new UsuarioRepository();
        }

        /// <summary>
        /// Endpoint que Compara a senha e email digitada pelo usuario com as mesmas que estao no banco de dados.
        /// </summary>
        /// <param name="Email">Email que sera validado</param>
        /// <param name="Senha">Senha que sera validada</param>
        /// <returns>Retorna StatusCode 200 com o Usuario encontrado</returns>

        [HttpPost]

        public IActionResult Login(string Email, string Senha)
        {
            try
            {
                UsuarioDomain usuario = _usuarioRepository.Login(Email, Senha);

                if (usuario == null)
                {
                    return StatusCode(404);
                }

                return StatusCode(200, usuario);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

    }
}
