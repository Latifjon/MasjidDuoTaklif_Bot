using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace MasjidDuoTaklif.Model
{
    public static class Bot
    {
        public static TelegramBotClient client;

        public static TelegramBotClient GetBotClient()
        {
            if (client != null)
            {
                client.OnMessage += BotOnMessageReceived;
                client.OnCallbackQuery += BotOnCallbackQueryReceived;

                client.StartReceiving(Array.Empty<UpdateType>());
                return client;
            }

            client = new TelegramBotClient(AppSettings.Key);

            client.OnMessage += BotOnMessageReceived;
            client.OnCallbackQuery += BotOnCallbackQueryReceived;
            client.StartReceiving(Array.Empty<UpdateType>());

            return client;
        }

        private static void BotOnMessageReceived(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

        }

        private static void BotOnCallbackQueryReceived(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
        {
        }
    }
}
