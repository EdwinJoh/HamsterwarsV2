using Entities.Models;
using Microsoft.AspNetCore.Components;
using SharedHelpers.DataTransferObjects;
using Syncfusion.Blazor.Grids;

namespace HamsterwarsV2.Ui.Pages
{
    public partial class History : ComponentBase
    {
        //public IEnumerable<Hamster>? Hamsters { get; set; }
        public IEnumerable<MatchHistoryDto>? Matches { get; set; }
        public List<MatchHistoryDto>? test { get; set; }
        public Hamster? Winner { get; set; }
        public Hamster? Loser { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //Hamsters = await _service.GetAllHamstersAsync();
            Matches = await _service.GetAllMatchesAsync();
            test = (List<MatchHistoryDto>?)await _service.GetAllMatchesAsync();

        }

        //private void GetMatch(int winnerId, int loserId)
        //{
        //    Winner = _service.GetMatchHamster(winnerId, Hamsters);
        //    Loser = _service.GetMatchHamster(loserId, Hamsters);
        //}

        private async void RemoveOneMatch(Matches match)
        {
            await _service.RemoveObjectAsync<Matches>("matches", match.Id);
            _nav.NavigateTo(_nav.Uri, forceLoad: true);
        }
        private SfGrid<MatchHistoryDto> DefaultGrid;
        public int GridHeight;
        public void Load(object args)
        {
            var RowHeight = 37; //height of the each row
            Int32.TryParse(this.DefaultGrid.Height, out GridHeight); //datagrid height
            var PageSize = (this.DefaultGrid.PageSettings as GridPageSettings).PageSize; //initial page size
            decimal PageResize = ((GridHeight) - (PageSize * RowHeight)) / RowHeight; //new page size is obtained here
#pragma warning disable BL0005
            (this.DefaultGrid.PageSettings as GridPageSettings).PageSize = PageSize + (int)Math.Round(PageResize);
#pragma warning restore BL0005
        }
    }
}
