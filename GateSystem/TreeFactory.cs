using System.Collections.Generic;

namespace GateSystem
{
    public class TreeFactory
    {
        private int Depth { get; set; }
        private List<Container> Containers { get; set; } = new List<Container>();
        public TreeSystem Create(int depth)
        {
            Depth = depth;
            Gate root = new Gate();
            AssginNode(root, 2);
            var tree = new TreeSystem() { Tree = root };
            tree.Containers.AddRange(Containers);
            return tree;
        }

        private void AssginNode (Gate node, int currentDepth)
        {
            if (currentDepth > Depth)
            {
                var c = new Container() { ContainerNumber = Containers.Count+1};
                node.LeftNode = c;
                Containers.Add(c);
                c = new Container() { ContainerNumber = Containers.Count+1};
                node.RightNode = c;
                Containers.Add(c);
                return;
            }
            var g = new Gate();
            node.LeftNode = g;
            AssginNode(g, currentDepth+1);
            g = new Gate();
            node.RightNode = g;
            AssginNode(g, currentDepth+1);
        }
    }
}
