using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PokeTamagotchiGame.ViewExceptions;

namespace PokeTamagotchiGame.View
{
    internal class Menu
    {
        private string nomeJogador = ""; // Will archive the name of the player; Vai conter o nome do jogador
        private int opcaoMenu; // Will have the Menu option selected by the player; Vai conter a opção do menu selecionada pelo jogador

        private void Separador() // Will print the Separator; Vai escrever um separador
        {
            Console.WriteLine("===============================================================================");
        }
        private void ApresentaJogo(){ // Game Apresentation name; Apresentação do nome do jogo

            this.Separador();
            
            Console.WriteLine("                            PokeTamagotchi                                     ");

            this.Separador();

        }

        private void ObtemNomeJogador() // Function that will get the player name; Função que vai obter o nome do jogador
        {
            bool continua = true;

            while(continua){ //While true will ask for the player names; Equanto verdadeiro vai perguntar o nome do jogador

                try {

                    Console.Write("Por favor, Digite o seu nome: ");

                    this.nomeJogador = Convert.ToString(Console.ReadLine());

                    //Player Name Validations; Nome do jogador validações

                    if (this.nomeJogador == "") // if the player name is null will throw the exception; Caso o nome do jogador seja nulo vai levantar um exceção
                    {
                        throw (new NotNullException("O nome do jogador não pode ser nulo"));
                    }
                    else if (char.IsDigit(this.nomeJogador[0])) // If the player name start with a number will throw one exception; Caso o nome do jogador comece com um numero vai levantar um exceção
                    {
                        throw (new CantBeANumberException("O nome do jogador não pode iniciar com número"));
                    }
                    else if (char.IsWhiteSpace(this.nomeJogador[0]))// If the player name start with a white space will throw one exception; Caso o nome do jogador inicie com um espaço em branco vai levantar um exceção
                    {
                        throw (new CantBeWhiteSpaceException("O nome do jogador não pode iniciar com espaço em branco"));
                    }
                    else if ((char.IsBetween(char.ToLower(this.nomeJogador[0]), 'a', 'z') == false))// If the player name start with one especial character will throw one exception; Caso o nome do jogador inicio com um caracter especial vai levantar uma exceção
                    {

                        throw (new CantBeSpecialCharacterExpeception("O nome do jogador não pode iniciar com caracteres especiais"));

                    }
                    else { // else is everything one with the player name will stop the while; Caso esteja tudo ok vai sair do while 
                        
                        continua = false; 
                    
                    }

                }
                catch(Exception ex){

                    Console.WriteLine(ex.Message);
                }
                
            }
            

        }

        private void ValidaOpcaoMenu(string op) // this function will validade the menu option choosed by the user; Esta função vai validar a opção do menu escolhida pelo usuário 
        {

            if (string.IsNullOrWhiteSpace(op)) { // if one menu option was not choosed by the user will throw; Se o usuário não escolher nenhuma opção vai levantar uma exceção

                throw (new NotNullException("A opção não pode ser nula"));
            }
            else if (int.TryParse(op, out _) == false) // if the user typed letters instead of one number will throw one exception; se o usuário digitar uma letra ao invés de um número vai levanter uma exceção
            {
                throw (new CantBeSpecialCharacterExpeception("A opção não pode ser letra ou caractere especial"));
            }
            else if (Convert.ToInt32(op) > 3) // if the menu menu option choosed by the user doesn't exist will throw one exception; se a opção escolhida pelo usuário seja inválida vai levantar uma exceção
            { 

                throw (new InvalidOptionException($"A opção {op} é invalida!"));
            }
            else // case is everything ok; Caso esteja tudo ok
            {
                int.TryParse(op, out this.opcaoMenu);

            }
   
        }
        private void OpcoesMenu() // Function to the menu options; Função para as opções do menu
        {

            bool continua = true;

            this.Separador();

            // Menu Options
            Console.WriteLine("1 - Adotar um mascote virtual");
            Console.WriteLine("2 - Ver seus mascotes");
            Console.WriteLine("3 - Sair do jogo");

            this.Separador();

            while (continua){ // while the user didn't choosed one valid menu option will keep asking; Enquanto o usuário não escolher uma opção valida vai ficar peguntando a opção a ser escolhida

                try
                {
                    Console.Write("Por favor, digite a opção a ser escolhida: ");

                    this.ValidaOpcaoMenu(Convert.ToString(Console.ReadLine()));

                    continua = false;
                }
                catch(Exception ex){

                    Console.WriteLine(ex.Message);

                }

            }
            

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

                    default:

                        throw (new InvalidOptionException($"A opção {this.opcaoMenu} é invalida!"));

                       
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
