using Events.Enums;

namespace Events.Models
{
    public class Market
    {
        public delegate void PromotionHandler(ProductType productType);
        private event PromotionHandler OnPromotionSent;

        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductTypeOnPromotion { get; set; }
        List<string> SubscribersEmails { get; set; } = [];
        List<string> UnsubscribeReasons { get; set; } = [];

        public void SubscribeForPromotion(PromotionHandler handler, string email)
        {
            OnPromotionSent += handler;
            SubscribersEmails.Add(email);
        }

        public void SentPromotions()
        {
            Console.WriteLine("==========");
            Console.WriteLine($"Market {Name} is sending promotions for {ProductTypeOnPromotion}");
            Console.WriteLine("...Sending...");
            Thread.Sleep(2000);
            NotifySubscribers();
        }

        private void NotifySubscribers()
        {
            OnPromotionSent(ProductTypeOnPromotion);
        }
    }
}
