using Messager.Models;

namespace Messager;

public interface IMessageService
{
    Task<SendResultSMS> SendSMSAsync(string phoneNumber);
}