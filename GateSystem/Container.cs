using System;
using System.Collections.Generic;
using System.Text;

namespace GateSystem
{
    public class Container:INode
    {
        public int ContainerNumber { get; set; }
        public bool HasBall { get; set; } = false;

        public string GetStateText()
        {
            return $"C{ContainerNumber}";
        }

        public INode RecieveBall()
        {
            lock (this) {
                HasBall = true;
            }
            // This is fanal Node 
            return null;
        }
    }
}
