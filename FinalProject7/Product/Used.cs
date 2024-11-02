namespace FinalProject7.Product;

public class Used(bool afterRenavation, int monthsInUse, short state)
{
    public bool AfterRenavation { get; } = afterRenavation;
    public int MonthsInUse { get; } = monthsInUse;
    public short State { get; } = state;
}