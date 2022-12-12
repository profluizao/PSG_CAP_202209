namespace ViajeFacil.Poco
{
    public class CidadePoco
    {
        public long CidadeId { get; set; }
        public string Nome { get; set; } = null!;
        public long CodigoIBGE7 { get; set; }
        public string? UF { get; set; } = null!;
        public long EstadoId { get; set; }
        public CidadePoco()
        { }
    }
}