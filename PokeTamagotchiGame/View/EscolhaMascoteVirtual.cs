using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PokeTamagotchiGame.Controller;
using PokeTamagotchiGame.Model;
using PokeTamagotchiGame.ViewExceptions;

namespace PokeTamagotchiGame.View
{
    internal class EscolhaMascoteVirtual: ApresentacaoAbstract
    {

        private int _offset = 1;
        private int _opcaoEscolhida;
        private Pokemon _Mascote { get; set; }
        private AdocaoMascote _adocaoMascote = new AdocaoMascote();

        private void _ApresentaEscolhaMascote() // Will Write the apresentation of EscolhaMascote; Vai fazer as apresentação da opção escolha mascote
        {
            base.LimparTela();

            base.Separador();

            base.EscreveEscolhaMascote();

            base.Separador();
        }
        private void _Opcoes() // Will write the options to choose the mascot; Vai escrever as opções para escolha do mascote
        {
               if (this._offset == 1) // If is the first mascot to be showed; Caso o primeiro mascote
               {
                    Console.WriteLine(" 1 - Escolher este Mascote  \n 2 - Proximo Mascote  \n 3 - Voltar para o Menu anterior");
               }
               else
               {
                    Console.WriteLine(" 1 - Escolher este Mascote \n 2 - Mascote Anterior \n 3 - Proximo Mascote \n 4 - Voltar para o Menu anterior");
                }
            
        }

        private void _ValidarOpcaoEscolhida(string op, int totalAlternativas) // This function will do a validation of the option choosed by the user; Esta Função vai fazer uma validação da opção escolhida pelo usuario
        {
            if (string.IsNullOrWhiteSpace(op))
            { // if one menu option was not choosed by the user will throw; Se o usuário não escolher nenhuma opção vai levantar uma exceção

                throw (new NotNullException("A opção não pode ser nula"));
            }
            else if (int.TryParse(op, out _) == false) // if the user typed letters instead of one number will throw one exception; se o usuário digitar uma letra ao invés de um número vai levanter uma exceção
            {
                throw (new CantBeSpecialCharacterExpeception("A opção não pode ser letra ou caractere especial"));
            }
            else if (Convert.ToInt32(op) > totalAlternativas) // if the menu menu option choosed by the user doesn't exist will throw one exception; se a opção escolhida pelo usuário seja inválida vai levantar uma exceção
            {

                throw (new InvalidOptionException($"A opção {op} é invalida!"));
            }
            else // case is everything ok; Caso esteja tudo ok
            {
                int.TryParse(op, out this._opcaoEscolhida);

            }
        }
        private void _PerguntarOpcaoEscolhida() // Will ask the user the option to be choosed; Vai perguntar ao usuário qual opção ele escolherá
        {
            bool continua = true;

            while (continua) { //While the option is not valid will keep asking; enquanto a opção não for vai continuar perguntando

                try
                {
                    Console.Write("Digite a opção escolhida: ");

                    if (this._offset == 1)
                    {
                        this._ValidarOpcaoEscolhida(Convert.ToString(Console.ReadLine()), 3);
                    }
                    else
                    {
                        this._ValidarOpcaoEscolhida(Convert.ToString(Console.ReadLine()), 4);
                    }

                    continua = false;
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            
            
        }

        private void _MostraPokemon() // Will show the reponse from the api; Vai mostrar a resposta da api
        {
            
            this._ApresentaEscolhaMascote();

            Console.Write("\n                          Obtendo dados...."); // Will show this mensage while is getting the data; Vai mostrar esta mensagem enquanto está obtendo os dados

            Console.SetCursorPosition(0, Console.CursorTop);

            this._Mascote = this._adocaoMascote.ListarPokemon(_offset);

            Console.Write($"{this._Mascote} \n\n");

            base.Separador();

            this._Opcoes();

            base.Separador();

            this._PerguntarOpcaoEscolhida();

        }
        internal void Main() // Function which will run what is needed; Função que vai rodar o que é necessário
        {

            bool continua = true;

            while (continua)
            {

                if (this._offset == 1)
                {
                    switch (this._opcaoEscolhida)
                    {

                        case 0:

                            this._MostraPokemon();

                            break;

                        case 1:

                            this._adocaoMascote.EscolherPokemon(this._offset, this._Mascote);

                            continua = false;

                            break;

                        case 2:

                            this._offset += 1;

                            this._MostraPokemon();

                            break;

                        case 3:

                            this._offset = 1;

                            continua = false;

                            Menu menu = new Menu();

                            menu.OpcoesMenu();
                            break;
                    }
                }
                else
                {
                    switch (this._opcaoEscolhida)
                    {

                        case 1:

                            this._adocaoMascote.EscolherPokemon(this._offset, this._Mascote);

                            continua = false;

                            break;

                        case 2:

                            this._offset -= 1;

                            this._MostraPokemon();

                            break;

                        case 3:

                            this._offset += 1;

                            this._MostraPokemon();

                            break;

                        case 4:

                            this._offset = 1;

                            continua = false;

                            Menu menu = new Menu();

                            menu.OpcoesMenu();

                            break;
                    }
                }
            } 


        }
    }
}
