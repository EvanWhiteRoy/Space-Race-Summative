namespace Space_Race_Summative
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerLabel1 = new System.Windows.Forms.Label();
            this.scorelabel1 = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.playerScore2 = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.playerLabel2 = new System.Windows.Forms.Label();
            this.scorelabel2 = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerLabel1
            // 
            this.playerLabel1.AutoSize = true;
            this.playerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel1.ForeColor = System.Drawing.Color.Blue;
            this.playerLabel1.Location = new System.Drawing.Point(26, 47);
            this.playerLabel1.Name = "playerLabel1";
            this.playerLabel1.Size = new System.Drawing.Size(78, 24);
            this.playerLabel1.TabIndex = 0;
            this.playerLabel1.Text = "ALLIES";
            // 
            // scorelabel1
            // 
            this.scorelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel1.ForeColor = System.Drawing.Color.Blue;
            this.scorelabel1.Location = new System.Drawing.Point(133, 47);
            this.scorelabel1.Name = "scorelabel1";
            this.scorelabel1.Size = new System.Drawing.Size(66, 24);
            this.scorelabel1.TabIndex = 1;
            this.scorelabel1.Text = "0";
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.Blue;
            this.titlelabel.Location = new System.Drawing.Point(309, 22);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(266, 63);
            this.titlelabel.TabIndex = 2;
            // 
            // subLabel
            // 
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.ForeColor = System.Drawing.Color.Blue;
            this.subLabel.Location = new System.Drawing.Point(347, 232);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(201, 92);
            this.subLabel.TabIndex = 3;
            // 
            // playerScore2
            // 
            this.playerScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore2.ForeColor = System.Drawing.Color.Blue;
            this.playerScore2.Location = new System.Drawing.Point(421, 47);
            this.playerScore2.Name = "playerScore2";
            this.playerScore2.Size = new System.Drawing.Size(66, 24);
            this.playerScore2.TabIndex = 4;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.ForeColor = System.Drawing.Color.Blue;
            this.player2Label.Location = new System.Drawing.Point(602, 47);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(0, 24);
            this.player2Label.TabIndex = 5;
            // 
            // playerLabel2
            // 
            this.playerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel2.ForeColor = System.Drawing.Color.Blue;
            this.playerLabel2.Location = new System.Drawing.Point(670, 47);
            this.playerLabel2.Name = "playerLabel2";
            this.playerLabel2.Size = new System.Drawing.Size(87, 24);
            this.playerLabel2.TabIndex = 6;
            this.playerLabel2.Text = "EMPIRE";
            // 
            // scorelabel2
            // 
            this.scorelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel2.ForeColor = System.Drawing.Color.Blue;
            this.scorelabel2.Location = new System.Drawing.Point(624, 47);
            this.scorelabel2.Name = "scorelabel2";
            this.scorelabel2.Size = new System.Drawing.Size(26, 24);
            this.scorelabel2.TabIndex = 7;
            this.scorelabel2.Text = "0";
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Blue;
            this.winLabel.Location = new System.Drawing.Point(388, 123);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(201, 92);
            this.winLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.scorelabel2);
            this.Controls.Add(this.playerLabel2);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.playerScore2);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.scorelabel1);
            this.Controls.Add(this.playerLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerLabel1;
        private System.Windows.Forms.Label scorelabel1;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label playerScore2;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label playerLabel2;
        private System.Windows.Forms.Label scorelabel2;
        private System.Windows.Forms.Label winLabel;
    }
}

