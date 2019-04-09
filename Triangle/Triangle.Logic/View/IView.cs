using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Core.View
{
    public interface IView
    {
        string SideA { get; }
        string SideB { get; }
        string SideC { get; }
        string Output { get; }
    }
}
