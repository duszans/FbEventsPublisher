using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace EventsProvider
{
    using System.ComponentModel;
      [BsonIgnoreExtraElements]
    public class FbEvent
    {
        public ObjectId Id { get; set; }

        [BsonElement("categoy")]
        public string Category { get; set; }

        [BsonElement("event_id")]
        public string  EventId { get; set; }

        [BsonElement("event_name")]
        public string Name { get; set; }


        [BsonElement("start_time")]
        [DisplayName("Start date")]
        public DateTime? StartDate { get; set; }

        [BsonElement("event_description")]
        public string Description { get; set; }
        [BsonElement("picture_url")]
        public string  PicSmallUrl { get; set; }


        [BsonElement("location_place")]
        public string Location { get; set; }

        public string Owner { get; set; }
      
        
    }
}