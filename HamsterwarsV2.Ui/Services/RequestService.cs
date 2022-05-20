using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

using System.Threading.Tasks;

namespace HamsterwarsV2.Ui.Services
{
    public class RequestService : IRequestService
    {
        private readonly HttpClient _httpClient;

        public RequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Hamster>> GetAllHamstersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<Hamster>>("hamster");
            return response!;
        }
        public async Task RemoveObjectAsync<T>(string objType, int id)
        {
            await _httpClient.DeleteAsync($"{objType}/delete/{id}");
        }
        public async Task<Hamster> GetRandomHamsterAsync()
        {
            var respons = await _httpClient.GetFromJsonAsync<Hamster>("hamster/random");
            return respons!;
        }
        public async Task VotedHamsterAsync(int id,Hamster hamster)
        {
            await _httpClient.PutAsJsonAsync($"/hamster/update/{id}",hamster);

        }
    }
}
