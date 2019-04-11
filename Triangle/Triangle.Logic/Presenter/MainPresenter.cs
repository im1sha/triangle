using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triangle.Core.Presenter
{
    public class MainPresenter : IPresenter
    {
        private readonly View.IView view;
        private readonly Model.TypeDeterminer model = new Model.TypeDeterminer();

        private readonly SideHandler sideHandler = new SideHandler();
        private readonly InputParser inputParser = new InputParser();

        private List<string> InputErrors;

        public MainPresenter(View.IView view)
        {
            this.view = view;
        }

        public string GetTriangleType(string sideA, string sideB, string sideC, string[] inputNames)
        {            
            InputErrors = new List<string>();

            string[] input = new[] { sideA, sideB, sideC };
            ulong[] sides = new ulong[input.Length];

            if (inputNames.Length != input.Length)
            {
                throw new ApplicationException();
            }

            for (int i = 0; i < input.Length; i++)
            {        
                try
                {
                    sides[i] = sideHandler.ConvertSideToULong(input[i], inputNames[i]);
                    sideHandler.CheckBounds(sides[i], inputNames[i]);
                }
                catch (ApplicationException e)
                {
                    InputErrors.Add(e.Message);
                }
            }

            if (InputErrors.Count > 0)
            {
                throw new ApplicationException(string.Join("\n", InputErrors)); 
            }

            return TypeToMessageConverter.GetMessageByTriangleType(model.GetTriangleType(sides[0], sides[1], sides[2]));
        }

        public string HandleInput(string text)
        {
            return inputParser.DeleteNulls(text);
        }

        public bool IsInputCharValid(string currentString, char newChar)
        {
            return inputParser.IsInputValid(currentString, newChar);
        }
    }
}



