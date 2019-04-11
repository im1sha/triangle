using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Core.Presenter
{
    public interface IPresenter
    {
        bool IsInputCharValid(string currentString, char newChar);
        string GetTriangleType(string sideA, string sideB, string sideC, string[] inputNames);
        string HandleInput(string text);
    }
}

