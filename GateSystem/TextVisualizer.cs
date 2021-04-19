using System;
using System.Collections.Generic;
using System.Text;

namespace GateSystem
{
    public class TextVisualizer : IVisualizer
    {
        public void Show(INode tree)
        {
            Queue<INode> nodes = new Queue<INode>();
            nodes.Enqueue(tree);
            Prersent(1, nodes);

        }
        void Prersent(int lvl, Queue<INode> queue)
        {
            Queue<INode> nextLvl = new Queue<INode>();
            Console.Write($"Depth {lvl}: ");
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                Console.Write(node.GetStateText());
                if (node is Gate)
                {
                    Gate g = (Gate)node;
                    nextLvl.Enqueue(g.LeftNode);
                    nextLvl.Enqueue(g.RightNode);
                }
            }
            Console.WriteLine();
            if (nextLvl.Count != 0)
            {
                Prersent(lvl + 1, nextLvl);
            }

        }


    }
}
