using System;
using System.ComponentModel.DataAnnotations;

namespace Bot.Database.MosqueDb.Tables
{
    /// <summary>
    /// 
    /// </summary>
    public class BotUser
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public Guid BotUserGuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string CallBackCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RegistrationDate { get; set; }
    }
}
