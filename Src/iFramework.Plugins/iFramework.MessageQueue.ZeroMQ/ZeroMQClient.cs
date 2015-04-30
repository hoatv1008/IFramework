﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFramework.MessageQueue.ZeroMQ
{
    public class ZeroMQClient : IMessageQueueClient
    {
        public void Publish(Message.IMessageContext messageContext, string topic)
        {
            throw new NotImplementedException();
        }

        public void CloseTopicClients()
        {
            throw new NotImplementedException();
        }

        public Message.IMessageContext WrapMessage(Message.IMessage @event)
        {
            throw new NotImplementedException();
        }
    }
}
