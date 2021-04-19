using FluentAssertions;
using GateSystem;
using Xunit;

namespace GateSystemTest
{
    public class BuildTreeTest
    {
        [Fact]
        public void BuildTreeWithDepth1()
        {
            TreeFactory factory = new TreeFactory();
            var treeSystem = factory.Create(1);
            treeSystem.Tree.Should().NotBeNull();
            treeSystem.Tree.Should().BeOfType(typeof (Gate));
            treeSystem.Tree.As<Gate>().LeftNode.Should().BeOfType(typeof(Container));
            treeSystem.Tree.As<Gate>().RightNode.Should().BeOfType(typeof(Container));
            treeSystem.Containers.Count.Should().Be(2);
            treeSystem.Containers[0].ContainerNumber.Should().Be(0);
            treeSystem.Containers[1].ContainerNumber.Should().Be(1);
        }
        [Fact]
        public void BuildTreeWithDepth2()
        {
            TreeFactory factory = new TreeFactory();
            var treeSystem = factory.Create(2);
            treeSystem.Tree.Should().NotBeNull();
            treeSystem.Tree.Should().BeOfType(typeof(Gate));
            treeSystem.Tree.As<Gate>().LeftNode.Should().BeOfType(typeof(Container));
            treeSystem.Tree.As<Gate>().RightNode.Should().BeOfType(typeof(Container));
            treeSystem.Containers.Count.Should().Be(2);
            treeSystem.Containers[0].ContainerNumber.Should().Be(0);
            treeSystem.Containers[1].ContainerNumber.Should().Be(1);
        }
       
    }
}
