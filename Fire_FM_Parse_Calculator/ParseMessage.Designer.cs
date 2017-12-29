namespace Fire_FM_Parse_Calculator
{
    partial class ParseMessage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.parseCounts = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.parseCounts);
            this.flowLayoutPanel1.Controls.Add(this.copy);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(123, 112);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // parseCounts
            // 
            this.parseCounts.AutoSize = true;
            this.parseCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parseCounts.Location = new System.Drawing.Point(15, 15);
            this.parseCounts.Margin = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.parseCounts.Name = "parseCounts";
            this.parseCounts.Size = new System.Drawing.Size(60, 24);
            this.parseCounts.TabIndex = 0;
            this.parseCounts.Text = "label1";
            // 
            // copy
            // 
            this.copy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(15, 59);
            this.copy.Margin = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(60, 33);
            this.copy.TabIndex = 1;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // ParseMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(148, 127);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParseMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Parse Count";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label parseCounts;
        private System.Windows.Forms.Button copy;
    }
}