using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.Sections;
public abstract class BaseSection(string title)
{
    protected string Title { get; } = title;
    public InformationBoard InfoBoard { private get; set; }
    protected Dictionary<short, string>? _mainNavigationList { get; set; } = null;

    public abstract void Activate();

    public void Input(string? readLine)
    {
        InfoBoard.ClearInput();
    }
}
