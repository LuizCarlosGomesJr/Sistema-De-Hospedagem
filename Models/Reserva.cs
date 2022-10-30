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
            int totalPessoas = 0;
            for(int i = 0; i < hospedes.Count; i++)
            {
               totalPessoas++; 

            }
            if (Suite.Capacidade >= totalPessoas)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new System.Exception("Excedido o número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int totalHospedes = 0;
            for(int i = 0; i < Hospedes.Count; i++)
            {
               totalHospedes++; 

            }

            return totalHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if ( DiasReservados >= 10 )
            {
                valor = valor - ((10 * valor) / 100) ;
            }

            return valor;
        }
    }
}