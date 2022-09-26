class Player{

    string name;
    List<Card> hand;

    public Player(string name){
        this.name = name;
        hand = new List<Card>();
    }

    public string Name{
        get{
            return name;
        }
    }

    public Card Draw(Deck dealt, int num){
        Card draw;
        for(int i = 0; i < num; i++){
            draw = dealt.Deal();
            hand.Add(draw);
        }
        return null!;
    }

    public Player ReadHand(){
        Card info;
        foreach(Card card in hand){
            info = new Card(card.Suit, card.Value);
            Console.WriteLine(info);
        }
        return null!;
    }

    public Card Play(int handIdx){
        Card play;
        if(handIdx < hand.Count){
            play = hand[handIdx];
            hand.RemoveAt(handIdx);
            Console.WriteLine($"-------------\nCard Played\n-------------\n{play}\n-------------");
            return play;
        }else{
            return null!;
        }
    }

}