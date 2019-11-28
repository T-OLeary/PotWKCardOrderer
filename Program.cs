using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaladinsOfTheWestKingdomCardOrderer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialise a deck of cards on start up. Full list just typed out initially

            Deck deck = Deck.newDeck();

            //Set order by to null, as the order is not known. Set turn to 1, as the first draw will
            //take place at the beginning of the first turn.

            //How to do input and confirmation? Console based app, so... what?
            //Well, could get user to conifmr what the cards are once they are drawn.
            //Need some form of immediate input validation as it can't wait until after 'the draft'
            //until the names are checked, too much is then immediately put on the user at the point
            //where in theory, in the game, they are supposed to be beginning their turn.

            //Take initial name input, then respond with either name not found, or ask user to confirm
            //that the card is correct.

            //User cannot confirm what they have done with the cards until after all three draws have been
            //validated / verified.

            //For played card: set TurnPlayed value to current turn, then set CardOrder value to null
            //For retained card: set CardOrder to 1
            //For card put on bottom of deck: set CardOrder

        }
    }
}
