namespace MyShittySpamBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.inputTextLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.fileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.souborTextBox = new System.Windows.Forms.TextBox();
            this.souborLabel = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.spamLabel = new System.Windows.Forms.Label();
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"Text mode", "File mode"});
            this.comboBox1.Location = new System.Drawing.Point(292, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 45);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.inputText.Location = new System.Drawing.Point(12, 187);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(257, 26);
            this.inputText.TabIndex = 1;
            // 
            // inputTextLabel
            // 
            this.inputTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.inputTextLabel.Location = new System.Drawing.Point(12, 147);
            this.inputTextLabel.Name = "inputTextLabel";
            this.inputTextLabel.Size = new System.Drawing.Size(257, 23);
            this.inputTextLabel.TabIndex = 2;
            this.inputTextLabel.Text = "Zadejte text který chcete spamovat";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.startButton.Location = new System.Drawing.Point(183, 448);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(153, 59);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start Spamming";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.stopButton.Location = new System.Drawing.Point(475, 448);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(153, 59);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop Spamming";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // fileDialog
            // 
            this.fileDialogue.FileName = "openFileDialog1";
            // 
            // souborTextBox
            // 
            this.souborTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.souborTextBox.Location = new System.Drawing.Point(536, 171);
            this.souborTextBox.Name = "souborTextBox";
            this.souborTextBox.Size = new System.Drawing.Size(257, 26);
            this.souborTextBox.TabIndex = 5;
            // 
            // souborLabel
            // 
            this.souborLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.souborLabel.Location = new System.Drawing.Point(536, 145);
            this.souborLabel.Name = "souborLabel";
            this.souborLabel.Size = new System.Drawing.Size(257, 23);
            this.souborLabel.TabIndex = 6;
            this.souborLabel.Text = "Vyberte soubor s textem na spam";
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(630, 203);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(75, 23);
            this.chooseButton.TabIndex = 7;
            this.chooseButton.Text = "Vybrat";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // spamLabel
            // 
            this.spamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.spamLabel.Location = new System.Drawing.Point(251, 406);
            this.spamLabel.Name = "spamLabel";
            this.spamLabel.Size = new System.Drawing.Size(331, 23);
            this.spamLabel.TabIndex = 8;
            this.spamLabel.Text = "Spamování započne, 5s po stisknutí tlačítka";
            // 
            // timerTextBox
            // 
            this.timerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.timerTextBox.Location = new System.Drawing.Point(380, 300);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(44, 26);
            this.timerTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(272, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zadejte interval mezi zprávami (ms)";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerTextBox);
            this.Controls.Add(this.spamLabel);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.souborLabel);
            this.Controls.Add(this.souborTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.inputTextLabel);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "SHittySPamThing?";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Timer timer;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timerTextBox;

        private System.Windows.Forms.Label spamLabel;

        private System.Windows.Forms.Button chooseButton;

        private System.Windows.Forms.Label souborLabel;
        private System.Windows.Forms.OpenFileDialog fileDialogue;
        private System.Windows.Forms.TextBox souborTextBox;

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label inputTextLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;

        private System.Windows.Forms.ComboBox comboBox1;

        #endregion
    }
}