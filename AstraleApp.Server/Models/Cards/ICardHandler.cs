namespace AstraleApp.Server.Models.Cards
{
  public struct Vector2f_t
  { 
    public float X;
    public float Y;
  }

  public interface ICardHandler
  {
    public Vector2f_t Position(Vector2f_t deltaPosition)
    {
      return deltaPosition;
    }

    public Vector2f_t Direction(Vector2f_t deltaDirection)
    {
      return deltaDirection;
    }
    // what are these select of methods? ...Position? ...Direction?
    // - improve upon these methods

    public TradingCard Trade(TradingCard cardA, TradingCard cardB)
    {
      (cardA, _) = (cardB, cardA); // using C# syntactic-sugar swap expression
      // discard inside swap with "_" (underscore) expression
      // use the Disjoing Set Union methods we "stole"
      return cardA;
    }

    public List<TradingCard> InHands(TradingCard card, List<TradingCard> tradingCards)
    {
      if (card.Equals(tradingCards.First())) 
      {
        tradingCards.Remove(card);
      }

      tradingCards.Add(card);

      return tradingCards;
    }
    // have a UInt16 instance validation method instead of this
  }
}
