namespace TorrentsUploader
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btUpload = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grConnexion = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.grLocal = new System.Windows.Forms.GroupBox();
            this.btBrowseOther = new System.Windows.Forms.Button();
            this.txtLocalOther = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btBrowseTV = new System.Windows.Forms.Button();
            this.txtLocalTV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btBrowseSeries = new System.Windows.Forms.Button();
            this.txtLocalSeries = new System.Windows.Forms.TextBox();
            this.btLocalSeries = new System.Windows.Forms.Label();
            this.btBrowseMovies = new System.Windows.Forms.Button();
            this.txtLocalMovies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grRemote = new System.Windows.Forms.GroupBox();
            this.txtRemoteOther = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemoteTV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemoteSeries = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemoteMovies = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkDelFiles = new System.Windows.Forms.CheckBox();
            this.progressBarUpload = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.grConnexion.SuspendLayout();
            this.grLocal.SuspendLayout();
            this.grRemote.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUpload
            // 
            this.btUpload.AccessibleName = "";
            this.btUpload.Location = new System.Drawing.Point(174, 266);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(121, 23);
            this.btUpload.TabIndex = 0;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fichierToolStripMenuItem.Text = "File";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.quitterToolStripMenuItem.Text = "Exit";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // grConnexion
            // 
            this.grConnexion.Controls.Add(this.txtPassword);
            this.grConnexion.Controls.Add(this.label3);
            this.grConnexion.Controls.Add(this.txtUser);
            this.grConnexion.Controls.Add(this.label2);
            this.grConnexion.Controls.Add(this.label1);
            this.grConnexion.Controls.Add(this.txtHost);
            this.grConnexion.Location = new System.Drawing.Point(12, 27);
            this.grConnexion.Name = "grConnexion";
            this.grConnexion.Size = new System.Drawing.Size(572, 42);
            this.grConnexion.TabIndex = 2;
            this.grConnexion.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(442, 13);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(124, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(253, 13);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(124, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host :";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(41, 13);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(171, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.WordWrap = false;
            // 
            // grLocal
            // 
            this.grLocal.Controls.Add(this.btBrowseOther);
            this.grLocal.Controls.Add(this.txtLocalOther);
            this.grLocal.Controls.Add(this.label7);
            this.grLocal.Controls.Add(this.btBrowseTV);
            this.grLocal.Controls.Add(this.txtLocalTV);
            this.grLocal.Controls.Add(this.label6);
            this.grLocal.Controls.Add(this.btBrowseSeries);
            this.grLocal.Controls.Add(this.txtLocalSeries);
            this.grLocal.Controls.Add(this.btLocalSeries);
            this.grLocal.Controls.Add(this.btBrowseMovies);
            this.grLocal.Controls.Add(this.txtLocalMovies);
            this.grLocal.Controls.Add(this.label4);
            this.grLocal.Location = new System.Drawing.Point(12, 75);
            this.grLocal.Name = "grLocal";
            this.grLocal.Size = new System.Drawing.Size(283, 185);
            this.grLocal.TabIndex = 3;
            this.grLocal.TabStop = false;
            this.grLocal.Text = "Local";
            // 
            // btBrowseOther
            // 
            this.btBrowseOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowseOther.Location = new System.Drawing.Point(255, 157);
            this.btBrowseOther.Name = "btBrowseOther";
            this.btBrowseOther.Size = new System.Drawing.Size(24, 22);
            this.btBrowseOther.TabIndex = 16;
            this.btBrowseOther.Text = "...";
            this.btBrowseOther.UseVisualStyleBackColor = true;
            this.btBrowseOther.Click += new System.EventHandler(this.btBrowseOther_Click);
            // 
            // txtLocalOther
            // 
            this.txtLocalOther.Location = new System.Drawing.Point(6, 158);
            this.txtLocalOther.Name = "txtLocalOther";
            this.txtLocalOther.Size = new System.Drawing.Size(247, 20);
            this.txtLocalOther.TabIndex = 14;
            this.txtLocalOther.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Other :";
            // 
            // btBrowseTV
            // 
            this.btBrowseTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowseTV.Location = new System.Drawing.Point(255, 118);
            this.btBrowseTV.Name = "btBrowseTV";
            this.btBrowseTV.Size = new System.Drawing.Size(24, 22);
            this.btBrowseTV.TabIndex = 13;
            this.btBrowseTV.Text = "...";
            this.btBrowseTV.UseVisualStyleBackColor = true;
            this.btBrowseTV.Click += new System.EventHandler(this.btBrowseTV_Click);
            // 
            // txtLocalTV
            // 
            this.txtLocalTV.Location = new System.Drawing.Point(6, 119);
            this.txtLocalTV.Name = "txtLocalTV";
            this.txtLocalTV.Size = new System.Drawing.Size(247, 20);
            this.txtLocalTV.TabIndex = 11;
            this.txtLocalTV.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TV :";
            // 
            // btBrowseSeries
            // 
            this.btBrowseSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowseSeries.Location = new System.Drawing.Point(255, 79);
            this.btBrowseSeries.Name = "btBrowseSeries";
            this.btBrowseSeries.Size = new System.Drawing.Size(24, 22);
            this.btBrowseSeries.TabIndex = 10;
            this.btBrowseSeries.Text = "...";
            this.btBrowseSeries.UseVisualStyleBackColor = true;
            this.btBrowseSeries.Click += new System.EventHandler(this.btBrowseSeries_Click);
            // 
            // txtLocalSeries
            // 
            this.txtLocalSeries.Location = new System.Drawing.Point(6, 80);
            this.txtLocalSeries.Name = "txtLocalSeries";
            this.txtLocalSeries.Size = new System.Drawing.Size(247, 20);
            this.txtLocalSeries.TabIndex = 8;
            this.txtLocalSeries.WordWrap = false;
            // 
            // btLocalSeries
            // 
            this.btLocalSeries.AutoSize = true;
            this.btLocalSeries.Location = new System.Drawing.Point(6, 64);
            this.btLocalSeries.Name = "btLocalSeries";
            this.btLocalSeries.Size = new System.Drawing.Size(42, 13);
            this.btLocalSeries.TabIndex = 9;
            this.btLocalSeries.Text = "Series :";
            // 
            // btBrowseMovies
            // 
            this.btBrowseMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowseMovies.Location = new System.Drawing.Point(255, 40);
            this.btBrowseMovies.Name = "btBrowseMovies";
            this.btBrowseMovies.Size = new System.Drawing.Size(24, 22);
            this.btBrowseMovies.TabIndex = 7;
            this.btBrowseMovies.Text = "...";
            this.btBrowseMovies.UseVisualStyleBackColor = true;
            this.btBrowseMovies.Click += new System.EventHandler(this.btBrowseMovies_Click);
            // 
            // txtLocalMovies
            // 
            this.txtLocalMovies.Location = new System.Drawing.Point(6, 41);
            this.txtLocalMovies.Name = "txtLocalMovies";
            this.txtLocalMovies.Size = new System.Drawing.Size(247, 20);
            this.txtLocalMovies.TabIndex = 6;
            this.txtLocalMovies.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Movies :";
            // 
            // grRemote
            // 
            this.grRemote.Controls.Add(this.txtRemoteOther);
            this.grRemote.Controls.Add(this.label5);
            this.grRemote.Controls.Add(this.txtRemoteTV);
            this.grRemote.Controls.Add(this.label8);
            this.grRemote.Controls.Add(this.txtRemoteSeries);
            this.grRemote.Controls.Add(this.label9);
            this.grRemote.Controls.Add(this.txtRemoteMovies);
            this.grRemote.Controls.Add(this.label10);
            this.grRemote.Location = new System.Drawing.Point(301, 75);
            this.grRemote.Name = "grRemote";
            this.grRemote.Size = new System.Drawing.Size(283, 185);
            this.grRemote.TabIndex = 17;
            this.grRemote.TabStop = false;
            this.grRemote.Text = "Remote";
            // 
            // txtRemoteOther
            // 
            this.txtRemoteOther.Location = new System.Drawing.Point(6, 158);
            this.txtRemoteOther.Name = "txtRemoteOther";
            this.txtRemoteOther.Size = new System.Drawing.Size(271, 20);
            this.txtRemoteOther.TabIndex = 14;
            this.txtRemoteOther.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Other :";
            // 
            // txtRemoteTV
            // 
            this.txtRemoteTV.Location = new System.Drawing.Point(6, 119);
            this.txtRemoteTV.Name = "txtRemoteTV";
            this.txtRemoteTV.Size = new System.Drawing.Size(271, 20);
            this.txtRemoteTV.TabIndex = 11;
            this.txtRemoteTV.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "TV :";
            // 
            // txtRemoteSeries
            // 
            this.txtRemoteSeries.Location = new System.Drawing.Point(6, 80);
            this.txtRemoteSeries.Name = "txtRemoteSeries";
            this.txtRemoteSeries.Size = new System.Drawing.Size(271, 20);
            this.txtRemoteSeries.TabIndex = 8;
            this.txtRemoteSeries.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Series :";
            // 
            // txtRemoteMovies
            // 
            this.txtRemoteMovies.Location = new System.Drawing.Point(6, 41);
            this.txtRemoteMovies.Name = "txtRemoteMovies";
            this.txtRemoteMovies.Size = new System.Drawing.Size(271, 20);
            this.txtRemoteMovies.TabIndex = 6;
            this.txtRemoteMovies.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Movies :";
            // 
            // checkDelFiles
            // 
            this.checkDelFiles.AutoSize = true;
            this.checkDelFiles.Location = new System.Drawing.Point(21, 266);
            this.checkDelFiles.Name = "checkDelFiles";
            this.checkDelFiles.Size = new System.Drawing.Size(112, 17);
            this.checkDelFiles.TabIndex = 18;
            this.checkDelFiles.Text = "Delete local files ?";
            this.checkDelFiles.UseVisualStyleBackColor = true;
            // 
            // progressBarUpload
            // 
            this.progressBarUpload.Location = new System.Drawing.Point(307, 266);
            this.progressBarUpload.Name = "progressBarUpload";
            this.progressBarUpload.Size = new System.Drawing.Size(271, 23);
            this.progressBarUpload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarUpload.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 296);
            this.Controls.Add(this.progressBarUpload);
            this.Controls.Add(this.checkDelFiles);
            this.Controls.Add(this.grRemote);
            this.Controls.Add(this.grLocal);
            this.Controls.Add(this.grConnexion);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Torrents Uploader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grConnexion.ResumeLayout(false);
            this.grConnexion.PerformLayout();
            this.grLocal.ResumeLayout(false);
            this.grLocal.PerformLayout();
            this.grRemote.ResumeLayout(false);
            this.grRemote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.GroupBox grConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocalMovies;
        private System.Windows.Forms.Button btBrowseMovies;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btBrowseOther;
        private System.Windows.Forms.TextBox txtLocalOther;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btBrowseTV;
        private System.Windows.Forms.TextBox txtLocalTV;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBrowseSeries;
        private System.Windows.Forms.TextBox txtLocalSeries;
        private System.Windows.Forms.Label btLocalSeries;
        private System.Windows.Forms.GroupBox grRemote;
        private System.Windows.Forms.TextBox txtRemoteOther;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemoteTV;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemoteSeries;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemoteMovies;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FolderBrowserDialog browserDialog;
        private System.Windows.Forms.CheckBox checkDelFiles;
        private System.Windows.Forms.ProgressBar progressBarUpload;
    }
}

