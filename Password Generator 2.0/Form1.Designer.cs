namespace Password_Generator_2._0
{
    class UnCopiedLabel : Label

    {

        int WM_GETTEXT = 0xD;

        int WM_LBUTTONDBLCLK = 0x203;

        bool doubleclickflag = false;

        protected override void WndProc(ref Message m)

        {

            if (m.Msg == WM_LBUTTONDBLCLK)

            {

                doubleclickflag = true;

            }

            if (m.Msg == WM_GETTEXT && doubleclickflag)

            {

                doubleclickflag = false;

                return;

            }

            base.WndProc(ref m);

        }

    }

    partial class PassGen2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGen2));
            ControlPanelUp = new Panel();
            labelCopied = new UnCopiedLabel();
            panelClose = new Panel();
            pictureBoxClose = new PictureBox();
            labelAppName = new UnCopiedLabel();
            labelPassword = new UnCopiedLabel();
            labelNumbers = new UnCopiedLabel();
            labelLetters = new UnCopiedLabel();
            labelSymbols = new UnCopiedLabel();
            labelExtra = new UnCopiedLabel();
            labelLengthView = new UnCopiedLabel();
            panel1 = new Panel();
            timerCopied = new System.Windows.Forms.Timer(components);
            ControlPanelUp.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // ControlPanelUp
            // 
            ControlPanelUp.BorderStyle = BorderStyle.FixedSingle;
            ControlPanelUp.Controls.Add(labelCopied);
            ControlPanelUp.Controls.Add(panelClose);
            ControlPanelUp.Controls.Add(labelAppName);
            ControlPanelUp.Location = new Point(0, 0);
            ControlPanelUp.Name = "ControlPanelUp";
            ControlPanelUp.Size = new Size(1040, 40);
            ControlPanelUp.TabIndex = 1;
            ControlPanelUp.MouseMove += ControlPanelUp_MouseMove;
            // 
            // labelCopied
            // 
            labelCopied.AutoSize = true;
            labelCopied.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopied.ForeColor = Color.DarkGoldenrod;
            labelCopied.Location = new Point(641, 3);
            labelCopied.Name = "labelCopied";
            labelCopied.Size = new Size(255, 33);
            labelCopied.TabIndex = 3;
            labelCopied.Text = "Password copied!";
            labelCopied.Visible = false;
            labelCopied.MouseMove += labelCopied_MouseMove;
            // 
            // panelClose
            // 
            panelClose.BackColor = SystemColors.ActiveCaptionText;
            panelClose.Controls.Add(pictureBoxClose);
            panelClose.Cursor = Cursors.Hand;
            panelClose.Location = new Point(1005, 3);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(30, 30);
            panelClose.TabIndex = 1;
            panelClose.MouseClick += panelClose_MouseClick;
            panelClose.MouseDown += panelClose_MouseDown;
            panelClose.MouseEnter += panelClose_MouseEnter;
            panelClose.MouseLeave += panelClose_MouseLeave;
            panelClose.MouseUp += panelClose_MouseUp;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxClose.Enabled = false;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(0, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(30, 30);
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelAppName.ForeColor = Color.DarkGoldenrod;
            labelAppName.Location = new Point(3, 3);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(285, 33);
            labelAppName.TabIndex = 1;
            labelAppName.Text = "Password Generator";
            labelAppName.DoubleClick += labelAppName_DoubleClick;
            labelAppName.MouseClick += labelAppName_MouseClick;
            labelAppName.MouseDoubleClick += labelAppName_MouseDoubleClick;
            labelAppName.MouseMove += labelAppName_MouseMove;
            // 
            // labelPassword
            // 
            labelPassword.BorderStyle = BorderStyle.FixedSingle;
            labelPassword.Cursor = Cursors.Hand;
            labelPassword.Font = new Font("Consolas", 24.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.DarkGoldenrod;
            labelPassword.Location = new Point(20, 120);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(1000, 96);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Choose password type";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            labelPassword.TextChanged += labelPassword_TextChanged;
            labelPassword.DoubleClick += labelPassword_DoubleClick;
            labelPassword.MouseClick += labelPassword_MouseClick;
            labelPassword.MouseDoubleClick += labelPassword_MouseDoubleClick;
            // 
            // labelNumbers
            // 
            labelNumbers.BorderStyle = BorderStyle.FixedSingle;
            labelNumbers.Cursor = Cursors.Hand;
            labelNumbers.Font = new Font("Consolas", 24.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumbers.ForeColor = Color.NavajoWhite;
            labelNumbers.Location = new Point(25, 375);
            labelNumbers.Name = "labelNumbers";
            labelNumbers.Size = new Size(300, 120);
            labelNumbers.TabIndex = 4;
            labelNumbers.Text = "Only Numbers";
            labelNumbers.TextAlign = ContentAlignment.MiddleCenter;
            labelNumbers.DoubleClick += labelNumbers_DoubleClick;
            labelNumbers.MouseClick += labelNumbers_MouseClick;
            labelNumbers.MouseDoubleClick += labelNumbers_MouseDoubleClick;
            labelNumbers.MouseDown += labelNumbers_MouseDown;
            labelNumbers.MouseEnter += labelNumbers_MouseEnter;
            labelNumbers.MouseLeave += labelNumbers_MouseLeave;
            labelNumbers.MouseUp += labelNumbers_MouseUp;
            // 
            // labelLetters
            // 
            labelLetters.BorderStyle = BorderStyle.FixedSingle;
            labelLetters.Cursor = Cursors.Hand;
            labelLetters.Font = new Font("Consolas", 24.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLetters.ForeColor = Color.NavajoWhite;
            labelLetters.Location = new Point(370, 375);
            labelLetters.Name = "labelLetters";
            labelLetters.Size = new Size(300, 120);
            labelLetters.TabIndex = 5;
            labelLetters.Text = "Numbers and Letters";
            labelLetters.TextAlign = ContentAlignment.MiddleCenter;
            labelLetters.DoubleClick += labelLetters_DoubleClick;
            labelLetters.MouseClick += labelLetters_MouseClick;
            labelLetters.MouseDoubleClick += labelLetters_MouseDoubleClick;
            labelLetters.MouseDown += labelLetters_MouseDown;
            labelLetters.MouseEnter += labelLetters_MouseEnter;
            labelLetters.MouseLeave += labelLetters_MouseLeave;
            labelLetters.MouseUp += labelLetters_MouseUp;
            // 
            // labelSymbols
            // 
            labelSymbols.BorderStyle = BorderStyle.FixedSingle;
            labelSymbols.Cursor = Cursors.Hand;
            labelSymbols.Font = new Font("Consolas", 24.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSymbols.ForeColor = Color.NavajoWhite;
            labelSymbols.Location = new Point(715, 375);
            labelSymbols.Name = "labelSymbols";
            labelSymbols.Size = new Size(300, 120);
            labelSymbols.TabIndex = 6;
            labelSymbols.Text = "All Symbols";
            labelSymbols.TextAlign = ContentAlignment.MiddleCenter;
            labelSymbols.DoubleClick += labelSymbols_DoubleClick;
            labelSymbols.MouseClick += labelSymbols_MouseClick;
            labelSymbols.MouseDoubleClick += labelSymbols_MouseDoubleClick;
            labelSymbols.MouseDown += labelSymbols_MouseDown;
            labelSymbols.MouseEnter += labelSymbols_MouseEnter;
            labelSymbols.MouseLeave += labelSymbols_MouseLeave;
            labelSymbols.MouseUp += labelSymbols_MouseUp;
            // 
            // labelExtra
            // 
            labelExtra.BorderStyle = BorderStyle.FixedSingle;
            labelExtra.Cursor = Cursors.Hand;
            labelExtra.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelExtra.ForeColor = Color.NavajoWhite;
            labelExtra.Location = new Point(420, 300);
            labelExtra.Name = "labelExtra";
            labelExtra.Size = new Size(200, 50);
            labelExtra.TabIndex = 7;
            labelExtra.Text = "Extra (40)";
            labelExtra.TextAlign = ContentAlignment.MiddleCenter;
            labelExtra.DoubleClick += labelExtra_DoubleClick;
            labelExtra.MouseClick += labelExtra_MouseClick;
            labelExtra.MouseDoubleClick += labelExtra_MouseDoubleClick;
            labelExtra.MouseDown += labelExtra_MouseDown;
            labelExtra.MouseEnter += labelExtra_MouseEnter;
            labelExtra.MouseLeave += labelExtra_MouseLeave;
            labelExtra.MouseUp += labelExtra_MouseUp;
            // 
            // labelLengthView
            // 
            labelLengthView.AutoSize = true;
            labelLengthView.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLengthView.ForeColor = Color.DarkGoldenrod;
            labelLengthView.Location = new Point(20, 232);
            labelLengthView.Name = "labelLengthView";
            labelLengthView.Size = new Size(150, 33);
            labelLengthView.TabIndex = 4;
            labelLengthView.Text = "Length: 0";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 520);
            panel1.TabIndex = 8;
            // 
            // timerCopied
            // 
            timerCopied.Interval = 2000;
            timerCopied.Tick += timerCopied_Tick;
            // 
            // PassGen2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 520);
            Controls.Add(labelLengthView);
            Controls.Add(labelExtra);
            Controls.Add(labelSymbols);
            Controls.Add(labelLetters);
            Controls.Add(labelNumbers);
            Controls.Add(labelPassword);
            Controls.Add(ControlPanelUp);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PassGen2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generator";
            Load += PassGen2_Load;
            ControlPanelUp.ResumeLayout(false);
            ControlPanelUp.PerformLayout();
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ControlPanelUp;
        private UnCopiedLabel labelAppName;
        private UnCopiedLabel labelPassword;
        private UnCopiedLabel labelNumbers;
        private UnCopiedLabel labelLetters;
        private UnCopiedLabel labelSymbols;
        private UnCopiedLabel labelExtra;
        private UnCopiedLabel labelCopied;
        private UnCopiedLabel labelLengthView;
        private Panel panel1;
        private System.Windows.Forms.Timer timerCopied;
        private PictureBox pictureBoxClose;
        private Panel panelClose;
    }
}