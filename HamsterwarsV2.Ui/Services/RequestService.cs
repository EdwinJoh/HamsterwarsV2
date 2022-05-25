using Entities.Models;
using Shared.DataTransferObjects;
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
            return respons;
        }
        public async Task VotedHamsterAsync(int id, Hamster hamster)
        {
            await _httpClient.PutAsJsonAsync($"/hamster/update/{id}", hamster);

        }
        public async Task<IEnumerable<Hamster>> GetWinnersAsync()
        {
            var respons = await _httpClient.GetFromJsonAsync<IEnumerable<Hamster>>("matches/winners");
            return respons!.OrderByDescending(w => w.Wins);
        }
        public async Task<IEnumerable<Hamster>> GetLosersAsync()
        {
            var respons = await _httpClient.GetFromJsonAsync<IEnumerable<Hamster>>("matches/losers");
            return respons!.OrderByDescending(d => d.Defeats);
        }
        public async Task<IEnumerable<MatchHistoryDto>> GetAllMatchesAsync()
        {
            var respons = await _httpClient.GetFromJsonAsync<IEnumerable<MatchHistoryDto>>("matches/matchHamsters");
            return respons!;
        }
        public Hamster GetMatchHamster(int id, IEnumerable<Hamster> hamsters)
        {
            if (hamsters.Any(i => i.Id == id))
            {
                return hamsters.Where(s => s.Id == id).Single();
            }
            else
            {
                return new Hamster { Name = "Removed" };
            }
        }

        public async Task<Hamster> CreateHamster(Hamster hamster)
        {
            var respons = await _httpClient.PostAsJsonAsync("hamster/",hamster);
            var newHamster = (await respons.Content.ReadFromJsonAsync<Hamster>());
            return newHamster;
            
        }
        public async Task<IEnumerable<Matches>> HamsterMatches(int id )
        {
            var respons = await _httpClient.GetFromJsonAsync<IEnumerable<Matches>>($"matches/matchWinners{id}");
            return respons!;
        }

        public async Task CreateMatchAsync(int winnerId, int loserId)
        {
            var newMatches = new Matches{ WinnerId = winnerId,LoserId = loserId,Timestamp = DateTime.Now };
            await _httpClient.PostAsJsonAsync($"matches", newMatches);
            
        }
    }
}
