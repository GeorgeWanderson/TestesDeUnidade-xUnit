using System;

namespace JornadaMilhas.Modelos
{
    public class Musica
    {
        public Musica(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Id { get; set; }
        private int? anoLancamento;
        public int? AnoLancamento
        {
            get => anoLancamento;
            set
            {
                if (value <= 0)
                {
                    anoLancamento = null;
                }
                else
                {
                    anoLancamento = value;
                }
            }
        }

        private string? artista;
        public string? Artista
        {
            get => artista;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    artista = "Artista desconhecido";
                }
                else
                {
                    artista = value;
                }
            }
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
        }

        public override string ToString()
        {
            return @$"Id: {Id} Nome: {Nome}";
        }
    }
}
