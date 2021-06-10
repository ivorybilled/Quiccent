using Quiccent.Constants;
using Quiccent.Handlers;
using Quiccent.Properties;
using Quiccent.Wrappers;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsInput;
using WindowsInput.Native;

namespace Quiccent
{
    public partial class Form1 : Form
    {
        private int _characterSelectionIndex;
        private NotifyIcon _trayIcon;

        public bool KeyHeld { private get; set; }

        public KeyWrapper CurrentKey { get; private set; }

        protected Accents Accents { get; set; }

        protected int CharacterSelectionIndex
        {
            get
            {
                return GetNextCharacterIndex();
            }

            set
            {
                if (value == 0)
                {
                    _characterSelectionIndex = 0;
                }
            }
        }

        public Form1()
        {
            InitializeNotifyIcon();

            InitializeComponent();

            InitializeAccents();

            InitializeKeyHandler();

            InitializeCharacterSelections();

            ListenForKeyReleases();
        }

        private void InitializeAccents()
        {
            Accents = new Accents();
        }

        private void InitializeNotifyIcon()
        {
            _trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new MenuItem[]
                    {
                        new MenuItem("Configure Character Choices", ConfigureCharacters),
                        new MenuItem("Help", Help),
                        new MenuItem("Exit", Exit)
                    }),
                Visible = true,
                Text = "Quiccent - Quick accent typing! Right click for more options.",
            };

            _trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_DoubleClick);
        }

        private void ListenForKeyReleases()
        {
            Task.Run(() => new AsyncKeyStateHandler(this).CheckLastKeyStillPressed());
        }

        private int GetNextCharacterIndex()
        {
            if (_characterSelectionIndex >= (CurrentKey.CharacterSelections?.Count() ?? 0))
            {
                _characterSelectionIndex = 0;
                return _characterSelectionIndex++;
            }

            return _characterSelectionIndex++;
        }

        private void InitializeCharacterSelections()
        {
            CurrentKey = new KeyWrapper(Accents, Keys.None);
        }

        private void InitializeKeyHandler()
        {
            var keyHandler = new KeyHandler(Keys.Oemtilde, this);

            // ID of 0 for just tilde key.
            keyHandler.Register(0, Constants.Constants.JustTilde);

            // ID of 1 for tilde + shift.
            keyHandler.Register(4, Constants.Constants.TildeAndShift);
        }

        private void HandleKeypress(bool shiftPressed)
        {
            SetCurrentKey(shiftPressed);

            if (CurrentKey.Key == Keys.None)
            {
                return;
            }

            if (!KeyHeld)
            {
                ResetBecauseKeyReleased();
            }

            PostKeyToActiveWindow();
        }

        private void SetCurrentKey(bool shiftPressed)
        {
            var potentialAccentKey = Constants.Constants.PossibleAccentedKeys.FirstOrDefault(kvp => KeyboardHandler.IsKeyDown(kvp.Key)).Key;
            var shouldAddCaps = shiftPressed || Keyboard.IsKeyToggled(Key.CapsLock);

            CurrentKey.Set(potentialAccentKey, shouldAddCaps);
        }

        private void ResetBecauseKeyReleased()
        {
            CharacterSelectionIndex = 0;
            KeyHeld = true;
        }

        protected void PostKeyToActiveWindow()
        {
            var keyboardSim = new InputSimulator();
            keyboardSim.Keyboard.KeyDown(VirtualKeyCode.BACK);

            // We may potentially need this but from my testing, input is very consistent and in order.
            // sim.Keyboard.Sleep(1);

            var nextMatchingCharacterText = CurrentKey.CharacterSelections[CharacterSelectionIndex];
            keyboardSim.Keyboard.TextEntry(nextMatchingCharacterText);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.Constants.WM_HOTKEY_MSG_ID)
            {
                HandleKeypress(m.WParam.ToInt32() == 1);
            }

            base.WndProc(ref m);
        }

        protected void ConfigureCharacters(object sender, EventArgs e)
        {
            var configureCharacters = new ConfigureCharacters(Accents);
            configureCharacters.Show();
        }

        protected void Help(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
        }

        protected void Exit(object sender, EventArgs e)
        {
            _trayIcon.Visible = false;
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ConfigureCharacters(null, null);
        }
    }
}
