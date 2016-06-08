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
    [EnableCors("http://localhost:3681", headers: "*", methods: "*")]
    public class QuestionController : ApiController
    {
        public IMessageRepository Messages { get; set; }

        public QuestionController(IMessageRepository messages)
        {
            Messages = messages;
        }

        [HttpGet]
        public Task<string> GetCurrentQuestion()
        {
            return this.Messages.GetCurrentQuestionAsync();
        }
    }
}
