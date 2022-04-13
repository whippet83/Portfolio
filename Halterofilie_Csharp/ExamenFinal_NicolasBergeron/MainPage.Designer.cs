namespace ExamenFinal_NicolasBergeron
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabAjouter = new System.Windows.Forms.TabPage();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.btnInitialiserAdd = new ExamenFinal_NicolasBergeron.PillButton();
            this.btnAddAthlete = new ExamenFinal_NicolasBergeron.PillButton();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtPrenomAdd = new System.Windows.Forms.TextBox();
            this.txtPaysAdd = new System.Windows.Forms.TextBox();
            this.lblPaysAthlete = new System.Windows.Forms.Label();
            this.lblPrenomAthlete = new System.Windows.Forms.Label();
            this.lblNomAthlete = new System.Windows.Forms.Label();
            this.lblIDAthlete = new System.Windows.Forms.Label();
            this.lblAthleteInfo = new System.Windows.Forms.Label();
            this.tabDel = new System.Windows.Forms.TabPage();
            this.txtTentaUpdate3 = new System.Windows.Forms.TextBox();
            this.txtTentaUpdate2 = new System.Windows.Forms.TextBox();
            this.lblTentaUpdate3 = new System.Windows.Forms.Label();
            this.lblTentaUpdate2 = new System.Windows.Forms.Label();
            this.lblTentaUpdate1 = new System.Windows.Forms.Label();
            this.txtTentaUpdate1 = new System.Windows.Forms.TextBox();
            this.pbDelUp = new System.Windows.Forms.PictureBox();
            this.btnInitialiseUpdate = new ExamenFinal_NicolasBergeron.PillButton();
            this.btnInitialiserDel = new ExamenFinal_NicolasBergeron.PillButton();
            this.btnUpdateAthlete = new ExamenFinal_NicolasBergeron.PillButton();
            this.txtIDUpdate = new System.Windows.Forms.TextBox();
            this.lblIDTUpdate = new System.Windows.Forms.Label();
            this.lblUpdateTab = new System.Windows.Forms.Label();
            this.btnSupDel = new ExamenFinal_NicolasBergeron.PillButton();
            this.txtIDDel = new System.Windows.Forms.TextBox();
            this.lblIDDel = new System.Windows.Forms.Label();
            this.lblSupDel = new System.Windows.Forms.Label();
            this.tabAddPoids = new System.Windows.Forms.TabPage();
            this.pbPoidsSoule = new System.Windows.Forms.PictureBox();
            this.btnIniPoid = new ExamenFinal_NicolasBergeron.PillButton();
            this.btnAddPoid = new ExamenFinal_NicolasBergeron.PillButton();
            this.txtTenta3 = new System.Windows.Forms.TextBox();
            this.lblTenta3 = new System.Windows.Forms.Label();
            this.txtTenta2 = new System.Windows.Forms.TextBox();
            this.txtTenta1 = new System.Windows.Forms.TextBox();
            this.lblTenta2 = new System.Windows.Forms.Label();
            this.lblTenta1 = new System.Windows.Forms.Label();
            this.txtIdPoid = new System.Windows.Forms.TextBox();
            this.lblIdPoid = new System.Windows.Forms.Label();
            this.lblPoidsEssai = new System.Windows.Forms.Label();
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.printPb = new System.Windows.Forms.PictureBox();
            this.afficherAthleteDgv = new System.Windows.Forms.DataGridView();
            this.lblPrint = new System.Windows.Forms.Label();
            this.tabPrintHistorique = new System.Windows.Forms.TabPage();
            this.historiquePb = new System.Windows.Forms.PictureBox();
            this.affichageHistoriqueDgv = new System.Windows.Forms.DataGridView();
            this.lblAffichageHistorique = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPoids = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPrintHistorique = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tabAjouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.tabDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelUp)).BeginInit();
            this.tabAddPoids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoidsSoule)).BeginInit();
            this.tabPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficherAthleteDgv)).BeginInit();
            this.tabPrintHistorique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiquePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affichageHistoriqueDgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcMain.Controls.Add(this.tabAjouter);
            this.tcMain.Controls.Add(this.tabDel);
            this.tcMain.Controls.Add(this.tabAddPoids);
            this.tcMain.Controls.Add(this.tabPrint);
            this.tcMain.Controls.Add(this.tabPrintHistorique);
            this.tcMain.Location = new System.Drawing.Point(409, -6);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1436, 1191);
            this.tcMain.TabIndex = 0;
            // 
            // tabAjouter
            // 
            this.tabAjouter.Controls.Add(this.pbAdd);
            this.tabAjouter.Controls.Add(this.btnInitialiserAdd);
            this.tabAjouter.Controls.Add(this.btnAddAthlete);
            this.tabAjouter.Controls.Add(this.txtIDAdd);
            this.tabAjouter.Controls.Add(this.txtNameAdd);
            this.tabAjouter.Controls.Add(this.txtPrenomAdd);
            this.tabAjouter.Controls.Add(this.txtPaysAdd);
            this.tabAjouter.Controls.Add(this.lblPaysAthlete);
            this.tabAjouter.Controls.Add(this.lblPrenomAthlete);
            this.tabAjouter.Controls.Add(this.lblNomAthlete);
            this.tabAjouter.Controls.Add(this.lblIDAthlete);
            this.tabAjouter.Controls.Add(this.lblAthleteInfo);
            this.tabAjouter.Location = new System.Drawing.Point(34, 4);
            this.tabAjouter.Name = "tabAjouter";
            this.tabAjouter.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjouter.Size = new System.Drawing.Size(1398, 1183);
            this.tabAjouter.TabIndex = 0;
            this.tabAjouter.Text = "Ajouter";
            this.tabAjouter.UseVisualStyleBackColor = true;
            // 
            // pbAdd
            // 
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAdd.Image = global::ExamenFinal_NicolasBergeron.Properties.Resources.man_gf3dd285ab_1920;
            this.pbAdd.Location = new System.Drawing.Point(0, 736);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(1402, 693);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 13;
            this.pbAdd.TabStop = false;
            // 
            // btnInitialiserAdd
            // 
            this.btnInitialiserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnInitialiserAdd.FlatAppearance.BorderSize = 0;
            this.btnInitialiserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialiserAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitialiserAdd.ForeColor = System.Drawing.Color.White;
            this.btnInitialiserAdd.Location = new System.Drawing.Point(568, 510);
            this.btnInitialiserAdd.Name = "btnInitialiserAdd";
            this.btnInitialiserAdd.Size = new System.Drawing.Size(205, 51);
            this.btnInitialiserAdd.TabIndex = 12;
            this.btnInitialiserAdd.Text = "Initialiser";
            this.btnInitialiserAdd.UseVisualStyleBackColor = false;
            this.btnInitialiserAdd.Click += new System.EventHandler(this.btnInitialiserAdd_Click);
            // 
            // btnAddAthlete
            // 
            this.btnAddAthlete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAddAthlete.FlatAppearance.BorderSize = 0;
            this.btnAddAthlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAthlete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAthlete.ForeColor = System.Drawing.Color.White;
            this.btnAddAthlete.Location = new System.Drawing.Point(304, 510);
            this.btnAddAthlete.Name = "btnAddAthlete";
            this.btnAddAthlete.Size = new System.Drawing.Size(205, 51);
            this.btnAddAthlete.TabIndex = 11;
            this.btnAddAthlete.Text = "Ajouter";
            this.btnAddAthlete.UseVisualStyleBackColor = false;
            this.btnAddAthlete.Click += new System.EventHandler(this.btnAddAthlete_Click);
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDAdd.Location = new System.Drawing.Point(304, 207);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(469, 39);
            this.txtIDAdd.TabIndex = 6;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameAdd.Location = new System.Drawing.Point(304, 279);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(469, 39);
            this.txtNameAdd.TabIndex = 7;
            // 
            // txtPrenomAdd
            // 
            this.txtPrenomAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrenomAdd.Location = new System.Drawing.Point(304, 345);
            this.txtPrenomAdd.Name = "txtPrenomAdd";
            this.txtPrenomAdd.Size = new System.Drawing.Size(469, 39);
            this.txtPrenomAdd.TabIndex = 8;
            // 
            // txtPaysAdd
            // 
            this.txtPaysAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaysAdd.Location = new System.Drawing.Point(304, 411);
            this.txtPaysAdd.Name = "txtPaysAdd";
            this.txtPaysAdd.Size = new System.Drawing.Size(469, 39);
            this.txtPaysAdd.TabIndex = 9;
            // 
            // lblPaysAthlete
            // 
            this.lblPaysAthlete.AutoSize = true;
            this.lblPaysAthlete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaysAthlete.Location = new System.Drawing.Point(91, 412);
            this.lblPaysAthlete.Name = "lblPaysAthlete";
            this.lblPaysAthlete.Size = new System.Drawing.Size(72, 38);
            this.lblPaysAthlete.TabIndex = 4;
            this.lblPaysAthlete.Text = "Pays";
            // 
            // lblPrenomAthlete
            // 
            this.lblPrenomAthlete.AutoSize = true;
            this.lblPrenomAthlete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrenomAthlete.Location = new System.Drawing.Point(91, 346);
            this.lblPrenomAthlete.Name = "lblPrenomAthlete";
            this.lblPrenomAthlete.Size = new System.Drawing.Size(114, 38);
            this.lblPrenomAthlete.TabIndex = 3;
            this.lblPrenomAthlete.Text = "Prénom";
            // 
            // lblNomAthlete
            // 
            this.lblNomAthlete.AutoSize = true;
            this.lblNomAthlete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomAthlete.Location = new System.Drawing.Point(91, 280);
            this.lblNomAthlete.Name = "lblNomAthlete";
            this.lblNomAthlete.Size = new System.Drawing.Size(78, 38);
            this.lblNomAthlete.TabIndex = 2;
            this.lblNomAthlete.Text = "Nom";
            // 
            // lblIDAthlete
            // 
            this.lblIDAthlete.AutoSize = true;
            this.lblIDAthlete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDAthlete.Location = new System.Drawing.Point(91, 208);
            this.lblIDAthlete.Name = "lblIDAthlete";
            this.lblIDAthlete.Size = new System.Drawing.Size(44, 38);
            this.lblIDAthlete.TabIndex = 1;
            this.lblIDAthlete.Text = "ID";
            // 
            // lblAthleteInfo
            // 
            this.lblAthleteInfo.AutoSize = true;
            this.lblAthleteInfo.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAthleteInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblAthleteInfo.Location = new System.Drawing.Point(83, 87);
            this.lblAthleteInfo.Name = "lblAthleteInfo";
            this.lblAthleteInfo.Size = new System.Drawing.Size(318, 45);
            this.lblAthleteInfo.TabIndex = 0;
            this.lblAthleteInfo.Text = "Information Athlète";
            // 
            // tabDel
            // 
            this.tabDel.Controls.Add(this.txtTentaUpdate3);
            this.tabDel.Controls.Add(this.txtTentaUpdate2);
            this.tabDel.Controls.Add(this.lblTentaUpdate3);
            this.tabDel.Controls.Add(this.lblTentaUpdate2);
            this.tabDel.Controls.Add(this.lblTentaUpdate1);
            this.tabDel.Controls.Add(this.txtTentaUpdate1);
            this.tabDel.Controls.Add(this.pbDelUp);
            this.tabDel.Controls.Add(this.btnInitialiseUpdate);
            this.tabDel.Controls.Add(this.btnInitialiserDel);
            this.tabDel.Controls.Add(this.btnUpdateAthlete);
            this.tabDel.Controls.Add(this.txtIDUpdate);
            this.tabDel.Controls.Add(this.lblIDTUpdate);
            this.tabDel.Controls.Add(this.lblUpdateTab);
            this.tabDel.Controls.Add(this.btnSupDel);
            this.tabDel.Controls.Add(this.txtIDDel);
            this.tabDel.Controls.Add(this.lblIDDel);
            this.tabDel.Controls.Add(this.lblSupDel);
            this.tabDel.Location = new System.Drawing.Point(34, 4);
            this.tabDel.Name = "tabDel";
            this.tabDel.Padding = new System.Windows.Forms.Padding(3);
            this.tabDel.Size = new System.Drawing.Size(1398, 1183);
            this.tabDel.TabIndex = 1;
            this.tabDel.UseVisualStyleBackColor = true;
            // 
            // txtTentaUpdate3
            // 
            this.txtTentaUpdate3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTentaUpdate3.Location = new System.Drawing.Point(304, 652);
            this.txtTentaUpdate3.Name = "txtTentaUpdate3";
            this.txtTentaUpdate3.Size = new System.Drawing.Size(469, 39);
            this.txtTentaUpdate3.TabIndex = 9;
            // 
            // txtTentaUpdate2
            // 
            this.txtTentaUpdate2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTentaUpdate2.Location = new System.Drawing.Point(304, 596);
            this.txtTentaUpdate2.Name = "txtTentaUpdate2";
            this.txtTentaUpdate2.Size = new System.Drawing.Size(469, 39);
            this.txtTentaUpdate2.TabIndex = 8;
            // 
            // lblTentaUpdate3
            // 
            this.lblTentaUpdate3.AutoSize = true;
            this.lblTentaUpdate3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTentaUpdate3.Location = new System.Drawing.Point(91, 653);
            this.lblTentaUpdate3.Name = "lblTentaUpdate3";
            this.lblTentaUpdate3.Size = new System.Drawing.Size(150, 38);
            this.lblTentaUpdate3.TabIndex = 23;
            this.lblTentaUpdate3.Text = "Tentative 3";
            // 
            // lblTentaUpdate2
            // 
            this.lblTentaUpdate2.AutoSize = true;
            this.lblTentaUpdate2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTentaUpdate2.Location = new System.Drawing.Point(91, 597);
            this.lblTentaUpdate2.Name = "lblTentaUpdate2";
            this.lblTentaUpdate2.Size = new System.Drawing.Size(150, 38);
            this.lblTentaUpdate2.TabIndex = 22;
            this.lblTentaUpdate2.Text = "Tentative 2";
            // 
            // lblTentaUpdate1
            // 
            this.lblTentaUpdate1.AutoSize = true;
            this.lblTentaUpdate1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTentaUpdate1.Location = new System.Drawing.Point(91, 537);
            this.lblTentaUpdate1.Name = "lblTentaUpdate1";
            this.lblTentaUpdate1.Size = new System.Drawing.Size(150, 38);
            this.lblTentaUpdate1.TabIndex = 21;
            this.lblTentaUpdate1.Text = "Tentative 1";
            // 
            // txtTentaUpdate1
            // 
            this.txtTentaUpdate1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTentaUpdate1.Location = new System.Drawing.Point(304, 536);
            this.txtTentaUpdate1.Name = "txtTentaUpdate1";
            this.txtTentaUpdate1.Size = new System.Drawing.Size(469, 39);
            this.txtTentaUpdate1.TabIndex = 7;
            // 
            // pbDelUp
            // 
            this.pbDelUp.Image = ((System.Drawing.Image)(resources.GetObject("pbDelUp.Image")));
            this.pbDelUp.Location = new System.Drawing.Point(-11, 859);
            this.pbDelUp.Name = "pbDelUp";
            this.pbDelUp.Size = new System.Drawing.Size(1422, 313);
            this.pbDelUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelUp.TabIndex = 19;
            this.pbDelUp.TabStop = false;
            // 
            // btnInitialiseUpdate
            // 
            this.btnInitialiseUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnInitialiseUpdate.FlatAppearance.BorderSize = 0;
            this.btnInitialiseUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialiseUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitialiseUpdate.ForeColor = System.Drawing.Color.White;
            this.btnInitialiseUpdate.Location = new System.Drawing.Point(568, 724);
            this.btnInitialiseUpdate.Name = "btnInitialiseUpdate";
            this.btnInitialiseUpdate.Size = new System.Drawing.Size(205, 51);
            this.btnInitialiseUpdate.TabIndex = 11;
            this.btnInitialiseUpdate.Text = "Initialiser";
            this.btnInitialiseUpdate.UseVisualStyleBackColor = false;
            this.btnInitialiseUpdate.Click += new System.EventHandler(this.btnInitialiseUpdate_Click);
            // 
            // btnInitialiserDel
            // 
            this.btnInitialiserDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnInitialiserDel.FlatAppearance.BorderSize = 0;
            this.btnInitialiserDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialiserDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitialiserDel.ForeColor = System.Drawing.Color.White;
            this.btnInitialiserDel.Location = new System.Drawing.Point(568, 280);
            this.btnInitialiserDel.Name = "btnInitialiserDel";
            this.btnInitialiserDel.Size = new System.Drawing.Size(205, 51);
            this.btnInitialiserDel.TabIndex = 5;
            this.btnInitialiserDel.Text = "Initialiser";
            this.btnInitialiserDel.UseVisualStyleBackColor = false;
            this.btnInitialiserDel.Click += new System.EventHandler(this.btnInitialiserDel_Click);
            // 
            // btnUpdateAthlete
            // 
            this.btnUpdateAthlete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnUpdateAthlete.FlatAppearance.BorderSize = 0;
            this.btnUpdateAthlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAthlete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAthlete.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAthlete.Location = new System.Drawing.Point(304, 724);
            this.btnUpdateAthlete.Name = "btnUpdateAthlete";
            this.btnUpdateAthlete.Size = new System.Drawing.Size(205, 51);
            this.btnUpdateAthlete.TabIndex = 10;
            this.btnUpdateAthlete.Text = "Confirmer";
            this.btnUpdateAthlete.UseVisualStyleBackColor = false;
            this.btnUpdateAthlete.Click += new System.EventHandler(this.btnUpdateAthlete_Click);
            // 
            // txtIDUpdate
            // 
            this.txtIDUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDUpdate.Location = new System.Drawing.Point(304, 477);
            this.txtIDUpdate.Name = "txtIDUpdate";
            this.txtIDUpdate.Size = new System.Drawing.Size(469, 39);
            this.txtIDUpdate.TabIndex = 6;
            // 
            // lblIDTUpdate
            // 
            this.lblIDTUpdate.AutoSize = true;
            this.lblIDTUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDTUpdate.Location = new System.Drawing.Point(91, 478);
            this.lblIDTUpdate.Name = "lblIDTUpdate";
            this.lblIDTUpdate.Size = new System.Drawing.Size(44, 38);
            this.lblIDTUpdate.TabIndex = 14;
            this.lblIDTUpdate.Text = "ID";
            // 
            // lblUpdateTab
            // 
            this.lblUpdateTab.AutoSize = true;
            this.lblUpdateTab.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUpdateTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblUpdateTab.Location = new System.Drawing.Point(83, 394);
            this.lblUpdateTab.Name = "lblUpdateTab";
            this.lblUpdateTab.Size = new System.Drawing.Size(618, 45);
            this.lblUpdateTab.TabIndex = 13;
            this.lblUpdateTab.Text = "Mettre à jour poids soulevé d\'un Athlète";
            // 
            // btnSupDel
            // 
            this.btnSupDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSupDel.FlatAppearance.BorderSize = 0;
            this.btnSupDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupDel.ForeColor = System.Drawing.Color.White;
            this.btnSupDel.Location = new System.Drawing.Point(304, 280);
            this.btnSupDel.Name = "btnSupDel";
            this.btnSupDel.Size = new System.Drawing.Size(205, 51);
            this.btnSupDel.TabIndex = 4;
            this.btnSupDel.Text = "Supprimer";
            this.btnSupDel.UseVisualStyleBackColor = false;
            this.btnSupDel.Click += new System.EventHandler(this.btnSupDel_Click);
            // 
            // txtIDDel
            // 
            this.txtIDDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDDel.Location = new System.Drawing.Point(304, 207);
            this.txtIDDel.Name = "txtIDDel";
            this.txtIDDel.Size = new System.Drawing.Size(469, 39);
            this.txtIDDel.TabIndex = 3;
            // 
            // lblIDDel
            // 
            this.lblIDDel.AutoSize = true;
            this.lblIDDel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDDel.Location = new System.Drawing.Point(91, 208);
            this.lblIDDel.Name = "lblIDDel";
            this.lblIDDel.Size = new System.Drawing.Size(44, 38);
            this.lblIDDel.TabIndex = 2;
            this.lblIDDel.Text = "ID";
            // 
            // lblSupDel
            // 
            this.lblSupDel.AutoSize = true;
            this.lblSupDel.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSupDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblSupDel.Location = new System.Drawing.Point(83, 87);
            this.lblSupDel.Name = "lblSupDel";
            this.lblSupDel.Size = new System.Drawing.Size(361, 45);
            this.lblSupDel.TabIndex = 1;
            this.lblSupDel.Text = "Suppprimer un Athlète";
            // 
            // tabAddPoids
            // 
            this.tabAddPoids.Controls.Add(this.pbPoidsSoule);
            this.tabAddPoids.Controls.Add(this.btnIniPoid);
            this.tabAddPoids.Controls.Add(this.btnAddPoid);
            this.tabAddPoids.Controls.Add(this.txtTenta3);
            this.tabAddPoids.Controls.Add(this.lblTenta3);
            this.tabAddPoids.Controls.Add(this.txtTenta2);
            this.tabAddPoids.Controls.Add(this.txtTenta1);
            this.tabAddPoids.Controls.Add(this.lblTenta2);
            this.tabAddPoids.Controls.Add(this.lblTenta1);
            this.tabAddPoids.Controls.Add(this.txtIdPoid);
            this.tabAddPoids.Controls.Add(this.lblIdPoid);
            this.tabAddPoids.Controls.Add(this.lblPoidsEssai);
            this.tabAddPoids.Location = new System.Drawing.Point(34, 4);
            this.tabAddPoids.Name = "tabAddPoids";
            this.tabAddPoids.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddPoids.Size = new System.Drawing.Size(1398, 1183);
            this.tabAddPoids.TabIndex = 2;
            this.tabAddPoids.Text = "Poids";
            this.tabAddPoids.UseVisualStyleBackColor = true;
            // 
            // pbPoidsSoule
            // 
            this.pbPoidsSoule.Image = global::ExamenFinal_NicolasBergeron.Properties.Resources.dude;
            this.pbPoidsSoule.Location = new System.Drawing.Point(-11, 718);
            this.pbPoidsSoule.Name = "pbPoidsSoule";
            this.pbPoidsSoule.Size = new System.Drawing.Size(1422, 477);
            this.pbPoidsSoule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoidsSoule.TabIndex = 16;
            this.pbPoidsSoule.TabStop = false;
            // 
            // btnIniPoid
            // 
            this.btnIniPoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnIniPoid.FlatAppearance.BorderSize = 0;
            this.btnIniPoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniPoid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniPoid.ForeColor = System.Drawing.Color.White;
            this.btnIniPoid.Location = new System.Drawing.Point(568, 510);
            this.btnIniPoid.Name = "btnIniPoid";
            this.btnIniPoid.Size = new System.Drawing.Size(205, 51);
            this.btnIniPoid.TabIndex = 15;
            this.btnIniPoid.Text = "Initialiser";
            this.btnIniPoid.UseVisualStyleBackColor = false;
            this.btnIniPoid.Click += new System.EventHandler(this.btnIniPoid_Click);
            // 
            // btnAddPoid
            // 
            this.btnAddPoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAddPoid.FlatAppearance.BorderSize = 0;
            this.btnAddPoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPoid.ForeColor = System.Drawing.Color.White;
            this.btnAddPoid.Location = new System.Drawing.Point(304, 510);
            this.btnAddPoid.Name = "btnAddPoid";
            this.btnAddPoid.Size = new System.Drawing.Size(205, 51);
            this.btnAddPoid.TabIndex = 14;
            this.btnAddPoid.Text = "Ajouter";
            this.btnAddPoid.UseVisualStyleBackColor = false;
            this.btnAddPoid.Click += new System.EventHandler(this.btnAddPoid_Click);
            // 
            // txtTenta3
            // 
            this.txtTenta3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenta3.Location = new System.Drawing.Point(304, 411);
            this.txtTenta3.Name = "txtTenta3";
            this.txtTenta3.Size = new System.Drawing.Size(469, 39);
            this.txtTenta3.TabIndex = 13;
            // 
            // lblTenta3
            // 
            this.lblTenta3.AutoSize = true;
            this.lblTenta3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenta3.Location = new System.Drawing.Point(91, 412);
            this.lblTenta3.Name = "lblTenta3";
            this.lblTenta3.Size = new System.Drawing.Size(150, 38);
            this.lblTenta3.TabIndex = 12;
            this.lblTenta3.Text = "Tentative 3";
            // 
            // txtTenta2
            // 
            this.txtTenta2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenta2.Location = new System.Drawing.Point(304, 345);
            this.txtTenta2.Name = "txtTenta2";
            this.txtTenta2.Size = new System.Drawing.Size(469, 39);
            this.txtTenta2.TabIndex = 11;
            // 
            // txtTenta1
            // 
            this.txtTenta1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenta1.Location = new System.Drawing.Point(304, 279);
            this.txtTenta1.Name = "txtTenta1";
            this.txtTenta1.Size = new System.Drawing.Size(469, 39);
            this.txtTenta1.TabIndex = 10;
            // 
            // lblTenta2
            // 
            this.lblTenta2.AutoSize = true;
            this.lblTenta2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenta2.Location = new System.Drawing.Point(91, 346);
            this.lblTenta2.Name = "lblTenta2";
            this.lblTenta2.Size = new System.Drawing.Size(150, 38);
            this.lblTenta2.TabIndex = 9;
            this.lblTenta2.Text = "Tentative 2";
            // 
            // lblTenta1
            // 
            this.lblTenta1.AutoSize = true;
            this.lblTenta1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenta1.Location = new System.Drawing.Point(91, 280);
            this.lblTenta1.Name = "lblTenta1";
            this.lblTenta1.Size = new System.Drawing.Size(150, 38);
            this.lblTenta1.TabIndex = 8;
            this.lblTenta1.Text = "Tentative 1";
            // 
            // txtIdPoid
            // 
            this.txtIdPoid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdPoid.Location = new System.Drawing.Point(304, 207);
            this.txtIdPoid.Name = "txtIdPoid";
            this.txtIdPoid.Size = new System.Drawing.Size(469, 39);
            this.txtIdPoid.TabIndex = 7;
            // 
            // lblIdPoid
            // 
            this.lblIdPoid.AutoSize = true;
            this.lblIdPoid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdPoid.Location = new System.Drawing.Point(91, 208);
            this.lblIdPoid.Name = "lblIdPoid";
            this.lblIdPoid.Size = new System.Drawing.Size(44, 38);
            this.lblIdPoid.TabIndex = 2;
            this.lblIdPoid.Text = "ID";
            // 
            // lblPoidsEssai
            // 
            this.lblPoidsEssai.AutoSize = true;
            this.lblPoidsEssai.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPoidsEssai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblPoidsEssai.Location = new System.Drawing.Point(83, 87);
            this.lblPoidsEssai.Name = "lblPoidsEssai";
            this.lblPoidsEssai.Size = new System.Drawing.Size(401, 45);
            this.lblPoidsEssai.TabIndex = 1;
            this.lblPoidsEssai.Text = "Poids soulevé par Athlète";
            // 
            // tabPrint
            // 
            this.tabPrint.Controls.Add(this.printPb);
            this.tabPrint.Controls.Add(this.afficherAthleteDgv);
            this.tabPrint.Controls.Add(this.lblPrint);
            this.tabPrint.Location = new System.Drawing.Point(34, 4);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrint.Size = new System.Drawing.Size(1398, 1183);
            this.tabPrint.TabIndex = 3;
            this.tabPrint.Text = "Affichage";
            this.tabPrint.UseVisualStyleBackColor = true;
            // 
            // printPb
            // 
            this.printPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.printPb.Image = global::ExamenFinal_NicolasBergeron.Properties.Resources.bob2;
            this.printPb.Location = new System.Drawing.Point(-11, 718);
            this.printPb.Name = "printPb";
            this.printPb.Size = new System.Drawing.Size(1413, 556);
            this.printPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.printPb.TabIndex = 4;
            this.printPb.TabStop = false;
            // 
            // afficherAthleteDgv
            // 
            this.afficherAthleteDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.afficherAthleteDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.afficherAthleteDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afficherAthleteDgv.Location = new System.Drawing.Point(83, 200);
            this.afficherAthleteDgv.Name = "afficherAthleteDgv";
            this.afficherAthleteDgv.ReadOnly = true;
            this.afficherAthleteDgv.RowHeadersVisible = false;
            this.afficherAthleteDgv.RowHeadersWidth = 62;
            this.afficherAthleteDgv.RowTemplate.Height = 33;
            this.afficherAthleteDgv.Size = new System.Drawing.Size(1226, 294);
            this.afficherAthleteDgv.TabIndex = 3;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblPrint.Location = new System.Drawing.Point(83, 87);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(503, 45);
            this.lblPrint.TabIndex = 2;
            this.lblPrint.Text = "Affichage des athlètes par poids";
            // 
            // tabPrintHistorique
            // 
            this.tabPrintHistorique.Controls.Add(this.historiquePb);
            this.tabPrintHistorique.Controls.Add(this.affichageHistoriqueDgv);
            this.tabPrintHistorique.Controls.Add(this.lblAffichageHistorique);
            this.tabPrintHistorique.Location = new System.Drawing.Point(34, 4);
            this.tabPrintHistorique.Name = "tabPrintHistorique";
            this.tabPrintHistorique.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrintHistorique.Size = new System.Drawing.Size(1398, 1183);
            this.tabPrintHistorique.TabIndex = 4;
            this.tabPrintHistorique.Text = "Affiche historique";
            this.tabPrintHistorique.UseVisualStyleBackColor = true;
            // 
            // historiquePb
            // 
            this.historiquePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.historiquePb.Image = ((System.Drawing.Image)(resources.GetObject("historiquePb.Image")));
            this.historiquePb.Location = new System.Drawing.Point(-11, 718);
            this.historiquePb.Name = "historiquePb";
            this.historiquePb.Size = new System.Drawing.Size(1413, 608);
            this.historiquePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.historiquePb.TabIndex = 5;
            this.historiquePb.TabStop = false;
            // 
            // affichageHistoriqueDgv
            // 
            this.affichageHistoriqueDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.affichageHistoriqueDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.affichageHistoriqueDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.affichageHistoriqueDgv.Location = new System.Drawing.Point(83, 200);
            this.affichageHistoriqueDgv.Name = "affichageHistoriqueDgv";
            this.affichageHistoriqueDgv.ReadOnly = true;
            this.affichageHistoriqueDgv.RowHeadersVisible = false;
            this.affichageHistoriqueDgv.RowHeadersWidth = 62;
            this.affichageHistoriqueDgv.RowTemplate.Height = 33;
            this.affichageHistoriqueDgv.Size = new System.Drawing.Size(1226, 294);
            this.affichageHistoriqueDgv.TabIndex = 4;
            // 
            // lblAffichageHistorique
            // 
            this.lblAffichageHistorique.AutoSize = true;
            this.lblAffichageHistorique.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAffichageHistorique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblAffichageHistorique.Location = new System.Drawing.Point(83, 87);
            this.lblAffichageHistorique.Name = "lblAffichageHistorique";
            this.lblAffichageHistorique.Size = new System.Drawing.Size(805, 45);
            this.lblAffichageHistorique.TabIndex = 1;
            this.lblAffichageHistorique.Text = "Affichage Historique des poids soulever des Athlètes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnAddPoids);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.pbMainLogo);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnPrintHistorique);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 1176);
            this.panel1.TabIndex = 1;
            // 
            // btnAddPoids
            // 
            this.btnAddPoids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAddPoids.FlatAppearance.BorderSize = 0;
            this.btnAddPoids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoids.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPoids.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddPoids.Location = new System.Drawing.Point(3, 284);
            this.btnAddPoids.Name = "btnAddPoids";
            this.btnAddPoids.Size = new System.Drawing.Size(449, 60);
            this.btnAddPoids.TabIndex = 10;
            this.btnAddPoids.Text = "Ajouter poids Soulevé";
            this.btnAddPoids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPoids.UseVisualStyleBackColor = false;
            this.btnAddPoids.Click += new System.EventHandler(this.btnAddPoids_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.lblLogo.Location = new System.Drawing.Point(89, 91);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(335, 45);
            this.lblLogo.TabIndex = 9;
            this.lblLogo.Text = "Haltérophilie Canada";
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMainLogo.Image = global::ExamenFinal_NicolasBergeron.Properties.Resources.log;
            this.pbMainLogo.Location = new System.Drawing.Point(-3, 61);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(97, 106);
            this.pbMainLogo.TabIndex = 8;
            this.pbMainLogo.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuit.Location = new System.Drawing.Point(-3, 1113);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(455, 60);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPrintHistorique
            // 
            this.btnPrintHistorique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnPrintHistorique.FlatAppearance.BorderSize = 0;
            this.btnPrintHistorique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintHistorique.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintHistorique.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrintHistorique.Location = new System.Drawing.Point(0, 482);
            this.btnPrintHistorique.Name = "btnPrintHistorique";
            this.btnPrintHistorique.Size = new System.Drawing.Size(452, 60);
            this.btnPrintHistorique.TabIndex = 6;
            this.btnPrintHistorique.Text = "Afficher Historique";
            this.btnPrintHistorique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintHistorique.UseVisualStyleBackColor = false;
            this.btnPrintHistorique.Click += new System.EventHandler(this.btnPrintHistorique_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(3, 416);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(449, 60);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Afficher la liste athlètes (poids)";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDel.Location = new System.Drawing.Point(3, 350);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(449, 60);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Supprimer/MIse à jour Athlète";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(0, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(452, 60);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter Athlète";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 1170);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haltérophilie Canada";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tcMain.ResumeLayout(false);
            this.tabAjouter.ResumeLayout(false);
            this.tabAjouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.tabDel.ResumeLayout(false);
            this.tabDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelUp)).EndInit();
            this.tabAddPoids.ResumeLayout(false);
            this.tabAddPoids.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoidsSoule)).EndInit();
            this.tabPrint.ResumeLayout(false);
            this.tabPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficherAthleteDgv)).EndInit();
            this.tabPrintHistorique.ResumeLayout(false);
            this.tabPrintHistorique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiquePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affichageHistoriqueDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcMain;
        private TabPage tabAjouter;
        private TabPage tabDel;
        private Panel panel1;
        private TabPage tabAddPoids;
        private TabPage tabPrint;
        private TabPage tabPrintHistorique;
        private Button btnQuit;
        private Button btnPrintHistorique;
        private Button btnPrint;
        private Button btnDel;
        private Button btnAdd;
        private PictureBox pbMainLogo;
        private Label lblLogo;
        private Label lblPaysAthlete;
        private Label lblPrenomAthlete;
        private Label lblNomAthlete;
        private Label lblIDAthlete;
        private Label lblAthleteInfo;
        private PictureBox pbAdd;
        private PillButton btnInitialiserAdd;
        private PillButton btnAddAthlete;
        private TextBox txtIDAdd;
        private TextBox txtNameAdd;
        private TextBox txtPrenomAdd;
        private TextBox txtPaysAdd;
        private PictureBox pbDelUp;
        private PillButton btnInitialiseUpdate;
        private PillButton btnInitialiserDel;
        private PillButton btnUpdateAthlete;
        private TextBox txtIDUpdate;
        private Label lblIDTUpdate;
        private Label lblUpdateTab;
        private PillButton btnSupDel;
        private TextBox txtIDDel;
        private Label lblIDDel;
        private Label lblSupDel;
        private Label lblPrint;
        private Label lblTentaUpdate1;
        private TextBox txtTentaUpdate1;
        private Button btnAddPoids;
        private TextBox txtTentaUpdate3;
        private TextBox txtTentaUpdate2;
        private Label lblTentaUpdate3;
        private Label lblTentaUpdate2;
        private PictureBox pbPoidsSoule;
        private PillButton btnIniPoid;
        private PillButton btnAddPoid;
        private TextBox txtTenta3;
        private Label lblTenta3;
        private TextBox txtTenta2;
        private TextBox txtTenta1;
        private Label lblTenta2;
        private Label lblTenta1;
        private TextBox txtIdPoid;
        private Label lblIdPoid;
        private Label lblPoidsEssai;
        private DataGridView afficherAthleteDgv;
        private DataGridView affichageHistoriqueDgv;
        private Label lblAffichageHistorique;
        private PictureBox printPb;
        private PictureBox historiquePb;
    }
}