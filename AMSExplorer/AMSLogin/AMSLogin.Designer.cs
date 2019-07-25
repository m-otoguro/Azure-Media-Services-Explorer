﻿namespace AMSExplorer
{
    partial class AMSLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMSLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDeleteAccountEntry = new System.Windows.Forms.Button();
            this.tabControlAMS = new System.Windows.Forms.TabControl();
            this.tabPageCredentials = new System.Windows.Forms.TabPage();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelAADAut = new System.Windows.Forms.LinkLabel();
            this.groupBoxAADAutMode = new System.Windows.Forms.GroupBox();
            this.radioButtonAADServicePrincipal = new System.Windows.Forms.RadioButton();
            this.radioButtonAADInteractive = new System.Windows.Forms.RadioButton();
            this.textBoxAMSResourceId = new System.Windows.Forms.TextBox();
            this.textBoxAADtenantId = new System.Windows.Forms.TextBox();
            this.labelADTenant = new System.Windows.Forms.Label();
            this.labelE2 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.tabPageAAD = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImportAll = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.accountmgtlink = new System.Windows.Forms.LinkLabel();
            this.pictureBoxJob = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonPickupAccount = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.linkLabelAMSOfflineDoc = new System.Windows.Forms.LinkLabel();
            this.tabControlAMS.SuspendLayout();
            this.tabPageCredentials.SuspendLayout();
            this.groupBoxAADAutMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAccountEntry
            // 
            resources.ApplyResources(this.buttonDeleteAccountEntry, "buttonDeleteAccountEntry");
            this.buttonDeleteAccountEntry.Name = "buttonDeleteAccountEntry";
            this.buttonDeleteAccountEntry.UseVisualStyleBackColor = true;
            this.buttonDeleteAccountEntry.Click += new System.EventHandler(this.ButtonDeleteAccount_Click);
            // 
            // tabControlAMS
            // 
            resources.ApplyResources(this.tabControlAMS, "tabControlAMS");
            this.tabControlAMS.Controls.Add(this.tabPageCredentials);
            this.tabControlAMS.Controls.Add(this.tabPageAAD);
            this.tabControlAMS.Name = "tabControlAMS";
            this.tabControlAMS.SelectedIndex = 0;
            // 
            // tabPageCredentials
            // 
            this.tabPageCredentials.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageCredentials.Controls.Add(this.textBoxDescription);
            this.tabPageCredentials.Controls.Add(this.label1);
            this.tabPageCredentials.Controls.Add(this.linkLabelAADAut);
            this.tabPageCredentials.Controls.Add(this.groupBoxAADAutMode);
            this.tabPageCredentials.Controls.Add(this.textBoxAMSResourceId);
            this.tabPageCredentials.Controls.Add(this.textBoxAADtenantId);
            this.tabPageCredentials.Controls.Add(this.labelADTenant);
            this.tabPageCredentials.Controls.Add(this.labelE2);
            this.tabPageCredentials.Controls.Add(this.textBoxLocation);
            this.tabPageCredentials.Controls.Add(this.labelLocation);
            resources.ApplyResources(this.tabPageCredentials, "tabPageCredentials");
            this.tabPageCredentials.Name = "tabPageCredentials";
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // linkLabelAADAut
            // 
            resources.ApplyResources(this.linkLabelAADAut, "linkLabelAADAut");
            this.linkLabelAADAut.Name = "linkLabelAADAut";
            this.linkLabelAADAut.TabStop = true;
            this.linkLabelAADAut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accountmgtlink_LinkClicked);
            // 
            // groupBoxAADAutMode
            // 
            this.groupBoxAADAutMode.Controls.Add(this.radioButtonAADServicePrincipal);
            this.groupBoxAADAutMode.Controls.Add(this.radioButtonAADInteractive);
            resources.ApplyResources(this.groupBoxAADAutMode, "groupBoxAADAutMode");
            this.groupBoxAADAutMode.Name = "groupBoxAADAutMode";
            this.groupBoxAADAutMode.TabStop = false;
            // 
            // radioButtonAADServicePrincipal
            // 
            resources.ApplyResources(this.radioButtonAADServicePrincipal, "radioButtonAADServicePrincipal");
            this.radioButtonAADServicePrincipal.Name = "radioButtonAADServicePrincipal";
            this.radioButtonAADServicePrincipal.UseVisualStyleBackColor = true;
            // 
            // radioButtonAADInteractive
            // 
            resources.ApplyResources(this.radioButtonAADInteractive, "radioButtonAADInteractive");
            this.radioButtonAADInteractive.Checked = true;
            this.radioButtonAADInteractive.Name = "radioButtonAADInteractive";
            this.radioButtonAADInteractive.TabStop = true;
            this.radioButtonAADInteractive.UseVisualStyleBackColor = true;
            // 
            // textBoxAMSResourceId
            // 
            resources.ApplyResources(this.textBoxAMSResourceId, "textBoxAMSResourceId");
            this.textBoxAMSResourceId.Name = "textBoxAMSResourceId";
            this.toolTip1.SetToolTip(this.textBoxAMSResourceId, resources.GetString("textBoxAMSResourceId.ToolTip"));
            // 
            // textBoxAADtenantId
            // 
            resources.ApplyResources(this.textBoxAADtenantId, "textBoxAADtenantId");
            this.textBoxAADtenantId.Name = "textBoxAADtenantId";
            // 
            // labelADTenant
            // 
            resources.ApplyResources(this.labelADTenant, "labelADTenant");
            this.labelADTenant.Name = "labelADTenant";
            // 
            // labelE2
            // 
            resources.ApplyResources(this.labelE2, "labelE2");
            this.labelE2.Name = "labelE2";
            // 
            // textBoxLocation
            // 
            resources.ApplyResources(this.textBoxLocation, "textBoxLocation");
            this.textBoxLocation.Name = "textBoxLocation";
            this.toolTip1.SetToolTip(this.textBoxLocation, resources.GetString("textBoxLocation.ToolTip"));
            // 
            // labelLocation
            // 
            resources.ApplyResources(this.labelLocation, "labelLocation");
            this.labelLocation.Name = "labelLocation";
            // 
            // tabPageAAD
            // 
            resources.ApplyResources(this.tabPageAAD, "tabPageAAD");
            this.tabPageAAD.Name = "tabPageAAD";
            this.tabPageAAD.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Name = "label5";
            // 
            // buttonExport
            // 
            resources.ApplyResources(this.buttonExport, "buttonExport");
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // buttonImportAll
            // 
            resources.ApplyResources(this.buttonImportAll, "buttonImportAll");
            this.buttonImportAll.Name = "buttonImportAll";
            this.buttonImportAll.UseVisualStyleBackColor = true;
            this.buttonImportAll.Click += new System.EventHandler(this.buttonImportAll_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // accountmgtlink
            // 
            resources.ApplyResources(this.accountmgtlink, "accountmgtlink");
            this.accountmgtlink.Name = "accountmgtlink";
            this.accountmgtlink.TabStop = true;
            this.accountmgtlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accountmgtlink_LinkClicked);
            // 
            // pictureBoxJob
            // 
            resources.ApplyResources(this.pictureBoxJob, "pictureBoxJob");
            this.pictureBoxJob.Image = global::AMSExplorer.Bitmaps.AzureMedia_Full_Color_64_opaque;
            this.pictureBoxJob.Name = "pictureBoxJob";
            this.pictureBoxJob.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelVersion
            // 
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelVersion.Name = "labelVersion";
            // 
            // buttonPickupAccount
            // 
            resources.ApplyResources(this.buttonPickupAccount, "buttonPickupAccount");
            this.buttonPickupAccount.Name = "buttonPickupAccount";
            this.buttonPickupAccount.UseVisualStyleBackColor = true;
            this.buttonPickupAccount.Click += new System.EventHandler(this.buttonPickupAccount_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.FullRowSelect = true;
            this.listViewAccounts.HideSelection = false;
            resources.ApplyResources(this.listViewAccounts, "listViewAccounts");
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.ShowItemToolTips = true;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.List;
            this.listViewAccounts.SelectedIndexChanged += new System.EventHandler(this.ListViewAccounts_SelectedIndexChanged);
            this.listViewAccounts.DoubleClick += new System.EventHandler(this.listBoxAcounts_DoubleClick);
            // 
            // linkLabelAMSOfflineDoc
            // 
            resources.ApplyResources(this.linkLabelAMSOfflineDoc, "linkLabelAMSOfflineDoc");
            this.linkLabelAMSOfflineDoc.Name = "linkLabelAMSOfflineDoc";
            this.linkLabelAMSOfflineDoc.TabStop = true;
            this.linkLabelAMSOfflineDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAMSOfflineDoc_LinkClicked);
            // 
            // AMSLogin
            // 
            this.AcceptButton = this.buttonLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.linkLabelAMSOfflineDoc);
            this.Controls.Add(this.listViewAccounts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPickupAccount);
            this.Controls.Add(this.pictureBoxJob);
            this.Controls.Add(this.accountmgtlink);
            this.Controls.Add(this.buttonImportAll);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControlAMS);
            this.Controls.Add(this.buttonDeleteAccountEntry);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AMSLogin";
            this.Load += new System.EventHandler(this.AMSLogin_Load);
            this.Shown += new System.EventHandler(this.AMSLogin_ShownAsync);
            this.tabControlAMS.ResumeLayout(false);
            this.tabPageCredentials.ResumeLayout(false);
            this.tabPageCredentials.PerformLayout();
            this.groupBoxAADAutMode.ResumeLayout(false);
            this.groupBoxAADAutMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDeleteAccountEntry;
        private System.Windows.Forms.TabControl tabControlAMS;
        private System.Windows.Forms.TabPage tabPageCredentials;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelE2;
        private System.Windows.Forms.Label labelADTenant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImportAll;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel accountmgtlink;
        private System.Windows.Forms.PictureBox pictureBoxJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxAMSResourceId;
        private System.Windows.Forms.TextBox textBoxAADtenantId;
        private System.Windows.Forms.TabPage tabPageAAD;
        private System.Windows.Forms.GroupBox groupBoxAADAutMode;
        private System.Windows.Forms.RadioButton radioButtonAADServicePrincipal;
        private System.Windows.Forms.RadioButton radioButtonAADInteractive;
        private System.Windows.Forms.LinkLabel linkLabelAADAut;
        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.Button buttonPickupAccount;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelAMSOfflineDoc;
    }
}