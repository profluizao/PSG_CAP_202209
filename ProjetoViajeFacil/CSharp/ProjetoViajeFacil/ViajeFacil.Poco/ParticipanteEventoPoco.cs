namespace ViajeFacil.Poco
{
    public class ParticipanteEventoPoco
    {
        public long ParticipanteEventoId { get; set; }
        public long EventoId { get; set; }
        public int Pagamento { get; set; }
        public string Sugestao { get; set; } = null!;
        public int? Avaliacao { get; set; }
        public long? UsuarioId { get; set; }

        public ParticipanteEventoPoco()
        { }
    }
}