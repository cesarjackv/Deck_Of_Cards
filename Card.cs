public class Card{
    public string Name, Suit;
    public int Value;

    public override string ToString(){
        return $"\nName: {Name}\nSuit: {Suit}\nValue: {Value}";
    }

    public Card(string suit, int val){
        if(val == 1){
            Name = "Ace";
        }else if(val == 11){
            Name = "Jack";
        }else if(val == 12){
            Name = "Queen";
        }else if(val == 13){
            Name = "King";
        }else{
            Name = val.ToString();
        }
        Suit = suit;
        Value = val;
    }

}