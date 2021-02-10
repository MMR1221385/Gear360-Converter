using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Gear360_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (all.Checked == true)
            {
                Process process = new Process();
                output.Text = "Starting Process...";
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "s.exe";
                output.Text = "Adding cammand to it...";
                start.Arguments = "/C c *.JPG";
                process.StartInfo = start;
                output.Text = "Converter Started...";
                process.Start();
                //System.Threading.Thread.Sleep(50000);
            }
            else
            {
                if (one.Checked == true)
                {
                    Process process = new Process();
                    output.Text = "Starting Process...";
                    ProcessStartInfo start = new ProcessStartInfo();
                    start.FileName = "s.exe";
                    start.Arguments = "/C c " + onep.Text + ".JPG";
                    output.Text = "Adding cammand to it...";
                    process.StartInfo = start;
                    process.Start();
                    output.Text = "Converter Started...";
                    //System.Threading.Thread.Sleep(50000);
                }
            }
        }
    }
}
