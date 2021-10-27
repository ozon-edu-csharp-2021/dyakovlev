using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseService.HttpModels;

namespace MerchandiseService.HttpClient
{
    public class MerchandiseHttpClient
    {
        private System.Net.Http.HttpClient _httpClient;

        public MerchandiseHttpClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MerchResponse> RequestMerch(MerchRequest request, CancellationToken ct)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync("/api/v1/request-merch", request, ct);
            return await responseMessage.Content.ReadFromJsonAsync<MerchResponse>();
        }
        
        public async Task<MerchDeliveredResponse> CheckMerchDelivered(MerchDeliveredRequest request, CancellationToken ct)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync("/api/v1/check-delivered", request, ct);
            return await responseMessage.Content.ReadFromJsonAsync<MerchDeliveredResponse>();
        }
    }
}