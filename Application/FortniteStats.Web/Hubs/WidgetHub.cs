using System.Threading.Tasks;
using FortniteStats.Web.Models.Widget;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace FortniteStats.Web.Hubs
{
    [HubName("widget")]
    public class WidgetHub : Hub
    {
        public WidgetHub()
        {
        }

        public void SubscribeOnStatsUpdates(WidgetOptions options)
        {
            var groupName = this.GetGroupName(options.EpicUserName, options.Platform, options.ApiKey);

            this.Groups.Add(this.Context.ConnectionId, groupName);
        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        public void SendStats()
        {
            Clients.All.sendStats("here should be stats=)");
        }

        private string GetGroupName(string userName, string platform, string apiKey)
        {
            return string.Concat(userName, "_", platform, "_" + apiKey);
        }
    }
}