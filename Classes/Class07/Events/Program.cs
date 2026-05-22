
using Events.Enums;
using Events.Models;

Console.WriteLine("========== SUPER MARKET ==========");

Market market = new Market
{
    Id = 1,
    Name = "Super Market",
    ProductTypeOnPromotion = ProductType.Electronics
};

User user1 = new User(1, "Bob Bobsky", "bobsky@gmail.com", 24, ProductType.Electronics);
User user2 = new User(2, "John Doe", "john@gmail.com", 26, ProductType.Food);
User user3 = new User(3, "Jane Dane", "janedae@gmail.com", 28, ProductType.Other);

market.SubscribeForPromotion(user1.ReadPromotion, user1.Email);
market.SubscribeForPromotion(user2.ReadPromotion, user2.Email);

market.SentPromotions();

Console.ReadLine();