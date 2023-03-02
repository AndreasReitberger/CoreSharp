using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace AndreasReitberger.Core.Interfaces
{
    public interface IRestApiClient : INotifyPropertyChanged, IDisposable
    {
        #region Properties

        public Guid Id { get; set; }

        #region Connection
        public string ServerAddress { get; set; }
        public bool IsSecure { get; set; }
        public bool LoginRequired { get; set; }
        public string ApiKey { get; set; }
        public int Port { get; set; }
        public bool IsOnline { get; set; }
        public bool IsConnecting { get; set; }
        public bool AuthenticationFailed { get; set; }
        public bool IsRefreshing { get; set; }
        #endregion

        #endregion

        #region Methods
        public Task CheckOnlineAsync(int Timeout = 10000);
        public Task CheckOnlineAsync(CancellationTokenSource cts);
        public bool CheckIfConfigurationHasChanged(object temp);
        public void CancelCurrentRequests();
        #endregion
    }
}
