namespace Tic_Tac_Toe
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblXWin = new System.Windows.Forms.Label();
            this.lblOWin = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Image = global::Tic_Tac_Toe.Properties.Resources.tic_tec;
            this.pictureBox1.Location = new System.Drawing.Point(6, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // A00
            // 
            this.A00.BackColor = System.Drawing.Color.White;
            this.A00.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A00.Location = new System.Drawing.Point(16, 76);
            this.A00.Margin = new System.Windows.Forms.Padding(2);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(75, 76);
            this.A00.TabIndex = 1;
            this.A00.UseVisualStyleBackColor = false;
            this.A00.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A10
            // 
            this.A10.BackColor = System.Drawing.Color.White;
            this.A10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A10.Location = new System.Drawing.Point(16, 158);
            this.A10.Margin = new System.Windows.Forms.Padding(2);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(75, 76);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = false;
            this.A10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A20
            // 
            this.A20.BackColor = System.Drawing.Color.White;
            this.A20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A20.Location = new System.Drawing.Point(16, 239);
            this.A20.Margin = new System.Windows.Forms.Padding(2);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(75, 76);
            this.A20.TabIndex = 1;
            this.A20.UseVisualStyleBackColor = false;
            this.A20.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A01
            // 
            this.A01.BackColor = System.Drawing.Color.White;
            this.A01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A01.Location = new System.Drawing.Point(96, 76);
            this.A01.Margin = new System.Windows.Forms.Padding(2);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(75, 76);
            this.A01.TabIndex = 1;
            this.A01.UseVisualStyleBackColor = false;
            this.A01.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A11
            // 
            this.A11.BackColor = System.Drawing.Color.White;
            this.A11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A11.Location = new System.Drawing.Point(96, 158);
            this.A11.Margin = new System.Windows.Forms.Padding(2);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(75, 76);
            this.A11.TabIndex = 1;
            this.A11.UseVisualStyleBackColor = false;
            this.A11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A21
            // 
            this.A21.BackColor = System.Drawing.Color.White;
            this.A21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A21.Location = new System.Drawing.Point(96, 239);
            this.A21.Margin = new System.Windows.Forms.Padding(2);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(75, 76);
            this.A21.TabIndex = 1;
            this.A21.UseVisualStyleBackColor = false;
            this.A21.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A02
            // 
            this.A02.BackColor = System.Drawing.Color.White;
            this.A02.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A02.Location = new System.Drawing.Point(176, 76);
            this.A02.Margin = new System.Windows.Forms.Padding(2);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(75, 76);
            this.A02.TabIndex = 1;
            this.A02.UseVisualStyleBackColor = false;
            this.A02.MouseCaptureChanged += new System.EventHandler(this.ButtonClick);
            // 
            // A12
            // 
            this.A12.BackColor = System.Drawing.Color.White;
            this.A12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A12.Location = new System.Drawing.Point(176, 158);
            this.A12.Margin = new System.Windows.Forms.Padding(2);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(75, 76);
            this.A12.TabIndex = 1;
            this.A12.UseVisualStyleBackColor = false;
            this.A12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A22
            // 
            this.A22.BackColor = System.Drawing.Color.White;
            this.A22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A22.Location = new System.Drawing.Point(176, 239);
            this.A22.Margin = new System.Windows.Forms.Padding(2);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(75, 76);
            this.A22.TabIndex = 1;
            this.A22.UseVisualStyleBackColor = false;
            this.A22.Click += new System.EventHandler(this.ButtonClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox3.Image = global::Tic_Tac_Toe.Properties.Resources.tic_tec;
            this.pictureBox3.Location = new System.Drawing.Point(6, 337);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(311, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(15, 349);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(76, 20);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(105, 349);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 20);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(193, 349);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblXWin
            // 
            this.lblXWin.AutoSize = true;
            this.lblXWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblXWin.Location = new System.Drawing.Point(264, 111);
            this.lblXWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXWin.Name = "lblXWin";
            this.lblXWin.Size = new System.Drawing.Size(2, 15);
            this.lblXWin.TabIndex = 4;
            // 
            // lblOWin
            // 
            this.lblOWin.AutoSize = true;
            this.lblOWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOWin.Location = new System.Drawing.Point(264, 158);
            this.lblOWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOWin.Name = "lblOWin";
            this.lblOWin.Size = new System.Drawing.Size(2, 15);
            this.lblOWin.TabIndex = 4;
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDraw.Location = new System.Drawing.Point(264, 207);
            this.lblDraw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(2, 15);
            this.lblDraw.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 422);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblOWin);
            this.Controls.Add(this.lblXWin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblXWin;
        private System.Windows.Forms.Label lblOWin;
        private System.Windows.Forms.Label lblDraw;
    }
}

