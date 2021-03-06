﻿using System.Threading.Tasks;

namespace IFramework.Message
{
    public interface IMessageAsyncHandler
    {
        Task Handle(object message);
    }

    public interface IMessageAsyncHandler<in TMessage> where TMessage : class
    {
        Task Handle(TMessage message);
    }
}