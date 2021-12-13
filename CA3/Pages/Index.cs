using CA3.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CA3.Shared.AllClasses;

namespace CA3.Pages
{
    public partial class Index : ComponentBase
    {
        private Root Main;
        private string ErrorMessage;
        private string League = "PL";

        private async Task GetTaskAsync()
        {
            try
            {
                string uri = "https://api.football-data.org/v2/competitions/" + League + "/standings?standingType=TOTAL"; ;
                Main = await Http.GetJsonAsync<Root>(uri);
                ErrorMessage = String.Empty;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }


        protected override async Task OnInitializedAsync()
        {
            await GetTaskAsync();
        }

    }


}