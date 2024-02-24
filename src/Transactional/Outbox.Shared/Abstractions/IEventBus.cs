﻿using Outbox.Shared.Events;

namespace Outbox.Shared.Abstractions
{
    public interface IEventBus : IKafka
    {
        void Publish(string serializeEvent, string type);

        void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

        void UnSubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

        void Consume(string eventName, string message);
    }
}
