using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPack
{
    public class MerchPackType : Enumeration
    {
        public IEnumerable<MerchItem> Items { get; } = new MerchItem[] {};
        
        public MerchPackType(int id, string name, IEnumerable<MerchItem> items) : base(id, name)
        {
            Items = items;
        }

        public static MerchPackType WelcomePack { get; } = new MerchPackType(1, nameof(WelcomePack), new []
        {
            new MerchItem(MerchItemType.Notepad), 
            new MerchItem(MerchItemType.Pen)
        });
        
        public static MerchPackType StarterPack { get; } = new MerchPackType(2, nameof(StarterPack), new []
        {
             new MerchItem(MerchItemType.Notepad), 
             new MerchItem(MerchItemType.Pen),
             new MerchItem(MerchItemType.TShirt)
        });
        public static MerchPackType ConferenceListenerPack { get; } = new MerchPackType(3, nameof(ConferenceListenerPack), new []
        {
            new MerchItem(MerchItemType.Notepad), 
            new MerchItem(MerchItemType.Pen),
            new MerchItem(MerchItemType.TShirt),
            new MerchItem(MerchItemType.Bag),
        });
        public static MerchPackType ConferenceSpeakerPack { get; } = new MerchPackType(4, nameof(ConferenceSpeakerPack), new []
        {
            new MerchItem(MerchItemType.Notepad), 
            new MerchItem(MerchItemType.Pen),
            new MerchItem(MerchItemType.TShirt),
            new MerchItem(MerchItemType.Bag),
            new MerchItem(MerchItemType.Socks),
        });
        public static MerchPackType VeteranPack { get; } = new MerchPackType(5, nameof(VeteranPack), new []
        {
            new MerchItem(MerchItemType.Notepad), 
            new MerchItem(MerchItemType.Pen),
            new MerchItem(MerchItemType.TShirt),
            new MerchItem(MerchItemType.Bag),
            new MerchItem(MerchItemType.Socks),
            new MerchItem(MerchItemType.Sweatshirt),
        });
    }
}