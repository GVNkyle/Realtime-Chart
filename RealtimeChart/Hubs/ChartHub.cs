using Microsoft.AspNetCore.SignalR;
using RealtimeChart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealtimeChart.Hubs
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data, string connectionId) => await Clients.Client(connectionId).SendAsync("broadcastchartdata", data);
        public string GetConnectionId() => Context.ConnectionId;
        public async Task BroadcastToUser(string data, string userId) => await Clients.User(userId).SendAsync("broadcasttouser", data);

    }
}
