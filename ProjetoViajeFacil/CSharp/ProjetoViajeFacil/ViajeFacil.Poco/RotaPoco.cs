namespace ViajeFacil.Poco
{
    public class RotaPoco
    {
        public long RotaId { get; set; }
        public string PontoInicial { get; set; } = null!;
        public string PontoFinal { get; set; } = null!;
        public RotaPoco()
        { }
    }
}