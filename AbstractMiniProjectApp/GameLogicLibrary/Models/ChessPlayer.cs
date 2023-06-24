namespace GameLogicLibrary.Models
{
    public class ChessPlayer : PlayerModel
    {
        public int Elo { get; set; }

        public int GetPlayerForce(int playerForce)
        {
            int output;
            if (playerForce == 0)
            {
                output = 220;
                return output;
            }

            output = playerForce * 1000;

            return output;
        }
    }
}
