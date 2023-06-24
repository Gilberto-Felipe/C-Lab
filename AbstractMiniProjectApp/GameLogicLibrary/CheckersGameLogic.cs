namespace GameLogicLibrary
{
    internal class CheckersGameLogic : GameLogic
    {
        public override int GetPlayerForce(int playerForce)
        {
            int output = 0;
            if (playerForce == 0)
            {
                return output;
            }

            output = playerForce * 2;

            return output;
        }
    }
}
