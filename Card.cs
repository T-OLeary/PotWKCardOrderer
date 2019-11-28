using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaladinsOfTheWestKingdomCardOrderer
{
    class Card
    {
        public int ID;
        public string PaladinName;
        public List<int> Workers;
        public List<int> Attributes;
        public int EffectID;
        public int? DeckOrder;
        public int? PlayedTurn;
    }
}
