using DSharpPlus;
using System.Threading.Tasks;

namespace Project_Eagles
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "", // Insert token here
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().Contains("ping"))
                    await e.Message.RespondAsync("pong!");
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
