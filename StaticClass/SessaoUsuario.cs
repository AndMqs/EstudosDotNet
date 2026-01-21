public class SessaoUsuario
{
    public string NomeUsuario {get; set;}
    public static string UsuarioAtivo {get; set;}

    public SessaoUsuario(string nomeUsuario)
    {
        NomeUsuario = nomeUsuario;
        UsuarioAtivo = nomeUsuario;
    }
}