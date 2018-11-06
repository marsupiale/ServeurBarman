namespace ServeurBarman
{
    partial class PageAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAccueil));
            this.BTN_deconnexion = new System.Windows.Forms.Button();
            this.BTN_Developers = new System.Windows.Forms.Button();
            this.PNL_Accueil = new System.Windows.Forms.Panel();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.TBX_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            this.BTN_Setting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBX_WaitingList = new System.Windows.Forms.ListBox();
            this.Btn_ResetCommande = new System.Windows.Forms.Button();
            this.btn_Servir = new System.Windows.Forms.Button();
            this.LBL_InfoCommande = new System.Windows.Forms.Label();
            this.lb_CommandeEnCours = new System.Windows.Forms.Label();
            this.LB_Etat_Gen = new System.Windows.Forms.Label();
            this.LBX_Activities = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GBX_Etat_general = new System.Windows.Forms.GroupBox();
            this.NUD_NbVerre_Ajouter = new System.Windows.Forms.NumericUpDown();
            this.LBL_Ajouter_Verre_Shooter = new System.Windows.Forms.Label();
            this.BTN_Remplir_Verre_Shooter = new System.Windows.Forms.Button();
            this.LB_Etat_Connection_Robot = new System.Windows.Forms.Label();
            this.LBL_Etat_Connection_Robot = new System.Windows.Forms.Label();
            this.LB_Etat_BD = new System.Windows.Forms.Label();
            this.LB_Base_Donne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Nb_Verre_Shooter = new System.Windows.Forms.Label();
            this.LB_NB_VerreRouge = new System.Windows.Forms.Label();
            this.LB_Nb_Bouteille = new System.Windows.Forms.Label();
            this.LBL_Bouteille = new System.Windows.Forms.Label();
            this.LB_Verre_Rouge = new System.Windows.Forms.Label();
            this.LB_Verre_Shooter = new System.Windows.Forms.Label();
            this.GBX_infoGeneral = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PNL_Bordure_Top = new System.Windows.Forms.Panel();
            this.BTN_Supprimer_Cmd = new System.Windows.Forms.Button();
            this.BTN_Pause_Commande = new System.Windows.Forms.Button();
            this.Btn_Connecter_Robot = new System.Windows.Forms.Button();
            this.pbx_Halt = new System.Windows.Forms.PictureBox();
            this.BTN_Connecter_BD = new System.Windows.Forms.Button();
            this.PNL_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            this.GBX_Etat_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbVerre_Ajouter)).BeginInit();
            this.GBX_infoGeneral.SuspendLayout();
            this.PNL_Bordure_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Halt)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_deconnexion
            // 
            resources.ApplyResources(this.BTN_deconnexion, "BTN_deconnexion");
            this.BTN_deconnexion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_deconnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_deconnexion.FlatAppearance.BorderSize = 2;
            this.BTN_deconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_deconnexion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_deconnexion.Name = "BTN_deconnexion";
            this.BTN_deconnexion.UseVisualStyleBackColor = true;
            this.BTN_deconnexion.Click += new System.EventHandler(this.BTN_deconnexion_Click);
            // 
            // BTN_Developers
            // 
            resources.ApplyResources(this.BTN_Developers, "BTN_Developers");
            this.BTN_Developers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Developers.FlatAppearance.BorderSize = 0;
            this.BTN_Developers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Developers.Name = "BTN_Developers";
            this.BTN_Developers.UseVisualStyleBackColor = true;
            this.BTN_Developers.Click += new System.EventHandler(this.BTN_Developers_Click);
            // 
            // PNL_Accueil
            // 
            this.PNL_Accueil.BackColor = System.Drawing.Color.Black;
            this.PNL_Accueil.Controls.Add(this.TBX_Password);
            this.PNL_Accueil.Controls.Add(this.TBX_Username);
            this.PNL_Accueil.Controls.Add(this.label4);
            this.PNL_Accueil.Controls.Add(this.label3);
            this.PNL_Accueil.Controls.Add(this.PBX_Logo);
            this.PNL_Accueil.Controls.Add(this.BTN_Setting);
            this.PNL_Accueil.Controls.Add(this.BTN_Developers);
            resources.ApplyResources(this.PNL_Accueil, "PNL_Accueil");
            this.PNL_Accueil.Name = "PNL_Accueil";
            // 
            // TBX_Password
            // 
            resources.ApplyResources(this.TBX_Password, "TBX_Password");
            this.TBX_Password.Name = "TBX_Password";
            // 
            // TBX_Username
            // 
            resources.ApplyResources(this.TBX_Username, "TBX_Username");
            this.TBX_Username.Name = "TBX_Username";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Name = "label3";
            // 
            // PBX_Logo
            // 
            this.PBX_Logo.BackgroundImage = global::ServeurBarman.Properties.Resources.JELLY_Bar_Logo;
            resources.ApplyResources(this.PBX_Logo, "PBX_Logo");
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.TabStop = false;
            // 
            // BTN_Setting
            // 
            this.BTN_Setting.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BTN_Setting, "BTN_Setting");
            this.BTN_Setting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Setting.Image = global::ServeurBarman.Properties.Resources.if_setting_18141171;
            this.BTN_Setting.Name = "BTN_Setting";
            this.BTN_Setting.UseVisualStyleBackColor = true;
            this.BTN_Setting.Click += new System.EventHandler(this.BTN_Setting_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LBX_WaitingList
            // 
            resources.ApplyResources(this.LBX_WaitingList, "LBX_WaitingList");
            this.LBX_WaitingList.FormattingEnabled = true;
            this.LBX_WaitingList.Name = "LBX_WaitingList";
            this.LBX_WaitingList.SizeChanged += new System.EventHandler(this.LBX_WaitingList_SizeChanged);
            // 
            // Btn_ResetCommande
            // 
            resources.ApplyResources(this.Btn_ResetCommande, "Btn_ResetCommande");
            this.Btn_ResetCommande.Name = "Btn_ResetCommande";
            this.Btn_ResetCommande.UseVisualStyleBackColor = true;
            this.Btn_ResetCommande.Click += new System.EventHandler(this.Btn_ResetCommande_Click);
            // 
            // btn_Servir
            // 
            this.btn_Servir.BackColor = System.Drawing.Color.Gray;
            this.btn_Servir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Servir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Servir.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_Servir, "btn_Servir");
            this.btn_Servir.Name = "btn_Servir";
            this.btn_Servir.UseVisualStyleBackColor = false;
            this.btn_Servir.Click += new System.EventHandler(this.btn_Servir_Click);
            // 
            // LBL_InfoCommande
            // 
            resources.ApplyResources(this.LBL_InfoCommande, "LBL_InfoCommande");
            this.LBL_InfoCommande.Name = "LBL_InfoCommande";
            // 
            // lb_CommandeEnCours
            // 
            this.lb_CommandeEnCours.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.lb_CommandeEnCours, "lb_CommandeEnCours");
            this.lb_CommandeEnCours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_CommandeEnCours.Name = "lb_CommandeEnCours";
            // 
            // LB_Etat_Gen
            // 
            resources.ApplyResources(this.LB_Etat_Gen, "LB_Etat_Gen");
            this.LB_Etat_Gen.Name = "LB_Etat_Gen";
            // 
            // LBX_Activities
            // 
            this.LBX_Activities.FormattingEnabled = true;
            resources.ApplyResources(this.LBX_Activities, "LBX_Activities");
            this.LBX_Activities.Name = "LBX_Activities";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // GBX_Etat_general
            // 
            this.GBX_Etat_general.Controls.Add(this.NUD_NbVerre_Ajouter);
            this.GBX_Etat_general.Controls.Add(this.LBL_Ajouter_Verre_Shooter);
            this.GBX_Etat_general.Controls.Add(this.BTN_Remplir_Verre_Shooter);
            this.GBX_Etat_general.Controls.Add(this.LB_Etat_Connection_Robot);
            this.GBX_Etat_general.Controls.Add(this.LBL_Etat_Connection_Robot);
            this.GBX_Etat_general.Controls.Add(this.LB_Etat_BD);
            this.GBX_Etat_general.Controls.Add(this.LB_Base_Donne);
            this.GBX_Etat_general.Controls.Add(this.label2);
            this.GBX_Etat_general.Controls.Add(this.LB_Nb_Verre_Shooter);
            this.GBX_Etat_general.Controls.Add(this.LB_NB_VerreRouge);
            this.GBX_Etat_general.Controls.Add(this.LB_Nb_Bouteille);
            this.GBX_Etat_general.Controls.Add(this.LBL_Bouteille);
            this.GBX_Etat_general.Controls.Add(this.LB_Verre_Rouge);
            this.GBX_Etat_general.Controls.Add(this.LB_Verre_Shooter);
            resources.ApplyResources(this.GBX_Etat_general, "GBX_Etat_general");
            this.GBX_Etat_general.Name = "GBX_Etat_general";
            this.GBX_Etat_general.TabStop = false;
            // 
            // NUD_NbVerre_Ajouter
            // 
            resources.ApplyResources(this.NUD_NbVerre_Ajouter, "NUD_NbVerre_Ajouter");
            this.NUD_NbVerre_Ajouter.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NUD_NbVerre_Ajouter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_NbVerre_Ajouter.Name = "NUD_NbVerre_Ajouter";
            this.NUD_NbVerre_Ajouter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBL_Ajouter_Verre_Shooter
            // 
            resources.ApplyResources(this.LBL_Ajouter_Verre_Shooter, "LBL_Ajouter_Verre_Shooter");
            this.LBL_Ajouter_Verre_Shooter.Name = "LBL_Ajouter_Verre_Shooter";
            // 
            // BTN_Remplir_Verre_Shooter
            // 
            resources.ApplyResources(this.BTN_Remplir_Verre_Shooter, "BTN_Remplir_Verre_Shooter");
            this.BTN_Remplir_Verre_Shooter.Name = "BTN_Remplir_Verre_Shooter";
            this.BTN_Remplir_Verre_Shooter.UseVisualStyleBackColor = true;
            this.BTN_Remplir_Verre_Shooter.Click += new System.EventHandler(this.BTN_Remplir_Verre_Shooter_Click);
            // 
            // LB_Etat_Connection_Robot
            // 
            resources.ApplyResources(this.LB_Etat_Connection_Robot, "LB_Etat_Connection_Robot");
            this.LB_Etat_Connection_Robot.ForeColor = System.Drawing.Color.Red;
            this.LB_Etat_Connection_Robot.Name = "LB_Etat_Connection_Robot";
            // 
            // LBL_Etat_Connection_Robot
            // 
            resources.ApplyResources(this.LBL_Etat_Connection_Robot, "LBL_Etat_Connection_Robot");
            this.LBL_Etat_Connection_Robot.Name = "LBL_Etat_Connection_Robot";
            // 
            // LB_Etat_BD
            // 
            resources.ApplyResources(this.LB_Etat_BD, "LB_Etat_BD");
            this.LB_Etat_BD.ForeColor = System.Drawing.Color.Red;
            this.LB_Etat_BD.Name = "LB_Etat_BD";
            // 
            // LB_Base_Donne
            // 
            resources.ApplyResources(this.LB_Base_Donne, "LB_Base_Donne");
            this.LB_Base_Donne.Name = "LB_Base_Donne";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // LB_Nb_Verre_Shooter
            // 
            resources.ApplyResources(this.LB_Nb_Verre_Shooter, "LB_Nb_Verre_Shooter");
            this.LB_Nb_Verre_Shooter.Name = "LB_Nb_Verre_Shooter";
            // 
            // LB_NB_VerreRouge
            // 
            resources.ApplyResources(this.LB_NB_VerreRouge, "LB_NB_VerreRouge");
            this.LB_NB_VerreRouge.Name = "LB_NB_VerreRouge";
            // 
            // LB_Nb_Bouteille
            // 
            resources.ApplyResources(this.LB_Nb_Bouteille, "LB_Nb_Bouteille");
            this.LB_Nb_Bouteille.Name = "LB_Nb_Bouteille";
            // 
            // LBL_Bouteille
            // 
            resources.ApplyResources(this.LBL_Bouteille, "LBL_Bouteille");
            this.LBL_Bouteille.Name = "LBL_Bouteille";
            // 
            // LB_Verre_Rouge
            // 
            resources.ApplyResources(this.LB_Verre_Rouge, "LB_Verre_Rouge");
            this.LB_Verre_Rouge.Name = "LB_Verre_Rouge";
            // 
            // LB_Verre_Shooter
            // 
            resources.ApplyResources(this.LB_Verre_Shooter, "LB_Verre_Shooter");
            this.LB_Verre_Shooter.Name = "LB_Verre_Shooter";
            // 
            // GBX_infoGeneral
            // 
            this.GBX_infoGeneral.Controls.Add(this.GBX_Etat_general);
            this.GBX_infoGeneral.Controls.Add(this.metroLabel1);
            this.GBX_infoGeneral.Controls.Add(this.LBX_Activities);
            this.GBX_infoGeneral.Controls.Add(this.LB_Etat_Gen);
            this.GBX_infoGeneral.Controls.Add(this.lb_CommandeEnCours);
            this.GBX_infoGeneral.Controls.Add(this.LBL_InfoCommande);
            resources.ApplyResources(this.GBX_infoGeneral, "GBX_infoGeneral");
            this.GBX_infoGeneral.Name = "GBX_infoGeneral";
            this.GBX_infoGeneral.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // PNL_Bordure_Top
            // 
            this.PNL_Bordure_Top.BackColor = System.Drawing.Color.Black;
            this.PNL_Bordure_Top.Controls.Add(this.BTN_deconnexion);
            resources.ApplyResources(this.PNL_Bordure_Top, "PNL_Bordure_Top");
            this.PNL_Bordure_Top.Name = "PNL_Bordure_Top";
            // 
            // BTN_Supprimer_Cmd
            // 
            resources.ApplyResources(this.BTN_Supprimer_Cmd, "BTN_Supprimer_Cmd");
            this.BTN_Supprimer_Cmd.Name = "BTN_Supprimer_Cmd";
            this.BTN_Supprimer_Cmd.UseVisualStyleBackColor = true;
            this.BTN_Supprimer_Cmd.Click += new System.EventHandler(this.BTN_Suprimé_Cmd_Click);
            // 
            // BTN_Pause_Commande
            // 
            this.BTN_Pause_Commande.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.BTN_Pause_Commande, "BTN_Pause_Commande");
            this.BTN_Pause_Commande.Name = "BTN_Pause_Commande";
            this.BTN_Pause_Commande.UseVisualStyleBackColor = false;
            this.BTN_Pause_Commande.Click += new System.EventHandler(this.BTN_Pause_Commande_Click);
            // 
            // Btn_Connecter_Robot
            // 
            this.Btn_Connecter_Robot.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.Btn_Connecter_Robot, "Btn_Connecter_Robot");
            this.Btn_Connecter_Robot.Name = "Btn_Connecter_Robot";
            this.Btn_Connecter_Robot.UseVisualStyleBackColor = false;
            this.Btn_Connecter_Robot.Click += new System.EventHandler(this.Btn_Connecter_Robot_Click);
            // 
            // pbx_Halt
            // 
            resources.ApplyResources(this.pbx_Halt, "pbx_Halt");
            this.pbx_Halt.BackgroundImage = global::ServeurBarman.Properties.Resources.stop1;
            this.pbx_Halt.Name = "pbx_Halt";
            this.pbx_Halt.TabStop = false;
            this.pbx_Halt.Click += new System.EventHandler(this.pbx_Halt_Click);
            // 
            // BTN_Connecter_BD
            // 
            this.BTN_Connecter_BD.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.BTN_Connecter_BD, "BTN_Connecter_BD");
            this.BTN_Connecter_BD.Name = "BTN_Connecter_BD";
            this.BTN_Connecter_BD.UseVisualStyleBackColor = false;
            this.BTN_Connecter_BD.Click += new System.EventHandler(this.BTN_Connecter_BD_Click);
            // 
            // PageAccueil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Connecter_BD);
            this.Controls.Add(this.Btn_Connecter_Robot);
            this.Controls.Add(this.PNL_Accueil);
            this.Controls.Add(this.BTN_Pause_Commande);
            this.Controls.Add(this.BTN_Supprimer_Cmd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GBX_infoGeneral);
            this.Controls.Add(this.btn_Servir);
            this.Controls.Add(this.Btn_ResetCommande);
            this.Controls.Add(this.LBX_WaitingList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_Halt);
            this.Controls.Add(this.PNL_Bordure_Top);
            this.DisplayHeader = false;
            this.Name = "PageAccueil";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.PageAccueil_Load);
            this.PNL_Accueil.ResumeLayout(false);
            this.PNL_Accueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            this.GBX_Etat_general.ResumeLayout(false);
            this.GBX_Etat_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbVerre_Ajouter)).EndInit();
            this.GBX_infoGeneral.ResumeLayout(false);
            this.GBX_infoGeneral.PerformLayout();
            this.PNL_Bordure_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Halt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Setting;
        private System.Windows.Forms.Button BTN_deconnexion;
        private System.Windows.Forms.Button BTN_Developers;
        private System.Windows.Forms.PictureBox PBX_Logo;
        private System.Windows.Forms.Panel PNL_Accueil;
        private System.Windows.Forms.PictureBox pbx_Halt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBX_WaitingList;
        private System.Windows.Forms.Button Btn_ResetCommande;
        private System.Windows.Forms.Button btn_Servir;
        private System.Windows.Forms.Label LBL_InfoCommande;
        private System.Windows.Forms.Label lb_CommandeEnCours;
        private System.Windows.Forms.Label LB_Etat_Gen;
        private System.Windows.Forms.ListBox LBX_Activities;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox GBX_Etat_general;
        private System.Windows.Forms.Label LB_Etat_Connection_Robot;
        private System.Windows.Forms.Label LBL_Etat_Connection_Robot;
        private System.Windows.Forms.Label LB_Etat_BD;
        private System.Windows.Forms.Label LB_Base_Donne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_Nb_Verre_Shooter;
        private System.Windows.Forms.Label LB_NB_VerreRouge;
        private System.Windows.Forms.Label LB_Nb_Bouteille;
        private System.Windows.Forms.Label LBL_Bouteille;
        private System.Windows.Forms.Label LB_Verre_Rouge;
        private System.Windows.Forms.Label LB_Verre_Shooter;
        private System.Windows.Forms.GroupBox GBX_infoGeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PNL_Bordure_Top;
        private System.Windows.Forms.Button BTN_Supprimer_Cmd;
        private System.Windows.Forms.Button BTN_Pause_Commande;
        private System.Windows.Forms.Button Btn_Connecter_Robot;
        private System.Windows.Forms.Button BTN_Remplir_Verre_Shooter;
        private System.Windows.Forms.NumericUpDown NUD_NbVerre_Ajouter;
        private System.Windows.Forms.Label LBL_Ajouter_Verre_Shooter;
        private System.Windows.Forms.Button BTN_Connecter_BD;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.TextBox TBX_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}