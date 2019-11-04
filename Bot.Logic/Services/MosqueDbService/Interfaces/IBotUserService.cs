using System.Collections.Generic;
using Bot.Database.MosqueDb.Tables;

namespace Bot.Logic.Services.MosqueDbService.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBotUserService
    {
        /// <summary>
        /// Возврашает список пользователей бота
        /// </summary>
        /// <returns></returns>
        List<BotUser> GetBotUsers();
        
        /// <summary>
        /// Довавление или удаление пользователья
        /// </summary>
        /// <param name="botUser"></param>
        void InsertOrUpdateUser(BotUser botUser);

        /// <summary>
        /// Находит пользователя бота из таблитцы
        /// </summary>
        /// <param name="chatId">Telegram Chat id</param>
        /// <returns></returns>
        BotUser FindBotUser(long chatId);
    }
}
