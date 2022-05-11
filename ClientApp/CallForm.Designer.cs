namespace ClientApp
{
    partial class CallForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(532, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect Voice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serviceNameLabel.Location = new System.Drawing.Point(178, 77);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(128, 32);
            this.serviceNameLabel.TabIndex = 3;
            this.serviceNameLabel.Text = "Reception";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.White;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(80, 249);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(550, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(476, 64);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Call us for bookings, assistance and business proposals within the network.";
            this.descriptionLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "IP:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(135, 378);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(107, 32);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "192.0.0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(424, 378);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(66, 32);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "8000";
            this.portLabel.Click += new System.EventHandler(this.portLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(191, 497);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(169, 32);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Disconnected";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 825);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CallForm";
            this.Text = "CallForm";
            this.Load += new System.EventHandler(this.CallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label serviceNameLabel;
        private Label descriptionLabel;
        private Label label4;
        private Label ipLabel;
        private Label label6;
        private Label portLabel;
        private Label label3;
        public Label statusLabel;
        private System.Windows.Forms.Timer timer1;
    }
}