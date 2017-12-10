using KuretarFixManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFixKuretar
{
    public partial class Form1 : Form
    {

        private int[] integerValues = new int[200];
        private string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static string passingText;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        WebClient webClient;               // Our WebClient that will be doing the downloading for us
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            FIX.Left = ((this.ClientSize.Width - textBox1.Width) / 2) - 10;
            RepairWoW.Left = (this.ClientSize.Width - RepairWoW.Width) / 2;
            textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            RecupTRP.Left = (this.ClientSize.Width + textBox1.Width - (2 * RecupTRP.Width)) / 2;
            RecupMacro.Left = (this.ClientSize.Width + textBox1.Width - (2 * RecupMacro.Width)) / 2;
            FixConnexion.Left = (this.ClientSize.Width - FixConnexion.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label3.Left = (this.ClientSize.Width - label3.Width) / 2;
            Open.Left = (this.ClientSize.Width - Open.Width) / 2;
            Solution1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            Solution2.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            progressBar.Left = (this.ClientSize.Width - progressBar.Width) / 2;
            labelPerc.Left = ((this.ClientSize.Width + progressBar.Width - (2 * labelPerc.Width)) / 2);
            labelSpeed.Left = ((this.ClientSize.Width + progressBar.Width - (2 * labelSpeed.Width)) / 2) - 75;
            labelDownloaded.Left = (this.ClientSize.Width - progressBar.Width) / 2;
            MoveFolder.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            FixDroits.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            fixPart.Left = (this.ClientSize.Width - fixPart.Width) / 2;
            cache.Left = (this.ClientSize.Width - cache.Width) / 2;
            HELPER.Left = ((this.ClientSize.Width + textBox1.Width - (2 * HELPER.Width)) / 2) + 10;
            CAS.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            Util.Left = ((this.ClientSize.Width + textBox1.Width - (2 * RecupMacro.Width)) / 2) + 10;
            Divers.Left = (this.ClientSize.Width - Divers.Width) / 2;
            Sorts.Left = ((this.ClientSize.Width - textBox1.Width) / 2) - 115;
            Cosme.Left = ((this.ClientSize.Width - textBox1.Width) / 2) - 115;
            Addons.Left = ((this.ClientSize.Width - textBox1.Width) / 2) - 115;
            Join.Left = (this.ClientSize.Width - Join.Width) / 2;
            Patch.Left = (this.ClientSize.Width - Patch.Width) / 2;
            Forge.Left = ((this.ClientSize.Width + textBox1.Width) / 2) - 100;
            Anim.Left = ((this.ClientSize.Width + textBox1.Width) / 2) - 100;
            Kuretar.Left = ((this.ClientSize.Width + textBox1.Width) / 2) - 100;
            Item.Left = ((this.ClientSize.Width + textBox1.Width) / 2) - 100;
            Start.Left = ((this.ClientSize.Width - textBox1.Width) / 2) - 105;
            Rejoin.Left = (this.ClientSize.Width - Rejoin.Width) / 2;
            Util2.Left = ((this.ClientSize.Width + textBox1.Width) / 2) - 40;
            Links.Left = (this.ClientSize.Width - Links.Width) / 2;
            Close.Left = (this.ClientSize.Width - Close.Width);
            Minimize.Left = (this.ClientSize.Width - Minimize.Width - Close.Width);
            title.Left = (this.ClientSize.Width - title.Width) / 60;
            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            Dons.Left = (this.ClientSize.Width - Dons.Width);
            Voter.Left = (this.ClientSize.Width - Dons.Width - Voter.Width);
            Sign.Left = (this.ClientSize.Width - Dons.Width - Voter.Width - Sign.Width);
            Start.Enabled = false;
            Start.Visible = false;
            Rejoin.Enabled = false;
            Rejoin.Visible = false;
            Util2.Enabled = false;
            Util2.Visible = false;
            Links.Enabled = false;
            Links.Visible = false;
            CAS.Enabled = false;
            CAS.Visible = false;
            Util.Enabled = false;
            Util.Visible = false;
            Divers.Enabled = false;
            Divers.Visible = false;
            HELPER.Enabled = false;
            HELPER.Visible = false;
            cache.Enabled = false;
            cache.Visible = false;
            fixPart.Enabled = false;
            fixPart.Visible = false;
            RepairWoW.Enabled = false;
            RepairWoW.Visible = false;
            textBox1.Enabled = false;
            FIX.Enabled = false;
            FIX.Visible = false;
            RecupTRP.Enabled = false;
            RecupTRP.Visible = false;
            RecupMacro.Enabled = false;
            RecupMacro.Visible = false;
            FixConnexion.Enabled = false;
            FixConnexion.Visible = false;
            labelPerc.Enabled = false;
            labelPerc.Visible = false;
            labelSpeed.Enabled = false;
            labelSpeed.Visible = false;
            labelDownloaded.Enabled = false;
            labelDownloaded.Visible = false;
            Solution1.Enabled = false;
            Solution1.Visible = false;
            Solution2.Enabled = false;
            Solution2.Visible = false;
            FixDroits.Enabled = false;
            FixDroits.Visible = false;
            MoveFolder.Enabled = false;
            MoveFolder.Visible = false;
            progressBar.Enabled = false;
            progressBar.Visible = false;
            Cosme.Enabled = false;
            Cosme.Visible = false;
            Sorts.Enabled = false;
            Sorts.Visible = false;
            Addons.Enabled = false;
            Addons.Visible = false;
            Join.Enabled = false;
            Join.Visible = false;
            Patch.Enabled = false;
            Patch.Visible = false;
            Forge.Enabled = false;
            Forge.Visible = false;
            Anim.Enabled = false;
            Anim.Visible = false;
            Kuretar.Enabled = false;
            Kuretar.Visible = false;
            Item.Enabled = false;
            Item.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Open_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Sélectionner votre dossier Kuretar et cliquer sur OK sur l'explorateur qui va s'ouvrir après la fermeture de cette fenêtre", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            folderBrowserDialog1.Description = "Sélectionner votre dossier Kuretar\n";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowserDialog1.SelectedPath + @"\Kuretar64.exe") || File.Exists(folderBrowserDialog1.SelectedPath + @"\Kuretar32.exe"))
                {
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                    FIX.Enabled = true;
                    FIX.Visible = true;
                    HELPER.Enabled = true;
                    HELPER.Visible = true;
                    MessageBox.Show("Dossier sélectionné, vous pouvez à présent naviguer avec les boutons FIX et HELPER", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Kuretar64.exe | Kuretar32.exe non trouvé"
                        + " Mauvais dossier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Open_MouseEnter(object sender, EventArgs e)
        {
            Open.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void Open_MouseLeave(object sender, EventArgs e)
        {
            Open.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void Open_MouseDown(object sender, MouseEventArgs e)
        {
            Open.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            Open.Location = new Point(Open.Location.X + 1, Open.Location.Y + 1);
        }

        private void Open_MouseUp(object sender, MouseEventArgs e)
        {
            Open.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            Open.Location = new Point(Open.Location.X - 1, Open.Location.Y - 1);
        }

        private int MaxInArray(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i]) max = numbers[i];
            }
            return max;
        }

        private void RepairWoW_MouseClick(object sender, MouseEventArgs e)
        {

            string pathRepair = folderBrowserDialog1.SelectedPath + @"\Data\data";

            var files = Directory.GetFiles(pathRepair).Select(Path.GetFileName);

            try
            {
                FileStream fs = File.Create(pathRepair + @"\temp.dat", 2048, FileOptions.None);
                BinaryWriter bw = new BinaryWriter(fs);
                ASCIIEncoding asen = new ASCIIEncoding();
                foreach (var file in files)
                {
                    byte[] ba = asen.GetBytes(file.ToString() + "\n");
                    bw.Write(ba);
                }

                bw.Close();
                fs.Close();
            }
#pragma warning disable CS0168 // La variable est déclarée mais jamais utilisée
            catch (Exception en)
#pragma warning restore CS0168 // La variable est déclarée mais jamais utilisée
            {

            }

            var data = File.ReadAllLines(pathRepair + @"\temp.dat").Select(s => s.Split('.')).ToArray();

            for (int i = 0; i < data.Length; i++)
            {

                if ((data[i][0]).StartsWith("data"))
                {

                    string value = data[i][1].ToString();
                    int indice = Int32.Parse(value);
                    for (int j = 0; j < integerValues.Length; j++)
                    {
                        integerValues[j] = indice;
                    }

                }

            }

            File.Delete(pathRepair + @"\data." + MaxInArray(integerValues).ToString("000"));
            if (File.Exists(pathRepair + @"\Cascrepair.mrk"))
            {
                File.Delete(pathRepair + @"\Cascrepair.mrk");
                MessageBox.Show("Installation réparée, vous pouvez relancer le jeu, il re-téléchargera quelques données", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                RepairWoW.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                RepairWoW.Enabled = false;
            }
            else
            {
                MessageBox.Show("Fichier inexistant en : " + pathRepair, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (RepairWoW.Enabled == false)
            {
                File.Delete(pathRepair + @"\temp.dat");
            }

        }

        private void RepairWoW_MouseEnter(object sender, EventArgs e)
        {
            RepairWoW.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void RepairWoW_MouseLeave(object sender, EventArgs e)
        {
            RepairWoW.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void RepairWoW_MouseDown(object sender, MouseEventArgs e)
        {
            RepairWoW.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            RepairWoW.Location = new Point(RepairWoW.Location.X + 1, RepairWoW.Location.Y + 1);
        }

        private void RepairWoW_MouseUp(object sender, MouseEventArgs e)
        {
            RepairWoW.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            RepairWoW.Location = new Point(RepairWoW.Location.X - 1, RepairWoW.Location.Y - 1);
        }

        private void RecupTRP_MouseClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Allez dans le dossier WTF/Account/votreCompte/SavedVariables\n" +
                "Pour trouver votre Compte Kuretar, il doit y avoir un dossier \"Legion\"\n"
                + "dedans et dans ce même dossier plusieurs dossiers avec le nom de vos personnages sur Kuretar\n"
                + "Votre dossier de compte porte un nom du genre \"XXXX#X\"\n", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            folderBrowserDialog2.Reset();
            folderBrowserDialog2.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog2.Description = "Sélectionner le dossier WTF/Account/votreCompte/SavedVariables";
            folderBrowserDialog2.SelectedPath = textBox1.Text;

            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {

                if (folderBrowserDialog2.SelectedPath.Contains("SavedVariables"))
                {

                    if (File.Exists(folderBrowserDialog2.SelectedPath + @"\totalRP3.lua"))
                    {
                        File.Delete(folderBrowserDialog2.SelectedPath + @"\totalRP3.lua");
                        File.Copy(folderBrowserDialog2.SelectedPath + @"\totalRP3.lua.bak", folderBrowserDialog2.SelectedPath + @"\totalRP3.lua");
                        File.Delete(desktopPath + @"\totalRP3.lua");
                        File.Copy(folderBrowserDialog2.SelectedPath + @"\totalRP3.lua.bak", desktopPath + @"\totalRP3.lua");
                        MessageBox.Show("Fiches TRP Récupérées et backup fait sur votre Bureau !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecupTRP.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                        RecupTRP.Enabled = false;
                    }
                    else
                    {
                        if ((File.Exists(folderBrowserDialog2.SelectedPath + @"\totalRP3.lua.bak")) == false)
                        {
                            MessageBox.Show("Veuillez sélectionner le SavedVariables de votre dossier de Compte\n WTF/Account/votreCompte/SavedVariables", "Mauvais Dossier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.Copy(folderBrowserDialog2.SelectedPath + @"\totalRP3.lua.bak", folderBrowserDialog2.SelectedPath + @"\totalRP3.lua");
                            if (File.Exists(desktopPath + @"\totalRP3.lua"))
                                File.Delete(desktopPath + @"\totalRP3.lua");
                            File.Copy(folderBrowserDialog2.SelectedPath + @"\totalRP3.lua.bak", desktopPath + @"\totalRP3.lua");
                            MessageBox.Show("Fiches TRP Récupérées et backup fait sur votre Bureau !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecupTRP.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                            RecupTRP.Enabled = false;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner le SavedVariables de votre dossier de Compte\n WTF/Account/votreCompte/SavedVariables", "Mauvais Dossier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void RecupTRP_MouseEnter(object sender, EventArgs e)
        {
            RecupTRP.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void RecupTRP_MouseLeave(object sender, EventArgs e)
        {
            RecupTRP.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void RecupTRP_MouseDown(object sender, MouseEventArgs e)
        {
            RecupTRP.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            RecupTRP.Location = new Point(RecupTRP.Location.X + 1, RecupTRP.Location.Y + 1);
        }

        private void RecupTRP_MouseUp(object sender, MouseEventArgs e)
        {
            RecupTRP.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            RecupTRP.Location = new Point(RecupTRP.Location.X - 1, RecupTRP.Location.Y - 1);
        }

        private void RecupMacro_MouseClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Allez dans le dossier WTF/Account/votreCompte/Legion\n" +
                "Pour trouver votre Compte Kuretar, il doit y avoir un dossier \"Legion\"\n"
                + "dedans et dans ce même dossier plusieurs dossiers avec le nom de vos personnages sur Kuretar\n"
                + "Votre dossier de compte porte un nom du genre \"XXXX#X\"\n", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            folderBrowserDialog3.Reset();
            folderBrowserDialog3.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog3.Description = "Sélectionner le dossier WTF/Account/votreCompte/Legion";
            folderBrowserDialog3.SelectedPath = textBox1.Text;

            if (folderBrowserDialog3.ShowDialog() == DialogResult.OK)
            {

                if (folderBrowserDialog3.SelectedPath.Contains("Legion"))
                {

                    var files = Directory.GetDirectories(folderBrowserDialog3.SelectedPath);

                    foreach (var dir in files)
                    {
                        if (File.Exists(dir + @"\macros-cache.old"))
                        {
                            File.Delete(dir + @"\macros-cache.txt");
                            File.Copy(dir + @"\macros-cache.old", dir + @"\macros-cache.txt");

                        }
                    }
                    MessageBox.Show("Macros récupérées !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecupMacro.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                    RecupMacro.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner le Legion de votre dossier de Compte\n WTF/Account/votreCompte/Legion", "Mauvais Dossier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void RecupMacro_MouseEnter(object sender, EventArgs e)
        {
            RecupMacro.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void RecupMacro_MouseLeave(object sender, EventArgs e)
        {
            RecupMacro.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void RecupMacro_MouseDown(object sender, MouseEventArgs e)
        {
            RecupMacro.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            RecupMacro.Location = new Point(RecupMacro.Location.X + 1, RecupMacro.Location.Y + 1);
        }

        private void RecupMacro_MouseUp(object sender, MouseEventArgs e)
        {
            RecupMacro.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            RecupMacro.Location = new Point(RecupMacro.Location.X - 1, RecupMacro.Location.Y - 1);
        }

        private void FixConnexion_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(textBox1.Text + @"\WTF\config.wtf"))
            {
                try
                {
                    FileStream fs = new FileStream(textBox1.Text + @"\WTF\config.wtf", FileMode.Append, FileAccess.Write, FileShare.None);
                    BinaryWriter bw = new BinaryWriter(fs);
                    ASCIIEncoding asen = new ASCIIEncoding();

                    byte[] ba = asen.GetBytes("\nSET M2UseLOD \"0\"");
                    bw.Write(ba);
                    bw.Close();
                    fs.Close();
                    MessageBox.Show("Fix déformation des modèles appliqué avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
#pragma warning disable CS0168 // La variable est déclarée mais jamais utilisée
                catch (Exception en)
#pragma warning restore CS0168 // La variable est déclarée mais jamais utilisée
                {

                }
            }
            else
            {
                MessageBox.Show("Le fichier n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var lines = File.ReadAllLines(textBox1.Text + @"\WTF\config.wtf");
            lines[0] = "SET PORTAL \"kuretar-serveur.fr\"";
            File.WriteAllLines(textBox1.Text + @"\WTF\config.wtf", lines);
            MessageBox.Show("Fix de connexion aux services de Kuretar effectué !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            FixConnexion.Enabled = false;

        }

        private void FixConnexion_MouseEnter(object sender, EventArgs e)
        {
            FixConnexion.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void FixConnexion_MouseLeave(object sender, EventArgs e)
        {
            FixConnexion.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void FixConnexion_MouseDown(object sender, MouseEventArgs e)
        {
            FixConnexion.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            FixConnexion.Location = new Point(FixConnexion.Location.X + 1, FixConnexion.Location.Y + 1);
        }

        private void FixConnexion_MouseUp(object sender, MouseEventArgs e)
        {
            FixConnexion.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            FixConnexion.Location = new Point(FixConnexion.Location.X - 1, FixConnexion.Location.Y - 1);
        }

        private void FIX_MouseDoucleClick(object sender, MouseEventArgs e)
        {
            if (Solution1.Visible == false)
            {
                cache.Enabled = true;
                cache.Visible = true;
                fixPart.Enabled = true;
                fixPart.Visible = true;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = true;
                Solution1.Visible = true;
                Solution2.Enabled = true;
                Solution2.Visible = true;
                FixDroits.Enabled = true;
                FixDroits.Visible = true;
                MoveFolder.Enabled = true;
                MoveFolder.Visible = true;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = false;
                Open.Visible = false;
                label1.Visible = false;
                RecupTRP.Enabled = true;
                RecupTRP.Visible = true;
                RecupMacro.Enabled = true;
                RecupMacro.Visible = true;
                FixConnexion.Enabled = true;
                FixConnexion.Visible = true;
                CAS.Enabled = true;
                CAS.Visible = true;
                Divers.Enabled = true;
                Divers.Visible = true;
                Util.Enabled = true;
                Util.Visible = true;
                Start.Enabled = false;
                Start.Visible = false;
                Rejoin.Enabled = false;
                Rejoin.Visible = false;
                Util2.Enabled = false;
                Util2.Visible = false;
                Links.Enabled = false;
                Links.Visible = false;
                Logo.Enabled = false;
                Logo.Visible = false;
                if (File.Exists(folderBrowserDialog1.SelectedPath + @"\Data\data\Cascrepair.mrk"))
                {
                    RepairWoW.Enabled = true;
                    RepairWoW.Visible = true;
                }
                else
                {
                    RepairWoW.Enabled = false;
                    RepairWoW.Visible = true;
                }
            }
            else
            {
                Logo.Enabled = true;
                Logo.Visible = true;
                CAS.Enabled = false;
                CAS.Visible = false;
                Divers.Enabled = false;
                Divers.Visible = false;
                Util.Enabled = false;
                Util.Visible = false;
                cache.Enabled = false;
                cache.Visible = false;
                fixPart.Enabled = false;
                fixPart.Visible = false;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = false;
                Solution1.Visible = false;
                Solution2.Enabled = false;
                Solution2.Visible = false;
                FixDroits.Enabled = false;
                FixDroits.Visible = false;
                MoveFolder.Enabled = false;
                MoveFolder.Visible = false;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = true;
                Open.Enabled = true;
                Open.Visible = true;
                label1.Visible = true;
                RecupTRP.Enabled = false;
                RecupTRP.Visible = false;
                RecupMacro.Enabled = false;
                RecupMacro.Visible = false;
                FixConnexion.Enabled = false;
                FixConnexion.Visible = false;
                Start.Enabled = false;
                Start.Visible = false;
                Rejoin.Enabled = false;
                Rejoin.Visible = false;
                Util2.Enabled = false;
                Util2.Visible = false;
                Links.Enabled = false;
                Links.Visible = false;
            }
        }

        private void FIX_MouseClick(object sender, MouseEventArgs e)
        {
            if (Solution1.Visible == false)
            {
                cache.Enabled = true;
                cache.Visible = true;
                fixPart.Enabled = true;
                fixPart.Visible = true;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = true;
                Solution1.Visible = true;
                Solution2.Enabled = true;
                Solution2.Visible = true;
                FixDroits.Enabled = true;
                FixDroits.Visible = true;
                MoveFolder.Enabled = true;
                MoveFolder.Visible = true;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = false;
                Open.Visible = false;
                label1.Visible = false;
                RecupTRP.Enabled = true;
                RecupTRP.Visible = true;
                RecupMacro.Enabled = true;
                RecupMacro.Visible = true;
                FixConnexion.Enabled = true;
                FixConnexion.Visible = true;
                CAS.Enabled = true;
                CAS.Visible = true;
                Divers.Enabled = true;
                Divers.Visible = true;
                Util.Enabled = true;
                Util.Visible = true;
                Cosme.Enabled = false;
                Cosme.Visible = false;
                Sorts.Enabled = false;
                Sorts.Visible = false;
                Addons.Enabled = false;
                Addons.Visible = false;
                Join.Enabled = false;
                Join.Visible = false;
                Patch.Enabled = false;
                Patch.Visible = false;
                Forge.Enabled = false;
                Forge.Visible = false;
                Anim.Enabled = false;
                Anim.Visible = false;
                Kuretar.Enabled = false;
                Kuretar.Visible = false;
                Item.Enabled = false;
                Item.Visible = false;
                Start.Enabled = false;
                Start.Visible = false;
                Rejoin.Enabled = false;
                Rejoin.Visible = false;
                Util2.Enabled = false;
                Util2.Visible = false;
                Links.Enabled = false;
                Links.Visible = false;
                Logo.Enabled = false;
                Logo.Visible = false;
                if (File.Exists(folderBrowserDialog1.SelectedPath + @"\Data\data\Cascrepair.mrk"))
                {
                    RepairWoW.Enabled = true;
                    RepairWoW.Visible = true;
                }
                else
                {
                    RepairWoW.Enabled = false;
                    RepairWoW.Visible = true;
                }
            }
            else
            {
                Logo.Enabled = true;
                Logo.Visible = true;
                CAS.Enabled = false;
                CAS.Visible = false;
                Divers.Enabled = false;
                Divers.Visible = false;
                Util.Enabled = false;
                Util.Visible = false;
                cache.Enabled = false;
                cache.Visible = false;
                fixPart.Enabled = false;
                fixPart.Visible = false;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = false;
                Solution1.Visible = false;
                Solution2.Enabled = false;
                Solution2.Visible = false;
                FixDroits.Enabled = false;
                FixDroits.Visible = false;
                MoveFolder.Enabled = false;
                MoveFolder.Visible = false;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = true;
                Open.Enabled = true;
                Open.Visible = true;
                label1.Visible = true;
                RecupTRP.Enabled = false;
                RecupTRP.Visible = false;
                RecupMacro.Enabled = false;
                RecupMacro.Visible = false;
                FixConnexion.Enabled = false;
                FixConnexion.Visible = false;
                Cosme.Enabled = false;
                Cosme.Visible = false;
                Sorts.Enabled = false;
                Sorts.Visible = false;
                Addons.Enabled = false;
                Addons.Visible = false;
                Join.Enabled = false;
                Join.Visible = false;
                Patch.Enabled = false;
                Patch.Visible = false;
                Forge.Enabled = false;
                Forge.Visible = false;
                Anim.Enabled = false;
                Anim.Visible = false;
                Kuretar.Enabled = false;
                Kuretar.Visible = false;
                Item.Enabled = false;
                Item.Visible = false;
                Start.Enabled = false;
                Start.Visible = false;
                Rejoin.Enabled = false;
                Rejoin.Visible = false;
                Util2.Enabled = false;
                Util2.Visible = false;
                Links.Enabled = false;
                Links.Visible = false;
            }
        }

        private void FIX_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 255; i > 188; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                FIX.ForeColor = Color.FromArgb(i, i, i);
                FIX.Update();
                FIX.Show();
            }
        }

        private void FIX_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 188; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                FIX.ForeColor = Color.FromArgb(i, i, i);
                FIX.Update();
                FIX.Show();
            }
        }

        private void FIX_MouseDown(object sender, MouseEventArgs e)
        {
            FIX.ForeColor = Color.FromArgb(188, 188, 188);
            FIX.Location = new Point(FIX.Location.X + 1, FIX.Location.Y + 1);
        }

        private void FIX_MouseUp(object sender, MouseEventArgs e)
        {
            FIX_MouseEnter(sender, e);
            FIX.Location = new Point(FIX.Location.X - 1, FIX.Location.Y - 1);
        }

        //FIX VISIBLE

        public void DownloadFile(string urlAddress, string location)
        {
            progressBar.ForeColor = Color.FromArgb(255, 209, 51);
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {

            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                MessageBox.Show("Download completed!");
                labelPerc.ResetText();
                labelSpeed.ResetText();
                labelDownloaded.ResetText();
                progressBar.Value = 0;
                progressBar.Refresh();
                progressBar.ResetText();
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                progressBar.Enabled = false;
                progressBar.Visible = false;

                if (File.Exists(textBox1.Text + @"\Data" + @"\config.rar"))
                {
                    string SourceFile = textBox1.Text + @"\Data" + @"\config.rar";
                    string DestinationPath = textBox1.Text + @"\Data";
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.EnableRaisingEvents = false;
                    process.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", SourceFile, DestinationPath);
                    process.Start();
                    MessageBox.Show("Extraction de config terminée");
                    MessageBox.Show("Essayer de démarrer votre jeu avec Kuretar64.exe ou 32.exe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    File.Delete(textBox1.Text + @"\Data" + @"\config.rar");
                }

                if (File.Exists(textBox1.Text + @"\Data" + @"\indices.rar"))
                {
                    string SourceFile = textBox1.Text + @"\Data" + @"\indices.rar";
                    string DestinationPath = textBox1.Text + @"\Data";
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.EnableRaisingEvents = false;
                    process.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", SourceFile, DestinationPath);
                    process.Start();
                    MessageBox.Show("Extraction de indices terminée");
                    MessageBox.Show("Essayer de démarrer votre jeu avec Kuretar64.exe ou 32.exe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    File.Delete(textBox1.Text + @"\Data" + @"\indices.rar");
                }

                if (File.Exists(textBox1.Text + @"\Interface" + @"\AddOnsTRPCrossfactionTrinityAdmin.rar"))
                {
                    string SourceFile = textBox1.Text + @"\Interface" + @"\AddOnsTRPCrossfactionTrinityAdmin.rar";
                    string DestinationPath = textBox1.Text + @"\Interface";
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.EnableRaisingEvents = false;
                    process.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", SourceFile, DestinationPath);
                    process.Start();
                    MessageBox.Show("Extraction des addOns terminée");
                    MessageBox.Show("Crossfaction, TRP3, TrinityAdmin installés !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    File.Delete(textBox1.Text + @"\Interface" + @"\AddOnsTRPCrossfactionTrinityAdmin.rar");
                }
            }
        }

        private void Solution1_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(textBox1.Text + @"\Data" + @"\config.rar"))
            {
                File.Delete(textBox1.Text + @"\Data" + @"\config.rar");
                DownloadFile("kuretar-serveur.fr/help/config.rar", textBox1.Text + @"\Data" + @"\config.rar");
                Solution1.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                Solution1.Enabled = false;
                labelPerc.Enabled = true;
                labelPerc.Visible = true;
                labelSpeed.Enabled = true;
                labelSpeed.Visible = true;
                labelDownloaded.Enabled = true;
                labelDownloaded.Visible = true;
                progressBar.Enabled = true;
                progressBar.Visible = true;
            }
            else
            {
                DownloadFile("kuretar-serveur.fr/help/config.rar", textBox1.Text + @"\Data" + @"\config.rar");
                Solution1.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                Solution1.Enabled = false;
                labelPerc.Enabled = true;
                labelPerc.Visible = true;
                labelSpeed.Enabled = true;
                labelSpeed.Visible = true;
                labelDownloaded.Enabled = true;
                labelDownloaded.Visible = true;
                progressBar.Enabled = true;
                progressBar.Visible = true;
            }
        }

        private void Solution1_MouseEnter(object sender, EventArgs e)
        {
            Solution1.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void Solution1_MouseDown(object sender, MouseEventArgs e)
        {
            Solution1.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            Solution1.Location = new Point(Solution1.Location.X + 1, Solution1.Location.Y + 1);
        }

        private void Solution1_MouseLeave(object sender, EventArgs e)
        {
            Solution1.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void Solution1_MouseUp(object sender, MouseEventArgs e)
        {
            Solution1.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            Solution1.Location = new Point(Solution1.Location.X - 1, Solution1.Location.Y - 1);
        }

        private void Solution2_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(textBox1.Text + @"\Data" + @"\indices.rar"))
            {
                File.Delete(textBox1.Text + @"\Data" + @"\indices.rar");
                DownloadFile("kuretar-serveur.fr/help/config.rar", textBox1.Text + @"\Data" + @"\indices.rar");
                Solution2.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                Solution2.Enabled = false;
                labelPerc.Enabled = true;
                labelPerc.Visible = true;
                labelSpeed.Enabled = true;
                labelSpeed.Visible = true;
                labelDownloaded.Enabled = true;
                labelDownloaded.Visible = true;
                progressBar.Enabled = true;
                progressBar.Visible = true;

            }
            else
            {
                DownloadFile("kuretar-serveur.fr/help/indices.rar", textBox1.Text + @"\Data" + @"\indices.rar");
                Solution2.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                Solution2.Enabled = false;
                labelPerc.Enabled = true;
                labelPerc.Visible = true;
                labelSpeed.Enabled = true;
                labelSpeed.Visible = true;
                labelDownloaded.Enabled = true;
                labelDownloaded.Visible = true;
                progressBar.Enabled = true;
                progressBar.Visible = true;
            }
        }

        private void Solution2_MouseEnter(object sender, EventArgs e)
        {
            Solution2.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void Solution2_MouseLeave(object sender, EventArgs e)
        {
            Solution2.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void Solution2_MouseDown(object sender, MouseEventArgs e)
        {
            Solution2.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            Solution2.Location = new Point(Solution2.Location.X + 1, Solution2.Location.Y + 1);
        }

        private void Solution2_MouseUp(object sender, MouseEventArgs e)
        {
            Solution2.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            Solution2.Location = new Point(Solution2.Location.X - 1, Solution2.Location.Y - 1);
        }

        private void FixDroits_MouseClick(object sender, MouseEventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                DirectoryInfo di = new DirectoryInfo(textBox1.Text);

                FileSystemAccessRule fsar = new FileSystemAccessRule(System.Security.Principal.WindowsIdentity.GetCurrent().Name, FileSystemRights.FullControl, AccessControlType.Allow);
                DirectorySecurity ds = null;

                ds = di.GetAccessControl();
                ds.AddAccessRule(fsar);
                di.SetAccessControl(ds);

                MessageBox.Show("Contrôle total appliqué sur le dossier Kuretar", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Le répertoire n'est pas le bon", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Directory.Exists(textBox1.Text + @"\Data"))
            {

                var files = Directory.GetDirectories(textBox1.Text + @"\Data");

                foreach (var dir in files)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);

                    FileSystemAccessRule fsar = new FileSystemAccessRule(System.Security.Principal.WindowsIdentity.GetCurrent().Name, FileSystemRights.FullControl, AccessControlType.Allow);
                    DirectorySecurity ds = null;

                    ds = di.GetAccessControl();
                    ds.AddAccessRule(fsar);
                    di.SetAccessControl(ds);
                }

                MessageBox.Show("Contrôle total appliqué sur les dossiers et sous-dossiers de \"Data\"", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Mauvais répertoire, ce n'est pas le dossier \"Data\"", "Mauvais Dossier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FixDroits.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            FixDroits.Enabled = false;
        }

        private void FixDroits_MouseEnter(object sender, EventArgs e)
        {
            FixDroits.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void FixDroits_MouseLeave(object sender, EventArgs e)
        {
            FixDroits.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void FixDroits_MouseDown(object sender, MouseEventArgs e)
        {
            FixDroits.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
            FixDroits.Location = new Point(FixDroits.Location.X + 1, FixDroits.Location.Y + 1);
        }

        private void FixDroits_MouseUp(object sender, MouseEventArgs e)
        {
            FixDroits.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            FixDroits.Location = new Point(FixDroits.Location.X - 1, FixDroits.Location.Y - 1);
        }

        private void MoveFolder_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Choisissez le répertoire où vous voulez déplacer votre dossier WoW", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            folderBrowserDialog4.Reset();
            folderBrowserDialog4.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog4.Description = "Sélectionner le répertoire de destination";
            string pathSource = textBox1.Text;

            if (folderBrowserDialog4.ShowDialog() == DialogResult.OK)
            {
                string getLastFolder = new DirectoryInfo(pathSource).Name;
                string destPath = folderBrowserDialog4.SelectedPath + @"\" + getLastFolder;
                try
                {
                    if (Directory.Exists(pathSource))
                    {
                        if (Directory.Exists(destPath) == false)
                        {
                            Directory.Move(pathSource, destPath);
                            MessageBox.Show("Déplacement terminé", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MoveFolder.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                            textBox1.Text = destPath;

                        }
                        else
                        {
                            Directory.Delete(destPath);
                            Directory.Move(pathSource, destPath);
                            MessageBox.Show("Déplacement terminé", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MoveFolder.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                            textBox1.Text = destPath;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dossier inexistant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (System.Exception)
                {

                }

            }
        }

        private void MoveFolder_MouseEnter(object sender, EventArgs e)
        {
            MoveFolder.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void MoveFolder_MouseLeave(object sender, EventArgs e)
        {
            MoveFolder.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void MoveFolder_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFolder.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
            MoveFolder.Location = new Point(MoveFolder.Location.X + 1, MoveFolder.Location.Y + 1);
        }

        private void MoveFolder_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFolder.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            MoveFolder.Location = new Point(MoveFolder.Location.X - 1, MoveFolder.Location.Y - 1);
        }

        private void cache_MouseClick(object sender, MouseEventArgs e)
        {

            if (Directory.Exists(textBox1.Text + @"\Cache"))
            {

                var files = Directory.GetDirectories(textBox1.Text + @"\Cache");

                foreach (var dir in files)
                {
                    if (Directory.Exists(dir))
                    {
                        Directory.Delete(dir, true);
                    }
                    else
                    {
                        MessageBox.Show("Le Dossier est vide", "Mauvais Dossier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Cache vidé, vos lags de connexions doivent être résolus", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cache.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelUp));
                cache.Enabled = false;

            }
            else
            {
                MessageBox.Show("Mauvais répertoire, ce n'est pas le dossier \"Cache\"", "Mauvais Dossier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cache_MouseEnter(object sender, EventArgs e)
        {
            cache.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
        }

        private void cache_MouseLeave(object sender, EventArgs e)
        {
            cache.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
        }

        private void cache_MouseDown(object sender, MouseEventArgs e)
        {
            cache.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModelOver));
            cache.Location = new Point(cache.Location.X + 1, cache.Location.Y + 1);
        }

        private void cache_MouseUp(object sender, MouseEventArgs e)
        {
            cache.BackgroundImage = ((System.Drawing.Image)(KuretarFixManager.Properties.Resources.buttonModel));
            cache.Location = new Point(cache.Location.X - 1, cache.Location.Y - 1);
        }

        private void HELPER_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 188; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                HELPER.ForeColor = Color.FromArgb(i, i, i);
                HELPER.Update();
                HELPER.Show();
            }
        }

        private void HELPER_MouseUp(object sender, MouseEventArgs e)
        {
            HELPER_MouseEnter(sender, e);
            HELPER.Location = new Point(HELPER.Location.X - 1, HELPER.Location.Y - 1);
        }

        private void HELPER_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 255; i > 188; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                HELPER.ForeColor = Color.FromArgb(i, i, i);
                HELPER.Update();
                HELPER.Show();
            }
        }

        private void HELPER_MouseDown(object sender, MouseEventArgs e)
        {
            HELPER.ForeColor = Color.FromArgb(188, 188, 188);
            HELPER.Location = new Point(HELPER.Location.X + 1, HELPER.Location.Y + 1);
        }

        private void HELPER_MouseDoucleClick(object sender, MouseEventArgs e)
        {
            if (Sorts.Visible == false)
            {
                cache.Enabled = false;
                cache.Visible = false;
                fixPart.Enabled = false;
                fixPart.Visible = false;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = false;
                Solution1.Visible = false;
                Solution2.Enabled = false;
                Solution2.Visible = false;
                FixDroits.Enabled = false;
                FixDroits.Visible = false;
                MoveFolder.Enabled = false;
                MoveFolder.Visible = false;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = false;
                Open.Visible = false;
                label1.Visible = false;
                RecupTRP.Enabled = false;
                RecupTRP.Visible = false;
                RecupMacro.Enabled = false;
                RecupMacro.Visible = false;
                FixConnexion.Enabled = false;
                FixConnexion.Visible = false;
                CAS.Enabled = false;
                CAS.Visible = false;
                Divers.Enabled = false;
                Divers.Visible = false;
                Util.Enabled = false;
                Util.Visible = false;
                Cosme.Enabled = true;
                Cosme.Visible = true;
                Sorts.Enabled = true;
                Sorts.Visible = true;
                Addons.Enabled = true;
                Addons.Visible = true;
                Join.Enabled = true;
                Join.Visible = true;
                Patch.Enabled = true;
                Patch.Visible = true;
                Forge.Enabled = true;
                Forge.Visible = true;
                Anim.Enabled = true;
                Anim.Visible = true;
                Kuretar.Enabled = true;
                Kuretar.Visible = true;
                Item.Enabled = true;
                Item.Visible = true;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                Start.Enabled = true;
                Start.Visible = true;
                Rejoin.Enabled = true;
                Rejoin.Visible = true;
                Util2.Enabled = true;
                Util2.Visible = true;
                Links.Enabled = true;
                Links.Visible = true;
                Logo.Enabled = false;
                Logo.Visible = false;
            }
            else
            {
                cache.Enabled = false;
                cache.Visible = false;
                fixPart.Enabled = false;
                fixPart.Visible = false;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = false;
                Solution1.Visible = false;
                Solution2.Enabled = false;
                Solution2.Visible = false;
                FixDroits.Enabled = false;
                FixDroits.Visible = false;
                MoveFolder.Enabled = false;
                MoveFolder.Visible = false;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = true;
                Open.Visible = true;
                label1.Visible = true;
                RecupTRP.Enabled = false;
                RecupTRP.Visible = false;
                RecupMacro.Enabled = false;
                RecupMacro.Visible = false;
                FixConnexion.Enabled = false;
                FixConnexion.Visible = false;
                CAS.Enabled = false;
                CAS.Visible = false;
                Divers.Enabled = false;
                Divers.Visible = false;
                Util.Enabled = false;
                Util.Visible = false;
                Cosme.Enabled = false;
                Cosme.Visible = false;
                Sorts.Enabled = false;
                Sorts.Visible = false;
                Addons.Enabled = false;
                Addons.Visible = false;
                Join.Enabled = false;
                Join.Visible = false;
                Patch.Enabled = false;
                Patch.Visible = false;
                Forge.Enabled = false;
                Forge.Visible = false;
                Anim.Enabled = false;
                Anim.Visible = false;
                Kuretar.Enabled = false;
                Kuretar.Visible = false;
                Item.Enabled = false;
                Item.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                Start.Enabled = false;
                Start.Visible = false;
                Rejoin.Enabled = false;
                Rejoin.Visible = false;
                Util2.Enabled = false;
                Util2.Visible = false;
                Links.Enabled = false;
                Links.Visible = false;
                Logo.Enabled = true;
                Logo.Visible = true;
            }
        }

        private void HELPER_MouseClick(object sender, MouseEventArgs e)
        {
            if(Sorts.Visible == false)
            {
                cache.Enabled = false;
                cache.Visible = false;
                fixPart.Enabled = false;
                fixPart.Visible = false;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = false;
                Solution1.Visible = false;
                Solution2.Enabled = false;
                Solution2.Visible = false;
                FixDroits.Enabled = false;
                FixDroits.Visible = false;
                MoveFolder.Enabled = false;
                MoveFolder.Visible = false;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = false;
                Open.Visible = false;
                label1.Visible = false;
                RecupTRP.Enabled = false;
                RecupTRP.Visible = false;
                RecupMacro.Enabled = false;
                RecupMacro.Visible = false;
                FixConnexion.Enabled = false;
                FixConnexion.Visible = false;
                CAS.Enabled = false;
                CAS.Visible = false;
                Divers.Enabled = false;
                Divers.Visible = false;
                Util.Enabled = false;
                Util.Visible = false;
                Cosme.Enabled = true;
                Cosme.Visible = true;
                Sorts.Enabled = true;
                Sorts.Visible = true;
                Addons.Enabled = true;
                Addons.Visible = true;
                Join.Enabled = true;
                Join.Visible = true;
                Patch.Enabled = true;
                Patch.Visible = true;
                Forge.Enabled = true;
                Forge.Visible = true;
                Anim.Enabled = true;
                Anim.Visible = true;
                Kuretar.Enabled = true;
                Kuretar.Visible = true;
                Item.Enabled = true;
                Item.Visible = true;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                Start.Enabled = true;
                Start.Visible = true;
                Rejoin.Enabled = true;
                Rejoin.Visible = true;
                Util2.Enabled = true;
                Util2.Visible = true;
                Links.Enabled = true;
                Links.Visible = true;
                Logo.Enabled = false;
                Logo.Visible = false;
            }
            else
            {
                cache.Enabled = false;
                cache.Visible = false;
                fixPart.Enabled = false;
                fixPart.Visible = false;
                labelPerc.Enabled = false;
                labelPerc.Visible = false;
                labelSpeed.Enabled = false;
                labelSpeed.Visible = false;
                labelDownloaded.Enabled = false;
                labelDownloaded.Visible = false;
                Solution1.Enabled = false;
                Solution1.Visible = false;
                Solution2.Enabled = false;
                Solution2.Visible = false;
                FixDroits.Enabled = false;
                FixDroits.Visible = false;
                MoveFolder.Enabled = false;
                MoveFolder.Visible = false;
                progressBar.Enabled = false;
                progressBar.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                textBox1.Visible = true;
                Open.Visible = true;
                label1.Visible = true;
                RecupTRP.Enabled = false;
                RecupTRP.Visible = false;
                RecupMacro.Enabled = false;
                RecupMacro.Visible = false;
                FixConnexion.Enabled = false;
                FixConnexion.Visible = false;
                CAS.Enabled = false;
                CAS.Visible = false;
                Divers.Enabled = false;
                Divers.Visible = false;
                Util.Enabled = false;
                Util.Visible = false;
                Cosme.Enabled = false;
                Cosme.Visible = false;
                Sorts.Enabled = false;
                Sorts.Visible = false;
                Addons.Enabled = false;
                Addons.Visible = false;
                Join.Enabled = false;
                Join.Visible = false;
                Patch.Enabled = false;
                Patch.Visible = false;
                Forge.Enabled = false;
                Forge.Visible = false;
                Anim.Enabled = false;
                Anim.Visible = false;
                Kuretar.Enabled = false;
                Kuretar.Visible = false;
                Item.Enabled = false;
                Item.Visible = false;
                RepairWoW.Enabled = false;
                RepairWoW.Visible = false;
                Start.Enabled = false;
                Start.Visible = false;
                Rejoin.Enabled = false;
                Rejoin.Visible = false;
                Util2.Enabled = false;
                Util2.Visible = false;
                Links.Enabled = false;
                Links.Visible = false;
                Logo.Enabled = true;
                Logo.Visible = true;
            }
        }

        //HELPER SHOW

        private void Sorts_MouseUp(object sender, MouseEventArgs e)
        {
            Sorts.ForeColor = Color.FromArgb(255, 255, 255);
            Sorts.Location = new Point(Sorts.Location.X - 1, Sorts.Location.Y - 1);
        }

        private void Sorts_MouseEnter(object sender, EventArgs e)
        {

            float m = Sorts.Font.Size;

                for (int j = (int)m; j < (int)m+4; j++)
                {

                    System.Threading.Thread.Sleep(15);
                    Sorts.Font = new Font("Lato", j, FontStyle.Bold);
                    Sorts.Location = new Point(Sorts.Location.X - 1, Sorts.Location.Y - (int)0.75);
                    Sorts.Refresh();
                    Sorts.Update();
                    Sorts.Show();
                }
                for(int i = 210; i < 255; i++)
                {
                    System.Threading.Thread.Sleep((int)0.5);
                    Sorts.ForeColor = Color.FromArgb(i, i, i);
                    Sorts.Refresh();
                    Sorts.Update();
                    Sorts.Show();
                }
 
        }

        private void Sorts_MouseLeave(object sender, EventArgs e)
        {
            float m = Sorts.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Sorts.Font = new Font("Lato", j, FontStyle.Bold);
                Sorts.Location = new Point(Sorts.Location.X + 1, Sorts.Location.Y + (int)0.75);
                Sorts.Refresh();
                Sorts.Update();
                Sorts.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Sorts.ForeColor = Color.FromArgb(i, i, i);
                Sorts.Refresh();
                Sorts.Update();
                Sorts.Show();
            }
        }

        private void Sorts_MouseDown(object sender, MouseEventArgs e)
        {
            Sorts.ForeColor = Color.FromArgb(210, 210, 210);
            Sorts.Location = new Point(Sorts.Location.X + 1, Sorts.Location.Y + 1);
        }

        private void Sorts_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/3424-cosm%C3%A9tiques-de-rp-l%C3%A9gion-liste-de-sorts-utiles-et-sympathiques/", "_blank");
                System.Threading.Thread.Sleep(150);
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/4300-de-la-magie-en-en-veux-tu-en-voil%C3%A0/", "_blank");
                System.Threading.Thread.Sleep(150);
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/2895-aura-liste-daura/", "_blank");
            }
            catch
            {

            }
        }


        private void Patch_MouseUp(object sender, MouseEventArgs e)
        {
            Patch.ForeColor = Color.FromArgb(255, 255, 255);
            Patch.Location = new Point(Patch.Location.X - 1, Patch.Location.Y - 1);
        }

        private void Patch_MouseLeave(object sender, EventArgs e)
        {
            float m = Patch.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Patch.Font = new Font("Lato", j, FontStyle.Bold);
                Patch.Location = new Point(Patch.Location.X + 1, Patch.Location.Y + (int)0.75);
                Patch.Refresh();
                Patch.Update();
                Patch.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Patch.ForeColor = Color.FromArgb(i, i, i);
                Patch.Refresh();
                Patch.Update();
                Patch.Show();
            }
        }

        private void Patch_MouseEnter(object sender, EventArgs e)
        {
            float m = Patch.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Patch.Font = new Font("Lato", j, FontStyle.Bold);
                Patch.Location = new Point(Patch.Location.X - 1, Patch.Location.Y - (int)0.75);
                Patch.Refresh();
                Patch.Update();
                Patch.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Patch.ForeColor = Color.FromArgb(i, i, i);
                Patch.Refresh();
                Patch.Update();
                Patch.Show();
            }
        }

        private void Patch_MouseDown(object sender, MouseEventArgs e)
        {
            Patch.ForeColor = Color.FromArgb(210, 210, 210);
            Patch.Location = new Point(Patch.Location.X + 1, Patch.Location.Y + 1);
        }

        private void Patch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/3379-important-patch-kuretar-officiel/", "_blank");
            }
            catch
            {

            }
        }

        private void Join_MouseUp(object sender, MouseEventArgs e)
        {
            Join.ForeColor = Color.FromArgb(255, 255, 255);
            Join.Location = new Point(Join.Location.X - 1, Join.Location.Y - 1);
        }

        private void Join_MouseLeave(object sender, EventArgs e)
        {
            float m = Join.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Join.Font = new Font("Lato", j, FontStyle.Bold);
                Join.Location = new Point(Join.Location.X + 1, Join.Location.Y + (int)0.75);
                Join.Refresh();
                Join.Update();
                Join.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Join.ForeColor = Color.FromArgb(i, i, i);
                Join.Refresh();
                Join.Update();
                Join.Show();
            }
        }

        private void Join_MouseEnter(object sender, EventArgs e)
        {
            float m = Join.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Join.Font = new Font("Lato", j, FontStyle.Bold);
                Join.Location = new Point(Join.Location.X - 1, Join.Location.Y - (int)0.75);
                Join.Refresh();
                Join.Update();
                Join.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Join.ForeColor = Color.FromArgb(i, i, i);
                Join.Refresh();
                Join.Update();
                Join.Show();
            }
        }

        private void Join_MouseDown(object sender, MouseEventArgs e)
        {
            Join.ForeColor = Color.FromArgb(210, 210, 210);
            Join.Location = new Point(Join.Location.X + 1, Join.Location.Y + 1);
        }

        private void Join_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/3957-72-nous-rejoindre/", "_blank");
            }
            catch
            {

            }
        }

        private void Item_MouseUp(object sender, MouseEventArgs e)
        {
            Item.ForeColor = Color.FromArgb(255, 255, 255);
            Item.Location = new Point(Item.Location.X - 1, Item.Location.Y - 1);
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            float m = Item.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Item.Font = new Font("Lato", j, FontStyle.Bold);
                Item.Location = new Point(Item.Location.X + 1, Item.Location.Y + (int)0.75);
                Item.Refresh();
                Item.Update();
                Item.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Item.ForeColor = Color.FromArgb(i, i, i);
                Item.Refresh();
                Item.Update();
                Item.Show();
            }
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            float m = Item.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Item.Font = new Font("Lato", j, FontStyle.Bold);
                Item.Location = new Point(Item.Location.X - 1, Item.Location.Y - (int)0.75);
                Item.Refresh();
                Item.Update();
                Item.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Item.ForeColor = Color.FromArgb(i, i, i);
                Item.Refresh();
                Item.Update();
                Item.Show();
            }
        }

        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            Item.ForeColor = Color.FromArgb(210, 210, 210);
            Item.Location = new Point(Item.Location.X + 1, Item.Location.Y + 1);
        }

        private void Item_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/item/listeforge.php", "_blank");
            }
            catch
            {

            }
        }

        private void Kuretar_MouseUp(object sender, MouseEventArgs e)
        {
            Kuretar.ForeColor = Color.FromArgb(255, 255, 255);
            Kuretar.Location = new Point(Kuretar.Location.X - 1, Kuretar.Location.Y - 1);
        }

        private void Kuretar_MouseLeave(object sender, EventArgs e)
        {
            float m = Kuretar.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Kuretar.Font = new Font("Lato", j, FontStyle.Bold);
                Kuretar.Location = new Point(Kuretar.Location.X + 1, Kuretar.Location.Y + (int)0.75);
                Kuretar.Refresh();
                Kuretar.Update();
                Kuretar.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Kuretar.ForeColor = Color.FromArgb(i, i, i);
                Kuretar.Refresh();
                Kuretar.Update();
                Kuretar.Show();
            }
        }

        private void Kuretar_MouseEnter(object sender, EventArgs e)
        {
            float m = Kuretar.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Kuretar.Font = new Font("Lato", j, FontStyle.Bold);
                Kuretar.Location = new Point(Kuretar.Location.X - 1, Kuretar.Location.Y - (int)0.75);
                Kuretar.Refresh();
                Kuretar.Update();
                Kuretar.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Kuretar.ForeColor = Color.FromArgb(i, i, i);
                Kuretar.Refresh();
                Kuretar.Update();
                Kuretar.Show();
            }
        }

        private void Kuretar_MouseDown(object sender, MouseEventArgs e)
        {
            Kuretar.ForeColor = Color.FromArgb(210, 210, 210);
            Kuretar.Location = new Point(Kuretar.Location.X + 1, Kuretar.Location.Y + 1);
        }

        private void Kuretar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://kuretar-serveur.fr/finder/front/index.php", "_blank");
            }
            catch
            {

            }
        }

        private void Anim_MouseUp(object sender, MouseEventArgs e)
        {
            Anim.ForeColor = Color.FromArgb(255, 255, 255);
            Anim.Location = new Point(Anim.Location.X - 1, Anim.Location.Y - 1);
        }

        private void Anim_MouseLeave(object sender, EventArgs e)
        {
            float m = Anim.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Anim.Font = new Font("Lato", j, FontStyle.Bold);
                Anim.Location = new Point(Anim.Location.X + 1, Anim.Location.Y + (int)0.75);
                Anim.Refresh();
                Anim.Update();
                Anim.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Anim.ForeColor = Color.FromArgb(i, i, i);
                Anim.Refresh();
                Anim.Update();
                Anim.Show();
            }
        }

        private void Anim_MouseEnter(object sender, EventArgs e)
        {
            float m = Anim.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Anim.Font = new Font("Lato", j, FontStyle.Bold);
                Anim.Location = new Point(Anim.Location.X - 1, Anim.Location.Y - (int)0.75);
                Anim.Refresh();
                Anim.Update();
                Anim.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Anim.ForeColor = Color.FromArgb(i, i, i);
                Anim.Refresh();
                Anim.Update();
                Anim.Show();
            }
        }

        private void Anim_MouseDown(object sender, MouseEventArgs e)
        {
            Anim.ForeColor = Color.FromArgb(210, 210, 210);
            Anim.Location = new Point(Anim.Location.X + 1, Anim.Location.Y + 1);
        }

        private void Anim_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/2423-liste-des-debug-anim-et-des-npc-playemote/", "_blank");
            }
            catch
            {

            }
        }

        private void Forge_MouseUp(object sender, MouseEventArgs e)
        {
            Forge.ForeColor = Color.FromArgb(255, 255, 255);
            Forge.Location = new Point(Forge.Location.X - 1, Forge.Location.Y - 1);
        }

        private void Forge_MouseLeave(object sender, EventArgs e)
        {
            float m = Forge.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Forge.Font = new Font("Lato", j, FontStyle.Bold);
                Forge.Location = new Point(Forge.Location.X + 1, Forge.Location.Y + (int)0.75);
                Forge.Refresh();
                Forge.Update();
                Forge.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Forge.ForeColor = Color.FromArgb(i, i, i);
                Forge.Refresh();
                Forge.Update();
                Forge.Show();
            }
        }

        private void Forge_MouseEnter(object sender, EventArgs e)
        {
            float m = Forge.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Forge.Font = new Font("Lato", j, FontStyle.Bold);
                Forge.Location = new Point(Forge.Location.X - 1, Forge.Location.Y - (int)0.75);
                Forge.Refresh();
                Forge.Update();
                Forge.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Forge.ForeColor = Color.FromArgb(i, i, i);
                Forge.Refresh();
                Forge.Update();
                Forge.Show();
            }
        }

        private void Forge_MouseDown(object sender, MouseEventArgs e)
        {
            Forge.ForeColor = Color.FromArgb(210, 210, 210);
            Forge.Location = new Point(Forge.Location.X + 1, Forge.Location.Y + 1);
        }

        private void Forge_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/forum/81-tutoriels-de-la-forge/", "_blank");
            }
            catch
            {

            }
        }

        private void Addons_MouseUp(object sender, MouseEventArgs e)
        {
            Addons.ForeColor = Color.FromArgb(255, 255, 255);
            Addons.Location = new Point(Addons.Location.X - 1, Addons.Location.Y - 1);
        }

        private void Addons_MouseLeave(object sender, EventArgs e)
        {
            float m = Addons.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Addons.Font = new Font("Lato", j, FontStyle.Bold);
                Addons.Location = new Point(Addons.Location.X + 1, Addons.Location.Y + (int)0.75);
                Addons.Refresh();
                Addons.Update();
                Addons.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Addons.ForeColor = Color.FromArgb(i, i, i);
                Addons.Refresh();
                Addons.Update();
                Addons.Show();
            }
        }

        private void Addons_MouseDown(object sender, MouseEventArgs e)
        {
            Addons.ForeColor = Color.FromArgb(210, 210, 210);
            Addons.Location = new Point(Addons.Location.X + 1, Addons.Location.Y + 1);
        }

        private void Addons_MouseEnter(object sender, EventArgs e)
        {
            float m = Addons.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Addons.Font = new Font("Lato", j, FontStyle.Bold);
                Addons.Location = new Point(Addons.Location.X - 1, Addons.Location.Y - (int)0.75);
                Addons.Refresh();
                Addons.Update();
                Addons.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Addons.ForeColor = Color.FromArgb(i, i, i);
                Addons.Refresh();
                Addons.Update();
                Addons.Show();
            }
        }

        private void Addons_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(textBox1.Text + @"\Interface" + @"\AddOnsTRPCrossfactionTrinityAdmin.rar"))
            {
                File.Delete(textBox1.Text + @"\Interface" + @"\AddOnsTRPCrossfactionTrinityAdmin.rar");
                DownloadFile("www.dropbox.com/s/gkkuxm2s4nl5i93/AddOnsTRPCrossfactionTrinityAdmin.rar?dl=1", textBox1.Text + @"\Interface" + @"\AddOnsTRPCrossfactionTrinityAdmin.rar");
                labelPerc.Enabled = true;
                labelPerc.Visible = true;
                labelSpeed.Enabled = true;
                labelSpeed.Visible = true;
                labelDownloaded.Enabled = true;
                labelDownloaded.Visible = true;
                progressBar.Enabled = true;
                progressBar.Visible = true;
            }
            else
            {
                DownloadFile("www.dropbox.com/s/gkkuxm2s4nl5i93/AddOnsTRPCrossfactionTrinityAdmin.rar?dl=1", textBox1.Text + @"\Interface" + @"\AddOnsTRPCrossfactionTrinityAdmin.rar");
                labelPerc.Enabled = true;
                labelPerc.Visible = true;
                labelSpeed.Enabled = true;
                labelSpeed.Visible = true;
                labelDownloaded.Enabled = true;
                labelDownloaded.Visible = true;
                progressBar.Enabled = true;
                progressBar.Visible = true;
            }
        }

        private void Cosme_MouseUp(object sender, MouseEventArgs e)
        {
            Cosme.ForeColor = Color.FromArgb(255, 255, 255);
            Cosme.Location = new Point(Cosme.Location.X - 1, Cosme.Location.Y - 1);
        }

        private void Cosme_MouseLeave(object sender, EventArgs e)
        {
            float m = Cosme.Font.Size;

            for (int j = (int)m; j > (int)m - 4; j--)
            {

                System.Threading.Thread.Sleep(15);
                Cosme.Font = new Font("Lato", j, FontStyle.Bold);
                Cosme.Location = new Point(Cosme.Location.X + 1, Cosme.Location.Y + (int)0.75);
                Cosme.Refresh();
                Cosme.Update();
                Cosme.Show();
            }
            for (int i = 255; i > 210; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Cosme.ForeColor = Color.FromArgb(i, i, i);
                Cosme.Refresh();
                Cosme.Update();
                Cosme.Show();
            }
        }

        private void Cosme_MouseEnter(object sender, EventArgs e)
        {
            float m = Cosme.Font.Size;

            for (int j = (int)m; j < (int)m + 4; j++)
            {

                System.Threading.Thread.Sleep(15);
                Cosme.Font = new Font("Lato", j, FontStyle.Bold);
                Cosme.Location = new Point(Cosme.Location.X - 1, Cosme.Location.Y - (int)0.75);
                Cosme.Refresh();
                Cosme.Update();
                Cosme.Show();
            }
            for (int i = 210; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Cosme.ForeColor = Color.FromArgb(i, i, i);
                Cosme.Refresh();
                Cosme.Update();
                Cosme.Show();
            }
        }

        private void Cosme_MouseDown(object sender, MouseEventArgs e)
        {
            Cosme.ForeColor = Color.FromArgb(210, 210, 210);
            Cosme.Location = new Point(Cosme.Location.X + 1, Cosme.Location.Y + 1);
        }

        private void Cosme_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/590-le-petit-guide-des-spells-utiles-au-rp-vanilla-%C3%A0-cata/", "_blank");
                System.Threading.Thread.Sleep(150);
                System.Diagnostics.Process.Start("http://www.kuretar-serveur.fr/forum/index.php?/topic/4213-le-grimoire-catalogue-dauras-et-de-comp%C3%A9tences/", "_blank");
            }
            catch
            {

            }
        }

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            for(int i = 188; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Close.ForeColor = Color.FromArgb(i, i, i);
                Close.Refresh();
                Close.Update();
                Close.Show();
            }
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 255; i > 188; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Close.ForeColor = Color.FromArgb(i, i, i);
                Close.Refresh();
                Close.Update();
                Close.Show();
            }
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            Close.ForeColor = Color.FromArgb(188, 188, 188);
            Close.Location = new Point(Close.Location.X + 1, Close.Location.Y + 1);
        }

        private void Close_MouseUp(object sender, MouseEventArgs e)
        {
            Close_MouseEnter(sender, e);
            Close.Location = new Point(Close.Location.X - 1, Close.Location.Y - 1);
        }

        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 188; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Minimize.ForeColor = Color.FromArgb(i, i, i);
                Minimize.Refresh();
                Minimize.Update();
                Minimize.Show();
            }
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 255; i > 188; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Minimize.ForeColor = Color.FromArgb(i, i, i);
                Minimize.Refresh();
                Minimize.Update();
                Minimize.Show();
            }
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            Minimize.ForeColor = Color.FromArgb(188, 188, 188);
            Minimize.Location = new Point(Minimize.Location.X + 1, Minimize.Location.Y + 1);
        }

        private void Minimize_MouseUp(object sender, MouseEventArgs e)
        {
            Minimize_MouseEnter(sender, e);
            Minimize.Location = new Point(Minimize.Location.X - 1, Minimize.Location.Y - 1);
        }

        private void Dons_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kuretar-serveur.fr/contribute/", "_blank");
        }

        private void Dons_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 188; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Dons.ForeColor = Color.FromArgb(i, i, i);
                Dons.Refresh();
                Dons.Update();
                Dons.Show();
            }
        }

        private void Dons_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 255; i > 188; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Dons.ForeColor = Color.FromArgb(i, i, i);
                Dons.Refresh();
                Dons.Update();
                Dons.Show();
            }
        }

        private void Dons_MouseDown(object sender, MouseEventArgs e)
        {
            Dons.ForeColor = Color.FromArgb(188,188,188);
            Dons.Location = new Point(Dons.Location.X + 1, Dons.Location.Y + 1);
        }

        private void Dons_MouseUp(object sender, MouseEventArgs e)
        {
            Dons_MouseEnter(sender, e);
            Dons.Location = new Point(Dons.Location.X - 1, Dons.Location.Y - 1);
        }

        private void Voter_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kuretar-serveur.fr/vote/", "_blank");
        }

        private void Voter_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 188; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Voter.ForeColor = Color.FromArgb(i, i, i);
                Voter.Refresh();
                Voter.Update();
                Voter.Show();
            }
        }

        private void Voter_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 255; i > 188; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Voter.ForeColor = Color.FromArgb(i, i, i);
                Voter.Refresh();
                Voter.Update();
                Voter.Show();
            }
        }

        private void Voter_MouseDown(object sender, MouseEventArgs e)
        {
            Voter.ForeColor = Color.FromArgb(188, 188, 188);
            Voter.Location = new Point(Voter.Location.X + 1, Voter.Location.Y + 1);
        }

        private void Voter_MouseUp(object sender, MouseEventArgs e)
        {
            Voter_MouseEnter(sender, e);
            Voter.Location = new Point(Voter.Location.X - 1, Voter.Location.Y - 1);
        }

        private void Sign_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kuretar-serveur.fr/account/register.php", "_blank");
        }

        private void Sign_MouseEnter(object sender, EventArgs e)
        {
            for(int i = 188; i < 255; i++)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Sign.ForeColor = Color.FromArgb(i, i, i);
                Sign.Refresh();
                Sign.Update();
                Sign.Show();
            }
        }

        private void Sign_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 255; i > 188; i--)
            {
                System.Threading.Thread.Sleep((int)0.5);
                Sign.ForeColor = Color.FromArgb(i, i, i);
                Sign.Refresh();
                Sign.Update();
                Sign.Show();
            }
        }

        private void Sign_MouseDown(object sender, MouseEventArgs e)
        {
            Sign.ForeColor = Color.FromArgb(188, 188, 188);
            Sign.Location = new Point(Sign.Location.X + 1, Sign.Location.Y + 1);
        }

        private void Sign_MouseUp(object sender, MouseEventArgs e)
        {
            Sign_MouseEnter(sender, e);
            Sign.Location = new Point(Sign.Location.X - 1, Sign.Location.Y - 1);
        }
    }
}