using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.Model
{
    internal class Pokemon
    {
        public string name {  get; set; }
        public int height { get; set; }

        public int weight { get; set; }

        public List<Ability> abilities { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.name} \n Altura: {this.height} \n Peso: {this.weight} \n Habilidades";
        }
    }

    
}
