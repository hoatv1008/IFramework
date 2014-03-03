﻿using IFramework.Event;
using IFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IFramework.Infrastructure;
using IFramework.Message;
using IFramework.Infrastructure.Unity.LifetimeManagers;

namespace Sample.CommandHandler
{
    public class CommandHandlerBase
    {
        protected IEventPublisher EventPublisher
        {
            get
            {
                return IoCFactory.Resolve<IEventPublisher>();
            }
        }

        protected IDomainRepository DomainRepository
        {
            get
            {
                return IoCFactory.Resolve<IDomainRepository>();
            }
        }

        public IMessageContext CommandContext
        {
            get
            {
                return PerMessageContextLifetimeManager.CurrentMessageContext;
            }
        }
    }
}
