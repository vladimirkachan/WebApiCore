using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApiCore.Data.Models
{
    public class Customer
    {
        [BsonId] 
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
        public DateTime BirthDate {get; set;}
    }
}
