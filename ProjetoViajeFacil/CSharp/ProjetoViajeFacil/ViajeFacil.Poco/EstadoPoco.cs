namespace ViajeFacil.Poco
{
    public class EstadoPoco
    {
        public long EstadoId { get; set; }
        public string Nome { get; set; } = null!;
        public long? CodigoUf { get; set; }
        public string UF { get; set; } = null!;
        public long RegiaoId { get; set; }
        public EstadoPoco()
        { }
    }
}