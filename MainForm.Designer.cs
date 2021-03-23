
namespace Durak
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.opponentLbl = new System.Windows.Forms.Label();
            this.playingLbl = new System.Windows.Forms.Label();
            this.yourLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(470, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 202);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(470, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 202);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(470, 517);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 202);
            this.panel3.TabIndex = 1;
            // 
            // opponentLbl
            // 
            this.opponentLbl.AutoSize = true;
            this.opponentLbl.Location = new System.Drawing.Point(476, 5);
            this.opponentLbl.Name = "opponentLbl";
            this.opponentLbl.Size = new System.Drawing.Size(105, 17);
            this.opponentLbl.TabIndex = 2;
            this.opponentLbl.Text = "Opponent Area";
            // 
            // playingLbl
            // 
            this.playingLbl.AutoSize = true;
            this.playingLbl.Location = new System.Drawing.Point(467, 257);
            this.playingLbl.Name = "playingLbl";
            this.playingLbl.Size = new System.Drawing.Size(88, 17);
            this.playingLbl.TabIndex = 3;
            this.playingLbl.Text = "Playing Area";
            // 
            // yourLbl
            // 
            this.yourLbl.AutoSize = true;
            this.yourLbl.Location = new System.Drawing.Point(467, 497);
            this.yourLbl.Name = "yourLbl";
            this.yourLbl.Size = new System.Drawing.Size(72, 17);
            this.yourLbl.TabIndex = 4;
            this.yourLbl.Text = "Your Area";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 739);
            this.Controls.Add(this.yourLbl);
            this.Controls.Add(this.playingLbl);
            this.Controls.Add(this.opponentLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label opponentLbl;
        private System.Windows.Forms.Label playingLbl;
        private System.Windows.Forms.Label yourLbl;
    }
}