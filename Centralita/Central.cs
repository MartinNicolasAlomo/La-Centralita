using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace EspacioCentralita
{
    public class Central
    {
        private List<Llamada> listaDeLlamadas;
        protected string? razonSocial;


        public Central()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Central(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }


        public float GananciasPorLocal
        {
            get { return CalcularGanancias(ETipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancias(ETipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancias(ETipoLlamada.Total); }
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }



        private const sbyte ESP_COLM_1 = -20;
        private const sbyte ESP_COLM_2 = -10;

        private string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"{"Razon Social:",ESP_COLM_1}                  {razonSocial,ESP_COLM_2}")
                .AppendLine($"{"Ganancias llamados Locales:",ESP_COLM_1}        {GananciasPorLocal.ToString("C2"),ESP_COLM_2}")
                .AppendLine($"{"Ganancias llamados Provinciales:",ESP_COLM_1}   {GananciasPorProvincial.ToString("C2"),ESP_COLM_2}")
                .AppendLine($"{"Ganancias Totales:",ESP_COLM_1}                 {GananciasPorTotal.ToString("C2"),ESP_COLM_2}")
                .AppendLine(Environment.NewLine);
            foreach (Llamada llamada in listaDeLlamadas)
            {
                text.AppendLine(llamada.ToString());
            }
            return text.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
        
        private float CalcularGanancias(ETipoLlamada tipo)
        {
            float gananciasTotales = 0;
            if (tipo == ETipoLlamada.Local)     //  llamada is Local llamadaLocal
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if (llamada is not null && llamada.GetType() == typeof(Local))
                    {
                        gananciasTotales += llamada.CostoLlamada;
                    }
                }
            }
            else if (tipo == ETipoLlamada.Provincial)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if (llamada.GetType() == typeof(Provincial))
                    {
                        gananciasTotales += llamada.CostoLlamada;
                    }
                }
            }
            else
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    gananciasTotales += llamada.CostoLlamada;
                }
            }
            return gananciasTotales;
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdernarPorDuracion);
        }


        public static bool operator ==(Central centralita, Llamada llamadaRecibida)
        {
            // Determinamos si esta llamada pertenece a la lista de llamadas
            if (centralita.listaDeLlamadas.Count > 0 && llamadaRecibida is not null)
            {
                foreach (Llamada llamadaExistente in centralita.listaDeLlamadas)
                {
                    if (llamadaRecibida == llamadaExistente)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Central centralita, Llamada llamadaRecibida)
        {
            return !(centralita == llamadaRecibida);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator +(Central centralita, Llamada llamadaRecibida)
        {
            if (centralita != llamadaRecibida)
            {
                centralita.AgregarLlamada(llamadaRecibida);
                return true;
            }
            return false;
        }

        /*
                 public static bool operator +(Coleccion coleccion, Pokemon pokemonAtrapado)
        {
            // Evaluamos que la lista de competidores tenga espacios y ademas que el nuevo competidor no exista 
            if (coleccion.Equipo.Count < cantMaxEquipo && coleccion.Equipo != pokemonAtrapado )
            {
                coleccion.Equipo.pokemonBatalla.Add(pokemonAtrapado);
                return true;
            }
            else if (coleccion.PC.Count < cantMaxPC && coleccion.PC != pokemonAtrapado )
            {

                coleccion.Equipo.pokemonBatalla.Add(pokemonAtrapado);
                return true;
            }
            return false;
        }
         
         
         
         
         */




    }
}