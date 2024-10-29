using FinalProject7.Sections;

namespace FinalProject7;
internal class SectionManager
{
    private readonly InformationBoard _ib = new();
    private readonly List<BaseSection> _sections = [];
    private short _activeSection = -1;
    public short ActiveSection
    {
        get => _activeSection;
        set
        {
            if (value < 0 || value >= _sections.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            _sections[value].Activate();
            _activeSection = value;
        }
    }
    public SectionManager()
    {
    
    }

    public void Input(string? readLine)
    {
        if(_activeSection == -1)return;
        _sections[_activeSection].Input(readLine);
    }

    public void Add(BaseSection section)
    {
        section.InfoBoard = _ib;
        _sections.Add(section);
    }
    public BaseSection this[int index] => _sections[index];
}

