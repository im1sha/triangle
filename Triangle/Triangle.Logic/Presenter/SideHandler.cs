using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Core.Presenter
{
    public class SideHandler
    {
        private string GetNaNError(string inputName)
        {
              return $"В поле ввода «{inputName}» должно быть целое положительное число.";
        }

        private string GetOutOfBoundsError(string inputName)
        {
            return $"В поле ввода «{inputName}» должно быть целое положительное число " +
                $"из промежутка от {MinValue} до {MaxValue}.";
        }

        public const ulong MaxValue = ulong.MaxValue / 2;

        public const ulong MinValue = 1;

        public ulong ConvertSideToULong(string side, string inputName)
        {
            if (ulong.TryParse(side, out ulong result))
            {
                return result;
            }
            throw new ApplicationException(GetNaNError(inputName));
        }

        public bool CheckBounds(ulong side, string inputName)
        {
            if (side <= MaxValue && side >= MinValue)
            {
                return true;
            };
            throw new ApplicationException(GetOutOfBoundsError(inputName));
        }
    }
}
