using NewChatWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NewChatWeb.Controllers
{
    [EnableCors("*", headers: "*", methods: "*")]
    public class LeaderboardController : ApiController
    {
        public IMessageRepository Messages { get; set; }

        public LeaderboardController(IMessageRepository messages)
        {
            Messages = messages;
        }

        [HttpGet]
        public Task<IEnumerable<KeyValuePair<string, int>>> GetScoresAsync()
        {
            return this.Messages.GetScoresAsync();
        }
    }
}
