namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool capacidade = Suite.Capacidade >= hospedes.Count;
            if (capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Quantidade de Hóspedes maior que a capacidade da reserva");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            bool dias = DiasReservados >= 10;
            
            if (dias)
            {
                valor -= valor * 0.1M;
            }

            return valor;
        }
    }
}