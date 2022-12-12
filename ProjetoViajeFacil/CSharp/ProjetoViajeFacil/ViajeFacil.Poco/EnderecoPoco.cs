﻿namespace ViajeFacil.Poco
{
    public class EnderecoPoco
    {
        public long EnderecoId { get; set; }
        public string Rua { get; set; } = null!;
        public int Numero { get; set; }
        public string? Complemento { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public long CidadeId { get; set; }
        public EnderecoPoco()
        { }
    }
}