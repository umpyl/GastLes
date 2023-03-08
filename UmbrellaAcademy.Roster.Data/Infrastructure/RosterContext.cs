using System.Text.Json;

namespace UmbrellaAcademy.Roster.Data.Infrastructure
{
    public class RosterContext
    {
        public RosterContext()
        {
            var options = new JsonSerializerOptions()
            {
                MaxDepth = 5,
                PropertyNameCaseInsensitive = true
            };

            Roster = JsonSerializer.Deserialize<Domain.Roster>(_json, options)!;
        }

        public Domain.Roster Roster { get; }

        private const string _json = @"{
              ""name"": ""The Umbrella Academy"",
              ""members"": [
                {
                  ""name"": ""Luther Hargreeves"",
                  ""nicknames"": [ ""Spaceboy"", ""Number One"" ],
                  ""image"": [ ""https://static.wikia.nocookie.net/umbrellaacademy/images/3/3b/Luther_Hargreeves_TUA_S3.jpg"" ],
                  ""number"": 1,
                  ""skills"": [ ""Superhuman Strength"", ""Enhanced Resilience"" ]
                },
                {
                  ""name"": ""Diego Hargreeves"",
                  ""nicknames"": [ ""The Kraken"", ""Number Two"" ],
                  ""image"": [ ""https://static.wikia.nocookie.net/umbrellaacademy/images/1/18/Diego_s3_promo.jpeg"" ],
                  ""number"": 2,
                  ""skills"": [ ""Master Knife-Thrower"", ""Master Martial Artist"", ""Staff Proficiency"", ""Skilled Lockpicker"" ]
                },
                {
                  ""name"": ""Allison Hargreeves"",
                  ""nicknames"": [ ""The Rumor"", ""Number Three"" ],
                  ""image"": [ ""https://static.wikia.nocookie.net/umbrellaacademy/images/d/d3/Allison_s3_promo.jpeg"" ],
                  ""number"": 3,
                  ""skills"": [ ""Mental Manipulation"", ""Reality Manipulation"" ]
                },
                {
                  ""name"": ""Klaus Hargreeves"",
                  ""nicknames"": [ ""The Séance"", ""Number Four"" ],
                  ""image"": [ ""https://static.wikia.nocookie.net/umbrellaacademy/images/c/c6/Klaus_s3_promo.jpeg"" ],
                  ""number"": 4,
                  ""skills"": [ ""Mediumship"", ""Retroactive Immortality"" ]
                },
                {
                  ""name"": ""Five Hargreeves"",
                  ""nicknames"": [ ""The Boy"", ""Number Five"" ],
                  ""image"": [ ""https://static.wikia.nocookie.net/umbrellaacademy/images/b/b2/Number_Five_TUA_S3.jpg"" ],
                  ""number"": 5,
                  ""skills"": [ ""Space-Time Manipulation"", ""Teleportation"", ""Chronokinesis"" ]
                },
                {
                  ""name"": ""Ben Hargreeves"",
                  ""nicknames"": [ ""The Horror"", ""Number Six"" ],
                  ""image"": [ ""https://static.wikia.nocookie.net/umbrellaacademy/images/3/37/S2_Ben_Hargreeves_motion_poster.png"" ],
                  ""number"": 6,
                  ""skills"": [ ""Eldritch Tentacles"" ]
                },
                {
                  ""name"": ""Viktor/Vanya Hargreeves"",
                  ""nicknames"": [ ""The White Violin"", ""Number Seven"" ],
                  ""image"": [ ""https://static.wikia.nocookie.net/umbrellaacademy/images/4/4b/Viktor_Hargreeves_TUA_S3.jpg"" ],
                  ""number"": 7,
                  ""skills"": [ ""Sound Manipulation"", ""Energy Manipulation"", ""Telekinesis"", ""Atmokinesis"" ]
                }
              ]
            }";
    }
}
