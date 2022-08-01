using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SendMessagee.Configuration
{
    public class SendMessageConfig
    {
        SendMessageSettingModel sendMessageConfig;
        public  SendMessageConfig()
        {
            var sendMessageConfigFile = System.IO.File.ReadAllText(@"C:\Users\halukcan.kasim\source\repos\SendMessagee\Configuration\SendMessageConfig.json");
            sendMessageConfig = JsonConvert.DeserializeObject<SendMessageSettingModel>(sendMessageConfigFile);
        }

        public SendMessageSettingModel GetMessageConfig() => sendMessageConfig;
    }
}
