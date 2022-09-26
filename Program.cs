Card cards = new Card("Hearts", 13);
// Console.WriteLine(cards);

Deck deck = new Deck();
deck.Shuffle();
// foreach(Card card in deck.cards){
//     Console.WriteLine(card);
// }

Player Cesar = new Player("Cesar");
Cesar.Draw(deck, 4);
Cesar.ReadHand();
Cesar.Play(3);
Cesar.ReadHand();
