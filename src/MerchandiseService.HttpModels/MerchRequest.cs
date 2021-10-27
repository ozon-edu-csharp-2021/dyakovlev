namespace MerchandiseService.HttpModels
{
    public class MerchRequest
    {
        public MerchRequestEmployeeModel Employee { get; set; }
        
        public MerchType MerchType { get; set; }
    }
}