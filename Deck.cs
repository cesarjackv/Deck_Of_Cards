public class Deck{

    public List<Card> cards = new List<Card>();
    public Deck(){
        Reset();
    }

    public List<Card> Reset(){
        cards.Clear();
        string[] suits = {
            "Hearts",
            "Diamonds",
            "Spades",
            "Clubs"
        };

        foreach(string suit in suits){
            for(int i = 1; i < 14; i++){
                cards.Add(new Card(suit, i));
            }
        }
        return cards;
    }

    public Card Deal(){
        Card dealt = cards[0];
        cards.RemoveAt(0);
        return dealt;
    }

    public void Shuffle(){
        List<Card> unshuffled = this.cards;
        List<Card> shuffled = new List<Card>();
        Random rand = new Random();

        while(unshuffled.Count > 0){
            int i = rand.Next(unshuffled.Count);
            shuffled.Add(unshuffled[i]);
            unshuffled.RemoveAt(i);
        }

        this.cards = shuffled;
    }

}