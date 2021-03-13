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
        private bool gameOver;
      
        public int id
        {
            set;get;
        }
        public int nivel
        {
            set;get;
        }

        public int indice
        {
            set; get;
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

        public bool Pri
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "pri";
                }
                else
                {
                    style = "";
                }
            }
        }
        public bool Ciudadano
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "ciudadano";
                }
                else
                {
                    style = "";
                }
            }
        }
        public bool Independiente
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "independiente";
                }
                else
                {
                    style = "";
                }
            }
        }

        public bool Morena
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "morena";
                }
                else
                {
                    style = "";
                }
            }
        }

        public bool Pan
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "pan";
                }
                else
                {
                    style = "";
                }
            }
        }
        public bool Proge
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "proge";
                }
                else
                {
                    style = "";
                }
            }
        }

        public bool Pt
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "pt";
                }
                else
                {
                    style = "";
                }
            }
        }
        public bool Social
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "social";
                }
                else
                {
                    style = "";
                }
            }
        }

        public bool Solidaridad
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "solidaridad";
                }
                else
                {
                    style = "";
                }
            }
        }
        public bool Verde
        {
            get => inicio;
            set
            {
                inicio = value;
                if (inicio)
                {
                    style = "verde";
                }
                else
                {
                    style = "";
                }
            }
        }

        public bool Over
        {
            get => gameOver;
            set
            {
                gameOver = value;
                if (gameOver)
                {
                    style = "gameOvers";
                }
                else
                {
                    style = "";
                }
            }
        }
        public int Sonido
        {
            set; get;
        }

    }
}
