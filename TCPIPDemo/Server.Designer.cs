namespace TCPIPDemo
{
    partial class Server
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
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtStatusServer = new System.Windows.Forms.TextBox();
            this.PanelDrawingServer = new System.Windows.Forms.Panel();
            this.txtMessageServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(47, 25);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 17;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(202, 26);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(60, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8000";
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(301, 24);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(75, 23);
            this.btnStar.TabIndex = 6;
            this.btnStar.Text = "Start";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(400, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtStatusServer
            // 
            this.txtStatusServer.Location = new System.Drawing.Point(47, 71);
            this.txtStatusServer.Multiline = true;
            this.txtStatusServer.Name = "txtStatusServer";
            this.txtStatusServer.Size = new System.Drawing.Size(396, 47);
            this.txtStatusServer.TabIndex = 8;
            // 
            // PanelDrawingServer
            // 
            this.PanelDrawingServer.BackColor = System.Drawing.SystemColors.Window;
            this.PanelDrawingServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelDrawingServer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PanelDrawingServer.Location = new System.Drawing.Point(47, 142);
            this.PanelDrawingServer.Name = "PanelDrawingServer";
            this.PanelDrawingServer.Size = new System.Drawing.Size(396, 307);
            this.PanelDrawingServer.TabIndex = 16;
            // 
            // txtMessageServer
            // 
            this.txtMessageServer.Location = new System.Drawing.Point(459, 71);
            this.txtMessageServer.Multiline = true;
            this.txtMessageServer.Name = "txtMessageServer";
            this.txtMessageServer.Size = new System.Drawing.Size(155, 47);
            this.txtMessageServer.TabIndex = 18;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 532);
            this.Controls.Add(this.txtMessageServer);
            this.Controls.Add(this.PanelDrawingServer);
            this.Controls.Add(this.txtStatusServer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtStatusServer;
        private System.Windows.Forms.Panel PanelDrawingServer;
        private System.Windows.Forms.TextBox txtMessageServer;
    }
}

