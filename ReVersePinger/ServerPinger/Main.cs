using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;
using System.Media;
using System.IO;
using WMPLib;

namespace ServerPinger
{
    public partial class FrmPinger : Form
    {
        public FrmPinger()
        {
            InitializeComponent();
        }


        //environment variables
        Stopwatch stopwatch = new Stopwatch();
        SoundPlayer song = new SoundPlayer();
        WindowsMediaPlayer player = new WindowsMediaPlayer();  //For MP3.
        bool playing = false;
        string programPath;


        private void SelectSongPath()
        {
            //Specify path of sound to play
            try
            {
                OpenFileDialog programSelect = new OpenFileDialog
                {
                    Filter = "Sound files|*.wav; *.mp3"
                };

                if (programSelect.ShowDialog() == DialogResult.OK)
                {
                    song.SoundLocation = programSelect.FileName;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured when attempting to select file:\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnStopPinging_Click(object sender, EventArgs e)
        {
            btnCheckIP.Enabled = true;
            btnStopPinging.Enabled = false;
            backgroundWorker1.CancelAsync();
        }


        private void BtnCheckIP_Click(object sender, EventArgs e)
        {
            try
            {
                btnCheckIP.Enabled = false;
                btnStopPinging.Enabled = true;
                btnStopPinging.Select();

                //writeLog("Attempting to ping " + txtIP.Text);
                backgroundWorker1.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                WriteLog(ex.Message.ToString());
            }
        }


        public void WriteLog(string text)
        {
            Invoke((MethodInvoker)delegate ()
            {
                DateTime timestamp = DateTime.Now;
                lstLog.Items.Add("[" + timestamp.ToLongTimeString() + "] " + text);
                lstLog.TopIndex = lstLog.Items.Count - 1;  //Makes it autoscroll
            });
        }


        private bool PingHostTCP(TcpClientWithTimeout c, string ipendpoint, int port)
        {
            try
            {
                string server = "Login server";
                if (radGameServer.Checked)
                    server = "Game server";
                stopwatch.Restart();
                WriteLog("Pinged " + server + "...");
                c.Connect(ipendpoint, port);
                stopwatch.Stop();  //Is this the right placement?
                //writeLog("Pinged " + ipendpoint + "...");

                return true;
            }
            catch (Exception)
            {
                //writeLog("[TCP] Caught exception");
                return false;
            }
        }


        #region BackgroundWorker Events
        //Do all the work in this backgroundworker method
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string serverString = "Login server";
            string royalsIP = "185.125.230.117";  //Login server 1
            int port = 8484;                      //Login server port

            if (radLoginServer2.Checked)
            {
                royalsIP = "185.125.230.180";     //Login server 2
                serverString = "Login server 2";
            }
            if (radGameServer.Checked)
            {
                royalsIP = "51.68.205.179";
                port = 7575;
                serverString = "Game server";
            }  

            bool successfulPing = false;

            //TcpClient client = new TcpClient();
            TcpClientWithTimeout client = new TcpClientWithTimeout();

            WriteLog("Starting ping sequence...");

            try
            {
                do
                {
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    if (PingHostTCP(client, royalsIP, port))
                    {
                        successfulPing = true;
                        WriteLog(serverString + " is up! " + "(" + stopwatch.ElapsedMilliseconds + " ms)");

                        if(chkPlaySong.Checked)
                            PlaySong();
                    }
                    else
                    {
                        Thread.Sleep((int)nmrPingDelay.Value * 1000);
                    }
                }
                while (!successfulPing);
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message.ToString());
            }

            //BackgroundWorker should never touch the UI so use invoke
            Invoke((MethodInvoker)delegate { btnCheckIP.Enabled = true; });
            Invoke((MethodInvoker)delegate { btnStopPinging.Enabled = false; });

            if (chkLaunchProgram.Checked)
                LaunchProgram();
        }


        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }


        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        #endregion


        private void NmrPingDelay_ValueChanged(object sender, EventArgs e)
        {
            if (nmrPingDelay.Value != 1)
                label3.Text = "seconds";
            else
                label3.Text = "second";
        }


        private void PlaySong()
        {
            //Only way I was able to make it play MP3 files
            if (song.SoundLocation.EndsWith(".mp3"))
            {
                player.URL = song.SoundLocation;

                player.controls.play();
                playing = true;
            }
            else
            {
                song.Play();
                playing = true;
            }
        }


        /// <summary>
        /// Uncheck to stop song playing.
        /// </summary>
        private void ChkPlaySong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlaySong.Checked)
                btnSoundLocation.Visible = true;
            else
                btnSoundLocation.Visible = false;
            if (playing)
            {
                song.Stop();
                player.controls.stop();
                playing = false;
            }
            else
                return;
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }


        private void LaunchProgram()
        {
            programPath = txtLaunchPath.Text;
            //WriteLog("Starting " + Path.GetFileName(programPath));
            WriteLog("Attempting to launch Royals...");
            try
            {
                Process.Start(programPath);
            }
            catch (Exception)
            {
                WriteLog("Cannot start the program. Please check the file path is valid and try again.");
            }
        }


        private void TxtLaunchPath_Click(object sender, EventArgs e)
        {
            SelectFilePath();
        }


        private void SelectFilePath()
        {
            //Select the program we'll be working with
            try
            {
                OpenFileDialog programSelect = new OpenFileDialog
                {
                    Filter = "MapleRoyals|MapleRoyals.exe"
                };

                if (programSelect.ShowDialog() == DialogResult.OK)
                {
                    programPath = programSelect.FileName;
                    txtLaunchPath.Text = programPath;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured when attempting to select file:\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ChkLaunchProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaunchProgram.Checked)
                txtLaunchPath.Visible = true;
            else
                txtLaunchPath.Visible = false;
        }


        private void LstLog_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //The listbox entry we clicked on
                string entry = lstLog.SelectedItem.ToString();

                //Check to see if entry is an IP (starts with a number..)
                if (!char.IsDigit(entry[0]))
                    return;

                //Cut string at the : between ip and port, creating 2 strings and putting them into array serverInfo
                string[] serverInfo = entry.Split(':');

                //Put selected IP:Port into proper textboxes
                //txtIP.Text = serverInfo[0];
                //txtPort.Text = serverInfo[1];
            }
            catch
            {
                return;
            }
        }


        private void btnSoundLocation_Click(object sender, EventArgs e)
        {
            SelectSongPath();
        }
    }
 }
