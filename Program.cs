using System;
using System.Threading.Tasks;

using DSharpPlus;
using DSharpPlus.EventArgs;

namespace UnicornMissionControlBot
{
    class Program
    {
        //static DiscordClient discord;

        private static string ClientID = "751432550886670467";
        private static string ClientSecret = "AzmL-A6bJP_nVKrqbBVYUm1b5qmqjQSz";

        private static string Token = "NzUxNDMyNTUwODg2NjcwNDY3.X1JAGQ.hsgky5PWSlSFdfYu9DggF2h48Ks";

        public static async Task Main(string[] args)
        {
            var discord = new DiscordClient(new DiscordConfiguration
            {
                Token = Program.Token,
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += OnMessageCreated;

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        private static async Task OnMessageCreated(MessageCreateEventArgs e)
        {
            if (string.Equals(e.Message.Content, "!mc", StringComparison.OrdinalIgnoreCase))
            {
                var status =
                "STATUS (please copy and paste complete message and edit appropriate):";

                var username = e.Message.Author.Username;
                await e.Message.RespondAsync(status);
               
            }
        }
    }
}
