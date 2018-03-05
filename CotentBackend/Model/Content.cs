using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentBackend.Model
{
    public class Content: Entity
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
        public int NodeDepth { get; set; }
        public string ParentIds { get; set; }
        public string NodeType { get; set; } // Leaf, Head, Branch!
        public bool Shared { get; set; }
        public string ShareType { get; set; } // R: Read, RW: Read & Write, RWD, Read & Write & Delete
        public string SharedIds { get; set; }
        public string OwnerId { get; set; }
        public string Tags { get; set; }
        public string LinkIds { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
