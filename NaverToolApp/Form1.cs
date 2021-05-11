﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Diagnostics;
using System.Threading;
using HtmlAgilityPack;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Linq;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace NaverToolApp
{
    public partial class Form1 : Form
    {
        string version = "1.2.2";
        string versionkeypath = @"SOFTWARE\WOW6432Node\Naver Images Downloader";
        string versionURL = "https://raw.githubusercontent.com/longkenj/navertool/master/VERSION.md"; //https://dev.longkenj.website/version.txt
        string versiondownloadlink = "http://bit.ly/navertool";

        string data = "";
        string file = "";
        string DownloadFolder = "";
        string DATESTAMP = "";
        string site = "";
        string url = "";
        string str = "";
        string Exif_images = "";
        string filename = "";
        string path = Environment.CurrentDirectory.ToString();

        int i = 0;
        int totalLines = 0;
        double bytesIn = 0;
        double totalBytes = 0;
        double percentage = 0;

        bool bnaver;
        bool bpost;
        bool bentertain;
        bool btopstar;
        bool btwitter;
        bool bimgur;
        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
        WebClient webClient;

        private Queue<string> _downloadUrls = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test area start

            //file = System.IO.Path.GetFileName("https://pbs.twimg.com/media/D0J48EMV4AAXt3W.jpg:orig");

            //test are end

            rdbPost.Checked = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            CreateReg();
            CheckVersion(versionURL);

        }

        static string ReadSubKeyValue(string subKey, string key)

        {

            string str = string.Empty;

            using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(subKey))

            {

                if (registryKey != null)

                {

                    str = registryKey.GetValue(key).ToString();

                    registryKey.Close();

                }

            }

            return str;

        }

        private void CreateReg()
        {

            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(versionkeypath, true);
            if (myKey == null)
            {

                myKey = Registry.LocalMachine.CreateSubKey(versionkeypath);
                myKey.SetValue("Version", version);
                myKey.Close();
            }
            else
            {
                myKey.SetValue("Version", version);
                myKey.Close();
            }
        }

        private void LinkNewVersion(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(versiondownloadlink);
        }

        private void CheckVersion(string url)
        {
            try
            {
                WebClient client = new WebClient();
                str = client.DownloadString(url);
                str = str.Substring(0, 5);
            }
            catch
            {
                Console.WriteLine("Please try again.");
            }
            if (str == "" || str == version)
            {
                label1.Visible = true;
            }
            else if (str != version)
            {

                label1.ForeColor = Color.Blue;
                label1.Text = "*New version " + str;
                label1.Cursor = Cursors.Hand;
                label1.Click += new EventHandler(LinkNewVersion);
            }
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            const int kNotFound = -1;

            var startIdx = strSource.IndexOf(strStart);
            if (startIdx != kNotFound)
            {
                startIdx += strStart.Length;
                var endIdx = strSource.IndexOf(strEnd, startIdx);
                if (endIdx > startIdx)
                {
                    return strSource.Substring(startIdx, endIdx - startIdx);
                }
            }
            return String.Empty;
        }

        private void lockwhendownload()
        {
            groupBox1.Enabled = false;
            btnPaste.Enabled = false;
            btnGet.Enabled = false;
            txtURL.Enabled = false;
            cbbSite.Enabled = false;

        }

        private void unlock()
        {
            groupBox1.Enabled = true;
            btnPaste.Enabled = true;
            btnGet.Enabled = true;
            txtURL.Enabled = true;
            cbbSite.Enabled = true;
        }



        private void btnGet_Click(object sender, EventArgs e)
        {
            string widthStart = "";
            string widthEnd = "";
            site = cbbSite.Text;
            url = txtURL.Text;

            bnaver = url.Contains("naver");
            bpost = url.Contains("post");
            bentertain = url.Contains("entertain");
            btopstar = url.Contains("topstarnews");
            btwitter = url.Contains("twitter");
            bimgur = url.Contains("imgur");

            //MessageBox.Show(url.Contains("topstarnews") +"");
            //if (url.Contains("naver") == false || url.Contains("post") == false || url.Contains("entertain") == false || url.Contains("topstarnews") == false || url == "")
            if (url == "")
            {
                MessageBox.Show("Please enter URL site to download.", "URL Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtURL.Focus();
                return;
            }
            else if (bnaver == false && btopstar == false && btwitter == false && bimgur == false)
            {
                MessageBox.Show("Please enter CORRECT URL site to download.", "URL Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtURL.Focus();
                return;
            }
            else
            {
                switch (site)
                {
                    case "":
                        MessageBox.Show("Please choose website to download.", "URL Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        cbbSite.Focus();
                        return;

                    case "Post Naver":
                        widthStart = "data-src=\"";
                        widthEnd = "?type=w1200\"";
                        break;

                    case "Entertain Naver":
                        widthStart = "src=\"";
                        widthEnd = "?type=w540";
                        break;

                    case "Topstar News":
                        widthStart = "<img src=\"./thumbnail";
                        widthEnd = "v150.jpg\" alt";
                        break;

                    case "Twitter":
                        widthStart = "<img data-aria-label-part src=\"";
                        widthEnd = "\" alt=";
                        break;

                    case "Imgur":
                        widthStart = "<meta itemprop=\"contentURL\" content=\"";
                        widthEnd = "\" alt=\"\">";
                        break;
                }
            }


            //Get Source

            var html = txtURL.Text;

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            if (cbbSite.Text == "Twitter")
            {
                var node02 = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='AdaptiveMediaOuterContainer']/img");
                rtbSource.Text = node02.OuterHtml;
                string s = rtbSource.Text;
            }
            else
                rtbSource.Text = ("Node Name: " + node.Name + "\n" + node.OuterHtml);


            //lockwhendownload();
            download_progress.Visible = true;

            DATESTAMP = DateTime.Now.ToString("yyyy_MM_dd");
            DownloadFolder = path + @"\" + site + "_" + DATESTAMP;

            System.IO.Directory.CreateDirectory(DownloadFolder);
            DirectorySecurity sec = System.IO.Directory.GetAccessControl(DownloadFolder);
            // Using this instead of the "Everyone" string means we work on non-English systems.
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            System.IO.Directory.SetAccessControl(DownloadFolder, sec);

            totalLines = rtbSource.Lines.Length;


            foreach (var line in rtbSource.Lines)
            {

                if (line.Contains(widthEnd))
                {
                    data = getBetween(line, widthStart, widthEnd);
                    file = System.IO.Path.GetFileName(data);

                    webClient = new WebClient();
                    if (cbbSite.Text == "Topstar News")
                    {

                        data = @"http://www.topstarnews.net/news/photo" + data + "org.jpg";
                        file = System.IO.Path.GetFileName(data);
                        _downloadUrls.Enqueue(data);


                    }
                    if(cbbSite.Text == "Imgur")
                    {
                        data = @"https:" + data;
                        file = System.IO.Path.GetFileName(data);
                        _downloadUrls.Enqueue(data);

                    }
                    else if (cbbSite.Text == "Twitter")
                    {
                        file = System.IO.Path.GetFileName(data);
                        data = data + ":orig";
                        _downloadUrls.Enqueue(data);
                    }
                    else
                        _downloadUrls.Enqueue(data);

                }

            }

            //download_progress.
            lockwhendownload();
            pictureBox1.Visible = true;
            Downloadfile();

        }



        private void Downloadfile()
        {
            if (_downloadUrls.Any())
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                var url = _downloadUrls.Dequeue();
                filename = System.IO.Path.GetFileName(url);
                Console.WriteLine(filename);
                client.DownloadFileAsync(new Uri(url), DownloadFolder + @"\" + filename);
                rtbLink.Text += url + System.Environment.NewLine;
                return;
            }

            //End of download
            lbl_Download_stt.Text = "Download Complete.";
            pictureBox1.Visible = false;
            unlock();
            simpleSound.Play();
            if (cbOpenFolder.Checked == true)
            {
                Process.Start("explorer.exe", DownloadFolder);
            }

        }

        private void startDownload(string uri, string filepath)
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(uri), DownloadFolder + @"\" + filepath);
            });
            thread.Start();
            //this.BeginInvoke((MethodInvoker)delegate {
            //    lockwhendownload();
            //    pictureBox1.Visible = true;
            //    simpleSound.Stop();
            //});
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                bytesIn = double.Parse(e.BytesReceived.ToString());
                totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                percentage = bytesIn / totalBytes * 100;
                lbl_Download_stt.Visible = true;
                lbl_Download_stt.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                download_progress.Value = int.Parse(Math.Truncate(percentage).ToString());

                //download_progress.Visible = false;

            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Downloadfile();
            lbl_Download_stt.Text = "Download Complete.";
            this.BeginInvoke((MethodInvoker)delegate
            {

                //when completed.
                //pictureBox1.Visible = false;
                //unlock();
                ////simpleSound.Play();

            });
        }


        private void rtbSource_Click(object sender, EventArgs e)
        {
            rtbSource.SelectAll();
        }

        private void rtbLink_Click(object sender, EventArgs e)
        {
            rtbLink.SelectAll();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //string textfile = rtbLink.Text;
            //File.WriteAllText(path + @"\Naver_link.txt", textfile);
            //string downloadfile = path + @"\Naver_link.txt";
            //if (File.Exists(downloadfile))
            //{
            //    MessageBox.Show("Text file export completed.");
            //}
            //else
            //    MessageBox.Show("Can not export file.");

            //WebClient webClient = new WebClient();
            //webClient.DownloadFile(path + @"\Naver_link.txt", @"c:\myfile.txt");
            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(rtbSource.Text);
            }
            rtbLink.Text = htmlCode;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtURL.Text = Clipboard.GetText();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/longkenj");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/longkenj/navertool");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            lblClose.Visible = true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            lblClose.Visible = false;
        }

        private void cbbSite_MouseClick(object sender, MouseEventArgs e)
        {
            cbbSite.DroppedDown = true;
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            url = txtURL.Text;
            if (url.Contains("topstarnews") == true)
            {
                cbbSite.Text = "Topstar News";
            }
            else if (url.Contains("entertain") == true)
            {
                cbbSite.Text = "Entertain Naver";
            }
            else if (url.Contains("post") == true)
            {
                cbbSite.Text = "Post Naver";
            }
            else if (url.Contains("twitter") == true)
            {
                cbbSite.Text = "Twitter";
            }
            else if (url.Contains("imgur") == true)
            {
                cbbSite.Text = "Imgur";
            }
            else
                cbbSite.Text = "";


        }

        private void rtbLink_TextChanged(object sender, EventArgs e)
        {
            //rtbLink.ScrollToCaret();
            // set the current caret position to the end
            rtbLink.SelectionStart = rtbLink.Text.Length;
            // scroll it automatically
            rtbLink.ScrollToCaret();
        }

        private void rtbLink_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {   //click event
                //MessageBox.Show("you got it!");
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Cut");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.MenuItems.Add(menuItem);

                rtbLink.ContextMenu = contextMenu;
            }
        }
        void CutAction(object sender, EventArgs e)
        {
            rtbLink.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbLink.SelectedText);
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rtbLink.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }


        private void ReadEXIF(string imagefolderpath)
        {

            var directories = ImageMetadataReader.ReadMetadata(imagefolderpath);

            // print out all metadata
            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    //Console.WriteLine($"{directory.Name} - {tag.Name} = {tag.Description}");
                    Exif_images += $"{directory.Name} - {tag.Name} = {tag.Description} " + System.Environment.NewLine;
                }

            }


            // access the date time
            //var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
            //var dateTime = subIfdDirectory?.GetDateTime(ExifDirectoryBase.TagDateTime);


        }

        private void btnExif_Click(object sender, EventArgs e)
        {

            string currentpath = Environment.CurrentDirectory.ToString();
            string fileName = ""; string pathName = "";
            OpenFileDialog bDialog = new OpenFileDialog();
            bDialog.Title = "Choose images file";
            bDialog.Filter = "Image format support | *.jpg; *.tiff; *.webp; *.psd; *.png; *.bmp; *.gif; *.ico; *.pcx";
            bDialog.InitialDirectory = currentpath;
            if (bDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = bDialog.SafeFileName;
                pathName = bDialog.FileName;
            }
            else return;

            ReadEXIF(@"" + pathName);
            rtbLink.Text = Exif_images;
            DATESTAMP = DateTime.Now.ToString("yyyy_MM_dd");
            string txtfilename = "EXIF_Images_" + DATESTAMP + ".txt";
            string txtfilepath = currentpath + @"\" + txtfilename;
            System.IO.File.WriteAllText(txtfilepath, Exif_images);
        }

        private static void GrantAccess(string file)
        {
            bool exists = System.IO.Directory.Exists(file);
            if (!exists)
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory(file);
                Console.WriteLine("The Folder is created Sucessfully");
            }
            else
            {
                Console.WriteLine("The Folder already exists");
            }
            DirectoryInfo dInfo = new DirectoryInfo(file);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);

        }


    }
}
