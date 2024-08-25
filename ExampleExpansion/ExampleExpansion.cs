using Exiled.API.Features;
using PlaceholderAPI.API.Abstract;

namespace ExampleExpansion
{
    public class ExampleExpansion : PlaceholderExpansion
    {
        public override string Author { get; set; } = "NotZer0Two";
        public override string Identifier { get; set; } = "example";
        public override string RequiredPlugin { get; set; } = null;

        public override string OnRequest(Player player, string param)
        {
            return $"Hello, {player.Nickname}";
        }

        public override string OnOfflineRequest(string param)
        {
            if(param == "notsad")
            {
                return "Im happpy :)";
            }

            return "No Friends :(";
        }
    }
}
