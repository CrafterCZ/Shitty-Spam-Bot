using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MyShittySpamBot
{
    public partial class Form1 : Form
    {
        private StreamReader _streamReader;
        
        public Form1()
        {
            InitializeComponent();
            
            inputText.Visible= false;
            inputTextLabel.Visible = false;

            souborLabel.Visible = false;
            souborTextBox.Visible = false;
            chooseButton.Visible = false;
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
                {  
                    InitialDirectory = @"C:\",  
                    Title = @"Najdi si ten soubor pico",  
              
                    CheckFileExists = true,  
                    CheckPathExists = true,  
              
                    DefaultExt = "txt",  
                    Filter = @"txt files (*.txt)|*.txt",  
                    FilterIndex = 2,  
                    RestoreDirectory = true,  
              
                    ReadOnlyChecked = true,  
                    ShowReadOnly = true  
                };  
              
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    souborTextBox.Text = fileDialog.SafeFileName;
                    //Pass the file path and file name to the StreamReader constructor
                    _streamReader = new StreamReader(fileDialog.FileName);
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                inputText.Visible= true;
                inputTextLabel.Visible = true;

                souborLabel.Visible = false;
                souborTextBox.Visible = false;
                chooseButton.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                inputText.Visible = false;
                inputTextLabel.Visible = false;

                souborLabel.Visible = true;
                souborTextBox.Visible = true;
                chooseButton.Visible = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //close the file
            try {_streamReader.Close();}
            catch
            {
                // ignored
            }

            timer.Stop();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Interval = int.Parse(timerTextBox.Text);
                timer.Start();
                Thread.Sleep(5000);
            }
            catch
            {
                MessageBox.Show(@"Nastav interval...", @"Error píčo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SendKeys.Send(inputText.Text);
                SendKeys.Send("{ENTER}");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    //Read the first line of text
                    string line = _streamReader.ReadLine();
                    //Continue to read until you reach end of file
                    if (line != null)
                    {
                        //write the lie to console window
                        SendKeys.Send(line);
                        SendKeys.Send("{ENTER}");
                        //Read the next line
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, @"Error píčo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                timer.Stop();
                MessageBox.Show(@"Yems", @"Oznámení píčo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}