namespace ViajeFacil.Poco
{
    public class RegiaoPoco
    {
        public long RegiaoId { get; set; }
        public string Nome { get; set; } = null!;
        public long PaisId { get; set; }

        public RegiaoPoco()
        { }
    }
}