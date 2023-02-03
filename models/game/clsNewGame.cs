namespace chessAPI.models.game;

public sealed class clsNewGame {
    public clsNewGame(){
        started = DateTime.Now;
        whites = 0;
        blacks = 0;
        turn = true;
        winner = 0;
    }

    public DateTime started { get; set; }
    public int whites { get; set; }
    public int blacks { get; set; }
    public bool turn { get; set; }
    public int winner { get; set; }
}