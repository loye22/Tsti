using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ZKTecoFingerPrintScanner_Implementation
{
    public partial class UserControl3 : Form
    {
        public UserControl3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //Properties.Settings.Default.momo = "c";
            // Properties.Settings.Default.Save();
            label1.Font = new Font(label1.Font, FontStyle.Underline);

            //MessageBox.Show(Properties.Settings.Default.served);
            Properties.Settings.Default.PropertyChanged += Settings_PropertyChanged;
            String f = "";
            axWindowsMediaPlayer1.URL = f;

        }


        public Label serverdLable()
        {
            //Properties.Settings.Default.momo;
            return label5;
        }




        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // Update the label's text property

            label5.Text = Properties.Settings.Default.served;
            label6.Text = Properties.Settings.Default.now;
            label7.Text = Properties.Settings.Default.next;

        }


        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          



            // Create an instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter for the file types
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Text Files (*.mp4)|*.mp4|All Files (*.*)|*.*";

            // Show the dialog box and wait for the user's response
            DialogResult result = openFileDialog.ShowDialog();

            // If the user clicked "OK", get the selected file path
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string directoryPath = Path.GetDirectoryName(filePath);
                axWindowsMediaPlayer1.URL = filePath;
               // MessageBox.Show(filePath);
                axWindowsMediaPlayer1.Ctlcontrols.play();

                //Console.WriteLine("Directory: " + directoryPath);
            }





        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
