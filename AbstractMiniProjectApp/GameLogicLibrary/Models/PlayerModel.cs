using static GameLogicLibrary.Enums;

namespace GameLogicLibrary.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public PieceColor PieceColor { get; set; } = PieceColor.Whithe;
    }
}
