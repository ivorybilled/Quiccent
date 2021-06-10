using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quiccent.Handlers
{
    public class KeyHandler
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private Keys _key;
        private IntPtr _hWnd;
        private int _id;

        public KeyHandler(Keys key, Form form)
        {
            _key = key;
            _hWnd = form.Handle;
            _id = GetHashCode();
        }

        public override int GetHashCode()
        {
            return (int)_key ^ _hWnd.ToInt32();
        }

        public bool Register(int comboCode, int id)
        {
            return RegisterHotKey(_hWnd, id, comboCode, (int)_key);
        }

        public bool Unregiser()
        {
            return UnregisterHotKey(_hWnd, _id);
        }

        public Keys CurrentKey()
        {
            return _key;
        }
    }
}
