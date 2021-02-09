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
            }
            else
            {
                Console.WriteLine("ESO ES FALLO " + model.AudioAcierto);
            }
        }

        private void MovImagen()
        {
            foreach (var item in matriz)
            {
                item.Inicio = false;
            }
           
            matriz[posicionPrd].Inicio = true;
            hitPosicion = posicionPrd;
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
            }
        }

        protected override async void OnInitialized()
        {
            await game();

        }
    }
}
