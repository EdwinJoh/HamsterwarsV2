using Entities.Models;
using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects;

namespace HamsterwarsV2.Ui.Pages
{
    public partial class History : ComponentBase
    {
        public IEnumerable<Hamster>? Hamsters { get; set; }
        public IEnumerable<MatchHistoryDto>? Matches { get; set; }
        public Hamster? Winner { get; set; }
        public Hamster? Loser { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Hamsters = await _service.GetAllHamstersAsync();
            Matches = await _service.GetAllMatchesAsync();
        }

        private void GetMatch(int winnerId, int loserId)
        {
            Winner = _service.GetMatchHamster(winnerId, Hamsters);
            Loser = _service.GetMatchHamster(loserId, Hamsters);
        }

        private async void RemoveOneMatch(Matches match)
        {
            await _service.RemoveObjectAsync<Matches>("matches", match.Id);
            _nav.NavigateTo(_nav.Uri, forceLoad: true);
        }
              
      
    }
}
