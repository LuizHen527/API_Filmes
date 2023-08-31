namespace WebAPI.Filmes.manha.Domains
{

    /// <summary>
    /// Classe que representa a entidade Usuario
    /// </summary>

    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool Permissao { get; set; }
    }
}
