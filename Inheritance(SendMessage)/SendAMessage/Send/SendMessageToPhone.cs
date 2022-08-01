using System;

namespace Send
{
    public class SendMessageToPhone : SendMessageBase
    {
        public SendMessageToPhone(string _adress, string _message): base(message:_message, address:_adress)
        {
        }
        public override void Send()
        {
            Console.WriteLine($"{Message} send to {Address} phone number");
        }
    }
}
