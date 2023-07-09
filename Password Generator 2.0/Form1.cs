using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace Password_Generator_2._0
{
    public partial class PassGen2 : Form
    {
        bool isGenerated = false;
        bool extra = false;
        int numberLength = 20;
        int letterSymbolsLength = 15;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public PassGen2()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(32, 32, 32);
            panelClose.BackColor = Color.FromArgb(50, 35, 35);
            ControlPanelUp.BackColor = Color.FromArgb(35, 35, 40);
            pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            labelNumbers.BackColor = Color.FromArgb(30, 35, 40);
            labelLetters.BackColor = Color.FromArgb(30, 35, 40);
            labelSymbols.BackColor = Color.FromArgb(30, 35, 40);
            labelExtra.BackColor = Color.FromArgb(50, 35, 35);
        }

        private void PassGen2_Load(object sender, EventArgs e)
        {

        }

        private void ControlPanelUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void labelAppName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelNumbers_MouseClick(object sender, MouseEventArgs? e)
        {
            string passwordString = "";

            for (int i = 0; i < numberLength; i++)
            {
                byte[] randomBytes = new byte[4];
                int randomNumber;
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomBytes);
                    randomNumber = Math.Abs(BitConverter.ToInt32(randomBytes, 0)) % 10;
                }
                passwordString += randomNumber.ToString();
            }
            labelPassword.Text = passwordString;
            Clipboard.SetText(labelPassword.Text);
            labelLengthView.Text = "Length: " + labelPassword.Text.Length.ToString();
            labelCopied.Visible = true;
            timerCopied.Enabled = false;
            timerCopied.Enabled = true;
        }

        private void labelSymbols_MouseClick(object sender, MouseEventArgs? e)
        {
            string passwordString = "";
            bool randomCheck = true;
            while (randomCheck)
            {
                passwordString = "";
                for (int i = 0; i < letterSymbolsLength; i++)
                {
                    byte[] randomBytes = new byte[4];
                    int randomNumber;
                    using (var rng = RandomNumberGenerator.Create())
                    {
                        rng.GetBytes(randomBytes);
                        randomNumber = Math.Abs(BitConverter.ToInt32(randomBytes, 0)) % 94;
                    }
                    char ascii = Convert.ToChar(randomNumber + 33);
                    passwordString += ascii;
                }

                bool symbol = false;
                bool letter = false;
                bool number = false;
                for (int i = 0; i < passwordString.Length; i++)
                {
                    if ((int)passwordString[i] > 47 && (int)passwordString[i] < 58)
                    {
                        number = true;
                    }
                    else if (((int)passwordString[i] > 64 && (int)passwordString[i] < 91) || ((int)passwordString[i] > 96 && (int)passwordString[i] < 123))
                    {
                        letter = true;
                    }
                    else if (((int)passwordString[i] > 32 && (int)passwordString[i] < 48) || ((int)passwordString[i] > 57 && (int)passwordString[i] < 65) || ((int)passwordString[i] > 90 && (int)passwordString[i] < 97 || (int)passwordString[i] > 122))
                    {
                        symbol = true;
                    }
                }

                if (symbol && letter && number)
                {
                    randomCheck = false;
                }
            }
            labelPassword.Text = passwordString;
            Clipboard.SetText(labelPassword.Text);
            labelLengthView.Text = "Length: " + labelPassword.Text.Length.ToString();
            labelCopied.Visible = true;
            timerCopied.Enabled = false;
            timerCopied.Enabled = true;
        }

        private void labelExtra_MouseClick(object sender, MouseEventArgs? e)
        {
            extra = !extra;
            if (extra)
            {
                labelExtra.BackColor = Color.FromArgb(10, 50, 10);
                numberLength = 40;
                letterSymbolsLength = 40;
            }
            else
            {
                labelExtra.BackColor = Color.FromArgb(50, 35, 35);
                numberLength = 20;
                letterSymbolsLength = 15;
            }
        }

        private void labelLetters_MouseClick(object sender, MouseEventArgs? e)
        {
            bool randomCheck = true;
            string passwordString = "";
            while (randomCheck)
            {
                passwordString = "";
                for (int i = 0; i < letterSymbolsLength; i++)
                {
                    byte[] randomBytes = new byte[4];
                    int randomNumber;
                    using (var rng = RandomNumberGenerator.Create())
                    {
                        rng.GetBytes(randomBytes);
                        randomNumber = Math.Abs(BitConverter.ToInt32(randomBytes, 0)) % 62;
                    }
                    if (randomNumber < 10)
                    {
                        char ascii = Convert.ToChar(randomNumber + 48);
                        passwordString += ascii;
                    }
                    else if (randomNumber < 36)
                    {
                        char ascii = Convert.ToChar(randomNumber + 55);
                        passwordString += ascii;
                    }
                    else
                    {
                        char ascii = Convert.ToChar(randomNumber + 61);
                        passwordString += ascii;
                    }
                }
                bool letter = false;
                bool number = false;
                for (int i = 0; i < passwordString.Length; i++)
                {
                    if ((int)passwordString[i] > 47 && (int)passwordString[i] < 58)
                    {
                        number = true;
                    }
                    else if (((int)passwordString[i] > 64 && (int)passwordString[i] < 91) || ((int)passwordString[i] > 96 && (int)passwordString[i] < 123))
                    {
                        letter = true;
                    }
                }

                if (letter && number)
                {
                    randomCheck = false;
                }
            }
            labelPassword.Text = passwordString;
            Clipboard.SetText(labelPassword.Text);
            labelLengthView.Text = "Length: " + labelPassword.Text.Length.ToString();
            labelCopied.Visible = true;
            timerCopied.Enabled = false;
            timerCopied.Enabled = true;
        }

        private void labelPassword_MouseClick(object sender, MouseEventArgs? e)
        {
            if (isGenerated)
            {
                Clipboard.SetText(labelPassword.Text);
                labelCopied.Visible = true;
                timerCopied.Enabled = false;
                timerCopied.Enabled = true;
            }
        }

        private void labelPassword_DoubleClick(object sender, EventArgs e)
        {
            labelPassword_MouseClick(sender, null);
        }

        private void labelPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelPassword_MouseClick(sender, e);
        }

        private void labelAppName_DoubleClick(object sender, EventArgs e)
        {
            labelAppName_MouseClick(sender, null);
        }

        private void labelAppName_MouseClick(object sender, MouseEventArgs? e)
        {

        }

        private void labelAppName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelAppName_MouseClick(sender, e);
        }

        private void labelSymbols_DoubleClick(object sender, EventArgs e)
        {
            labelSymbols_MouseClick(sender, null);
        }

        private void labelLetters_DoubleClick(object sender, EventArgs e)
        {
            labelLetters_MouseClick(sender, null);
        }

        private void labelNumbers_DoubleClick(object sender, EventArgs e)
        {
            labelNumbers_MouseClick(sender, null);
        }

        private void labelExtra_DoubleClick(object sender, EventArgs e)
        {
            labelExtra_MouseClick(sender, null);
        }

        private void labelExtra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelExtra_MouseClick(sender, e);
        }

        private void labelSymbols_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelSymbols_MouseClick(sender, e);
        }

        private void labelLetters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelLetters_MouseClick(sender, e);
        }

        private void labelNumbers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelNumbers_MouseClick(sender, e);
        }

        private void timerCopied_Tick(object sender, EventArgs e)
        {
            labelCopied.Visible = false;
            timerCopied.Enabled = false;
        }

        private void labelSymbols_MouseEnter(object sender, EventArgs e)
        {
            labelSymbols.BackColor = Color.FromArgb(35, 45, 55);
        }

        private void labelSymbols_MouseLeave(object sender, EventArgs e)
        {
            labelSymbols.BackColor = Color.FromArgb(30, 35, 40);
        }

        private void labelSymbols_MouseDown(object sender, MouseEventArgs e)
        {
            labelSymbols.BackColor = Color.FromArgb(35, 50, 65);
        }

        private void labelSymbols_MouseUp(object sender, MouseEventArgs e)
        {
            labelSymbols.BackColor = Color.FromArgb(35, 45, 55);
        }

        private void labelLetters_MouseEnter(object sender, EventArgs e)
        {
            labelLetters.BackColor = Color.FromArgb(35, 45, 55);
        }

        private void labelLetters_MouseLeave(object sender, EventArgs e)
        {
            labelLetters.BackColor = Color.FromArgb(30, 35, 40);
        }

        private void labelLetters_MouseDown(object sender, MouseEventArgs e)
        {
            labelLetters.BackColor = Color.FromArgb(35, 50, 65);
        }

        private void labelLetters_MouseUp(object sender, MouseEventArgs e)
        {
            labelLetters.BackColor = Color.FromArgb(35, 45, 55);
        }

        private void labelNumbers_MouseEnter(object sender, EventArgs e)
        {
            labelNumbers.BackColor = Color.FromArgb(35, 45, 55);
        }

        private void labelNumbers_MouseLeave(object sender, EventArgs e)
        {
            labelNumbers.BackColor = Color.FromArgb(30, 35, 40);
        }

        private void labelNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            labelNumbers.BackColor = Color.FromArgb(35, 50, 65);
        }

        private void labelNumbers_MouseUp(object sender, MouseEventArgs e)
        {
            labelNumbers.BackColor = Color.FromArgb(35, 45, 55);
        }

        private void labelCopied_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelExtra_MouseEnter(object sender, EventArgs e)
        {
            if (extra)
            {
                labelExtra.BackColor = Color.FromArgb(10, 60, 10);
            }
            else
            {
                labelExtra.BackColor = Color.FromArgb(60, 35, 35);
            }
        }

        private void labelExtra_MouseLeave(object sender, EventArgs e)
        {
            if (extra)
            {
                labelExtra.BackColor = Color.FromArgb(10, 50, 10);
            }
            else
            {
                labelExtra.BackColor = Color.FromArgb(50, 35, 35);
            }
        }

        private void labelExtra_MouseDown(object sender, MouseEventArgs e)
        {
            if (extra)
            {
                labelExtra.BackColor = Color.FromArgb(5, 70, 5);
            }
            else
            {
                labelExtra.BackColor = Color.FromArgb(70, 30, 30);
            }
        }

        private void labelExtra_MouseUp(object sender, MouseEventArgs e)
        {
            if (extra)
            {
                labelExtra.BackColor = Color.FromArgb(10, 60, 10);
            }
            else
            {
                labelExtra.BackColor = Color.FromArgb(60, 35, 35);
            }
        }

        private void labelPassword_TextChanged(object sender, EventArgs e)
        {
            isGenerated = true;
        }

        private void panelClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(70, 35, 35);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(50, 35, 35);
        }

        private void panelClose_MouseDown(object sender, MouseEventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(120, 35, 35);
        }

        private void panelClose_MouseUp(object sender, MouseEventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(70, 35, 35);
        }
    }
}