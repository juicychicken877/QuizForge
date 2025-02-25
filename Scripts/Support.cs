using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMakerTaker.Scripts
{
    public static class Support
    {
        public static readonly Color DEFAULT_BUTTON_COLOR = Color.WhiteSmoke;
        public static readonly Color SELECTED_BUTTON_COLOR = Color.LightBlue;
        public static readonly Color CORRECT_BUTTON_COLOR = Color.LightGreen;
        public static readonly Color INCORRECT_BUTTON_COLOR = Color.FromArgb(242, 65, 65);

        public static List<T> ShuffleList<T>(List<T> list)
        {
            List<T> randomizedList = list;

            Random random = new();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T temp = randomizedList[k];
                randomizedList[k] = randomizedList[n];
                randomizedList[n] = temp;
            }

            return randomizedList;
        }

    }
}
