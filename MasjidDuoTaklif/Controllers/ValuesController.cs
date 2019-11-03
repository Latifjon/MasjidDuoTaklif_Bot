using MasjidDuoTaklif.Model;
using Microsoft.AspNetCore.Mvc;

namespace MasjidDuoTaklif.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public string Get()
        {
            var me = Bot.GetBotClient().GetMeAsync().Result;
            return $"Start listening for @{me.Username}";
        }
    }
}
