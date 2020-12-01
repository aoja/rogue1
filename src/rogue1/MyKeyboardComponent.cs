using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SadConsole.Components;
using SadConsole;

namespace Rogue1
{
    public class MyKeyboardComponent : KeyboardConsoleComponent
    {
        public override void ProcessKeyboard(Console console, SadConsole.Input.Keyboard info, out bool handled)
        {
            if (info.IsKeyPressed(Keys.Space))
            {
                console.DefaultBackground = Color.White.GetRandomColor(Global.Random);
                console.Clear();
            }

            handled = true;
        }
    }
}
