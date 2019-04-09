using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Core.Presenter
{
    public interface IPresenter
    {
        bool IsInputValid(string currentString, char newChar);
        string GetTriangleType(string sideA, string sideB, string sideC, string[] inputNames);
    }
}

