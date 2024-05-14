using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacioCentralita
{
    public class Local : Llamada
    {
        protected float costo;


        public Local(string origen, float duracion, string destino, float costo) : base(duracion, origen, destino)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NumeroOrigen, llamada.Duracion, llamada.NumeroDestino, costo)
        {
        }


        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }


        protected override string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Tipo de Llamada: Local")
                .Append(base.Mostrar())
                .AppendLine($"Costo por Minuto: {costo:C2}")
                .AppendLine($"Costo de Llamada: {CostoLlamada:C2}")
                ;
            return text.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj?.GetType() == typeof(Local);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        private float CalcularCosto()
        {
            return costo * duracion;
        }



    }
}
