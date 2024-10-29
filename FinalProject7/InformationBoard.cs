namespace FinalProject7;
public class InformationBoard
{
    private const int BoardWidth = 40;
    private const int BoardHeight = 5;
    public InformationBoard()
    {
        Console.Write('\u2554');
        for (var i = 0; i < BoardWidth + 1; i++)
        {
            Console.Write('\u2550');
        }
        Console.Write('\u2557');
        Console.SetCursorPosition(BoardWidth / 2 + 1, 0);
        Console.Write('\u2566');
        Console.WriteLine();



        for (var i = 0; i < BoardHeight; i++)
        {
            Console.Write('\u2551');
            Console.CursorLeft = BoardWidth / 2 + 1;
            Console.Write('\u2551');
            Console.CursorLeft = BoardWidth + 2;
            Console.Write('\u2551');
            Console.WriteLine();
        }

        Console.Write('\u255A');
        for (var i = 0; i < BoardWidth + 1; i++)
        {
            Console.Write('\u2550');
        }
        Console.Write('\u255D');
        Console.SetCursorPosition(BoardWidth / 2 + 1, BoardHeight + 1);
        Console.Write('\u2569');
        Console.WriteLine();
        SetBusket(10);
        SetOrders(0);
        const string text = "Навигация";
        Console.SetCursorPosition(2 + BoardWidth / 2 + (2 + BoardWidth / 2 - text.Length) / 2, 0);
        Console.Write(text);
        Console.SetCursorPosition(0, BoardHeight + 2);
        Console.WriteLine();
        Console.Write("Ввод: ");
    }

    public void SetBusket(short count)
    {
        var basket = $"Корзина: {count}";
        Console.SetCursorPosition((1 + BoardWidth / 2 - basket.Length) / 2, 2);
        Console.Write(basket);
    }

    public void SetOrders(short count)
    {
        var order = $"Заказы: {count}";
        Console.SetCursorPosition((1 + BoardWidth / 2 - order.Length) / 2, 4);
        Console.Write(order);
    }

    public void ClearInput()
    {
        Helpers.ClearCurrentConsoleLine(0, BoardHeight + 3);
    }
}

