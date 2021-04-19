using System.Collections.Generic;

namespace GateSystem
{
    public class TreeSystem
    {
        public TreeSystem()
        {
            Containers = new List<Container>();
        }
        public INode Tree { get; set; }
        public List<Container> Containers { get; set; }

        public void RunBall()
        {
            var currentNode = Tree;
            do
            {
                currentNode = currentNode.RecieveBall();
            } while (currentNode != null);
        }

        public Container Predict()
        {
            dynamic retNode =(Gate) Tree;
            do
            {
                retNode = retNode.Predict();
            } while (!(retNode is Container));
            return retNode;
        }

        public void Visualize(IVisualizer visualizer)
        {
            visualizer.Show(Tree);
        }
    }
}
