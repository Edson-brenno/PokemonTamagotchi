using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.View
{
    internal class Menu
    {
        private string nomeJogador = "";
        private int opcaoMenu;

        private void Separador()
        {
            Console.WriteLine("===============================================================================");
        }
        private void ApresentaJogo(){

            this.Separador();
            
            Console.WriteLine("                            PokeTamagotchi                                     ");

            this.Separador();

        }

        private void ObtemNomeJogador()
        {
            Console.Write("Por favor, Digite o seu nome: ");

            this.nomeJogador = Convert.ToString(Console.ReadLine());

        }
        private void OpcoesMenu()
        {
            this.Separador();

            Console.WriteLine("1 - Adotar um mascote virtual");
            Console.WriteLine("2 - Ver seus mascotes");
            Console.WriteLine("3 - Sair do jogo");

            this.Separador();

            Console.Write("Por favor, digite a opção a ser escolhida: ");

            this.opcaoMenu = Convert.ToInt32(Console.ReadLine());

            switch (this.opcaoMenu)
                {
                    case 1:

                        Console.WriteLine("Bem vindo a adoção do seu mascote");
                        break;

                    case 2:

                        Console.WriteLine("vendo seu mascote");
                        break;

                    case 3:

                        Console.WriteLine("Saindo do jogo...");

                        break;

             }
            
               
        }

        public void Main()
        {

            this.ApresentaJogo();

            this.ObtemNomeJogador();

            this.OpcoesMenu();
        }
    }
}
