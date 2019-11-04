using System.Collections.Generic;
using Bot.Database.MosqueDb;
using Bot.Database.MosqueDb.Tables;
using Bot.Logic.Services.MosqueDbService.Interfaces;

namespace Bot.Logic.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BotUserService : IBotUserService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly MosqueDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public BotUserService(MosqueDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<BotUser> GetBotUsers()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="botUser"></param>
        public void InsertOrUpdateUser(BotUser botUser)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public BotUser FindBotUser(long chatId)
        {
            throw new System.NotImplementedException();
        }
    }
}
