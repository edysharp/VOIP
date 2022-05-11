namespace ClientApp
{
    partial class AddServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hostServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Of Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(337, 87);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(381, 39);
            this.serviceNameTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(337, 158);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(381, 39);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(132, 244);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(280, 39);
            this.ipTextBox.TabIndex = 4;
            this.ipTextBox.Text = Program.GetIPAddress();
            this.ipTextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(534, 247);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(184, 39);
            this.portTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port:";
            // 
            // hostServiceButton
            // 
            this.hostServiceButton.Location = new System.Drawing.Point(81, 341);
            this.hostServiceButton.Name = "hostServiceButton";
            this.hostServiceButton.Size = new System.Drawing.Size(637, 62);
            this.hostServiceButton.TabIndex = 8;
            this.hostServiceButton.Text = "Host Service";
            this.hostServiceButton.UseVisualStyleBackColor = true;
            this.hostServiceButton.Click += new System.EventHandler(this.hostServiceButton_Click);
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.hostServiceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddServiceForm";
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox serviceNameTextBox;
        private TextBox descriptionTextBox;
        private TextBox ipTextBox;
        private TextBox portTextBox;
        private Label label3;
        private Label label4;
        private Button hostServiceButton;
    }
}