using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacioCentralita
{
    public enum EFranjas { Franja_1, Franja_2, Franja_3 }

    public class Provincial : Llamada
    {
        protected EFranjas franjaHoraria;


        public Provincial(EFranjas miFranja, Llamada llamada) : this(llamada.NumeroOrigen, miFranja, llamada.Duracion, llamada.NumeroDestino)
        {
        }

        public Provincial(string origen, EFranjas miFranja, float duracion, string destino) : base(duracion, origen, destino)
        {
            franjaHoraria = miFranja;
        }


        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }


        protected override string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Tipo de Llamada: Provincial")
                .Append(base.Mostrar())
                .AppendLine($"Franja Horaria: {franjaHoraria}")
                .AppendLine($"Costo de Llamada: {CostoLlamada:C2}")
                ;
            return text.ToString();
        }

        private float CalcularCosto()
        {
            switch (franjaHoraria)
            {
                case EFranjas.Franja_1:
                    return 0.99f * duracion;
                case EFranjas.Franja_2:
                    return 1.25f * duracion;
                case EFranjas.Franja_3:
                    return 0.66f * duracion;
                default:
                    return 0;
            }
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object? obj)
        {
            return obj.GetType() == typeof(Provincial);
        }



    }
}
