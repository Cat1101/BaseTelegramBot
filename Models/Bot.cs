using BaseTelegramBot.Models.Commands;
using Telegram.Bot;

namespace BaseTelegramBot.Models;

public static class Bot
{
    private static TelegramBotClient _client;
    private static List<Command> _commands;

    public static IReadOnlyList<Command> Commands => _commands;

    public static async Task<TelegramBotClient> Get()
    {
        if (_client != null)
        {
            return _client;
        }

        _commands = new List<Command> { new HelloCommand() };

        _client = new TelegramBotClient(AppSettings.Key);
        string hookUrl = String.Format(AppSettings.Url, "api/message/update");
        await _client.SetWebhookAsync(hookUrl);
        return _client;
    }
}