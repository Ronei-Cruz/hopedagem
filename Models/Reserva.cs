namespace hopedagem.Models
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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            var qtdCapacidade = Suite.Capacidade;

            if (hospedes.Count == qtdCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                try
                {
                    Console.WriteLine("A quantidade de hospedes é maior que a capacidade permitida");
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            var qtd = 0;
            foreach (var item in Hospedes)
            {
                qtd = Hospedes.Count;
            }
            return qtd;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                var desconto = valor * 0.10M;
                valor = valor -desconto;
            }

            return valor;
        }
    }
}