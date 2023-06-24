namespace GameLogicLibrary
{
    public class ChessGameLogic : GameLogic
    {
        public override int GetPlayerForce(int playerForce)
        {
            int output = 0;
            if (playerForce == 0)
            {
                return output;
            }

            output = playerForce * 1000;

            return output;
        }
    }
}
