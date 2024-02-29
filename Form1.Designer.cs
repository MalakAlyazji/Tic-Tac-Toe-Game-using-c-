
namespace tictactoeproject
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
            this.btrestart = new System.Windows.Forms.Button();
            this.lbturn = new System.Windows.Forms.Label();
            this.lbwinner = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Winner :";
            // 
            // btrestart
            // 
            this.btrestart.BackColor = System.Drawing.Color.Black;
            this.btrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrestart.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrestart.ForeColor = System.Drawing.Color.Transparent;
            this.btrestart.Location = new System.Drawing.Point(19, 688);
            this.btrestart.Name = "btrestart";
            this.btrestart.Size = new System.Drawing.Size(319, 72);
            this.btrestart.TabIndex = 2;
            this.btrestart.Text = "Restart Game";
            this.btrestart.UseVisualStyleBackColor = false;
            this.btrestart.Click += new System.EventHandler(this.btrestart_Click);
            // 
            // lbturn
            // 
            this.lbturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbturn.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbturn.Location = new System.Drawing.Point(12, 245);
            this.lbturn.Name = "lbturn";
            this.lbturn.Size = new System.Drawing.Size(222, 68);
            this.lbturn.TabIndex = 3;
            this.lbturn.Text = "Player1";
            // 
            // lbwinner
            // 
            this.lbwinner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbwinner.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwinner.ForeColor = System.Drawing.Color.Lime;
            this.lbwinner.Location = new System.Drawing.Point(16, 484);
            this.lbwinner.Name = "lbwinner";
            this.lbwinner.Size = new System.Drawing.Size(218, 68);
            this.lbwinner.TabIndex = 4;
            this.lbwinner.Text = "In Progress";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(266, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(821, 68);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tic-Tac-Toe Game";
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.label3_Paint);
            // 
            // bt9
            // 
            this.bt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt9.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt9.Location = new System.Drawing.Point(1062, 600);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(175, 169);
            this.bt9.TabIndex = 8;
            this.bt9.Tag = "?";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt8
            // 
            this.bt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt8.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt8.Location = new System.Drawing.Point(769, 600);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(175, 169);
            this.bt8.TabIndex = 7;
            this.bt8.Tag = "?";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt7
            // 
            this.bt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt7.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt7.Location = new System.Drawing.Point(480, 600);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(175, 169);
            this.bt7.TabIndex = 6;
            this.bt7.Tag = "?";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt6
            // 
            this.bt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt6.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt6.Location = new System.Drawing.Point(1062, 383);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(175, 169);
            this.bt6.TabIndex = 5;
            this.bt6.Tag = "?";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt5
            // 
            this.bt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt5.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt5.Location = new System.Drawing.Point(769, 383);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(175, 169);
            this.bt5.TabIndex = 4;
            this.bt5.Tag = "?";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt4
            // 
            this.bt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt4.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt4.Location = new System.Drawing.Point(480, 383);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(175, 169);
            this.bt4.TabIndex = 3;
            this.bt4.Tag = "?";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt3
            // 
            this.bt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt3.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt3.Location = new System.Drawing.Point(1062, 185);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(175, 169);
            this.bt3.TabIndex = 2;
            this.bt3.Tag = "?";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt2
            // 
            this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt2.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt2.Location = new System.Drawing.Point(769, 170);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(175, 184);
            this.bt2.TabIndex = 1;
            this.bt2.Tag = "?";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt1
            // 
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.Image = global::tictactoeproject.Properties.Resources.questionmark;
            this.bt1.Location = new System.Drawing.Point(463, 171);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(192, 184);
            this.bt1.TabIndex = 0;
            this.bt1.Tag = "?";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1363, 864);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbwinner);
            this.Controls.Add(this.lbturn);
            this.Controls.Add(this.btrestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btrestart;
        private System.Windows.Forms.Label lbturn;
        private System.Windows.Forms.Label lbwinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt1;
    }
}

