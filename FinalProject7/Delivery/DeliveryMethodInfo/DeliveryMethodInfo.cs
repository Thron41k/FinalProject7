namespace FinalProject7.Delivery.DeliveryMethodInfo;

/// <summary>
/// Представляет метод доставки с именем и телефонным номером.
/// </summary>
/// <param name="name">Имя метода доставки.</param>
/// <param name="phone">Телефонный номер метода доставки.</param>
public abstract class DeliveryMethodInfo(string name, string phone)
{
    /// <summary>
    /// Возвращает имя метода доставки.
    /// </summary>
    public string Name { get; } = name;
    /// <summary>
    /// Возвращает телефонный номер метода доставки.
    /// </summary>
    public string Phone { get; } = phone;
}
