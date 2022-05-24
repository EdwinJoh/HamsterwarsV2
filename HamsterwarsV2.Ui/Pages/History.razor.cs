using Entities.Models;
using Microsoft.AspNetCore.Components;

namespace HamsterwarsV2.Ui.Pages
{
    public partial class History :ComponentBase
    {
        protected override async Task OnInitializedAsync()
        {
            Hamsters = await _service.GetAllHamstersAsync();
            Matches = await _service.GetAllMatchesAsync();
        }
        public IEnumerable<Hamster>? Hamsters { get; set; }
        public IEnumerable<Matches>? Matches { get; set; }


        public Hamster? Winner { get; set; }
        public Hamster? Loser { get; set; }

        private void GetMatch(int winnerId, int loserId)
        {
            Winner = _service.GetMatchHamster(winnerId, Hamsters);
            Loser = _service.GetMatchHamster(loserId, Hamsters);
        }

        private void RemoveOneMatch(Matches match)
        {

        }


        private void RemoveAll()
        {

        }
        private string topPickQuantity { get; set; } = "5";
        private string CheckSelected
        {
            get
            {
                return topPickQuantity;
            }
            set
            {
                ChangeEventArgs selectedEventArgs = new ChangeEventArgs();
                selectedEventArgs.Value = value;
                OnChangeSelected(selectedEventArgs);
            }
        }
        private void OnChangeSelected(ChangeEventArgs e)
        {
            if (e.Value.ToString() != string.Empty)
            {
                topPickQuantity = e.Value.ToString();
                //GetStats(topPickQuantity);
            }
        }
    }
}
