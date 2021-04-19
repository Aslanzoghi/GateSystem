using System;

namespace GateSystem
{
    public class Gate : INode
    {
        public Gate(bool state)
        {
            State = state;
        }
        public Gate()
        {
            State =Convert.ToBoolean((new System.Random().Next(0, 2)));
            OriginalState = State;
        }
        private bool State { get; set; }
        private bool OriginalState { get;set; } 
        public INode RecieveBall()
        {
           lock (this)
            {
                INode ret = State ? LeftNode : RightNode;
                State = !State;
                return ret;
            }

        }
        public string GetStateText()
        {
            return State ? "L" : "R";
        }
        public INode Predict()
        {
            return OriginalState ? RightNode : LeftNode;
        }
        public INode LeftNode { get; set; }
        public INode RightNode { get; set; }
    }
}
