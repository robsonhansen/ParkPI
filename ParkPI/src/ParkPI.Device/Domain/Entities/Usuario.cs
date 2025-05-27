public class Usuario
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get; set; }
    public string Email { get; set; }
    public string HashSenha { get; set; }

    public PerfilUsuario Perfil { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

    private Usuario(string nome, string email, string hashSenha, PerfilUsuario perfil)
    {
        Nome = nome;
        Email = email;
        HashSenha = hashSenha;
        Perfil = perfil;
    }

    public void AtualizarSenha(string hashSenha)
    {
        HashSenha = hashSenha;
    }
}