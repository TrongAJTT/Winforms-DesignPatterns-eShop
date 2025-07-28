using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.Resources
{
    public class NetWorking
    {
        public event Action<bool> OnNetworkStatusChanged;
        private bool lastNetworkStatus = false;

        public void StartMonitoring()
        {
            NetworkChange.NetworkAvailabilityChanged += async (sender, e) =>
            {
                bool isAvailable = e.IsAvailable;
                bool internet = await CanAccessInternet();

                if (isAvailable != lastNetworkStatus)
                {
                    OnNetworkStatusChanged?.Invoke(internet);
                    lastNetworkStatus = isAvailable;
                }
            };
        }

        public static bool IsNetworkAvailable()
        {
            return NetworkInterface.GetIsNetworkAvailable() &&
                   NetworkInterface.GetAllNetworkInterfaces()
                   .Any(n => n.OperationalStatus == OperationalStatus.Up &&
                             n.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                             n.NetworkInterfaceType != NetworkInterfaceType.Tunnel);
        }

        public static async Task<bool> CanAccessInternet()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(2);
                    HttpResponseMessage response = await client.GetAsync("https://www.google.com");
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
