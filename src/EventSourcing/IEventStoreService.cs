using EventStore.ClientAPI;
using System;

namespace EventSourcing
{
    public interface IEventStoreService
    {
        IEventStoreConnection GetConnection();
    }
}
