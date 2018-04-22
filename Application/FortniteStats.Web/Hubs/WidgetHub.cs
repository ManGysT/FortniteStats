using System.Threading.Tasks;
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

        public void RunUpdaterJob()
        {
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
    }
}