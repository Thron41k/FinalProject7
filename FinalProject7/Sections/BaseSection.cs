using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.Sections;
public class BaseSection(string title, InformationBoard infoBoard)
{
    private string Title { get; } = title;
    public InformationBoard InfoBoard { private get; set; } = infoBoard;

    public void Activate()
    {
        Console.Title = Title;
    }

    public void Input(string? readLine)
    {
        InfoBoard.ClearInput();
    }
}
