using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Help_Jakob
{
    /// <summary>
    /// Send a message to one or more recievers
    /// </summary>
    internal class MessageSender
    {
        public HTMLConverter hTMLConverter { get; private set; }

        public MessageSender()
        {
            hTMLConverter = new HTMLConverter();
        }

        public void sendMessage(CarrierEnum.MessageCarrier type, Message m, bool isHTML)
        {
            if (type.Equals(CarrierEnum.MessageCarrier.Smtp))
            {
                sendMsgViaSmtp(type, m, isHTML);
            }
            else if (type.Equals(CarrierEnum.MessageCarrier.VMessage))
            {
                SendMsgViaVMessage(type, m, isHTML);
            }
        }
        public void sendMessageToAll(CarrierEnum.MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            foreach (string reciever in to)
            {
                if (type.Equals(CarrierEnum.MessageCarrier.Smtp))
                {
                    sendMsgViaSmtp(type, m, isHTML);
                }
                else if (type.Equals(CarrierEnum.MessageCarrier.VMessage))
                {
                    SendMsgViaVMessage(type, m, isHTML);
                }
            }
        }

        private void sendMsgViaSmtp(CarrierEnum.MessageCarrier type, Message m, bool isHTML)
        {

            if (isHTML)
                m.Body = hTMLConverter.ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via Smtp

        }

        private void SendMsgViaVMessage(CarrierEnum.MessageCarrier type, Message m, bool isHTML)
        {

            if (isHTML)
                m.Body = hTMLConverter.ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via VMessage

        }
    }
}
