namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHostClient = new System.Windows.Forms.TextBox();
            this.txtMessageClient = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtStatusClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnColor = new System.Windows.Forms.Button();
            this.PanelDrawingClient = new System.Windows.Forms.Panel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PenDraw = new System.Windows.Forms.PictureBox();
            this.Eraser = new System.Windows.Forms.PictureBox();
            this.txtMsgOld = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eraser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(301, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port :";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(208, 37);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(60, 20);
            this.txtPortClient.TabIndex = 9;
            this.txtPortClient.Text = "8000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Host :";
            // 
            // txtHostClient
            // 
            this.txtHostClient.Location = new System.Drawing.Point(53, 37);
            this.txtHostClient.Name = "txtHostClient";
            this.txtHostClient.Size = new System.Drawing.Size(100, 20);
            this.txtHostClient.TabIndex = 7;
            this.txtHostClient.Text = "127.0.0.1";
            // 
            // txtMessageClient
            // 
            this.txtMessageClient.Location = new System.Drawing.Point(15, 64);
            this.txtMessageClient.Multiline = true;
            this.txtMessageClient.Name = "txtMessageClient";
            this.txtMessageClient.Size = new System.Drawing.Size(396, 37);
            this.txtMessageClient.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(53, 107);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtStatusClient
            // 
            this.txtStatusClient.Location = new System.Drawing.Point(436, 26);
            this.txtStatusClient.Multiline = true;
            this.txtStatusClient.Name = "txtStatusClient";
            this.txtStatusClient.Size = new System.Drawing.Size(135, 104);
            this.txtStatusClient.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Width";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(436, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 49);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(436, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 126);
            this.panel2.TabIndex = 17;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(13, 100);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 77);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 54);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(436, 149);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(68, 48);
            this.btnColor.TabIndex = 16;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // PanelDrawingClient
            // 
            this.PanelDrawingClient.BackColor = System.Drawing.SystemColors.Window;
            this.PanelDrawingClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelDrawingClient.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PanelDrawingClient.Location = new System.Drawing.Point(15, 136);
            this.PanelDrawingClient.Name = "PanelDrawingClient";
            this.PanelDrawingClient.Size = new System.Drawing.Size(396, 307);
            this.PanelDrawingClient.TabIndex = 15;
            this.PanelDrawingClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDrawing_MouseDown);
            this.PanelDrawingClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDrawing_MouseMove);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Aide";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem1,
            this.ouvrirToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem1
            // 
            this.enregistrerToolStripMenuItem1.Name = "enregistrerToolStripMenuItem1";
            this.enregistrerToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem1.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem1.Click += new System.EventHandler(this.enregistrerToolStripMenuItem1_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quiterToolStripMenuItem.Text = "Quiter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PenDraw
            // 
            this.PenDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PenDraw.Image = ((System.Drawing.Image)(resources.GetObject("PenDraw.Image")));
            this.PenDraw.InitialImage = ((System.Drawing.Image)(resources.GetObject("PenDraw.InitialImage")));
            this.PenDraw.Location = new System.Drawing.Point(525, 226);
            this.PenDraw.Name = "PenDraw";
            this.PenDraw.Size = new System.Drawing.Size(66, 72);
            this.PenDraw.TabIndex = 22;
            this.PenDraw.TabStop = false;
            this.PenDraw.Click += new System.EventHandler(this.PenDraw_Click);
            // 
            // Eraser
            // 
            this.Eraser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
            this.Eraser.InitialImage = ((System.Drawing.Image)(resources.GetObject("Eraser.InitialImage")));
            this.Eraser.Location = new System.Drawing.Point(525, 149);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(56, 48);
            this.Eraser.TabIndex = 23;
            this.Eraser.TabStop = false;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // txtMsgOld
            // 
            this.txtMsgOld.Location = new System.Drawing.Point(170, 107);
            this.txtMsgOld.Multiline = true;
            this.txtMsgOld.Name = "txtMsgOld";
            this.txtMsgOld.Size = new System.Drawing.Size(206, 23);
            this.txtMsgOld.TabIndex = 24;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 456);
            this.Controls.Add(this.txtMsgOld);
            this.Controls.Add(this.Eraser);
            this.Controls.Add(this.PenDraw);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.PanelDrawingClient);
            this.Controls.Add(this.txtStatusClient);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageClient);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHostClient);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eraser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHostClient;
        private System.Windows.Forms.TextBox txtMessageClient;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtStatusClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel PanelDrawingClient;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox PenDraw;
        private System.Windows.Forms.PictureBox Eraser;
        private System.Windows.Forms.TextBox txtMsgOld;
    }
}

