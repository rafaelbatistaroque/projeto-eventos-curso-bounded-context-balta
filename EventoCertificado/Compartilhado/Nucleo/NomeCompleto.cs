namespace Nucleo.Core
{
    public class NomeCompleto
    {
        public string PrimeiroNome { get; }
        public string SobreNome { get; }

        public NomeCompleto(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
        }

        public string EscreverNome()
        {
            return $"{PrimeiroNome} {SobreNome}";
        }
    }
}
