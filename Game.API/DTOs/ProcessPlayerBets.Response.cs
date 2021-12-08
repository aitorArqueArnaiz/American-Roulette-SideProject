namespace Game.API.DTOs
{
    public class ProcessPlayerBetsResponse
    {
        public long playerId { get; set; }
        public double? playerWin { get; set; }
    }
}
