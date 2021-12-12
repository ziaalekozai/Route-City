using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_City
{
    public class Node
    {
        public Node(int cost)
        {
            Cost = cost;
        }
        public Node(string name)
        {
            Name = name;
        }
        
        public Node(string name, int cost, bool mode)
        {
            this.Name = name;
            this.Cost = cost;
            this.Status = mode;
            
        }

        public string Name { get; set; }
        public int Cost { get; set; }
        public bool Status { get; set; }
        public List<Node> Neighbours { get; set; }

    }
}
