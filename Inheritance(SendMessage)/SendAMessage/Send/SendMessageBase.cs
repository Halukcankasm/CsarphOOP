namespace Send
{
    public abstract class SendMessageBase : ISendMessage
    {
        public string Address { get; set; }
        public string Message { get; set; }

        public SendMessageBase(string message, string address)
        {
            Address = address;
            Message = message;
        }

        public abstract void Send();
    }
}