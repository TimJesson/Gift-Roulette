namespace Gift_Roulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbGift = new System.Windows.Forms.PictureBox();
            this.lblWinLoss = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pbGiftRoulette = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pbWinLose = new System.Windows.Forms.PictureBox();
            this.btnHTP = new System.Windows.Forms.Button();
            this.lblPasses = new System.Windows.Forms.Label();
            this.pbSlowClap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGiftRoulette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlowClap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShuffle.Location = new System.Drawing.Point(894, 293);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(312, 79);
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Visible = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpen.Location = new System.Drawing.Point(896, 391);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(310, 78);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Image = ((System.Drawing.Image)(resources.GetObject("btnPass.Image")));
            this.btnPass.Location = new System.Drawing.Point(894, 488);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(312, 78);
            this.btnPass.TabIndex = 2;
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Visible = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::Gift_Roulette.Resource1.PlayAgain1;
            this.btnReset.Location = new System.Drawing.Point(894, 589);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(312, 78);
            this.btnReset.TabIndex = 3;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbGift
            // 
            this.pbGift.BackColor = System.Drawing.Color.Transparent;
            this.pbGift.Image = global::Gift_Roulette.Resource1.Gift;
            this.pbGift.Location = new System.Drawing.Point(419, 254);
            this.pbGift.Name = "pbGift";
            this.pbGift.Size = new System.Drawing.Size(420, 413);
            this.pbGift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGift.TabIndex = 4;
            this.pbGift.TabStop = false;
            this.pbGift.Visible = false;
            // 
            // lblWinLoss
            // 
            this.lblWinLoss.AutoSize = true;
            this.lblWinLoss.BackColor = System.Drawing.Color.Transparent;
            this.lblWinLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLoss.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWinLoss.Location = new System.Drawing.Point(29, 71);
            this.lblWinLoss.Name = "lblWinLoss";
            this.lblWinLoss.Size = new System.Drawing.Size(0, 39);
            this.lblWinLoss.TabIndex = 5;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(514, 341);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 31);
            this.lblCount.TabIndex = 6;
            // 
            // pbGiftRoulette
            // 
            this.pbGiftRoulette.BackColor = System.Drawing.Color.Transparent;
            this.pbGiftRoulette.BackgroundImage = global::Gift_Roulette.Resource1.GiftRoulette;
            this.pbGiftRoulette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGiftRoulette.Location = new System.Drawing.Point(593, 0);
            this.pbGiftRoulette.Name = "pbGiftRoulette";
            this.pbGiftRoulette.Size = new System.Drawing.Size(551, 137);
            this.pbGiftRoulette.TabIndex = 7;
            this.pbGiftRoulette.TabStop = false;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.SystemColors.Control;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Crimson;
            this.lblTurn.Location = new System.Drawing.Point(295, 529);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 37);
            this.lblTurn.TabIndex = 8;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Image = global::Gift_Roulette.Resource1.StartGame;
            this.btnStartGame.Location = new System.Drawing.Point(419, 269);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(446, 150);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pbWinLose
            // 
            this.pbWinLose.BackColor = System.Drawing.Color.Transparent;
            this.pbWinLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWinLose.Location = new System.Drawing.Point(355, 143);
            this.pbWinLose.Name = "pbWinLose";
            this.pbWinLose.Size = new System.Drawing.Size(523, 120);
            this.pbWinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWinLose.TabIndex = 10;
            this.pbWinLose.TabStop = false;
            this.pbWinLose.Visible = false;
            // 
            // btnHTP
            // 
            this.btnHTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTP.Image = global::Gift_Roulette.Resource1.HTP;
            this.btnHTP.Location = new System.Drawing.Point(503, 442);
            this.btnHTP.Name = "btnHTP";
            this.btnHTP.Size = new System.Drawing.Size(275, 68);
            this.btnHTP.TabIndex = 11;
            this.btnHTP.UseVisualStyleBackColor = true;
            this.btnHTP.Click += new System.EventHandler(this.btnHTP_Click);
            // 
            // lblPasses
            // 
            this.lblPasses.AutoSize = true;
            this.lblPasses.BackColor = System.Drawing.Color.Transparent;
            this.lblPasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPasses.Location = new System.Drawing.Point(995, 466);
            this.lblPasses.Name = "lblPasses";
            this.lblPasses.Size = new System.Drawing.Size(0, 20);
            this.lblPasses.TabIndex = 12;
            // 
            // pbSlowClap
            // 
            this.pbSlowClap.BackColor = System.Drawing.Color.Transparent;
            this.pbSlowClap.Location = new System.Drawing.Point(30, 285);
            this.pbSlowClap.Name = "pbSlowClap";
            this.pbSlowClap.Size = new System.Drawing.Size(383, 241);
            this.pbSlowClap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlowClap.TabIndex = 13;
            this.pbSlowClap.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gift_Roulette.Resource1.christmasBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 685);
            this.Controls.Add(this.pbSlowClap);
            this.Controls.Add(this.btnHTP);
            this.Controls.Add(this.pbWinLose);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pbGiftRoulette);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblWinLoss);
            this.Controls.Add(this.pbGift);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblPasses);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGiftRoulette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlowClap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbGift;
        private System.Windows.Forms.Label lblWinLoss;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pbGiftRoulette;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pbWinLose;
        private System.Windows.Forms.Button btnHTP;
        private System.Windows.Forms.Label lblPasses;
        private System.Windows.Forms.PictureBox pbSlowClap;
    }
}

