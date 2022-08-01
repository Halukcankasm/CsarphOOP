using System;
using System.Collections.Generic;
using System.Text;

namespace Send
{
    public class SendMessageToMail : SendMessageBase
    {
        public SendMessageToMail(string _address, string _message) : base(address:_address, message:_message)
        {
        }
        public override void Send()
        {
            Console.WriteLine($"{Message} send to {Address}  Mail");
        }
    }
}
