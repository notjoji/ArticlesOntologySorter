using Newtonsoft.Json;
using System.Collections.Generic;

namespace ArticlesOntologySorter
{
    public class Namespaces
    {
        public string @default { get; set; }
        [JsonProperty("ontolis-avis")]
        public string OntolisAvis { get; set; }
        public string owl { get; set; }
        public string rdf { get; set; }
        public string rdfs { get; set; }
        public string xsd { get; set; }
    }

    public class NodeAttributes
    {
    }

    public class Node
    {
        public NodeAttributes attributes { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string @namespace { get; set; }
        public int position_x { get; set; }
        public int position_y { get; set; }
    }

    public class RelationAttributes
    {
    }

    public class Relation
    {
        public RelationAttributes attributes { get; set; }
        public string destination_node_id { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string @namespace { get; set; }
        public string source_node_id { get; set; }
    }

    public class Onto
    {
        public string last_id { get; set; }
        public Namespaces namespaces { get; set; }
        public List<Node> nodes { get; set; }
        public List<Relation> relations { get; set; }
        public string visualize_ont_path { get; set; }
    }
}
