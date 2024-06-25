namespace RDP
{
    partial class RDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDC));
            this.axMsRdpClient8NotSafeForScripting1 = new AxMSTSCLib.AxMsRdpClient8NotSafeForScripting();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.bt00 = new System.Windows.Forms.Button();
            this.PnlSuperior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient8NotSafeForScripting1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMsRdpClient8NotSafeForScripting1
            // 
            this.axMsRdpClient8NotSafeForScripting1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMsRdpClient8NotSafeForScripting1.Enabled = true;
            this.axMsRdpClient8NotSafeForScripting1.Location = new System.Drawing.Point(-28, -38);
            this.axMsRdpClient8NotSafeForScripting1.Name = "axMsRdpClient8NotSafeForScripting1";
            this.axMsRdpClient8NotSafeForScripting1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsRdpClient8NotSafeForScripting1.OcxState")));
            this.axMsRdpClient8NotSafeForScripting1.Size = new System.Drawing.Size(1371, 768);
            this.axMsRdpClient8NotSafeForScripting1.TabIndex = 0;
            this.axMsRdpClient8NotSafeForScripting1.OnConnecting += new System.EventHandler(this.axMsRdpClient8NotSafeForScripting1_OnConnecting);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1174, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(1265, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // bt00
            // 
            this.bt00.Location = new System.Drawing.Point(-3, 12);
            this.bt00.Name = "bt00";
            this.bt00.Size = new System.Drawing.Size(75, 23);
            this.bt00.TabIndex = 3;
            this.bt00.Text = "tetetes";
            this.bt00.UseVisualStyleBackColor = true;
            this.bt00.Click += new System.EventHandler(this.bt00_Click);
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlSuperior.Location = new System.Drawing.Point(-3, -4);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(1356, 16);
            this.PnlSuperior.TabIndex = 4;
            this.PnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSuperior_Paint);
            this.PnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseDown);
            // 
            // RDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.PnlSuperior);
            this.Controls.Add(this.bt00);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.axMsRdpClient8NotSafeForScripting1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RDC";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient8NotSafeForScripting1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private AxMSTSCLib.AxMsRdpClient8NotSafeForScripting axMsRdpClient8NotSafeForScripting1;
        private System.Windows.Forms.Button bt00;
        private System.Windows.Forms.Panel PnlSuperior;
    }
}

