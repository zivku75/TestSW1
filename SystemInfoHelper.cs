using System;
using System.Net;
using System.Net.Sockets;

namespace SystemInfoApp
{
    /// <summary>
    /// Helper class to retrieve system information
    /// </summary>
    public static class SystemInfoHelper
    {
        /// <summary>
        /// Gets the local IP address of the computer on the network
        /// </summary>
        /// <returns>Local IP address as string</returns>
        public static string GetLocalIPAddress()
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    // Connect to any external address (doesn't actually send data)
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    string ipAddress = endPoint?.Address.ToString();

                    if (!string.IsNullOrEmpty(ipAddress))
                    {
                        return ipAddress;
                    }
                }

                // Fallback method: Get hostname and resolve to IP
                string hostName = Dns.GetHostName();
                IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

                foreach (IPAddress ip in hostEntry.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }

                return "IP Not Found";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}