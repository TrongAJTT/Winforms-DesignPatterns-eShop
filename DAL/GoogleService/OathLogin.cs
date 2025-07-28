using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System.IO;
using System.Net.Http;
using System.Threading;
using System;
using System.Threading.Tasks;

namespace _3S_eShop.DAL.GoogleService
{
    internal class OathLogin
    {
        private static string[] Scopes = {
            "https://www.googleapis.com/auth/userinfo.profile",
            "https://www.googleapis.com/auth/userinfo.email"
        };
        private static string _credentialsPath = Environment.GetEnvironmentVariable("GOATH_CREDENTIALS_PATH");
        private static string ApplicationName = Environment.GetEnvironmentVariable("GOATH_APP_NAME");

        public static async Task<string> RequestLogin()
        {
            UserCredential credential;

            using (var stream = new FileStream(_credentialsPath, FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token";
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)
                );
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Lấy thông tin người dùng
            string userInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";
            string responseBody = "";
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", credential.Token.AccessToken);
                var response = await httpClient.GetAsync(userInfoUrl);
                response.EnsureSuccessStatusCode(); // Ném ngoại lệ nếu có lỗi

                responseBody = await response.Content.ReadAsStringAsync();
            }
            return responseBody;
        }
    }
}
