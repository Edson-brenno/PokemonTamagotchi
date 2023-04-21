using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.View
{
    internal abstract class ApresentacaoAbstract
    {
        protected void Separador() // Will print the Separator; Vai escrever um separador
        {
            Console.WriteLine("===============================================================================");
        }
        protected void ApresentaJogo()
        { // Game Apresentation name; Apresentação do nome do jogo

            Separador();

            Console.WriteLine("                            PokeTamagotchi                                     ");

            Separador();

        }

        protected void EscreveMenu()
        { // Game Apresentation name; Apresentação do nome do jogo

            Console.WriteLine("                                Menu                                     ");

            
        }

        protected void EscreveEscolhaMascote() // Write Escolha Mascote; Escreve Escolha Mascote
        {
            Console.WriteLine("                           Escolha Mascote                               ");
        }

        protected void LimparTela() // Clear the console; Limpa o console
        {
            Console.Clear();
        }

    }
}
