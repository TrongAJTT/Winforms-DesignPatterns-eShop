using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.Connect;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _3S_eShop.DAL.Database
{
    internal class RedisHandler
    {
        public static void StoreEmailOtp(string email, string otp)
        {
            Redis.Instance.StringSet("otp:email:" + email, otp, TimeSpan.FromMinutes(5));
        }

        public static Task StoreEmailOtpAsync(string email, string otp)
        {
            return Redis.Instance.StringSetAsync("otp:email:" + email, otp, TimeSpan.FromMinutes(5));
        }

        public static string GetEmailOtp(string email)
        {
            return Redis.Instance.StringGet("otp:email:" + email);
        }

        public static void RemoveEmailOtp(string email)
        {
            Redis.Instance.GetDatabase().KeyDelete("otp:email:" + email);
        }

        public static void StoreSignInSession(string email, string content)
        {
            Redis.Instance.StringSet("session:" + email, content, TimeSpan.FromDays(7));
        }

        public static string ReadSignInSession(string email)
        {
            return Redis.Instance.StringGet("session:" + email);
        }

        public static void RemoveSignInSession(string email)
        {
            Redis.Instance.KeyDelete("session:" + email);
        }

        public static void StoreEmail(string email)
        {
            Redis.Instance.StringSet("email:exist:" + email, "0");
        }

        public static bool IsEmailExist(string email)
        {
            return Redis.Instance.StringGet("email:exist:" + email) != null;
        }

        public static void StoreSpecForProductCategory(string categoryId, string value)
        {
            Redis.Instance.StringSet("spec:category:" + categoryId, value);
        }

        public static string GetSpecForProductCategory(string categoryId)
        {
            return Redis.Instance.StringGet("spec:category:" + categoryId);
        }

        public static string GetPolicyDate()
        {
            return Redis.Instance.StringGet("policy:date");
        }

        public static string GetPolicyContent()
        {
            return Redis.Instance.StringGet("policy:content");
        }

        public static void UpdatePolicy(string newContent)
        {
            Redis.Instance.StringSet("policy:date", DateTime.Now.ToString());
            Redis.Instance.StringSet("policy:content", newContent);
        }

        public static void AddBanner(BannerObject obj, bool isMainBanner)
        {
            // Lấy dữ liệu hiện tại từ Redis và xử lý dữ liệu
            string keyName = isMainBanner ? "banner:main" : "banner:sub";
            string value = Redis.Instance.StringGet(keyName);
            List<BannerObject> list = (value == null)
                ? new List<BannerObject>()
                : JsonConvert.DeserializeObject<List<BannerObject>>(value);
            list.Add(obj);
            // Lưu dữ liệu trở lại Redis
            string json = JsonConvert.SerializeObject(list);
            Redis.Instance.StringSet(keyName, json);
        }

        public static List<BannerObject> GetAllBanner(bool isMainBanner)
        {
            string keyName = isMainBanner ? "banner:main" : "banner:sub";
            string value = Redis.Instance.StringGet(keyName);
            if (value == null)
                return new List<BannerObject>();
            return JsonConvert.DeserializeObject<List<BannerObject>>(value);
        }

        public static void EditBanner(BannerObject updatedBanner, bool isMainBanner)
        {
            // Lấy dữ liệu hiện tại từ Redis và xử lý dữ liệu
            string keyName = isMainBanner ? "banner:main" : "banner:sub";
            string value = Redis.Instance.StringGet(keyName);
            List<BannerObject> list = (value == null)
                ? new List<BannerObject>()
                : JsonConvert.DeserializeObject<List<BannerObject>>(value);
            // Tìm kiếm và cập nhật banner
            int index = list.FindIndex(x => x.Id == updatedBanner.Id);
            if (index != -1)
            {
                list[index] = updatedBanner;
                // Lưu dữ liệu trở lại Redis
                string json = JsonConvert.SerializeObject(list);
                Redis.Instance.StringSet(keyName, json);
            }
        }

        public static void RemoveBanner(string id, bool isMainBanner)
        {
            string keyName = isMainBanner ? "banner:main" : "banner:sub";
            string value = Redis.Instance.StringGet(keyName);
            List<BannerObject> list = (value == null)
                ? new List<BannerObject>()
                : JsonConvert.DeserializeObject<List<BannerObject>>(value);
            list.RemoveAll(x => x.Id == id);
            // Lưu dữ liệu trở lại Redis
            string json = JsonConvert.SerializeObject(list);
            Redis.Instance.StringSet(keyName, json);
        }

    }
}