using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest2.Data
{
    public class MessageData
    {
        public MessageData(string messageText)
        {
            MessageText = messageText;
        }
        public string MessageText { get; set; }
    }
}
