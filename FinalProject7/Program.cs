using FinalProject7;
using FinalProject7.Sections;

var sm = new SectionManager();
sm.Add(new FirstSection("Главный раздел"));
string? input;
do
{
    input = Console.ReadLine();
} while (!string.Equals(input, "exit"));

