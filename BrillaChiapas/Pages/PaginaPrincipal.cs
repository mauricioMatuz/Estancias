using BrillaChiapas.Componets;
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
        int time = 2500;
        private String message = " ";
        bool gameIsRunning = true;
        int[] posicionPrds;
        public List<PaginaPrincipalModel> matriz { get; set; } = new List<PaginaPrincipalModel>();
        public List<PaginaPrincipalModel> matriz2 { get; set; } = new List<PaginaPrincipalModel>();
        public void prueba()
        {
            posicionPrds = Random(0, 12);
        }
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

        private void MovImagen()
        {
            foreach (var item in matriz)
            {
                item.Inicio = false;
                item.Ciudadano = false;
                item.Independiente = false;
                item.Morena = false;
                item.Pan = false;
                item.Pri = false;
                item.Proge = false;
                item.Pt = false;
                item.Social = false;
                item.Solidaridad = false;
                item.Verde = false;
                item.Over = false;
            }
            posicionPrds = Random(0, 12);
            int a = 0;
            while (a < 12)
            {
                matriz[posicionPrds[a]].Inicio = true;
                a++;
                matriz[posicionPrds[a]].Ciudadano = true;
                a++;
                matriz[posicionPrds[a]].Independiente = true;
                a++;
                matriz[posicionPrds[a]].Independiente = true;
                a++;
                matriz[posicionPrds[a]].Morena = true;
                a++;
                matriz[posicionPrds[a]].Pan = true;
                a++;
                matriz[posicionPrds[a]].Pri = true;
                a++;
                matriz[posicionPrds[a]].Proge = true;
                a++;
                matriz[posicionPrds[a]].Pt = true;
                a++;
                matriz[posicionPrds[a]].Social = true;
                a++;
                matriz[posicionPrds[a]].Solidaridad = true;
                a++;
                matriz[posicionPrds[a]].Verde = true;
                a++;
            }
            hitPosicion = posicionPrds[0];
            if (currentTime == 0)
            {
    
                matriz.Clear();
                matriz.Add(new PaginaPrincipalModel
                {
                    id = 1
                });
                matriz[0].Over = true;
                Console.WriteLine("SI BORRA");
                
            }
            StateHasChanged();
        }

        private async Task BotonReicioAsync() {
            matriz.Clear();
            for (int i = 0; i < 12; i++)
            {
                //for(int x = 0; x < 6; x++)
                matriz.Add(new PaginaPrincipalModel
                {
                    id = i
                });
            }
            score = 0;
            currentTime = 20;
            hitPosicion = 0;
            message = " ";
            gameIsRunning = true;
            await game();
        }


        private void MouseAction(PaginaPrincipalModel model)
        {
            //foreach (var item in matriz)
            //{
            //    item.Acerto = false;
            //    item.Ciudadano = false;
            //    item.Independiente = false;
            //    item.Morena = false;
            //    item.Pan = false;
            //    item.Pri = false;
            //    item.Proge = false;
            //    item.Pt = false;
            //    item.Social = false;
            //    item.Solidaridad = false;
            //    item.Verde = false;
            //}
            if (model.id == hitPosicion && currentTime > 0)
            {
                matriz[posicionPrds[0]].Acerto = true;
                matriz[posicionPrds[11]].Ciudadano = true;
                matriz[posicionPrds[1]].Independiente = true;
                matriz[posicionPrds[2]].Independiente = true;
                matriz[posicionPrds[3]].Morena = true;
                matriz[posicionPrds[4]].Pan = true;
                matriz[posicionPrds[5]].Pri = true;
                matriz[posicionPrds[6]].Proge = true;
                matriz[posicionPrds[7]].Pt = true;
                matriz[posicionPrds[8]].Social = true;
                matriz[posicionPrds[9]].Solidaridad = true;
                matriz[posicionPrds[10]].Verde = true;
                hitPosicion = posicionPrds[0];
                score += 1;
                model.indice = 0;
                time = 1000;
            }
            else
            {
                model.indice = 1;
                time = 1000;
            }
           
            model.Sonido = currentTime;
            time = 2500;
        }

        
        public int[] Random(int inico, int fin)
        {
            int[] guardarNumero = new int[12];
            int i = 0;
            
            guardarNumero[i] = new Random().Next(inico, fin);
            for(i = 1; i < guardarNumero.Length; i++)
            {
                guardarNumero[i] = new Random().Next(inico, fin);
                for (int x = 0; x < i; x++)
                {
                    if(guardarNumero[i] == guardarNumero[x])
                    {
                        i--;
                    }
                }
            }
            return guardarNumero;
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
                Console.WriteLine(time + " TIME");
                await Task.Delay(time);
            }
        }

        protected override async void OnInitialized()
        {
           
            await game();
        }
    }
}
