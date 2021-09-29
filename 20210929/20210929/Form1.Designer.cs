namespace _20210929
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
            this.lblevszak = new System.Windows.Forms.Label();
            this.txbhonapszama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.szamol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem a hónap számát";
            // 
            // lblevszak
            // 
            this.lblevszak.AutoSize = true;
            this.lblevszak.Location = new System.Drawing.Point(93, 69);
            this.lblevszak.Name = "lblevszak";
            this.lblevszak.Size = new System.Drawing.Size(35, 13);
            this.lblevszak.TabIndex = 1;
            this.lblevszak.Text = "label2";
            this.lblevszak.Visible = false;
            // 
            // txbhonapszama
            // 
            this.txbhonapszama.Location = new System.Drawing.Point(133, 6);
            this.txbhonapszama.Name = "txbhonapszama";
            this.txbhonapszama.Size = new System.Drawing.Size(100, 20);
            this.txbhonapszama.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // szamol
            // 
            this.szamol.Location = new System.Drawing.Point(12, 113);
            this.szamol.Name = "szamol";
            this.szamol.Size = new System.Drawing.Size(75, 23);
            this.szamol.TabIndex = 4;
            this.szamol.Text = "Évszak";
            this.szamol.UseVisualStyleBackColor = true;
            this.szamol.Click += new System.EventHandler(this.Szamol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 159);
            this.Controls.Add(this.szamol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbhonapszama);
            this.Controls.Add(this.lblevszak);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblevszak;
        private System.Windows.Forms.TextBox txbhonapszama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button szamol;
    }
}

