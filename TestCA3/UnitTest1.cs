using CA3;
using CA3.Pages;
using CA3.Shared;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using static CA3.Shared.AllClasses;

namespace TestCA3
{
    public class UnitTest1
    {
       /* [Fact]
        public void IndexComponentDoesntRenderCorrectly()
        {
            // Arrange
            using var ctx = new TextContent();

            // Act
            var cut = ctx.RenderComponent<CA3.Pages.Index>();

            cut.MarkupMatches("<p>Calling the API has run into a problem.</p> <p>A reminder that the API can only make 10 requests per minute.</p>");
        }

        

        [Fact]
        public async Task TestParse()
        {
            var Http = new HttpClient();

            string teststring = "{\"count\":1,\"filters\":{},\"competition\":{\"id\":2021,\"area\":{\"id\":2072,\"name\":\"England\"},\"name\":\"Premier League\",\"code\":\"PL\",\"plan\":\"TIER_ONE\",\"lastUpdated\":\"2020-12-12T19:56:23Z\"},\"matches\":[{\"id\":303874,\"season\":{\"id\":619,\"startDate\":\"2020-09-12\",\"endDate\":\"2021-05-23\",\"currentMatchday\":12},\"utcDate\":\"2020-12-11T20:00:00Z\",\"status\":\"FINISHED\",\"matchday\":12,\"stage\":\"REGULAR_SEASON\",\"group\":\"Regular Season\",\"lastUpdated\":\"2020-12-12T00:55:18Z\",\"odds\":{\"msg\":\"Activate Odds-Package in User-Panel to retrieve odds.\"},\"score\":{\"winner\":\"AWAY_TEAM\",\"duration\":\"REGULAR\",\"fullTime\":{\"homeTeam\":1,\"awayTeam\":2},\"halfTime\":{\"homeTeam\":1,\"awayTeam\":1},\"extraTime\":{\"homeTeam\":null,\"awayTeam\":null},\"penalties\":{\"homeTeam\":null,\"awayTeam\":null}},\"homeTeam\":{\"id\":341,\"name\":\"Leeds United FC\"},\"awayTeam\":{\"id\":563,\"name\":\"West Ham United FC\"},\"referees\":[{\"id\":11605,\"name\":\"Michael Oliver\",\"role\":\"MAIN_REFEREE\",\"nationality\":\"England\"},{\"id\":11564,\"name\":\"Stuart Burt\",\"role\":\"ASSISTANT_N1\",\"nationality\":\"England\"},{\"id\":11488,\"name\":\"Simon Bennett\",\"role\":\"ASSISTANT_N2\",\"nationality\":\"England\"},{\"id\":11469,\"name\":\"Darren England\",\"role\":\"FOURTH_OFFICIAL\",\"nationality\":\"England\"}]}]}";
            Root test = JsonSerializer.Deserialize<Root>(teststring);
            Root test2;

            string uri = "https://api.football-data.org/v2/competitions/" + League + "/standings?standingType=TOTAL";

            test2 = await Http.GetJsonAsync<Root>(uri);

           

            await Task.CompletedTask;
            

           


        }*/
    }
}