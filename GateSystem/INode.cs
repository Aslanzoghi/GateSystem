using System;
using System.Collections.Generic;
using System.Text;

namespace GateSystem
{
    public interface INode
    {
          INode RecieveBall();
        string GetStateText();
    }
}
