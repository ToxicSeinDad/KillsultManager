using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace KillsultManager
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"C:\Users\"+Environment.UserName+@"\AppData\Roaming\KM"); //idk future updates maybe, now only for the yes no question
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            string kfile = @"C:\Users\"+Environment.UserName+@"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\RoamingState\project-halcyon\assets\killsults.txt";

            if (File.Exists((kfile)))
            {
                System.Diagnostics.Process.Start("notepad.exe", kfile);
                guna2CustomGradientPanel1.Visible = true;
                label2.Location = new Point(104, 372);
                label2.Text = "Opened Killsults.txt!";
                timer1.Start();
            }

            else
            {
                MessageBox.Show("Killsults file doesn't exist, install some killsults first or check your Zephyr installation!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!File.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\KM\NoQuestion.kmanager_questionfile"))
            {
                DialogResult dialogResult = MessageBox.Show("1.) You can get banned for hate speech, if you use this Killsults\n2.) You'll need Zephyr to use the Killsults \n3.) I've made this killsults just for fun, nobody should feel offended\n\n I am not responsible for any bans using this Killsults", "KillsultManager Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Create(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\KM\NoQuestion.kmanager_questionfile");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("You have top accept this, if you want to use the program!");
                    Application.Exit();
                }
            }


            guna2BorderlessForm1.ResizeForm = false;
            guna2CustomGradientPanel1.Visible = false;
        }


   
        private void guna2Button1_Click(object sender, EventArgs e)//toxic
        {
            label2.Location = new Point(104, 372);
            label2.Text = "Downloading Toxic Killsults...";
            string kfile = @"C:\Users\"+Environment.UserName+@"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\RoamingState\project-halcyon\assets\killsults.txt";
            label2.Text = "Downloading Killsults...";

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(
                    
                    new System.Uri("https://cdn.discordapp.com/attachments/1021044549721796619/1021084521489236028/killsults.txt"),
               
                    kfile);
               
                label2.Location = new Point(50, 372);
                label2.Text = "Status: Done; new Killsults: Very Toxic!";
                guna2CustomGradientPanel1.Show();
                timer1.Start();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            label2.Location = new Point(104, 372);
            string kfile = @"C:\Users\"+Environment.UserName+@"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\RoamingState\project-halcyon\assets\killsults.txt";

            if (File.Exists(kfile))
            {
                label2.Text = "Deleted Killsults";
                File.Delete(kfile);
                timer1.Start();
            }

else
            {
                MessageBox.Show("Killsults are already deleted (Couldn't find any file in "+kfile+" )");
            }

        }

        private async void guna2Button3_Click(object sender, EventArgs e)//ad
        {
            MessageBox.Show("Just Edit the Killsults to your Name");

            label2.Location = new Point(104, 372);
            label2.Text = "Downloading AD Killsults...";
            string kfile = @"C:\Users\"+Environment.UserName+@"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\RoamingState\project-halcyon\assets\killsults.txt";
            label2.Text = "Downloading Killsults...";

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(

                    new System.Uri("https://cdn.discordapp.com/attachments/1021044549721796619/1021084304706654339/killsults.txt"),

                    kfile);

                label2.Location = new Point(50, 372);
                if (File.Exists(kfile))
                {
                    label2.Text = "Status: Done; new Killsults: Advertisement!";
                    await Task.Delay(1000);
                    System.Diagnostics.Process.Start("notepad.exe", kfile);
                }

               
                guna2CustomGradientPanel1.Show();
                timer1.Start();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)//yt insult
        {
            label2.Location = new Point(104, 372);
            label2.Text = "Downloading YT Killsults...";
            string kfile = @"C:\Users\"+Environment.UserName+@"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\RoamingState\project-halcyon\assets\killsults.txt";
            label2.Text = "Downloading Killsults...";

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(

                    new System.Uri("https://cdn.discordapp.com/attachments/1021044549721796619/1021084696857284712/killsults.txt"),

                    kfile);

                label2.Location = new Point(50, 372);
                label2.Text = "Status: Done; new Killsults: YouTuber Insults!";
                guna2CustomGradientPanel1.Show();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!guna2CustomGradientPanel1.Visible)
            {
                guna2CustomGradientPanel1.Show();

            }
            guna2CustomGradientPanel1.Width -= 5;
            if (guna2CustomGradientPanel1.Width == 0)
            {
                guna2CustomGradientPanel1.Hide();
                guna2CustomGradientPanel1.Width = 277;
                timer1.Interval = 100;
                timer1.Stop();
            }
        }

        private async void guna2Button6_Click(object sender, EventArgs e)
        {

            timer1.Start();
            label2.Text = "Quitting...";
            await Task.Delay(6000); //Yeah you have to wait. for real. am I funny?
            Application.Exit();

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete all KM files?", "KillsultManager Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               if (File.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\KM\NoQuestion.kmanager_questionfile"))
                {
                    File.Delete(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\KM\NoQuestion.kmanager_questionfile");
                }
              
                if (File.Exists(@"C:\Users\"+Environment.UserName+@"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\RoamingState\project-halcyon\assets\killsults.txt"))
                {
                    File.Delete(@"C:\Users\"+Environment.UserName+@"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\RoamingState\project-halcyon\assets\killsults.txt");
                }
              if (Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\KM"))
                {
                    Directory.Delete(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\KM");
                }
               
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }
    }
}


