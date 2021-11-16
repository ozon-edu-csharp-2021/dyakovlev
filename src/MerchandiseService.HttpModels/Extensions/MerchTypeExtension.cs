using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.HttpModels.Extensions
{
    public static class MerchTypeExtension
    {
        public static MerchPackType ToMerchPackType(this MerchType merchType)
        {
            return merchType switch
            {
                MerchType.StarterPack => MerchPackType.StarterPack,
                MerchType.WelcomePack => MerchPackType.WelcomePack,
                MerchType.ConferenceListenerPack => MerchPackType.ConferenceListenerPack,
                MerchType.ConferenceSpeakerPack => MerchPackType.ConferenceSpeakerPack,
                MerchType.VeteranPack => MerchPackType.VeteranPack,
            };
        }
    }
}