namespace TicTacToe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerX = new System.Windows.Forms.TextBox();
            this.playerO = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.VSComputer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Two Name";
            // 
            // playerX
            // 
            this.playerX.Location = new System.Drawing.Point(127, 9);
            this.playerX.Name = "playerX";
            this.playerX.Size = new System.Drawing.Size(157, 20);
            this.playerX.TabIndex = 1;
            // 
            // playerO
            // 
            this.playerO.Location = new System.Drawing.Point(127, 35);
            this.playerO.Name = "playerO";
            this.playerO.Size = new System.Drawing.Size(157, 20);
            this.playerO.TabIndex = 2;
            // 
            // Play
            // 
            this.Play.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Play.Location = new System.Drawing.Point(216, 62);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 3;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.submitPlay);
            // 
            // VSComputer
            // 
            this.VSComputer.AutoSize = true;
            this.VSComputer.Location = new System.Drawing.Point(12, 65);
            this.VSComputer.MaximumSize = new System.Drawing.Size(132, 17);
            this.VSComputer.MinimumSize = new System.Drawing.Size(132, 17);
            this.VSComputer.Name = "VSComputer";
            this.VSComputer.Size = new System.Drawing.Size(132, 17);
            this.VSComputer.TabIndex = 4;
            this.VSComputer.Text = "Play Against Computer";
            this.VSComputer.UseVisualStyleBackColor = true;
            this.VSComputer.CheckedChanged += new System.EventHandler(this.VSComputer_CheckedChanged);
            // 
            // Form2
            // 
            this.AcceptButton = this.Play;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 93);
            this.Controls.Add(this.VSComputer);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.playerO);
            this.Controls.Add(this.playerX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - Weston Fausett";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerX;
        private System.Windows.Forms.TextBox playerO;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.CheckBox VSComputer;
    }
}