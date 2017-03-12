using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulkina
{
    class Logger
    {
        private Dictionary<string, string> movingMessages = new Dictionary<string, string>();

        public Logger()
        {
            movingMessages.Add("UP", "Передвинули фишку наверх");
            movingMessages.Add("RIGHT", "Передвинули фишку вправо");
            movingMessages.Add("DOWN", "Передвинули фишку вниз");
            movingMessages.Add("LEFT", "Передвинули фишку влево");
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintAction(string key, int x, int y)
        {
            Console.WriteLine(movingMessages[key] + ". Координаты ({0}, {1}).", x, y);
        }
    }
}
