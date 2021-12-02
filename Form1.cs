using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;

namespace dotManager
{
    public partial class Form1 : Form
    {

        public static string appdatafolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string appfolder = Path.Combine(appdatafolder, "dotGame\\");

        private bool downloadComplete = false;

        
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1);
            this.Show();
            prepareWorkDir();
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            dropMeta.Hide();
            gpanel.Show();
            downloadBtn.Enabled = true;
            installBtn.Enabled = false;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            metadata gameinfo = JsonConvert.DeserializeObject<metadata>(File.ReadAllText(files[0]));
            if (System.IO.File.Exists(appfolder + gameinfo.archivename))
            {
                installBtn.Enabled = true;
            }

            typeGameInfo(gameinfo);
        }


            public String garc = null;
            public String ghost = null;
        public String gname = null;
        public String gexec = null;

        public void typeGameInfo(metadata gameinfo)
        {
            garc = gameinfo.archivename;
            gname = gameinfo.title;
            ghost = gameinfo.host;
            gexec = gameinfo.executable;
            gtitle.Text = gameinfo.title;
            originalsize.Text = gameinfo.originalsize;
            repacksize.Text = gameinfo.repacksize;
            setuptype.Text = gameinfo.setup;
            otherinfo.Text = gameinfo.comment;
        }

        public void downloadArchive(String archivename, String host)
        {
            bool canDownload = true;
            this.AllowDrop = false;
            Uri hostUri = new Uri(host, UriKind.Absolute);
            if (System.IO.File.Exists(appfolder + archivename))
            {
               DialogResult dialogResult = MessageBox.Show("Game archive already exists, do you want to redownload?", "dotGame | File Exists", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
                {
                    System.IO.File.Delete(archivename);
                    canDownload = true;
                }
               else
                {
                    canDownload = false;
                }
            }
            // download
            if (canDownload == true)
            {
                WebClient client = new WebClient();
                System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
                client.DownloadFileAsync(hostUri, appfolder + archivename);
            }

        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Minimum = 0;
            double recive = double.Parse(e.BytesReceived.ToString());
            double total = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = recive / total * 100;
            lstatus.Text = percentage.ToString()+"%";
            if (int.Parse(Math.Truncate(percentage).ToString()) < 0 )
            {
                progressBar1.Value = 0;
            }
            else { progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString()); }
            
            lstatus.Text = Math.Round((e.BytesReceived / 1024d / 1024d),2).ToString() + "MB's / " + Math.Round((e.TotalBytesToReceive / 1024d / 1024d),2).ToString() + " MB's downloaded";
        }

        public async void prepareWorkDir()
        {
            System.IO.Directory.CreateDirectory(appfolder);
            if (!System.IO.File.Exists(appfolder + "linker.bat"))
            {
                string[] linkerCode =
                {
                    "set lnn=%1", "set ldd=%2", "set lnn=%lnn:\"=%", "set ldd=%ldd:\"=%", "mklink \"%userprofile%\\Desktop\\%lnn%\" \"%ldd%\""
                };
                File.WriteAllLines(appfolder + "linker.bat", linkerCode);
            }

            if (!System.IO.File.Exists(appfolder + "arc.exe"))
            {
                
                dropMeta.Text = "Downloading arc.exe this may take some time";
                this.AllowDrop = false;

                Uri arcUri = new Uri("https://files.exefiles.com/a/arc.exe/B57977528C92003A4BF710A735663065/Arc.exe", UriKind.Absolute);
                WebClient pwebClient = new WebClient();
                pwebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(arc_dfc);
                pwebClient.DownloadFileAsync(arcUri, appfolder+"arc.exe");

                while (!downloadComplete)
                {
                    Application.DoEvents();
                }

                downloadComplete = false;

            }
            
        }

        void arc_dfc(object sender, AsyncCompletedEventArgs e)
        {
            downloadComplete = true;
            dropMeta.Text = "Drop Metadata file here to begin!";
            this.AllowDrop = true;
        }


        //this needs to be here, othervise designer breaks lol
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class metadata
        { 
            public string title { get; set; }
            public string originalsize { get; set; }
            public string repacksize { get; set; }
            public string host { get; set; }
            public string archivename { get; set; }
            public string setup { get; set; }
            public string executable { get; set; }
            public string comment { get; set; }

        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            downloadArchive(garc, ghost);
            this.AllowDrop = false;
            installBtn.Enabled = true;
        }

        private void installBtn_Click(object sender, EventArgs e)
        {
            this.AllowDrop = false;
            gpanel.Hide();
            dropMeta.Visible = true;
            dropMeta.Text = "Select Installation Path";
            
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                dropMeta.Text = "Installing to: \n" +folderBrowserDialog1.SelectedPath;

                var inst = Process.Start(appfolder + "arc.exe", "x -o+ "+appfolder+garc+" --yes --display --diskpath\"" + folderBrowserDialog1.SelectedPath +"\"");
                inst.WaitForExit();

                dropMeta.Text = "Creating Desktop Shortcut...";

                var link = Process.Start(appfolder + "linker.bat", "\"" +gname + "\" " + "\"" +folderBrowserDialog1.SelectedPath + @"\" + gexec+"\"");
                Thread.Sleep(1);     
                dropMeta.Text = gname + "\nInstalled successfully!";
                Thread.Sleep(3);

            }
            dropMeta.Visible = false;
            gpanel.Show();

        }

    }
}

