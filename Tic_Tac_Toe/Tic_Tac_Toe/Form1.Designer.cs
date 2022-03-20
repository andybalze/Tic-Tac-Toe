namespace TicTacToe
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
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameVCOmputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoTurn = new System.Windows.Forms.Label();
            this.xWinCountLabel = new System.Windows.Forms.Label();
            this.oWinCountLabel = new System.Windows.Forms.Label();
            this.drawCountLabel = new System.Windows.Forms.Label();
            this.xWinCount = new System.Windows.Forms.Label();
            this.oWinCount = new System.Windows.Forms.Label();
            this.drawCount = new System.Windows.Forms.Label();
            this.scoresGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.scoresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.A1.Location = new System.Drawing.Point(8, 29);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.A2.Location = new System.Drawing.Point(89, 29);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.A3.Location = new System.Drawing.Point(170, 29);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.B1.Location = new System.Drawing.Point(8, 107);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.B2.Location = new System.Drawing.Point(89, 107);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.B3.Location = new System.Drawing.Point(170, 107);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.C1.Location = new System.Drawing.Point(8, 185);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.C2.Location = new System.Drawing.Point(89, 185);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.C3.Location = new System.Drawing.Point(170, 185);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.newGameVCOmputerToolStripMenuItem,
            this.showScoresToolStripMenuItem,
            this.resetWinCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.newGameToolStripMenuItem.Text = "Ne&w Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.New_Game);
            // 
            // newGameVCOmputerToolStripMenuItem
            // 
            this.newGameVCOmputerToolStripMenuItem.Name = "newGameVCOmputerToolStripMenuItem";
            this.newGameVCOmputerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.newGameVCOmputerToolStripMenuItem.Text = "New Game V Computer";
            this.newGameVCOmputerToolStripMenuItem.Click += new System.EventHandler(this.newGameVComputer);
            // 
            // showScoresToolStripMenuItem
            // 
            this.showScoresToolStripMenuItem.Name = "showScoresToolStripMenuItem";
            this.showScoresToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showScoresToolStripMenuItem.Text = "Show Scores";
            this.showScoresToolStripMenuItem.Click += new System.EventHandler(this.showScores);
            // 
            // resetWinCountsToolStripMenuItem
            // 
            this.resetWinCountsToolStripMenuItem.Name = "resetWinCountsToolStripMenuItem";
            this.resetWinCountsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.resetWinCountsToolStripMenuItem.Text = "Reset Win Counts";
            this.resetWinCountsToolStripMenuItem.Click += new System.EventHandler(this.resetWinCounts);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // whoTurn
            // 
            this.whoTurn.AutoSize = true;
            this.whoTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoTurn.Location = new System.Drawing.Point(100, 5);
            this.whoTurn.MaximumSize = new System.Drawing.Size(250, 15);
            this.whoTurn.MinimumSize = new System.Drawing.Size(51, 15);
            this.whoTurn.Name = "whoTurn";
            this.whoTurn.Size = new System.Drawing.Size(60, 15);
            this.whoTurn.TabIndex = 11;
            this.whoTurn.Text = "X\'s Turn";
            // 
            // xWinCountLabel
            // 
            this.xWinCountLabel.AutoSize = true;
            this.xWinCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWinCountLabel.Location = new System.Drawing.Point(4, 30);
            this.xWinCountLabel.MaximumSize = new System.Drawing.Size(80, 13);
            this.xWinCountLabel.MinimumSize = new System.Drawing.Size(80, 13);
            this.xWinCountLabel.Name = "xWinCountLabel";
            this.xWinCountLabel.Size = new System.Drawing.Size(80, 13);
            this.xWinCountLabel.TabIndex = 13;
            this.xWinCountLabel.Text = "X Win Count";
            this.xWinCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oWinCountLabel
            // 
            this.oWinCountLabel.AutoSize = true;
            this.oWinCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWinCountLabel.Location = new System.Drawing.Point(4, 109);
            this.oWinCountLabel.MaximumSize = new System.Drawing.Size(80, 13);
            this.oWinCountLabel.MinimumSize = new System.Drawing.Size(80, 13);
            this.oWinCountLabel.Name = "oWinCountLabel";
            this.oWinCountLabel.Size = new System.Drawing.Size(80, 13);
            this.oWinCountLabel.TabIndex = 14;
            this.oWinCountLabel.Text = "O Win Count";
            this.oWinCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawCountLabel
            // 
            this.drawCountLabel.AutoSize = true;
            this.drawCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCountLabel.Location = new System.Drawing.Point(8, 188);
            this.drawCountLabel.MaximumSize = new System.Drawing.Size(73, 13);
            this.drawCountLabel.MinimumSize = new System.Drawing.Size(73, 13);
            this.drawCountLabel.Name = "drawCountLabel";
            this.drawCountLabel.Size = new System.Drawing.Size(73, 13);
            this.drawCountLabel.TabIndex = 15;
            this.drawCountLabel.Text = "Draw Count";
            this.drawCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xWinCount
            // 
            this.xWinCount.AutoSize = true;
            this.xWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWinCount.Location = new System.Drawing.Point(37, 48);
            this.xWinCount.Name = "xWinCount";
            this.xWinCount.Size = new System.Drawing.Size(15, 16);
            this.xWinCount.TabIndex = 16;
            this.xWinCount.Text = "0";
            // 
            // oWinCount
            // 
            this.oWinCount.AutoSize = true;
            this.oWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWinCount.Location = new System.Drawing.Point(37, 127);
            this.oWinCount.Name = "oWinCount";
            this.oWinCount.Size = new System.Drawing.Size(15, 16);
            this.oWinCount.TabIndex = 17;
            this.oWinCount.Text = "0";
            // 
            // drawCount
            // 
            this.drawCount.AutoSize = true;
            this.drawCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCount.Location = new System.Drawing.Point(37, 206);
            this.drawCount.Name = "drawCount";
            this.drawCount.Size = new System.Drawing.Size(15, 16);
            this.drawCount.TabIndex = 18;
            this.drawCount.Text = "0";
            // 
            // scoresGroupBox
            // 
            this.scoresGroupBox.Controls.Add(this.xWinCountLabel);
            this.scoresGroupBox.Controls.Add(this.drawCount);
            this.scoresGroupBox.Controls.Add(this.oWinCountLabel);
            this.scoresGroupBox.Controls.Add(this.oWinCount);
            this.scoresGroupBox.Controls.Add(this.drawCountLabel);
            this.scoresGroupBox.Controls.Add(this.xWinCount);
            this.scoresGroupBox.Location = new System.Drawing.Point(258, 28);
            this.scoresGroupBox.Name = "scoresGroupBox";
            this.scoresGroupBox.Size = new System.Drawing.Size(88, 232);
            this.scoresGroupBox.TabIndex = 19;
            this.scoresGroupBox.TabStop = false;
            this.scoresGroupBox.Text = "Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 272);
            this.Controls.Add(this.scoresGroupBox);
            this.Controls.Add(this.whoTurn);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 320);
            this.MinimumSize = new System.Drawing.Size(260, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - Weston Fausett";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scoresGroupBox.ResumeLayout(false);
            this.scoresGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label whoTurn;
        private System.Windows.Forms.Label xWinCountLabel;
        private System.Windows.Forms.Label oWinCountLabel;
        private System.Windows.Forms.Label drawCountLabel;
        private System.Windows.Forms.Label xWinCount;
        private System.Windows.Forms.Label oWinCount;
        private System.Windows.Forms.Label drawCount;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameVCOmputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showScoresToolStripMenuItem;
        private System.Windows.Forms.GroupBox scoresGroupBox;
    }
}

