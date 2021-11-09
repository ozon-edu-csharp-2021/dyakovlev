using MerchandiseService.Domain.AggregationModels.ValueObjects;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPack
{
    public class MerchItemType : Enumeration
    {
        public Sku Sku { get; }


        public MerchItemType(int id, string name, Sku sku) : base(id, name)
        {
            Sku = sku;
        }

        public static MerchItemType TShirt { get; } = new(1, nameof(TShirt), 1);
        public static MerchItemType Sweatshirt { get; } = new(2, nameof(Sweatshirt), 2);
        public static MerchItemType Notepad { get; } = new(3, nameof(Notepad), 3);
        public static MerchItemType Bag { get; } = new(4, nameof(Bag), 4);
        public static MerchItemType Pen { get; } = new(5, nameof(Pen), 5);
        public static MerchItemType Socks { get; } = new(6, nameof(Socks), 6);
    }
}