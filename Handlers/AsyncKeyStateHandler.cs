using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiccent.Handlers
{
    public class AsyncKeyStateHandler
    {
        private Form1 _form { get; set; }

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int key);

        public AsyncKeyStateHandler(Form1 form)
        {
            _form = form;
        }

        public async void CheckLastKeyStillPressed()
        {
            while (true)
            {
                if (!KeyIsHeld(_form.CurrentKey.Key))
                {
                    _form.KeyHeld = false;
                }

                await Task.Delay(25);
            }
        }

        private bool KeyIsHeld(Keys key)
        {
            return (GetAsyncKeyState((int)key) & 0x8000) > 0;
        }
    }
}
