
namespace SimpleShapes
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.MoveXBtn = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MoveYBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.SquareRadBtn = new System.Windows.Forms.RadioButton();
            this.TriangleRadBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(25, 473);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(95, 43);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // MoveXBtn
            // 
            this.MoveXBtn.Location = new System.Drawing.Point(285, 387);
            this.MoveXBtn.Name = "MoveXBtn";
            this.MoveXBtn.Size = new System.Drawing.Size(79, 43);
            this.MoveXBtn.TabIndex = 1;
            this.MoveXBtn.Text = "MoveX";
            this.MoveXBtn.UseVisualStyleBackColor = true;
            this.MoveXBtn.Click += new System.EventHandler(this.MoveXBtn_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(25, 22);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(450, 350);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MoveYBtn
            // 
            this.MoveYBtn.Location = new System.Drawing.Point(398, 387);
            this.MoveYBtn.Name = "MoveYBtn";
            this.MoveYBtn.Size = new System.Drawing.Size(77, 43);
            this.MoveYBtn.TabIndex = 3;
            this.MoveYBtn.Text = "MoveY";
            this.MoveYBtn.UseVisualStyleBackColor = true;
            this.MoveYBtn.Click += new System.EventHandler(this.MoveYBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(392, 473);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(83, 43);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SquareRadBtn
            // 
            this.SquareRadBtn.AutoSize = true;
            this.SquareRadBtn.Location = new System.Drawing.Point(25, 387);
            this.SquareRadBtn.Name = "SquareRadBtn";
            this.SquareRadBtn.Size = new System.Drawing.Size(59, 17);
            this.SquareRadBtn.TabIndex = 5;
            this.SquareRadBtn.TabStop = true;
            this.SquareRadBtn.Text = "Square";
            this.SquareRadBtn.UseVisualStyleBackColor = true;
            // 
            // TriangleRadBtn
            // 
            this.TriangleRadBtn.AutoSize = true;
            this.TriangleRadBtn.Location = new System.Drawing.Point(25, 422);
            this.TriangleRadBtn.Name = "TriangleRadBtn";
            this.TriangleRadBtn.Size = new System.Drawing.Size(63, 17);
            this.TriangleRadBtn.TabIndex = 6;
            this.TriangleRadBtn.TabStop = true;
            this.TriangleRadBtn.Text = "Triangle";
            this.TriangleRadBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 528);
            this.Controls.Add(this.TriangleRadBtn);
            this.Controls.Add(this.SquareRadBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.MoveYBtn);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.MoveXBtn);
            this.Controls.Add(this.CreateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button MoveXBtn;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button MoveYBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.RadioButton SquareRadBtn;
        private System.Windows.Forms.RadioButton TriangleRadBtn;
    }
}

