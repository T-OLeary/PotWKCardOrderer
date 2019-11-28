using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Threading;

namespace PaladinsOfTheWestKingdomCardOrderer
{
    class Deck : List<Card>
    {
        public static Deck NewDeck()
        {
            Deck deck = new Deck();

            XmlReader cardTypes = XmlReader.Create("CardTypesXML.xml");

            //This moves the Xmlreader onto the first actual node (CardTypes in this case)
            cardTypes.MoveToContent();

            //Loop through the Xmlreader (God help me) until the reader gets to the end (or crashes)

            while (cardTypes.EOF != true)
            {
                Card card = Deck.FetchNextCardDetails(cardTypes);
                deck.Add(card);
            }

            cardTypes.Dispose();

            return deck;
        }

        private static Card FetchNextCardDetails(XmlReader cardTypes)
        {
            Card nextCard = new Card();
            
            return nextCard;
        }

    }
}
