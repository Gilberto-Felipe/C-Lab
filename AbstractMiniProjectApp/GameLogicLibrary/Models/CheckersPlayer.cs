namespace GameLogicLibrary.Models
{
    internal class CheckersPlayer : PlayerModel
    {
        public int PlayerForce { get; set; }

        public int GetPlayerForce(int playerForce)
        {
            int output;
            if (playerForce == 0)
            {
                output = 1000;
                return output;
            }

            output = playerForce / 2;

            return output;
        }
    }
}
