using FluentAssertions;
using GateSystem;
using Xunit;

namespace GateSystemTest
{
    public class GateRunnerTest
    {
        [Fact]
        public void RunForDepth1()
        {
            var system = new TreeSystem();
            var gate = new Gate(true);
            var lcontainer = new Container();
            gate.LeftNode = lcontainer;
            var rcontainer = new Container() { ContainerNumber = 1 };
            gate.RightNode = rcontainer;
            system.Tree = gate;
            system.Containers.Add(lcontainer);
            system.Containers.Add(rcontainer);
            GateRunner gr = new GateRunner();
            int s = gr.RunSystem(system);
            s.Should().Be(1);

        }

        [Fact]
        public void RunForDepth2()
        {
            var system = new TreeSystem();
            var gate = new Gate(true);
            var lgate = new Gate(false);
            gate.LeftNode = lgate;
            var rgate = new Gate(true);
            gate.RightNode = rgate;
            var c1 = new Container();
            lgate.LeftNode = c1;
            var c2 = new Container() { ContainerNumber = 1 };
            lgate.RightNode = c2;
            var c3 = new Container() { ContainerNumber = 2 };
            rgate.LeftNode = c3;
            var c4 = new Container() { ContainerNumber = 3 };
            rgate.RightNode = c4;
            system.Tree = gate;
            system.Containers.Add(c1);
            system.Containers.Add(c2);
            system.Containers.Add(c3);
            system.Containers.Add(c4);
            GateRunner gr = new GateRunner();
            int s = gr.RunSystem(system);
            s.Should().Be(3);

        }

        [Fact]
        public void RunForDepth2Other()
        {
            var system = new TreeSystem();
            var gate = new Gate(false);
            var lgate = new Gate(true);
            gate.LeftNode = lgate;
            var rgate = new Gate(true);
            gate.RightNode = rgate;
            var c1 = new Container();
            lgate.LeftNode = c1;
            var c2 = new Container() { ContainerNumber = 1 };
            lgate.RightNode = c2;
            var c3 = new Container() { ContainerNumber = 2 };
            rgate.LeftNode = c3;
            var c4 = new Container() { ContainerNumber = 3 };
            rgate.RightNode = c4;
            system.Tree = gate;
            system.Containers.Add(c1);
            system.Containers.Add(c2);
            system.Containers.Add(c3);
            system.Containers.Add(c4);
            GateRunner gr = new GateRunner();
            int s = gr.RunSystem(system);
            s.Should().Be(1);

        }
        [Fact]
        public void RunForDepth1Predict()
        {
            var system = new TreeSystem();
            var gate = new Gate(true);
            var lcontainer = new Container();
            gate.LeftNode = lcontainer;
            var rcontainer = new Container() { ContainerNumber = 1 };
            gate.RightNode = rcontainer;
            system.Tree = gate;
            system.Containers.Add(lcontainer);
            system.Containers.Add(rcontainer);
            GateRunner gr = new GateRunner();
            int s = gr.Predict(system);
            s.Should().Be(1);

        }

        [Fact]
        public void RunForDepth2Predict()
        {
            var system = new TreeSystem();
            var gate = new Gate(true);
            var lgate = new Gate(false);
            gate.LeftNode = lgate;
            var rgate = new Gate(true);
            gate.RightNode = rgate;
            var c1 = new Container();
            lgate.LeftNode = c1;
            var c2 = new Container() { ContainerNumber = 1 };
            lgate.RightNode = c2;
            var c3 = new Container() { ContainerNumber = 2 };
            rgate.LeftNode = c3;
            var c4 = new Container() { ContainerNumber = 3 };
            rgate.RightNode = c4;
            system.Tree = gate;
            system.Containers.Add(c1);
            system.Containers.Add(c2);
            system.Containers.Add(c3);
            system.Containers.Add(c4);
            GateRunner gr = new GateRunner();
            int s = gr.Predict(system);
            s.Should().Be(3);

        }

        [Fact]
        public void RunForDepth2OtherPredict()
        {
            var system = new TreeSystem();
            var gate = new Gate(false);
            var lgate = new Gate(true);
            gate.LeftNode = lgate;
            var rgate = new Gate(true);
            gate.RightNode = rgate;
            var c1 = new Container();
            lgate.LeftNode = c1;
            var c2 = new Container() { ContainerNumber = 1 };
            lgate.RightNode = c2;
            var c3 = new Container() { ContainerNumber = 2 };
            rgate.LeftNode = c3;
            var c4 = new Container() { ContainerNumber = 3 };
            rgate.RightNode = c4;
            system.Tree = gate;
            system.Containers.Add(c1);
            system.Containers.Add(c2);
            system.Containers.Add(c3);
            system.Containers.Add(c4);
            GateRunner gr = new GateRunner();
            int s = gr.Predict(system);
            s.Should().Be(1);

        }
    }
}
