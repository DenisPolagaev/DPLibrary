using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;

namespace DPLibrary.DPNet.SMB
{
    public sealed class NetworkSMBConnection : IDisposable
    {
        private readonly string _networkName;

        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource,
            string password, string username, int flags);

        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags,
            bool force);
        
        
        /// <param name="networkName">Network Path</param>
        /// <param name="credentials">credential</param>
        public NetworkSMBConnection(string networkName, NetworkCredential credentials)
        {
            _networkName = networkName;
            
            var netResource = new NetResource()
            {
                Scope = ResourceScope.GlobalNetwork,
                ResourceType = ResourceType.Disk,
                DisplayType = ResourceDisplayType.Share,
                RemoteName = _networkName
            };

            var userName = string.IsNullOrEmpty(credentials.Domain)
                ? credentials.UserName
                : $@"{credentials.Domain}\{credentials.UserName}";

            var result = WNetAddConnection2(
                netResource,
                credentials.Password,
                userName,
                0);
            
            if (result != 0)
            {
                throw new Win32Exception(result);
            }  
        }

        ~NetworkSMBConnection()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            WNetCancelConnection2(_networkName, 0, true);
        }
    }
}