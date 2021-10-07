
namespace Amoba_Bodnar_Tesok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Name2 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Első játékos neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Második játékos neve:";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(191, 33);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(100, 20);
            this.Name1.TabIndex = 2;
            // 
            // Name2
            // 
            this.Name2.Location = new System.Drawing.Point(191, 66);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(100, 20);
            this.Name2.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(332, 33);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(118, 46);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Amőba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Name2;
        private System.Windows.Forms.Button Start;
    }
}

