using SeaBattle_3;
using System.Drawing;

Board AIboard = new Board();
Board Myboard = new Board();


Notifications Notify = new Notifications();

AIboard.Hit += Notify.DisplayAIMsg;
AIboard.DefeatOfTheShip += Notify.DisplayAIMsg;
AIboard.Miss += Notify.DisplayMyMsg;
AIboard.Win += Notify.DisplayMyMsg;

Myboard.Hit += Notify.DisplayMyMsg;
Myboard.DefeatOfTheShip += Notify.DisplayAIMsg;
Myboard.Miss += Notify.DisplayMyMsg;
Myboard.Win += Notify.DisplayMyMsg;

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

        if (!CheckBoard(Myboard))
        {
            AIboard.OnWin("ПОБЕДИЛ ИИ.");
            break;
        }
        Myboard.MyShot(AIboard);
        if (!CheckBoard(AIboard))
        {
            Myboard.OnWin("ВЫ ПОБЕДИЛИ.");
            break;
        }
    }
}

bool CheckBoard(Board board)
{
    bool flag = false;
    for (var i = 0; i < Board.Size; i++)
    {
        for (var j = 0; j < Board.Size; j++)
        {
            if (board.CellMas[i, j].State == CellState.Ship)
            {
                flag = true;
                break;
            }
        }
        if (flag)
            break;
    }
    return flag;
}

internal class Notifications
{
    public void DisplayAIMsg(string msg)
    {
        Console.WriteLine(msg);
    }
    public void DisplayMyMsg(string msg)
    {
        Console.WriteLine(msg);
    }
}