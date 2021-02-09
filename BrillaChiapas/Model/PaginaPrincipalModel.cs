using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrillaChiapas.Model
{
    public class PaginaPrincipalModel
    {
        private bool inicio;
        private bool acerto;
        public int id
        {
            set;get;
        }
        public String style
        {
            set; get;
        }

        public bool Inicio
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "mole";
                }
                else
                {
                    style = "";
                }
            }
        }
        public bool Acerto
        {
            get => acerto;
            set
            {
                acerto = value;
                if (acerto)
                {
                    style = "acerto";
                }
                else
                {
                    style = "";
                }
            }
        }
        public class Sonido
        {
            public bool reproduciendo { get; set; }
          public String rutaSonido { get; set; }
        }
        
        Sonido[] sonidos = new Sonido[]
        {
        new Sonido{ reproduciendo = false, rutaSonido = "sound/correcto.wav"},
        };

    }
}
