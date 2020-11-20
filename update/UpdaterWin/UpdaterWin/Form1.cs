using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace UpdaterWin

                            // cracked.to/MrB00t

                            // Subscribe to my youtube channel https://www.youtube.com/channel/UCT9GsLbadapvAF8DowXJi4w
                            // Made by MrB00t
{
    public partial class Form1 : Form
    {
        string Currentversion = "2.0";   //  Change version of your program

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();


            if (!webClient.DownloadString("https://pastebin.com/raw/rbAUM63F").Contains(Currentversion))              // Keep updating your pastebin with the lastest program version  'example: 5.0 for me'
            {

                if (MessageBox.Show("New update it, download it or no?", "Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.youtube.com/channel/UCT9GsLbadapvAF8DowXJi4w");
                }

            }
            else
            {
                MessageBox.Show("Last version already");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = Currentversion;

            string version = new WebClient().DownloadString("https://pastebin.com/raw/rbAUM63F");

            if (version.Contains(Currentversion))
            {
                label4.Text = "UPDATED";
                label4.ForeColor = Color.Green;

            }
            else
            {
                label4.Text = "OUTDATED";
                label4.ForeColor = Color.Red;
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by MrB00t#0001", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}