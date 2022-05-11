namespace ClientApp
{
    partial class ServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopServiceButton = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.serviceText = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.incomingCallsListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.audiConnectedLabel = new System.Windows.Forms.Label();
            this.endCallButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // stopServiceButton
            // 
            this.stopServiceButton.Location = new System.Drawing.Point(56, 650);
            this.stopServiceButton.Name = "stopServiceButton";
            this.stopServiceButton.Size = new System.Drawing.Size(633, 81);
            this.stopServiceButton.TabIndex = 4;
            this.stopServiceButton.Text = "Stop Service";
            this.stopServiceButton.UseVisualStyleBackColor = true;
            this.stopServiceButton.Click += new System.EventHandler(this.stopServiceButton_Click);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusText.Location = new System.Drawing.Point(180, 52);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(169, 32);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "Disconnected";
            // 
            // serviceText
            // 
            this.serviceText.AutoSize = true;
            this.serviceText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serviceText.Location = new System.Drawing.Point(507, 52);
            this.serviceText.Name = "serviceText";
            this.serviceText.Size = new System.Drawing.Size(128, 32);
            this.serviceText.TabIndex = 6;
            this.serviceText.Text = "Reception";
            // 
            // ipText
            // 
            this.ipText.AutoSize = true;
            this.ipText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ipText.Location = new System.Drawing.Point(133, 120);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(119, 32);
            this.ipText.TabIndex = 7;
            this.ipText.Text = "127.0.0.1";
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portText.Location = new System.Drawing.Point(473, 120);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(70, 32);
            this.portText.TabIndex = 8;
            this.portText.Text = "8080";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Incoming Calls:";
            // 
            // incomingCallsListBox
            // 
            this.incomingCallsListBox.FormattingEnabled = true;
            this.incomingCallsListBox.ItemHeight = 32;
            this.incomingCallsListBox.Location = new System.Drawing.Point(75, 273);
            this.incomingCallsListBox.Name = "incomingCallsListBox";
            this.incomingCallsListBox.Size = new System.Drawing.Size(590, 228);
            this.incomingCallsListBox.TabIndex = 11;
            this.incomingCallsListBox.SelectedIndexChanged += new System.EventHandler(this.incomingCallsListBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // audiConnectedLabel
            // 
            this.audiConnectedLabel.AutoSize = true;
            this.audiConnectedLabel.Location = new System.Drawing.Point(89, 538);
            this.audiConnectedLabel.Name = "audiConnectedLabel";
            this.audiConnectedLabel.Size = new System.Drawing.Size(240, 32);
            this.audiConnectedLabel.TabIndex = 12;
            this.audiConnectedLabel.Text = "🔊 Audio Connected";
            this.audiConnectedLabel.Click += new System.EventHandler(this.audiConnectedLabel_Click);
            audiConnectedLabel.Hide();
            // 
            // endCallButton
            // 
            this.endCallButton.Location = new System.Drawing.Point(366, 538);
            this.endCallButton.Name = "endCallButton";
            this.endCallButton.Size = new System.Drawing.Size(299, 46);
            this.endCallButton.TabIndex = 13;
            this.endCallButton.Text = "End Call";
            this.endCallButton.UseVisualStyleBackColor = true;
            this.endCallButton.Click += new System.EventHandler(this.endCallButton_Click);

            endCallButton.Hide();
            
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 818);
            this.Controls.Add(this.endCallButton);
            this.Controls.Add(this.audiConnectedLabel);
            this.Controls.Add(this.incomingCallsListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.serviceText);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.stopServiceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button stopServiceButton;
        private Label statusText;
        private Label serviceText;
        private Label ipText;
        private Label portText;
        private BindingSource bindingSource1;
        private Label label5;
        private ListBox incomingCallsListBox;
        private System.Windows.Forms.Timer timer1;
        private Label audiConnectedLabel;
        private Button endCallButton;
    }
}