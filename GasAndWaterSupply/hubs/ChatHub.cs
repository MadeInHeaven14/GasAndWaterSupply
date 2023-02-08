using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace GasAndWaterSupply.hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string senderName, string receiverName, string message)
        {
            // получение текущего пользователя, который отправил сообщение
            //var userName = Context.UserIdentifier;
            //if (Context.UserIdentifier is string userName)
            //{
            //    await Clients.Users(to, userName).SendAsync("Receive", message, userName);
            //}
            await this.Clients.All.SendAsync("Receive", senderName, receiverName, message);
        }

        //public override async Task OnConnectedAsync()
        //{
        //    await Clients.All.SendAsync("Notify", $"Приветствуем {Context.UserIdentifier}");
        //    await base.OnConnectedAsync();
        //}
    }
}
