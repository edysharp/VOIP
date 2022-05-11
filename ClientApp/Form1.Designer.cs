namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addService = new System.Windows.Forms.Button();
            this.servicePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(379, 495);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(349, 80);
            this.addService.TabIndex = 0;
            this.addService.Text = "Add Service";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // servicePanel
            // 
            this.servicePanel.BackColor = System.Drawing.Color.White;
            this.servicePanel.Location = new System.Drawing.Point(58, 89);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(670, 383);
            this.servicePanel.TabIndex = 1;
            this.servicePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.servicePanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a service to call:";
            // 
            // refreshServices
            // 
            this.refreshServices.Location = new System.Drawing.Point(58, 495);
            this.refreshServices.Name = "refreshServices";
            this.refreshServices.Size = new System.Drawing.Size(315, 80);
            this.refreshServices.TabIndex = 3;
            this.refreshServices.Text = "Refresh";
            this.refreshServices.UseVisualStyleBackColor = true;
            this.refreshServices.Click += new System.EventHandler(this.refreshServices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.refreshServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicePanel);
            this.Controls.Add(this.addService);
            this.Name = "Form1";
            this.Text = "VOI CALL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addService;
        private FlowLayoutPanel servicePanel;
        private Label label1;
        private Button refreshServices;
    }
}