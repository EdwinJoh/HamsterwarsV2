using Entities.Models;
using Microsoft.AspNetCore.Components;
using Radzen;
using SharedHelpers.DataTransferObjects;


namespace HamsterwarsV2.Ui.Pages
{
    public partial class History : ComponentBase
    {

        public IEnumerable<MatchHistoryDto>? Matches { get; set; }
        public IEnumerable<MatchHistoryDto>? SelectedMatches { get; set; }
        void ClearSelection()
        {
            SelectedMatches = null;
        }

        protected override async Task OnInitializedAsync()
        {
            Matches = await _service.GetAllMatchesAsync();
            SelectedMatches = Matches.Take(1).ToList();
        }


        private async void DeleteRow(int id)
        {
            await _service.RemoveObjectAsync<Matches>("matches", id);
            Matches = await _service.GetAllMatchesAsync();
            //this.StateHasChanged();
            //_nav.NavigateTo(_nav.Uri, forceLoad: true);
        }

    }
}
