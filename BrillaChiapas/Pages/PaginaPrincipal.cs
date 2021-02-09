using BrillaChiapas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrillaChiapas.Pages
{
    public partial class PaginaPrincipal
    {
        private int score = 0;
        private int currentTime = 20;
        private int random;
        int hitPosicion = 0;
        private String message = " ";
        bool gameIsRunning = true;
        public List<PaginaPrincipalModel> matriz { get; set; } = new List<PaginaPrincipalModel>();
        int posicionPrd = new Random().Next(0, 12);
        public PaginaPrincipal()
        {
            for (int i = 0; i < 12; i++)
            {
                //for(int x = 0; x < 6; x++)
                matriz.Add(new PaginaPrincipalModel
                {
                    id = i
                });
            }
        }

        private void MouseAction(PaginaPrincipalModel model)
        {
            
            Console.WriteLine("valor de random " + posicionPrd);
            foreach (var item in matriz)
            {
                item.Acerto = false;
            }
            
            if (model.id == hitPosicion)
            {
                matriz[posicionPrd].Acerto = true;
                score += 1;
                int indice;
                indice = model.indice = 0;
                Console.WriteLine("esto es indice en if " + model.indice);
            }
            else
            {
                int indice;
                indice = model.indice = 1;
                Console.WriteLine("esto es indice " + model.indice);
            }
        }
        private void MovImagen()
        {
            int posicionPrd = new Random().Next(0, 12);
            foreach (var item in matriz)
            {
                item.Inicio = false;
            }
            int posicionPrds = new Random().Next(0, 12);
            matriz[posicionPrds].Inicio = true;
            hitPosicion = posicionPrds;
            StateHasChanged();
        }

        private async Task game()
        {
            while (gameIsRunning)
            {
                
                
                currentTime--;
                if (currentTime == 0)
                {
                    message = "FIN DEL JUEGO";
                    gameIsRunning = false;
                }
                MovImagen();
                await Task.Delay(1000);
                
                model.indice = 3;
            }
        }

        protected override async void OnInitialized()
        {
            await game();

        }
    }
}
