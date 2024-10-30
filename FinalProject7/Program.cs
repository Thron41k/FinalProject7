using FinalProject7;
using FinalProject7.Sections;

var sm = new SectionManager();
sm.Add(new FirstSection("Главный раздел"));
sm.ActiveSection = 0;
string? input;
do
{
    input = Console.ReadLine();
    sm.Input(input);
} while (!string.Equals(input, "exit"));

