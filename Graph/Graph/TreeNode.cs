using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// Примерное описание триноды
    /// </summary>
    internal class TreeNode
    {
        public char Name { get; set; }
        private readonly List<TreeNode> Children = new List<TreeNode>();

        public TreeNode(char name)
        {
            Name = name;
        }

        public IEnumerable<TreeNode> ChildrenNodes
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

        /// <summary>
        /// Получить все ChildrenNodes включая вложенных путём поиск в ширину
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>

        private static IEnumerable<TreeNode> GetAllNodes(TreeNode node)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<TreeNode> allNodes = new();
            queue.Enqueue(node);

            while(queue.Count > 0)
            {
                var treeNode = queue.Dequeue();
                allNodes.Add(treeNode);

                foreach (var item in treeNode.ChildrenNodes)
                    queue.Enqueue(item);
            }

            return allNodes;

        }
    }
}
