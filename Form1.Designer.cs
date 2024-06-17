namespace CSharp_PTbac2
{
    partial class Form1
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
            this.btngiaipt = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbkq = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btngiaipt
            // 
            this.btngiaipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btngiaipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiaipt.Location = new System.Drawing.Point(255, 291);
            this.btngiaipt.Name = "btngiaipt";
            this.btngiaipt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btngiaipt.Size = new System.Drawing.Size(206, 71);
            this.btngiaipt.TabIndex = 0;
            this.btngiaipt.Text = "GIẢI PHƯƠNG TRÌNH";
            this.btngiaipt.UseVisualStyleBackColor = true;
            this.btngiaipt.Click += new System.EventHandler(this.btngiaipt_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(15, 108);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(42, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Nhập a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(81, 105);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 2;
            this.txta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(81, 172);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 4;
            this.txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(15, 175);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(42, 13);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "Nhập b";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(81, 240);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 6;
            this.txtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(15, 243);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(42, 13);
            this.lblc.TabIndex = 5;
            this.lblc.Text = "Nhập c";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(199, 105);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(398, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(199, 240);
            this.trackBar3.Minimum = -10;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(398, 45);
            this.trackBar3.TabIndex = 9;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(199, 172);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(398, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(145, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lsbkq
            // 
            this.lsbkq.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lsbkq.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lsbkq.FormattingEnabled = true;
            this.lsbkq.Location = new System.Drawing.Point(18, 368);
            this.lsbkq.Name = "lsbkq";
            this.lsbkq.Size = new System.Drawing.Size(623, 160);
            this.lsbkq.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "KẾT QUẢ";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(41, 403);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(158, 15);
            this.lblkq.TabIndex = 15;
            this.lblkq.Text = "Hãy bấm Giải Phương Trình";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(658, 559);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbkq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btngiaipt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiaipt;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbkq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkq;
    }
}

