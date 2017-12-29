namespace Fire_FM_Parse_Calculator
{
    partial class FireFmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireFmForm));
            this.calculate = new System.Windows.Forms.Button();
            this.sfCount = new System.Windows.Forms.TextBox();
            this.sfLabel = new System.Windows.Forms.Label();
            this.impCount = new System.Windows.Forms.TextBox();
            this.impLabel = new System.Windows.Forms.Label();
            this.dbCount = new System.Windows.Forms.TextBox();
            this.dbLabel = new System.Windows.Forms.Label();
            this.ddCount = new System.Windows.Forms.TextBox();
            this.ddLabel = new System.Windows.Forms.Label();
            this.fpCount = new System.Windows.Forms.TextBox();
            this.fpLabel = new System.Windows.Forms.Label();
            this.bpCount = new System.Windows.Forms.TextBox();
            this.bpLabel = new System.Windows.Forms.Label();
            this.msCount = new System.Windows.Forms.TextBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.infCount = new System.Windows.Forms.TextBox();
            this.infLabel = new System.Windows.Forms.Label();
            this.bbCount = new System.Windows.Forms.TextBox();
            this.bbLabel = new System.Windows.Forms.Label();
            this.secsLabel = new System.Windows.Forms.Label();
            this.timeSecs = new System.Windows.Forms.TextBox();
            this.minsLabel = new System.Windows.Forms.Label();
            this.timeMins = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.saLabel = new System.Windows.Forms.Label();
            this.saCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(61, 523);
            this.calculate.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(115, 34);
            this.calculate.TabIndex = 25;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // sfCount
            // 
            this.sfCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfCount.Location = new System.Drawing.Point(196, 481);
            this.sfCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.sfCount.Name = "sfCount";
            this.sfCount.Size = new System.Drawing.Size(84, 22);
            this.sfCount.TabIndex = 24;
            this.sfCount.Text = "0";
            this.sfCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // sfLabel
            // 
            this.sfLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfLabel.AutoSize = true;
            this.sfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfLabel.Location = new System.Drawing.Point(68, 481);
            this.sfLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.sfLabel.Name = "sfLabel";
            this.sfLabel.Size = new System.Drawing.Size(108, 25);
            this.sfLabel.TabIndex = 23;
            this.sfLabel.Text = "Short Fuse";
            // 
            // impCount
            // 
            this.impCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.impCount.Location = new System.Drawing.Point(196, 439);
            this.impCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.impCount.Name = "impCount";
            this.impCount.Size = new System.Drawing.Size(84, 22);
            this.impCount.TabIndex = 22;
            this.impCount.Text = "0";
            this.impCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // impLabel
            // 
            this.impLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.impLabel.AutoSize = true;
            this.impLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impLabel.Location = new System.Drawing.Point(106, 439);
            this.impLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.impLabel.Name = "impLabel";
            this.impLabel.Size = new System.Drawing.Size(70, 25);
            this.impLabel.TabIndex = 21;
            this.impLabel.Text = "Impact";
            // 
            // dbCount
            // 
            this.dbCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbCount.Location = new System.Drawing.Point(196, 397);
            this.dbCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.dbCount.Name = "dbCount";
            this.dbCount.Size = new System.Drawing.Size(84, 22);
            this.dbCount.TabIndex = 20;
            this.dbCount.Text = "0";
            this.dbCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // dbLabel
            // 
            this.dbLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbLabel.AutoSize = true;
            this.dbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLabel.Location = new System.Drawing.Point(53, 397);
            this.dbLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(123, 25);
            this.dbLabel.TabIndex = 19;
            this.dbLabel.Text = "Dragonblaze";
            // 
            // ddCount
            // 
            this.ddCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddCount.Location = new System.Drawing.Point(196, 355);
            this.ddCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.ddCount.Name = "ddCount";
            this.ddCount.Size = new System.Drawing.Size(84, 22);
            this.ddCount.TabIndex = 18;
            this.ddCount.Text = "0";
            this.ddCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // ddLabel
            // 
            this.ddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddLabel.AutoSize = true;
            this.ddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLabel.Location = new System.Drawing.Point(45, 355);
            this.ddLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.ddLabel.Name = "ddLabel";
            this.ddLabel.Size = new System.Drawing.Size(131, 25);
            this.ddLabel.TabIndex = 17;
            this.ddLabel.Text = "Dual Dragons";
            // 
            // fpCount
            // 
            this.fpCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpCount.Location = new System.Drawing.Point(196, 313);
            this.fpCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.fpCount.Name = "fpCount";
            this.fpCount.Size = new System.Drawing.Size(84, 22);
            this.fpCount.TabIndex = 16;
            this.fpCount.Text = "0";
            this.fpCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // fpLabel
            // 
            this.fpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpLabel.AutoSize = true;
            this.fpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpLabel.Location = new System.Drawing.Point(71, 313);
            this.fpLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(105, 25);
            this.fpLabel.TabIndex = 15;
            this.fpLabel.Text = "Frost Palm";
            // 
            // bpCount
            // 
            this.bpCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bpCount.Location = new System.Drawing.Point(196, 271);
            this.bpCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.bpCount.Name = "bpCount";
            this.bpCount.Size = new System.Drawing.Size(84, 22);
            this.bpCount.TabIndex = 14;
            this.bpCount.Text = "0";
            this.bpCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // bpLabel
            // 
            this.bpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bpLabel.AutoSize = true;
            this.bpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpLabel.Location = new System.Drawing.Point(51, 271);
            this.bpLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.bpLabel.Name = "bpLabel";
            this.bpLabel.Size = new System.Drawing.Size(125, 25);
            this.bpLabel.TabIndex = 13;
            this.bpLabel.Text = "Blazing Palm";
            // 
            // msCount
            // 
            this.msCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msCount.Location = new System.Drawing.Point(196, 229);
            this.msCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.msCount.Name = "msCount";
            this.msCount.Size = new System.Drawing.Size(84, 22);
            this.msCount.TabIndex = 12;
            this.msCount.Text = "0";
            this.msCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // msLabel
            // 
            this.msLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msLabel.AutoSize = true;
            this.msLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msLabel.Location = new System.Drawing.Point(31, 229);
            this.msLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(145, 25);
            this.msLabel.TabIndex = 11;
            this.msLabel.Text = "Meteor Shower";
            // 
            // infCount
            // 
            this.infCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infCount.Location = new System.Drawing.Point(196, 145);
            this.infCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.infCount.Name = "infCount";
            this.infCount.Size = new System.Drawing.Size(84, 22);
            this.infCount.TabIndex = 8;
            this.infCount.Text = "0";
            this.infCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // infLabel
            // 
            this.infLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infLabel.AutoSize = true;
            this.infLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infLabel.Location = new System.Drawing.Point(104, 145);
            this.infLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.infLabel.Name = "infLabel";
            this.infLabel.Size = new System.Drawing.Size(72, 25);
            this.infLabel.TabIndex = 7;
            this.infLabel.Text = "Inferno";
            // 
            // bbCount
            // 
            this.bbCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bbCount.Location = new System.Drawing.Point(196, 103);
            this.bbCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.bbCount.Name = "bbCount";
            this.bbCount.Size = new System.Drawing.Size(84, 22);
            this.bbCount.TabIndex = 6;
            this.bbCount.Text = "0";
            this.bbCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // bbLabel
            // 
            this.bbLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bbLabel.AutoSize = true;
            this.bbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbLabel.Location = new System.Drawing.Point(45, 103);
            this.bbLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.bbLabel.Name = "bbLabel";
            this.bbLabel.Size = new System.Drawing.Size(132, 25);
            this.bbLabel.TabIndex = 5;
            this.bbLabel.Text = "Blazing Beam";
            // 
            // secsLabel
            // 
            this.secsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secsLabel.AutoSize = true;
            this.secsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secsLabel.Location = new System.Drawing.Point(284, 59);
            this.secsLabel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.secsLabel.Name = "secsLabel";
            this.secsLabel.Size = new System.Drawing.Size(72, 20);
            this.secsLabel.TabIndex = 4;
            this.secsLabel.Text = "seconds";
            // 
            // timeSecs
            // 
            this.timeSecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSecs.Location = new System.Drawing.Point(196, 61);
            this.timeSecs.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.timeSecs.Name = "timeSecs";
            this.timeSecs.Size = new System.Drawing.Size(84, 22);
            this.timeSecs.TabIndex = 3;
            this.timeSecs.Text = "0";
            this.timeSecs.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // minsLabel
            // 
            this.minsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minsLabel.AutoSize = true;
            this.minsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minsLabel.Location = new System.Drawing.Point(288, 19);
            this.minsLabel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.minsLabel.Name = "minsLabel";
            this.minsLabel.Size = new System.Drawing.Size(68, 20);
            this.minsLabel.TabIndex = 2;
            this.minsLabel.Text = "minutes";
            // 
            // timeMins
            // 
            this.timeMins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeMins.Location = new System.Drawing.Point(196, 19);
            this.timeMins.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.timeMins.Name = "timeMins";
            this.timeMins.Size = new System.Drawing.Size(84, 22);
            this.timeMins.TabIndex = 1;
            this.timeMins.Text = "0";
            this.timeMins.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(121, 19);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(56, 25);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time";
            // 
            // saLabel
            // 
            this.saLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saLabel.AutoSize = true;
            this.saLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saLabel.Location = new System.Drawing.Point(14, 187);
            this.saLabel.Margin = new System.Windows.Forms.Padding(0, 8, 20, 9);
            this.saLabel.Name = "saLabel";
            this.saLabel.Size = new System.Drawing.Size(162, 25);
            this.saLabel.TabIndex = 9;
            this.saLabel.Text = "Smouldering Ash";
            // 
            // saCount
            // 
            this.saCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saCount.Location = new System.Drawing.Point(196, 187);
            this.saCount.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.saCount.Name = "saCount";
            this.saCount.Size = new System.Drawing.Size(84, 22);
            this.saCount.TabIndex = 10;
            this.saCount.Text = "0";
            this.saCount.Enter += new System.EventHandler(this.textbox_OnFocus);
            // 
            // FireFmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(375, 572);
            this.Controls.Add(this.saLabel);
            this.Controls.Add(this.saCount);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeMins);
            this.Controls.Add(this.minsLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.timeSecs);
            this.Controls.Add(this.sfCount);
            this.Controls.Add(this.secsLabel);
            this.Controls.Add(this.sfLabel);
            this.Controls.Add(this.bbLabel);
            this.Controls.Add(this.impCount);
            this.Controls.Add(this.bbCount);
            this.Controls.Add(this.impLabel);
            this.Controls.Add(this.infLabel);
            this.Controls.Add(this.dbCount);
            this.Controls.Add(this.infCount);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.ddCount);
            this.Controls.Add(this.msCount);
            this.Controls.Add(this.ddLabel);
            this.Controls.Add(this.bpLabel);
            this.Controls.Add(this.fpCount);
            this.Controls.Add(this.bpCount);
            this.Controls.Add(this.fpLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(393, 580);
            this.Name = "FireFmForm";
            this.Text = "Fire FM Parse Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox sfCount;
        private System.Windows.Forms.Label sfLabel;
        private System.Windows.Forms.TextBox impCount;
        private System.Windows.Forms.Label impLabel;
        private System.Windows.Forms.TextBox dbCount;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.TextBox ddCount;
        private System.Windows.Forms.Label ddLabel;
        private System.Windows.Forms.TextBox fpCount;
        private System.Windows.Forms.Label fpLabel;
        private System.Windows.Forms.TextBox bpCount;
        private System.Windows.Forms.Label bpLabel;
        private System.Windows.Forms.TextBox msCount;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.TextBox infCount;
        private System.Windows.Forms.Label infLabel;
        private System.Windows.Forms.TextBox bbCount;
        private System.Windows.Forms.Label bbLabel;
        private System.Windows.Forms.Label secsLabel;
        private System.Windows.Forms.TextBox timeSecs;
        private System.Windows.Forms.Label minsLabel;
        private System.Windows.Forms.TextBox timeMins;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label saLabel;
        private System.Windows.Forms.TextBox saCount;
    }
}

