using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class TreeNode
    {
        char Name { get; set; }
        public readonly List<TreeNode> Children = new List<TreeNode>();

        public TreeNode(char name)
        {
            Name = name;
        }

        public IEnumerable<TreeNode> IncidentNodes
        {
            get
            {
                foreach (var node in Children)
                    yield return node;
            }
        }

        public void Connect(TreeNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            if (Children.Count >= 3)
                throw new ArgumentOutOfRangeException(nameof(node), "Тринода не может содержать более трёх детей");

            Children.Add(node);
        }

        //IEnumerable<TreeNode> GetAllNodes(TreeNode node)
        //{

        //}
    }
}
