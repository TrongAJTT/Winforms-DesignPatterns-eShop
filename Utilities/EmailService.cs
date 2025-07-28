using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using _3S_eShop.PatternDistinctive.Singleton;

namespace _3S_eShop.Connect
{
    public sealed class EmailService
    {
        private static readonly Lazy<EmailService> instance = new Lazy<EmailService>(() => new EmailService());

        private readonly SmtpClient smtpClient;

        private const string SmtpHost = "your-smtp-host"; // Thay thế bằng máy chủ SMTP của bạn, ví dụ: "smtp.gmail.com" cho Gmail
        private const int SmtpPort = 587;
        private const string SenderEmail = "your-email@email.com";
        private const string SenderPassword = "your-app-password";

        private EmailService()
        {
            smtpClient = new SmtpClient(SmtpHost, SmtpPort)
            {
                Credentials = new NetworkCredential(SenderEmail, SenderPassword),
                EnableSsl = true
            };
        }

        public static EmailService Instance => instance.Value;

        /// <summary>
        /// Gửi email đơn giản
        /// </summary>
        public void SendSimpleEmail(string toEmail, string subject, string body)
        {
            try
            {
                var mailMessage = new MailMessage(SenderEmail, toEmail)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                };
                smtpClient.Send(mailMessage);
                Console.WriteLine($"Email gửi tới {toEmail} thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi email tới {toEmail}: {ex.Message}");
                Logger.Instance.LogErrorException(ex, $"EMAIL SERVICE - Lỗi khi gửi email tới {toEmail}.");
            }
        }

        /// <summary>
        /// Gửi email với định dạng HTML
        /// </summary>
        public void SendHtmlEmail(string toEmail, string subject, string htmlBody)
        {
            try
            {
                var mailMessage = new MailMessage(SenderEmail, toEmail)
                {
                    Subject = subject,
                    Body = htmlBody,
                    IsBodyHtml = true
                };
                smtpClient.Send(mailMessage);
                Console.WriteLine($"Email HTML gửi tới {toEmail} thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi email tới {toEmail}: {ex.Message}");
                Logger.Instance.LogErrorException(ex, $"EMAIL SERVICE - Lỗi khi gửi email tới {toEmail}");
            }
        }

        /// <summary>
        /// Gửi email hàng loạt (sử dụng bất đồng bộ)
        /// </summary>
        public async Task SendBulkEmailsAsync(List<string> emailList, string subject, string body, bool isHtml = false)
        {
            var tasks = new List<Task>();

            foreach (var email in emailList)
            {
                tasks.Add(Task.Run(() =>
                {
                    try
                    {
                        var mailMessage = new MailMessage(SenderEmail, email)
                        {
                            Subject = subject,
                            Body = body,
                            IsBodyHtml = isHtml
                        };
                        smtpClient.Send(mailMessage);
                        Console.WriteLine($"Email gửi tới {email} thành công!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi gửi email tới {email}: {ex.Message}");
                        Logger.Instance.LogErrorException(ex, $"EMAIL SERVICE - Lỗi khi gửi email tới {email}");
                    }
                }));
            }

            await Task.WhenAll(tasks); // Đợi tất cả các tác vụ hoàn thành
        }

        /// <summary>
        /// Gửi email hàng loạt (sử dụng Parallel.ForEach)
        /// </summary>
        public void SendBulkEmailsParallel(List<string> emailList, string subject, string body, bool isHtml = false)
        {
            Parallel.ForEach(emailList, email =>
            {
                try
                {
                    var mailMessage = new MailMessage(SenderEmail, email)
                    {
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = isHtml
                    };
                    smtpClient.Send(mailMessage);
                    Console.WriteLine($"Email gửi tới {email} thành công!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi gửi email tới {email}: {ex.Message}");
                    Logger.Instance.LogErrorException(ex, $"EMAIL SERVICE - Lỗi khi gửi email tới {email}");
                }
            });
        }

        public async Task SendSimpleEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                var mailMessage = new MailMessage(SenderEmail, toEmail)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                };

                // Sử dụng phương thức async SendMailAsync
                await smtpClient.SendMailAsync(mailMessage);
                Console.WriteLine($"Email gửi tới {toEmail} thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi email tới {toEmail}: {ex.Message}");
                Logger.Instance.LogErrorException(ex, $"EMAIL SERVICE - Lỗi khi gửi email tới {toEmail}.");
            }
        }
    }

}
