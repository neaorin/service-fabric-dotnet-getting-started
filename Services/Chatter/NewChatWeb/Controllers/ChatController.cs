using ChatWeb.Domain;
using NewChatWeb.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NewChatWeb.Controllers
{
    [EnableCors("http://localhost:3681", headers: "*", methods: "*")]
    public class ChatController : ApiController
    {
        public IMessageRepository Messages { get; set; }

        public ChatController(IMessageRepository messages)
        {
            Messages = messages;
        }

        // GET: api/chat
        [HttpGet]
        public Task<IEnumerable<KeyValuePair<DateTime, Message>>> GetMessages()
        {

            return this.Messages.GetMessagesAsync();
        }

        // POST api/chat
        [HttpPost]
        public async Task<IHttpActionResult> Add([FromBody] Message message)
        {
            if (message == null)
            {
                ServiceEventSource.Current.Message("Received message with no content");
                return this.BadRequest();
            }
            await this.Messages.AddMessageAsync(message);

            return this.ResponseMessage(new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.OK));
        }

        //DELETE api/chat
        [HttpDelete]
        public async Task<IHttpActionResult> ClearMessages()
        {
            await this.Messages.ClearMessagesAsync();

            return this.ResponseMessage(new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.OK));
        }
    }
}