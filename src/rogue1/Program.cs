using Microsoft.Xna.Framework;

namespace Rogue1
{
    internal static class Program
    {
        private static void Main()
        {
            SadConsole.Settings.UseDefaultExtendedFont = true;

            SadConsole.Game.Create(80, 25);
            SadConsole.Game.OnInitialize = OnInitialize;
            SadConsole.Game.OnDraw = OnDraw;
            SadConsole.Game.OnUpdate = OnUpdate;

            // Start the game loop.
            SadConsole.Game.Instance.Run();

            // Dispose of the game instance on shutdown.
            SadConsole.Game.Instance.Dispose();
        }

        private static void OnInitialize()
        {
            var console = new SadConsole.Console(80, 25);
            console.FillWithRandomGarbage();
            _ = console.Fill(new Rectangle(3, 3, 23, 3), Color.Violet, Color.Black, 0, 0);
            console.Print(4, 4, "Hello world!");
            console.IsFocused = true;
            console.Cursor.IsVisible = true;

            // Add the custom keyboard handler.
            console.Components.Add(new MyKeyboardComponent());

            // Focus the screen to the default console.
            SadConsole.Global.CurrentScreen = console;
        }

        private static void OnDraw(GameTime time)
        {
        }

        private static void OnUpdate(GameTime time)
        {
        }
    }
}
