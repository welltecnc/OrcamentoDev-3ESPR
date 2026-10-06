

namespace OrcamentoDev.Models
{
    // OrcamentoUrgente herda de Orcamento
    class OrcamentoUrgente : Orcamento
    {
        //propriedade da classe orcamentoUrgente
        public bool Urgente { get; set; }

        //Construtor que vai repassar para a classe (orcamento) via base
        public OrcamentoUrgente(string cliente,int horasEstimadas, decimal valorHora,bool urgente)
            :base(cliente,horasEstimadas,valorHora)
        {
            Urgente = urgente;
        }

        //Polimorfismo que vai sobreescrever o calculo adicionando a taxa de urgência
        public override decimal CalcularTotal()
        {
            decimal totalBase = base.CalcularTotal();
            return Urgente ? totalBase * 1.20m : totalBase; // 20% de acréscimo
        }
    }
}
