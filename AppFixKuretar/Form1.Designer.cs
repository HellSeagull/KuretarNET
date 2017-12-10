using System;
using System.Windows.Forms;

namespace AppFixKuretar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.RepairWoW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RecupTRP = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.RecupMacro = new System.Windows.Forms.Button();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.FixConnexion = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelPerc = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.Solution1 = new System.Windows.Forms.Button();
            this.Solution2 = new System.Windows.Forms.Button();
            this.MoveFolder = new System.Windows.Forms.Button();
            this.FixDroits = new System.Windows.Forms.Button();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            this.fixPart = new System.Windows.Forms.Label();
            this.FIX = new System.Windows.Forms.Label();
            this.HELPER = new System.Windows.Forms.Label();
            this.cache = new System.Windows.Forms.Button();
            this.CAS = new System.Windows.Forms.Label();
            this.Divers = new System.Windows.Forms.Label();
            this.Util = new System.Windows.Forms.Label();
            this.Sorts = new System.Windows.Forms.Label();
            this.Cosme = new System.Windows.Forms.Label();
            this.Addons = new System.Windows.Forms.Label();
            this.Forge = new System.Windows.Forms.Label();
            this.Anim = new System.Windows.Forms.Label();
            this.Kuretar = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.Join = new System.Windows.Forms.Label();
            this.Patch = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.Util2 = new System.Windows.Forms.Label();
            this.Rejoin = new System.Windows.Forms.Label();
            this.Links = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Dons = new System.Windows.Forms.Label();
            this.Voter = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(168, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Open
            // 
            this.Open.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Open.BackColor = System.Drawing.Color.Transparent;
            this.Open.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Open.Cursor = System.Windows.Forms.Cursors.Default;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Lato Heavy", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(370, 197);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(96, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Open_MouseClick);
            this.Open.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Open_MouseDown);
            this.Open.MouseEnter += new System.EventHandler(this.Open_MouseEnter);
            this.Open.MouseLeave += new System.EventHandler(this.Open_MouseLeave);
            this.Open.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Open_MouseUp);
            // 
            // RepairWoW
            // 
            this.RepairWoW.BackColor = System.Drawing.Color.Transparent;
            this.RepairWoW.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.RepairWoW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RepairWoW.FlatAppearance.BorderSize = 0;
            this.RepairWoW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepairWoW.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairWoW.ForeColor = System.Drawing.Color.White;
            this.RepairWoW.Location = new System.Drawing.Point(370, 204);
            this.RepairWoW.Name = "RepairWoW";
            this.RepairWoW.Size = new System.Drawing.Size(96, 60);
            this.RepairWoW.TabIndex = 2;
            this.RepairWoW.Text = "RepairWoW";
            this.RepairWoW.UseVisualStyleBackColor = false;
            this.RepairWoW.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RepairWoW_MouseClick);
            this.RepairWoW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RepairWoW_MouseDown);
            this.RepairWoW.MouseEnter += new System.EventHandler(this.RepairWoW_MouseEnter);
            this.RepairWoW.MouseLeave += new System.EventHandler(this.RepairWoW_MouseLeave);
            this.RepairWoW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RepairWoW_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dossier Kuretar";
            // 
            // RecupTRP
            // 
            this.RecupTRP.BackColor = System.Drawing.Color.Transparent;
            this.RecupTRP.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.RecupTRP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecupTRP.FlatAppearance.BorderSize = 0;
            this.RecupTRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecupTRP.Font = new System.Drawing.Font("Lato Heavy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecupTRP.ForeColor = System.Drawing.Color.White;
            this.RecupTRP.Location = new System.Drawing.Point(587, 270);
            this.RecupTRP.Name = "RecupTRP";
            this.RecupTRP.Size = new System.Drawing.Size(98, 60);
            this.RecupTRP.TabIndex = 5;
            this.RecupTRP.Text = "Recup TRP";
            this.RecupTRP.UseVisualStyleBackColor = false;
            this.RecupTRP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RecupTRP_MouseClick);
            this.RecupTRP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecupTRP_MouseDown);
            this.RecupTRP.MouseEnter += new System.EventHandler(this.RecupTRP_MouseEnter);
            this.RecupTRP.MouseLeave += new System.EventHandler(this.RecupTRP_MouseLeave);
            this.RecupTRP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RecupTRP_MouseUp);
            // 
            // RecupMacro
            // 
            this.RecupMacro.BackColor = System.Drawing.Color.Transparent;
            this.RecupMacro.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.RecupMacro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecupMacro.FlatAppearance.BorderSize = 0;
            this.RecupMacro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecupMacro.Font = new System.Drawing.Font("Lato Heavy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecupMacro.ForeColor = System.Drawing.Color.White;
            this.RecupMacro.Location = new System.Drawing.Point(587, 204);
            this.RecupMacro.Name = "RecupMacro";
            this.RecupMacro.Size = new System.Drawing.Size(98, 60);
            this.RecupMacro.TabIndex = 6;
            this.RecupMacro.Text = "Recup Macro";
            this.RecupMacro.UseVisualStyleBackColor = false;
            this.RecupMacro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RecupMacro_MouseClick);
            this.RecupMacro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecupMacro_MouseDown);
            this.RecupMacro.MouseEnter += new System.EventHandler(this.RecupMacro_MouseEnter);
            this.RecupMacro.MouseLeave += new System.EventHandler(this.RecupMacro_MouseLeave);
            this.RecupMacro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RecupMacro_MouseUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "©Kuretar";
            // 
            // FixConnexion
            // 
            this.FixConnexion.BackColor = System.Drawing.Color.Transparent;
            this.FixConnexion.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.FixConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FixConnexion.FlatAppearance.BorderSize = 0;
            this.FixConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixConnexion.Font = new System.Drawing.Font("Lato Heavy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixConnexion.ForeColor = System.Drawing.Color.White;
            this.FixConnexion.Location = new System.Drawing.Point(370, 270);
            this.FixConnexion.Name = "FixConnexion";
            this.FixConnexion.Size = new System.Drawing.Size(96, 60);
            this.FixConnexion.TabIndex = 11;
            this.FixConnexion.Text = "Fix Connexion\r\n+\r\nPatch";
            this.FixConnexion.UseVisualStyleBackColor = false;
            this.FixConnexion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FixConnexion_MouseClick);
            this.FixConnexion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FixConnexion_MouseDown);
            this.FixConnexion.MouseEnter += new System.EventHandler(this.FixConnexion_MouseEnter);
            this.FixConnexion.MouseLeave += new System.EventHandler(this.FixConnexion_MouseLeave);
            this.FixConnexion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FixConnexion_MouseUp);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(273, 480);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(294, 23);
            this.progressBar.TabIndex = 13;
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.BackColor = System.Drawing.Color.Transparent;
            this.labelPerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPerc.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerc.ForeColor = System.Drawing.Color.White;
            this.labelPerc.Location = new System.Drawing.Point(573, 484);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(0, 17);
            this.labelPerc.TabIndex = 14;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSpeed.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(520, 506);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(0, 17);
            this.labelSpeed.TabIndex = 15;
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloaded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDownloaded.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloaded.ForeColor = System.Drawing.Color.White;
            this.labelDownloaded.Location = new System.Drawing.Point(270, 506);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(0, 17);
            this.labelDownloaded.TabIndex = 16;
            // 
            // Solution1
            // 
            this.Solution1.BackColor = System.Drawing.Color.Transparent;
            this.Solution1.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.Solution1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Solution1.FlatAppearance.BorderSize = 0;
            this.Solution1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solution1.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solution1.ForeColor = System.Drawing.Color.White;
            this.Solution1.Location = new System.Drawing.Point(168, 204);
            this.Solution1.Name = "Solution1";
            this.Solution1.Size = new System.Drawing.Size(96, 60);
            this.Solution1.TabIndex = 17;
            this.Solution1.Text = "Solution n°1";
            this.Solution1.UseVisualStyleBackColor = false;
            this.Solution1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Solution1_MouseClick);
            this.Solution1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Solution1_MouseDown);
            this.Solution1.MouseEnter += new System.EventHandler(this.Solution1_MouseEnter);
            this.Solution1.MouseLeave += new System.EventHandler(this.Solution1_MouseLeave);
            this.Solution1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Solution1_MouseUp);
            // 
            // Solution2
            // 
            this.Solution2.BackColor = System.Drawing.Color.Transparent;
            this.Solution2.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.Solution2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Solution2.FlatAppearance.BorderSize = 0;
            this.Solution2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solution2.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solution2.ForeColor = System.Drawing.Color.White;
            this.Solution2.Location = new System.Drawing.Point(168, 270);
            this.Solution2.Name = "Solution2";
            this.Solution2.Size = new System.Drawing.Size(96, 60);
            this.Solution2.TabIndex = 18;
            this.Solution2.Text = "Solution n°2";
            this.Solution2.UseVisualStyleBackColor = false;
            this.Solution2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Solution2_MouseClick);
            this.Solution2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Solution2_MouseDown);
            this.Solution2.MouseEnter += new System.EventHandler(this.Solution2_MouseEnter);
            this.Solution2.MouseLeave += new System.EventHandler(this.Solution2_MouseLeave);
            this.Solution2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Solution2_MouseUp);
            // 
            // MoveFolder
            // 
            this.MoveFolder.BackColor = System.Drawing.Color.Transparent;
            this.MoveFolder.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.MoveFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveFolder.FlatAppearance.BorderSize = 0;
            this.MoveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveFolder.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveFolder.ForeColor = System.Drawing.Color.White;
            this.MoveFolder.Location = new System.Drawing.Point(168, 402);
            this.MoveFolder.Name = "MoveFolder";
            this.MoveFolder.Size = new System.Drawing.Size(96, 60);
            this.MoveFolder.TabIndex = 19;
            this.MoveFolder.Text = "Move Folder";
            this.MoveFolder.UseVisualStyleBackColor = false;
            this.MoveFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoveFolder_MouseClick);
            this.MoveFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFolder_MouseDown);
            this.MoveFolder.MouseEnter += new System.EventHandler(this.MoveFolder_MouseEnter);
            this.MoveFolder.MouseLeave += new System.EventHandler(this.MoveFolder_MouseLeave);
            this.MoveFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveFolder_MouseUp);
            // 
            // FixDroits
            // 
            this.FixDroits.BackColor = System.Drawing.Color.Transparent;
            this.FixDroits.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.FixDroits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FixDroits.FlatAppearance.BorderSize = 0;
            this.FixDroits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixDroits.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixDroits.ForeColor = System.Drawing.Color.White;
            this.FixDroits.Location = new System.Drawing.Point(168, 336);
            this.FixDroits.Name = "FixDroits";
            this.FixDroits.Size = new System.Drawing.Size(96, 60);
            this.FixDroits.TabIndex = 20;
            this.FixDroits.Text = "Fix Droits";
            this.FixDroits.UseVisualStyleBackColor = false;
            this.FixDroits.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FixDroits_MouseClick);
            this.FixDroits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FixDroits_MouseDown);
            this.FixDroits.MouseEnter += new System.EventHandler(this.FixDroits_MouseEnter);
            this.FixDroits.MouseLeave += new System.EventHandler(this.FixDroits_MouseLeave);
            this.FixDroits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FixDroits_MouseUp);
            // 
            // fixPart
            // 
            this.fixPart.AutoSize = true;
            this.fixPart.BackColor = System.Drawing.Color.Transparent;
            this.fixPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixPart.Font = new System.Drawing.Font("Lemon/Milk", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixPart.ForeColor = System.Drawing.Color.White;
            this.fixPart.Location = new System.Drawing.Point(308, 78);
            this.fixPart.Name = "fixPart";
            this.fixPart.Size = new System.Drawing.Size(214, 35);
            this.fixPart.TabIndex = 21;
            this.fixPart.Text = "fix disponibles";
            // 
            // FIX
            // 
            this.FIX.AutoSize = true;
            this.FIX.BackColor = System.Drawing.Color.Transparent;
            this.FIX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FIX.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.FIX.Location = new System.Drawing.Point(168, 53);
            this.FIX.Name = "FIX";
            this.FIX.Size = new System.Drawing.Size(59, 33);
            this.FIX.TabIndex = 22;
            this.FIX.Text = "FIX";
            this.FIX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FIX_MouseClick);
            this.FIX.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FIX_MouseDoucleClick);
            this.FIX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FIX_MouseDown);
            this.FIX.MouseEnter += new System.EventHandler(this.FIX_MouseEnter);
            this.FIX.MouseLeave += new System.EventHandler(this.FIX_MouseLeave);
            this.FIX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FIX_MouseUp);
            // 
            // HELPER
            // 
            this.HELPER.AutoSize = true;
            this.HELPER.BackColor = System.Drawing.Color.Transparent;
            this.HELPER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HELPER.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HELPER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.HELPER.Location = new System.Drawing.Point(581, 53);
            this.HELPER.Name = "HELPER";
            this.HELPER.Size = new System.Drawing.Size(121, 33);
            this.HELPER.TabIndex = 22;
            this.HELPER.Text = "HELPER";
            this.HELPER.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HELPER_MouseClick);
            this.HELPER.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HELPER_MouseDoucleClick);
            this.HELPER.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HELPER_MouseDown);
            this.HELPER.MouseEnter += new System.EventHandler(this.HELPER_MouseEnter);
            this.HELPER.MouseLeave += new System.EventHandler(this.HELPER_MouseLeave);
            this.HELPER.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HELPER_MouseUp);
            // 
            // cache
            // 
            this.cache.BackColor = System.Drawing.Color.Transparent;
            this.cache.BackgroundImage = global::KuretarFixManager.Properties.Resources.buttonModel;
            this.cache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cache.FlatAppearance.BorderSize = 0;
            this.cache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cache.Font = new System.Drawing.Font("Lato Heavy", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cache.ForeColor = System.Drawing.Color.White;
            this.cache.Location = new System.Drawing.Point(370, 336);
            this.cache.Name = "cache";
            this.cache.Size = new System.Drawing.Size(96, 60);
            this.cache.TabIndex = 24;
            this.cache.Text = "Vider Cache (fix lags)";
            this.cache.UseVisualStyleBackColor = false;
            this.cache.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cache_MouseClick);
            this.cache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cache_MouseDown);
            this.cache.MouseEnter += new System.EventHandler(this.cache_MouseEnter);
            this.cache.MouseLeave += new System.EventHandler(this.cache_MouseLeave);
            this.cache.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cache_MouseUp);
            // 
            // CAS
            // 
            this.CAS.AutoSize = true;
            this.CAS.BackColor = System.Drawing.Color.Transparent;
            this.CAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAS.Font = new System.Drawing.Font("Lato Heavy", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAS.ForeColor = System.Drawing.Color.White;
            this.CAS.Location = new System.Drawing.Point(170, 147);
            this.CAS.Name = "CAS";
            this.CAS.Size = new System.Drawing.Size(93, 21);
            this.CAS.TabIndex = 25;
            this.CAS.Text = "Erreur CAS";
            // 
            // Divers
            // 
            this.Divers.AutoSize = true;
            this.Divers.BackColor = System.Drawing.Color.Transparent;
            this.Divers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divers.Font = new System.Drawing.Font("Lato Heavy", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divers.ForeColor = System.Drawing.Color.White;
            this.Divers.Location = new System.Drawing.Point(387, 147);
            this.Divers.Name = "Divers";
            this.Divers.Size = new System.Drawing.Size(59, 21);
            this.Divers.TabIndex = 26;
            this.Divers.Text = "Divers";
            // 
            // Util
            // 
            this.Util.AutoSize = true;
            this.Util.BackColor = System.Drawing.Color.Transparent;
            this.Util.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Util.Font = new System.Drawing.Font("Lato Heavy", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Util.ForeColor = System.Drawing.Color.White;
            this.Util.Location = new System.Drawing.Point(595, 147);
            this.Util.Name = "Util";
            this.Util.Size = new System.Drawing.Size(76, 21);
            this.Util.TabIndex = 27;
            this.Util.Text = "Utilitaire";
            // 
            // Sorts
            // 
            this.Sorts.AutoSize = true;
            this.Sorts.BackColor = System.Drawing.Color.Transparent;
            this.Sorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sorts.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Sorts.Location = new System.Drawing.Point(60, 279);
            this.Sorts.Name = "Sorts";
            this.Sorts.Size = new System.Drawing.Size(203, 33);
            this.Sorts.TabIndex = 28;
            this.Sorts.Text = "Listes de Sorts";
            this.Sorts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sorts_MouseClick);
            this.Sorts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sorts_MouseDown);
            this.Sorts.MouseEnter += new System.EventHandler(this.Sorts_MouseEnter);
            this.Sorts.MouseLeave += new System.EventHandler(this.Sorts_MouseLeave);
            this.Sorts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sorts_MouseUp);
            // 
            // Cosme
            // 
            this.Cosme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cosme.AutoSize = true;
            this.Cosme.BackColor = System.Drawing.Color.Transparent;
            this.Cosme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cosme.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cosme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Cosme.Location = new System.Drawing.Point(60, 213);
            this.Cosme.Name = "Cosme";
            this.Cosme.Size = new System.Drawing.Size(179, 33);
            this.Cosme.TabIndex = 29;
            this.Cosme.Text = "Cosmétiques";
            this.Cosme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cosme_MouseClick);
            this.Cosme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cosme_MouseDown);
            this.Cosme.MouseEnter += new System.EventHandler(this.Cosme_MouseEnter);
            this.Cosme.MouseLeave += new System.EventHandler(this.Cosme_MouseLeave);
            this.Cosme.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cosme_MouseUp);
            // 
            // Addons
            // 
            this.Addons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Addons.AutoSize = true;
            this.Addons.BackColor = System.Drawing.Color.Transparent;
            this.Addons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addons.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Addons.Location = new System.Drawing.Point(61, 345);
            this.Addons.Name = "Addons";
            this.Addons.Size = new System.Drawing.Size(111, 33);
            this.Addons.TabIndex = 30;
            this.Addons.Text = "Addons";
            this.Addons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Addons_MouseClick);
            this.Addons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Addons_MouseDown);
            this.Addons.MouseEnter += new System.EventHandler(this.Addons_MouseEnter);
            this.Addons.MouseLeave += new System.EventHandler(this.Addons_MouseLeave);
            this.Addons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Addons_MouseUp);
            // 
            // Forge
            // 
            this.Forge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Forge.AutoSize = true;
            this.Forge.BackColor = System.Drawing.Color.Transparent;
            this.Forge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forge.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Forge.Location = new System.Drawing.Point(581, 213);
            this.Forge.Name = "Forge";
            this.Forge.Size = new System.Drawing.Size(205, 33);
            this.Forge.TabIndex = 31;
            this.Forge.Text = "Tutoriels Forge";
            this.Forge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Forge_MouseClick);
            this.Forge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Forge_MouseDown);
            this.Forge.MouseEnter += new System.EventHandler(this.Forge_MouseEnter);
            this.Forge.MouseLeave += new System.EventHandler(this.Forge_MouseLeave);
            this.Forge.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Forge_MouseUp);
            // 
            // Anim
            // 
            this.Anim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Anim.AutoSize = true;
            this.Anim.BackColor = System.Drawing.Color.Transparent;
            this.Anim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anim.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Anim.Location = new System.Drawing.Point(581, 279);
            this.Anim.Name = "Anim";
            this.Anim.Size = new System.Drawing.Size(168, 33);
            this.Anim.TabIndex = 32;
            this.Anim.Text = "Liste Debug";
            this.Anim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Anim_MouseClick);
            this.Anim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Anim_MouseDown);
            this.Anim.MouseEnter += new System.EventHandler(this.Anim_MouseEnter);
            this.Anim.MouseLeave += new System.EventHandler(this.Anim_MouseLeave);
            this.Anim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Anim_MouseUp);
            // 
            // Kuretar
            // 
            this.Kuretar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Kuretar.AutoSize = true;
            this.Kuretar.BackColor = System.Drawing.Color.Transparent;
            this.Kuretar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kuretar.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kuretar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Kuretar.Location = new System.Drawing.Point(581, 345);
            this.Kuretar.Name = "Kuretar";
            this.Kuretar.Size = new System.Drawing.Size(198, 33);
            this.Kuretar.TabIndex = 33;
            this.Kuretar.Text = "Kuretar Finder";
            this.Kuretar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Kuretar_MouseClick);
            this.Kuretar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kuretar_MouseDown);
            this.Kuretar.MouseEnter += new System.EventHandler(this.Kuretar_MouseEnter);
            this.Kuretar.MouseLeave += new System.EventHandler(this.Kuretar_MouseLeave);
            this.Kuretar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Kuretar_MouseUp);
            // 
            // Item
            // 
            this.Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Item.AutoSize = true;
            this.Item.BackColor = System.Drawing.Color.Transparent;
            this.Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Item.Location = new System.Drawing.Point(581, 411);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(248, 33);
            this.Item.TabIndex = 34;
            this.Item.Text = "Liste Items Forgés";
            this.Item.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Item_MouseClick);
            this.Item.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Item_MouseDown);
            this.Item.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Item.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.Item.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Item_MouseUp);
            // 
            // Join
            // 
            this.Join.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Join.AutoSize = true;
            this.Join.BackColor = System.Drawing.Color.Transparent;
            this.Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Join.Location = new System.Drawing.Point(319, 213);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(237, 33);
            this.Join.TabIndex = 36;
            this.Join.Text = "Rejoindre Kuretar";
            this.Join.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Join_MouseClick);
            this.Join.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Join_MouseDown);
            this.Join.MouseEnter += new System.EventHandler(this.Join_MouseEnter);
            this.Join.MouseLeave += new System.EventHandler(this.Join_MouseLeave);
            this.Join.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Join_MouseUp);
            // 
            // Patch
            // 
            this.Patch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Patch.AutoSize = true;
            this.Patch.BackColor = System.Drawing.Color.Transparent;
            this.Patch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patch.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Patch.Location = new System.Drawing.Point(319, 279);
            this.Patch.Name = "Patch";
            this.Patch.Size = new System.Drawing.Size(186, 33);
            this.Patch.TabIndex = 37;
            this.Patch.Text = "Patch Officiel";
            this.Patch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Patch_MouseClick);
            this.Patch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Patch_MouseDown);
            this.Patch.MouseEnter += new System.EventHandler(this.Patch_MouseEnter);
            this.Patch.MouseLeave += new System.EventHandler(this.Patch_MouseLeave);
            this.Patch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Patch_MouseUp);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Lato", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(74, 147);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(151, 21);
            this.Start.TabIndex = 38;
            this.Start.Text = "Bien Commencer";
            // 
            // Util2
            // 
            this.Util2.AutoSize = true;
            this.Util2.BackColor = System.Drawing.Color.Transparent;
            this.Util2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Util2.Font = new System.Drawing.Font("Lato", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Util2.ForeColor = System.Drawing.Color.White;
            this.Util2.Location = new System.Drawing.Point(642, 147);
            this.Util2.Name = "Util2";
            this.Util2.Size = new System.Drawing.Size(83, 21);
            this.Util2.TabIndex = 39;
            this.Util2.Text = "Utilitaire";
            // 
            // Rejoin
            // 
            this.Rejoin.AutoSize = true;
            this.Rejoin.BackColor = System.Drawing.Color.Transparent;
            this.Rejoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rejoin.Font = new System.Drawing.Font("Lato", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejoin.ForeColor = System.Drawing.Color.White;
            this.Rejoin.Location = new System.Drawing.Point(385, 147);
            this.Rejoin.Name = "Rejoin";
            this.Rejoin.Size = new System.Drawing.Size(90, 21);
            this.Rejoin.TabIndex = 40;
            this.Rejoin.Text = "Rejoindre";
            // 
            // Links
            // 
            this.Links.AutoSize = true;
            this.Links.BackColor = System.Drawing.Color.Transparent;
            this.Links.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Links.Font = new System.Drawing.Font("Lemon/Milk", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Links.ForeColor = System.Drawing.Color.White;
            this.Links.Location = new System.Drawing.Point(323, 78);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(182, 35);
            this.Links.TabIndex = 41;
            this.Links.Text = "Liens Utiles";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Lato Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.Close.Location = new System.Drawing.Point(835, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 42;
            this.Close.Text = "X";
            this.Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MouseClick);
            this.Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Close_MouseDown);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Close_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Lato Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.Minimize.Location = new System.Drawing.Point(806, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(19, 23);
            this.Minimize.TabIndex = 43;
            this.Minimize.Text = "_";
            this.Minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseClick);
            this.Minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseDown);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseUp);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Lato Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(13, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(116, 23);
            this.title.TabIndex = 44;
            this.title.Text = "Kuretar.NET";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::KuretarFixManager.Properties.Resources.logoPlaceholder;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(319, 279);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(195, 195);
            this.Logo.TabIndex = 45;
            this.Logo.TabStop = false;
            // 
            // Dons
            // 
            this.Dons.AutoSize = true;
            this.Dons.BackColor = System.Drawing.Color.Transparent;
            this.Dons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dons.Font = new System.Drawing.Font("Lato Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.Dons.Location = new System.Drawing.Point(804, 551);
            this.Dons.Name = "Dons";
            this.Dons.Size = new System.Drawing.Size(54, 23);
            this.Dons.TabIndex = 46;
            this.Dons.Text = "Dons";
            this.Dons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dons_MouseClick);
            this.Dons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dons_MouseDown);
            this.Dons.MouseEnter += new System.EventHandler(this.Dons_MouseEnter);
            this.Dons.MouseLeave += new System.EventHandler(this.Dons_MouseLeave);
            this.Dons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dons_MouseUp);
            // 
            // Voter
            // 
            this.Voter.AutoSize = true;
            this.Voter.BackColor = System.Drawing.Color.Transparent;
            this.Voter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voter.Font = new System.Drawing.Font("Lato Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.Voter.Location = new System.Drawing.Point(742, 551);
            this.Voter.Name = "Voter";
            this.Voter.Size = new System.Drawing.Size(56, 23);
            this.Voter.TabIndex = 47;
            this.Voter.Text = "Voter";
            this.Voter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Voter_MouseClick);
            this.Voter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Voter_MouseDown);
            this.Voter.MouseEnter += new System.EventHandler(this.Voter_MouseEnter);
            this.Voter.MouseLeave += new System.EventHandler(this.Voter_MouseLeave);
            this.Voter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Voter_MouseUp);
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.BackColor = System.Drawing.Color.Transparent;
            this.Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign.Font = new System.Drawing.Font("Lato Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.Sign.Location = new System.Drawing.Point(650, 551);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(86, 23);
            this.Sign.TabIndex = 48;
            this.Sign.Text = "S\'inscrire";
            this.Sign.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sign_MouseClick);
            this.Sign.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sign_MouseDown);
            this.Sign.MouseEnter += new System.EventHandler(this.Sign_MouseEnter);
            this.Sign.MouseLeave += new System.EventHandler(this.Sign_MouseLeave);
            this.Sign.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sign_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(861, 574);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Voter);
            this.Controls.Add(this.Dons);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Links);
            this.Controls.Add(this.Rejoin);
            this.Controls.Add(this.Util2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Patch);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Kuretar);
            this.Controls.Add(this.Anim);
            this.Controls.Add(this.Forge);
            this.Controls.Add(this.Addons);
            this.Controls.Add(this.Cosme);
            this.Controls.Add(this.Sorts);
            this.Controls.Add(this.Util);
            this.Controls.Add(this.Divers);
            this.Controls.Add(this.CAS);
            this.Controls.Add(this.cache);
            this.Controls.Add(this.HELPER);
            this.Controls.Add(this.FIX);
            this.Controls.Add(this.fixPart);
            this.Controls.Add(this.FixDroits);
            this.Controls.Add(this.MoveFolder);
            this.Controls.Add(this.Solution2);
            this.Controls.Add(this.Solution1);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.FixConnexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecupMacro);
            this.Controls.Add(this.RecupTRP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepairWoW);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuretar Fix Manager";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button RepairWoW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecupTRP;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button RecupMacro;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button FixConnexion;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelDownloaded;
        private System.Windows.Forms.Button Solution1;
        private System.Windows.Forms.Button Solution2;
        private System.Windows.Forms.Button MoveFolder;
        private System.Windows.Forms.Button FixDroits;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
        private System.Windows.Forms.Label fixPart;
        private System.Windows.Forms.Label FIX;
        private System.Windows.Forms.Label HELPER;
        private System.Windows.Forms.Button cache;
        private System.Windows.Forms.Label CAS;
        private System.Windows.Forms.Label Divers;
        private System.Windows.Forms.Label Util;
        private Label Sorts;
        private Label Cosme;
        private Label Addons;
        private Label Forge;
        private Label Anim;
        private Label Kuretar;
        private Label Item;
        private Label Join;
        private Label Patch;
        private Label Start;
        private Label Util2;
        private Label Rejoin;
        private Label Links;
        private new Label Close;
        private Label Minimize;
        private Label title;
        private PictureBox Logo;
        private Label Dons;
        private Label Voter;
        private Label Sign;
    }
}

