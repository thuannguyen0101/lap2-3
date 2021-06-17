namespace HiTrader
{
    public class Coin
    {
        public string Symbol { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Volume { get; set; }
        public double Bid { get; set; }
        public double BidSize { get; set; }
        
        public override string ToString()
        {
            return $"Coin: {Symbol} - 24h-High: {High} - 24h-Low: {Low} - 24h-Volume: {Volume} - Bid: {Bid} - Bid Size: {BidSize}";
        }
    }
}