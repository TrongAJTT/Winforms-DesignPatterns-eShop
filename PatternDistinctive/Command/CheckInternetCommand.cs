
using System;
using System.Net;
using System.Net.NetworkInformation;


namespace _3S_eShop.PatternDistinctive.Command
{
    public class CheckInternetCommand : ICommand<bool>
    {
        private readonly string _testUrl = "http://www.google.com";
        public CheckInternetCommand()
        {
        }

        public bool Execute()
        {
            return CheckInternetConnection();
        }

        private bool CheckInternetConnection()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_testUrl);
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

