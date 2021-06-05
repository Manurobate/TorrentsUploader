using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;

namespace TorrentsUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadValues();
        }

        private void SaveValues()
        {
            // Connexion infos
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("host");
            config.AppSettings.Settings.Add("host", txtHost.Text);
            config.AppSettings.Settings.Remove("user");
            config.AppSettings.Settings.Add("user", txtUser.Text);
            config.AppSettings.Settings.Remove("password");
            config.AppSettings.Settings.Add("password", txtPassword.Text);

            // Local paths
            config.AppSettings.Settings.Remove("localMovies");
            config.AppSettings.Settings.Add("localMovies", txtLocalMovies.Text);
            config.AppSettings.Settings.Remove("localSeries");
            config.AppSettings.Settings.Add("localSeries", txtLocalSeries.Text);
            config.AppSettings.Settings.Remove("localTV");
            config.AppSettings.Settings.Add("localTV", txtLocalTV.Text);
            config.AppSettings.Settings.Remove("localOther");
            config.AppSettings.Settings.Add("localOther", txtLocalOther.Text);

            // Remote paths
            config.AppSettings.Settings.Remove("remoteMovies");
            config.AppSettings.Settings.Add("remoteMovies", txtRemoteMovies.Text);
            config.AppSettings.Settings.Remove("remoteSeries");
            config.AppSettings.Settings.Add("remoteSeries", txtRemoteSeries.Text);
            config.AppSettings.Settings.Remove("remoteTV");
            config.AppSettings.Settings.Add("remoteTV", txtRemoteTV.Text);
            config.AppSettings.Settings.Remove("remoteOther");
            config.AppSettings.Settings.Add("remoteOther", txtRemoteOther.Text);

            // Options
            config.AppSettings.Settings.Remove("deleteLocalFiles");
            config.AppSettings.Settings.Add("deleteLocalFiles", checkDelFiles.Checked.ToString());

            config.Save(ConfigurationSaveMode.Modified);
        }

        private void LoadValues()
        {
            // Connexion infos
            txtHost.Text = ConfigurationManager.AppSettings["host"];
            txtUser.Text = ConfigurationManager.AppSettings["user"];
            txtPassword.Text = ConfigurationManager.AppSettings["password"];

            // Local paths
            txtLocalMovies.Text = ConfigurationManager.AppSettings["localMovies"];
            txtLocalSeries.Text = ConfigurationManager.AppSettings["localSeries"];
            txtLocalTV.Text = ConfigurationManager.AppSettings["localTV"];
            txtLocalOther.Text = ConfigurationManager.AppSettings["localOther"];

            // Remote paths
            txtRemoteMovies.Text = ConfigurationManager.AppSettings["remoteMovies"];
            txtRemoteSeries.Text = ConfigurationManager.AppSettings["remoteSeries"];
            txtRemoteTV.Text = ConfigurationManager.AppSettings["remoteTV"];
            txtRemoteOther.Text = ConfigurationManager.AppSettings["remoteOther"];

            // Options
            if ("True".Equals(ConfigurationManager.AppSettings["deleteLocalFiles"]))
                checkDelFiles.Checked = true;
            else
                checkDelFiles.Checked = false;
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            // TODO Check Values
            if (txtHost.Text.Length == 0 || txtUser.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("No credentials found. Can't connect to the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btUpload.Enabled = false;

            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Ftp,
                HostName = txtHost.Text,
                UserName = txtUser.Text,
                Password = txtPassword.Text,
                // Enable FTPS in explicit mode, aka FTPES
                FtpSecure = FtpSecure.Explicit,
            };

            using (Session session = new Session())
            {
                // Connect
                try
                {
                    session.Open(sessionOptions);


                    // Ulpload files
                    int iNbFiles = 0;
                    int iCpt = 0;

                    bool bMovies, bSeries, bTV, bOther;

                    try
                    {
                        iNbFiles += Directory.GetFiles(txtLocalMovies.Text).Length;
                        bMovies = true;
                    }
                    catch (Exception ex)
                    {
                        bMovies = false;
                    }

                    try
                    {
                        iNbFiles += Directory.GetFiles(txtLocalSeries.Text).Length;
                        bSeries = true;
                    }
                    catch (Exception ex)
                    {
                        bSeries = false;
                    }

                    try
                    {
                        iNbFiles += Directory.GetFiles(txtLocalTV.Text).Length;
                        bTV = true;
                    }
                    catch (Exception ex)
                    {
                        bTV = false;
                    }

                    try
                    {
                        iNbFiles += Directory.GetFiles(txtLocalOther.Text).Length;
                        bOther = true;
                    }
                    catch (Exception ex)
                    {
                        bOther = false;
                    }

                    if (bMovies)
                    {
                        foreach (string file in Directory.GetFiles(txtLocalMovies.Text))
                        {
                            iCpt++;
                            progressBarUpload.Value = (iCpt * 100) / iNbFiles;
                            session.PutFileToDirectory(file, txtRemoteMovies.Text, checkDelFiles.Checked);
                        }
                    }

                    if (bSeries)
                    {
                        foreach (string file in Directory.GetFiles(txtLocalSeries.Text))
                        {
                            iCpt++;
                            progressBarUpload.Value = (iCpt * 100) / iNbFiles;
                            session.PutFileToDirectory(file, txtRemoteSeries.Text, checkDelFiles.Checked);
                        }
                    }

                    if (bTV)
                    {
                        foreach (string file in Directory.GetFiles(txtLocalTV.Text))
                        {
                            iCpt++;
                            progressBarUpload.Value = (iCpt * 100) / iNbFiles;
                            session.PutFileToDirectory(file, txtRemoteTV.Text, checkDelFiles.Checked);
                        }
                    }

                    if (bOther)
                    {
                        foreach (string file in Directory.GetFiles(txtLocalOther.Text))
                        {
                            iCpt++;
                            progressBarUpload.Value = (iCpt * 100) / iNbFiles;
                            session.PutFileToDirectory(file, txtRemoteOther.Text, checkDelFiles.Checked);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBarUpload.Value = 0;
                }
            }

            btUpload.Enabled = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void btBrowseMovies_Click(object sender, EventArgs e)
        {
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocalMovies.Text = browserDialog.SelectedPath;
            }
        }

        private void btBrowseSeries_Click(object sender, EventArgs e)
        {
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocalSeries.Text = browserDialog.SelectedPath;
            }
        }

        private void btBrowseTV_Click(object sender, EventArgs e)
        {
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocalTV.Text = browserDialog.SelectedPath;
            }
        }

        private void btBrowseOther_Click(object sender, EventArgs e)
        {
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocalOther.Text = browserDialog.SelectedPath;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveValues();
        }
    }
}
