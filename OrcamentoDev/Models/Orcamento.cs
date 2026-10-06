

using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace OrcamentoDev.Models
{
 class Orcamento
    {
        //campos privados
        private string _cliente;
        private int _horasEstimadas;
        private decimal _valorHora;

        //propriedades publicas para receber os campos privados

        public string Cliente
        {
            get => _cliente;
            set => _cliente = value;

        }

        public int HorasEstimadas
        {
            get => _horasEstimadas;
            set => _horasEstimadas = value > 0 ? value : 0;
        }

        public decimal ValorHora
        {
            get => _valorHora;
            set => _valorHora = value > 0 ? value : 0;
        }

        //Construtor 

        public Orcamento(string cliente,int horasEstimadas, decimal valorHora)
        {
            _cliente = cliente;
            _horasEstimadas = horasEstimadas;
            _valorHora = valorHora; 

        }
        // Método virtual para permitir polimorfismo nas classe filhas
        public virtual decimal CalcularTotal()
        {
            return _horasEstimadas * _valorHora;
        }




    }
}
