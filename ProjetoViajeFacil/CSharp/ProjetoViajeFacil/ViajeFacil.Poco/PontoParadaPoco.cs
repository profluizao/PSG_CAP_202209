namespace ViajeFacil.Poco
{
    public class PontoParadaPoco
    {
        public long PontoParadaId { get; set; }
        public string Descricao { get; set; } = null!;
        public string Latitude { get; set; } = null!;
        public string Longitude { get; set; } = null!;
        public long RotaId { get; set; }

        public PontoParadaPoco()
        { }
    }
}