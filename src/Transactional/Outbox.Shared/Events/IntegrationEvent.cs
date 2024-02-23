﻿using Newtonsoft.Json;

namespace Outbox.Shared.Events
{
    public class IntegrationEvent
    {

        //[JsonProperty]
        //public Guid Id { get; private set; }

        [JsonProperty]
        public DateTime CreatedDate { get; private set; }



        public IntegrationEvent()
        {
            //Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        [JsonConstructor]
        public IntegrationEvent(Guid id, DateTime createdDate)
        {
            //Id = id;
            CreatedDate = createdDate;
        }
    }
}
