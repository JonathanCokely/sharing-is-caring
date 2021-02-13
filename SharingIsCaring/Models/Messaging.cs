using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class Messaging
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public Messaging()
        {
            When = DateTime.Now;
        }
    }
}
