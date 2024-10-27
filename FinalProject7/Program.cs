using FinalProject7;

var ib = new InformationBoard();
var input = "";
do
{
    ib.Input(Console.ReadLine());
} while (!string.Equals(input, "exit"));

