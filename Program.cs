using SeaBattle_3;
using System.Drawing;

Board AIboard = new Board();
Board Myboard = new Board();


Myboard.MyGenerateShips();

AIboard.AIGenerateShips();

Console.WriteLine();
Game(AIboard, Myboard);

void Game(Board AIboard, Board Myboard)
{
    Thread.Sleep(5000);
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("         ИГРА НАЧАТА!");
    Thread.Sleep(500);
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("             3");
    Thread.Sleep(300);
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("             2");
    Thread.Sleep(300);
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("             1");
    Thread.Sleep(300);
    Console.Clear();
    while (true)
    {
        AIboard.AIShot(Myboard);
        bool flag = false;
        for (var i = 0; i < Board.Size; i++)
        {
            for (var j = 0; j < Board.Size; j++)
            {
                if (AIboard.CellMas[i, j].State == CellState.Ship)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                break;
        }
        if (!flag)
        {
            Console.WriteLine("ИГРА ОКОНЧЕНА!");
            break;
        }
        Myboard.MyShot(AIboard);
    }
}