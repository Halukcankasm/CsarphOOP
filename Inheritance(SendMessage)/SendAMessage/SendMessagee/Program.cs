using Send;
using SendMessagee.Configuration;
using System;

namespace SendMessagee
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessageConfig sendMessageConfig = new SendMessageConfig();
            SendMessageSettingModel messageSettingModel = sendMessageConfig.GetMessageConfig();

            SendMessageBase send = (messageSettingModel.SendMessageType == "Mail") ? send = new SendMessageToMail("example@hotmail.com", "example message about send mail") : send = new SendMessageToPhone("5487892210", "example message about send tel");

            send.Send();
        }
    }
}
