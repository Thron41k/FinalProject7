using FinalProject7;
using FinalProject7.Delivery;
using FinalProject7.Delivery.DeliveryMethodInfo;
using FinalProject7.Order;
using FinalProject7.Product;
using FinalProject7.Product.Categories;

var shoppingCart = new ShoppingCart();
shoppingCart.Add(new Product<NetworkEquipmentCategory>("Wi-Fi роутер Cudy WR300", "9095836", new NetworkEquipmentCategory(true, "2.4 ГГц", 4, "100 Мбит/с"), "3 LAN, 100 Мбит/с, 4 (802.11n), Wi-Fi 300 Мбит/с, IPv6", 1250, 1, "Cudy "));
shoppingCart.Add(new Product<TVCategory>("Samsung UE32T4500AUXCE", "5319240", new TVCategory("80 см", "1366x768", "60 Гц", true), "Edge LED, HD, Wi-Fi, 60 Гц, Tizen, HDMI х 2, USB х 1 шт", 29599, 1, "Samsung"));
shoppingCart.Add(new Product<FridgeCategory, Used>("OURSSON RF0480", "9078058", new FridgeCategory("106 кВтч/год", " 42 дБ", " 46 л", 1), "46 л, внешнее покрытие-металл, пластик, размораживание - ручное, 48.5 см х 49.5 см х 44.4 см", 13299, 1, "Oursson", new Used(true, 12, 7)));
var delivery = new HomeDelivery(new Courier("Петров Петр Петрович", "8-800-555-35-35", "ООО \"ООО\""), "ул. Пушкина, 1");
var order = new Order<HomeDelivery>(delivery, shoppingCart);
var id = OrderDatabase.GetInstance().AddOrder(order);
var order2 = OrderDatabase.GetInstance().GetOrderById<IOrder>(id);
if (order == order2)
    order2.WriteOrderInfo();
string? input;
do
{
    input = Console.ReadLine();
} while (!string.Equals(input, "exit"));

