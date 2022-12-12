namespace ViajeFacil.Poco
{
    public class UsuarioPoco
    {
        public long UsuarioId { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string login { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public long InstituicaoId { get; set; }
        public long EnderecoId { get; set; }
        public long TipoUsuarioId { get; set; }

        public UsuarioPoco()
        { }
    }
}