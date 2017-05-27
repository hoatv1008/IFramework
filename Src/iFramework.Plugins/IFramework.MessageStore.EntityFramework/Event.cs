﻿using IFramework.Event;
using IFramework.Message;

namespace IFramework.MessageStoring
{
    public class Event : Message
    {
        public Event()
        {
        }

        public Event(IMessageContext messageContext) :
            base(messageContext)
        {
            var domainEvent = messageContext.Message as IDomainEvent;
            if (domainEvent != null)
            {
                AggregateRootID = domainEvent.AggregateRootID.ToString();
                AggregateRootType = domainEvent.AggregateRootName;
                Version = domainEvent.Version;
            }
        }

        public string AggregateRootID { get; set; }
        public string AggregateRootType { get; set; }

        public int Version { get; set; }
        //        return ParentMessage;
        //    {
        //    get
        //{

        //public Message Parent
        //    }
        //}

        //public IEnumerable<Message> Children
        //{
        //    get
        //    {
        //        return ChildrenMessage;
        //    }
        //}
    }
}