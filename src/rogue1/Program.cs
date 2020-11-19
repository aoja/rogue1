namespace Rogue1
{
    using Microsoft.Xna.Framework;

    internal static class Program
    {
        private static void Main()
        {
            SadConsole.Settings.UseDefaultExtendedFont = true;

            SadConsole.Game.Create(80, 25);
            SadConsole.Game.OnInitialize = OnInitialize;
            SadConsole.Game.OnDraw = OnDraw;
            SadConsole.Game.OnUpdate = OnUpdate;

            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        private static void OnInitialize()
        {
        }

        private static void OnDraw(GameTime time)
        {
        }

        private static void OnUpdate(GameTime time)
        {
        }
    }
}
