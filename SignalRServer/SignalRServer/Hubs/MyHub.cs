using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRServer.Hubs
{
    public class MyHub:Hub
    {
        public async Task SendMessageAsync(string message)
        {
            //reciveMessage fonksiyonun adı
            await Clients.All.SendAsync("reciveMessage", message);
        }
    }
}
