using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.Model
{
    internal class Ability
    {
        public AbilityName ability { get; set; }

        public class AbilityName
        {
            public string name { get; set; }
        }
    }
}
