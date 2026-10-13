using System;
using System.Collections.Generic;
using System.Text;
namespace TipCalculator.Maui.Models
{
    public class ConsumoCompartido
    {
        //Creamos Variables de instancia
        private decimal _importeDelConsumo;
        private decimal _porcentajeDePropina;
        private int _numeroDePersonas;
        public decimal ImporteDelConsumo => _importeDelConsumo;
        //propiedades
        public decimal ImportePropina => _importeDelConsumo * _porcentajeDePropina / 100.0m;
        public decimal ImporteDelConsumoConPropina => _importeDelConsumo + ImportePropina;
        public decimal ImporteDelConsumoPorpersona => _importeDelConsumo / _numeroDePersonas;
        public decimal ImporteDePropinaPorPersona => ImportePropina / _numeroDePersonas;
        public decimal ImporteDelConsumoConPropinaPorPersona => ImporteDelConsumoConPropina/ _numeroDePersonas;
        //constructor
        public ConsumoCompartido (decimal consumo,decimal porcentajeDepropina, int numeroDePersonas=1)
        {
            _importeDelConsumo= consumo;
            _porcentajeDePropina= porcentajeDepropina;
            _numeroDePersonas = numeroDePersonas;

        }
    }
}
