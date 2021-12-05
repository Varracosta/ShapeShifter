
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
            this.MoveBoxClockWiseBtn = new System.Windows.Forms.Button();
            this.DimensionsTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CircleRadBtn = new System.Windows.Forms.RadioButton();
            this.HexagonRadBtn = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorPBox = new System.Windows.Forms.PictureBox();
            this.colorLbl = new System.Windows.Forms.Label();
            this.choseShapeLbl = new System.Windows.Forms.Label();
            this.animationsLbl = new System.Windows.Forms.Label();
            this.MoveCircleClockwiseBtn = new System.Windows.Forms.Button();
            this.txtFileUploadLbl = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.ChoseFileTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.speedLbl = new System.Windows.Forms.Label();
            this.FasterMoveRateBtn = new System.Windows.Forms.Button();
            this.SlowerMoveRateBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreateFromFileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateBtn.Location = new System.Drawing.Point(11, 133);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(76, 35);
            this.CreateBtn.TabIndex = 6;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // MoveXBtn
            // 
            this.MoveXBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveXBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveXBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveXBtn.Location = new System.Drawing.Point(130, 65);
            this.MoveXBtn.Name = "MoveXBtn";
            this.MoveXBtn.Size = new System.Drawing.Size(86, 43);
            this.MoveXBtn.TabIndex = 7;
            this.MoveXBtn.Text = "Horizontaly";
            this.MoveXBtn.UseVisualStyleBackColor = false;
            this.MoveXBtn.Click += new System.EventHandler(this.MoveXBtn_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(12, 37);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(450, 450);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MoveYBtn
            // 
            this.MoveYBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveYBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveYBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveYBtn.Location = new System.Drawing.Point(227, 65);
            this.MoveYBtn.Name = "MoveYBtn";
            this.MoveYBtn.Size = new System.Drawing.Size(85, 43);
            this.MoveYBtn.TabIndex = 8;
            this.MoveYBtn.Text = "Verticaly";
            this.MoveYBtn.UseVisualStyleBackColor = false;
            this.MoveYBtn.Click += new System.EventHandler(this.MoveYBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopBtn.Location = new System.Drawing.Point(13, 122);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(90, 47);
            this.StopBtn.TabIndex = 10;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SquareRadBtn
            // 
            this.SquareRadBtn.AutoSize = true;
            this.SquareRadBtn.Location = new System.Drawing.Point(11, 46);
            this.SquareRadBtn.Name = "SquareRadBtn";
            this.SquareRadBtn.Size = new System.Drawing.Size(59, 17);
            this.SquareRadBtn.TabIndex = 1;
            this.SquareRadBtn.TabStop = true;
            this.SquareRadBtn.Text = "Square";
            this.SquareRadBtn.UseVisualStyleBackColor = true;
            // 
            // TriangleRadBtn
            // 
            this.TriangleRadBtn.AutoSize = true;
            this.TriangleRadBtn.Location = new System.Drawing.Point(11, 69);
            this.TriangleRadBtn.Name = "TriangleRadBtn";
            this.TriangleRadBtn.Size = new System.Drawing.Size(63, 17);
            this.TriangleRadBtn.TabIndex = 2;
            this.TriangleRadBtn.TabStop = true;
            this.TriangleRadBtn.Text = "Triangle";
            this.TriangleRadBtn.UseVisualStyleBackColor = true;
            // 
            // MoveBoxClockWiseBtn
            // 
            this.MoveBoxClockWiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveBoxClockWiseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveBoxClockWiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveBoxClockWiseBtn.Location = new System.Drawing.Point(130, 126);
            this.MoveBoxClockWiseBtn.Name = "MoveBoxClockWiseBtn";
            this.MoveBoxClockWiseBtn.Size = new System.Drawing.Size(86, 43);
            this.MoveBoxClockWiseBtn.TabIndex = 9;
            this.MoveBoxClockWiseBtn.Text = "Box ClockWise";
            this.MoveBoxClockWiseBtn.UseVisualStyleBackColor = false;
            this.MoveBoxClockWiseBtn.Click += new System.EventHandler(this.MoveBoxClockWiseBtn_Click);
            // 
            // DimensionsTxtBox
            // 
            this.DimensionsTxtBox.AllowDrop = true;
            this.DimensionsTxtBox.Location = new System.Drawing.Point(128, 99);
            this.DimensionsTxtBox.Name = "DimensionsTxtBox";
            this.DimensionsTxtBox.Size = new System.Drawing.Size(50, 20);
            this.DimensionsTxtBox.TabIndex = 5;
            this.DimensionsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DimensionsTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.DimensionsTxtBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edge/Diameter (px): ";
            // 
            // CircleRadBtn
            // 
            this.CircleRadBtn.AutoSize = true;
            this.CircleRadBtn.Location = new System.Drawing.Point(130, 46);
            this.CircleRadBtn.Name = "CircleRadBtn";
            this.CircleRadBtn.Size = new System.Drawing.Size(51, 17);
            this.CircleRadBtn.TabIndex = 3;
            this.CircleRadBtn.TabStop = true;
            this.CircleRadBtn.Text = "Circle";
            this.CircleRadBtn.UseVisualStyleBackColor = true;
            // 
            // HexagonRadBtn
            // 
            this.HexagonRadBtn.AutoSize = true;
            this.HexagonRadBtn.Location = new System.Drawing.Point(130, 69);
            this.HexagonRadBtn.Name = "HexagonRadBtn";
            this.HexagonRadBtn.Size = new System.Drawing.Size(68, 17);
            this.HexagonRadBtn.TabIndex = 4;
            this.HexagonRadBtn.TabStop = true;
            this.HexagonRadBtn.Text = "Hexagon";
            this.HexagonRadBtn.UseVisualStyleBackColor = true;
            // 
            // ColorPBox
            // 
            this.ColorPBox.BackColor = System.Drawing.Color.White;
            this.ColorPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPBox.Location = new System.Drawing.Point(251, 99);
            this.ColorPBox.Name = "ColorPBox";
            this.ColorPBox.Size = new System.Drawing.Size(27, 20);
            this.ColorPBox.TabIndex = 12;
            this.ColorPBox.TabStop = false;
            this.ColorPBox.Click += new System.EventHandler(this.ColorPBox_Click);
            // 
            // colorLbl
            // 
            this.colorLbl.AutoSize = true;
            this.colorLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colorLbl.Location = new System.Drawing.Point(200, 102);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(34, 13);
            this.colorLbl.TabIndex = 13;
            this.colorLbl.Text = "Color:";
            // 
            // choseShapeLbl
            // 
            this.choseShapeLbl.AutoSize = true;
            this.choseShapeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choseShapeLbl.Location = new System.Drawing.Point(10, 15);
            this.choseShapeLbl.Name = "choseShapeLbl";
            this.choseShapeLbl.Size = new System.Drawing.Size(103, 16);
            this.choseShapeLbl.TabIndex = 14;
            this.choseShapeLbl.Text = "Chose shape:";
            // 
            // animationsLbl
            // 
            this.animationsLbl.AutoSize = true;
            this.animationsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animationsLbl.Location = new System.Drawing.Point(8, 16);
            this.animationsLbl.Name = "animationsLbl";
            this.animationsLbl.Size = new System.Drawing.Size(62, 16);
            this.animationsLbl.TabIndex = 15;
            this.animationsLbl.Text = "Move it:";
            // 
            // MoveCircleClockwiseBtn
            // 
            this.MoveCircleClockwiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveCircleClockwiseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoveCircleClockwiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveCircleClockwiseBtn.Location = new System.Drawing.Point(222, 126);
            this.MoveCircleClockwiseBtn.Name = "MoveCircleClockwiseBtn";
            this.MoveCircleClockwiseBtn.Size = new System.Drawing.Size(86, 43);
            this.MoveCircleClockwiseBtn.TabIndex = 10;
            this.MoveCircleClockwiseBtn.Text = "Circle ClockWise";
            this.MoveCircleClockwiseBtn.UseVisualStyleBackColor = false;
            this.MoveCircleClockwiseBtn.Click += new System.EventHandler(this.MoveCircleClockwiseBtn_Click);
            // 
            // txtFileUploadLbl
            // 
            this.txtFileUploadLbl.AutoSize = true;
            this.txtFileUploadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFileUploadLbl.Location = new System.Drawing.Point(489, 435);
            this.txtFileUploadLbl.Name = "txtFileUploadLbl";
            this.txtFileUploadLbl.Size = new System.Drawing.Size(107, 16);
            this.txtFileUploadLbl.TabIndex = 17;
            this.txtFileUploadLbl.Text = "Upload txt file:";
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UploadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UploadBtn.Location = new System.Drawing.Point(672, 461);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(65, 23);
            this.UploadBtn.TabIndex = 14;
            this.UploadBtn.Text = "Load";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // ChoseFileTxtBox
            // 
            this.ChoseFileTxtBox.AllowDrop = true;
            this.ChoseFileTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoseFileTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ChoseFileTxtBox.Location = new System.Drawing.Point(492, 463);
            this.ChoseFileTxtBox.Name = "ChoseFileTxtBox";
            this.ChoseFileTxtBox.Size = new System.Drawing.Size(164, 20);
            this.ChoseFileTxtBox.TabIndex = 13;
            this.ChoseFileTxtBox.Text = "Chose file...";
            this.ChoseFileTxtBox.Click += new System.EventHandler(this.ChoseFileTxtBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Controls.Add(this.SquareRadBtn);
            this.panel1.Controls.Add(this.TriangleRadBtn);
            this.panel1.Controls.Add(this.DimensionsTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CircleRadBtn);
            this.panel1.Controls.Add(this.choseShapeLbl);
            this.panel1.Controls.Add(this.HexagonRadBtn);
            this.panel1.Controls.Add(this.colorLbl);
            this.panel1.Controls.Add(this.ColorPBox);
            this.panel1.Location = new System.Drawing.Point(480, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 181);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.speedLbl);
            this.panel2.Controls.Add(this.FasterMoveRateBtn);
            this.panel2.Controls.Add(this.SlowerMoveRateBtn);
            this.panel2.Controls.Add(this.MoveBoxClockWiseBtn);
            this.panel2.Controls.Add(this.MoveXBtn);
            this.panel2.Controls.Add(this.MoveYBtn);
            this.panel2.Controls.Add(this.StopBtn);
            this.panel2.Controls.Add(this.animationsLbl);
            this.panel2.Controls.Add(this.MoveCircleClockwiseBtn);
            this.panel2.Location = new System.Drawing.Point(480, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 197);
            this.panel2.TabIndex = 21;
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(13, 64);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(41, 13);
            this.speedLbl.TabIndex = 19;
            this.speedLbl.Text = "Speed:";
            // 
            // FasterMoveRateBtn
            // 
            this.FasterMoveRateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FasterMoveRateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FasterMoveRateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FasterMoveRateBtn.Location = new System.Drawing.Point(61, 83);
            this.FasterMoveRateBtn.Name = "FasterMoveRateBtn";
            this.FasterMoveRateBtn.Size = new System.Drawing.Size(42, 25);
            this.FasterMoveRateBtn.TabIndex = 12;
            this.FasterMoveRateBtn.Text = "+";
            this.FasterMoveRateBtn.UseVisualStyleBackColor = false;
            this.FasterMoveRateBtn.Click += new System.EventHandler(this.FasterMoveRateBtn_Click);
            // 
            // SlowerMoveRateBtn
            // 
            this.SlowerMoveRateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SlowerMoveRateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SlowerMoveRateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlowerMoveRateBtn.Location = new System.Drawing.Point(13, 83);
            this.SlowerMoveRateBtn.Name = "SlowerMoveRateBtn";
            this.SlowerMoveRateBtn.Size = new System.Drawing.Size(42, 25);
            this.SlowerMoveRateBtn.TabIndex = 11;
            this.SlowerMoveRateBtn.Text = "-";
            this.SlowerMoveRateBtn.UseVisualStyleBackColor = false;
            this.SlowerMoveRateBtn.Click += new System.EventHandler(this.SlowerMoveRateBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateFromFileBtn
            // 
            this.CreateFromFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateFromFileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateFromFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateFromFileBtn.Location = new System.Drawing.Point(743, 461);
            this.CreateFromFileBtn.Name = "CreateFromFileBtn";
            this.CreateFromFileBtn.Size = new System.Drawing.Size(69, 23);
            this.CreateFromFileBtn.TabIndex = 15;
            this.CreateFromFileBtn.Text = "Create";
            this.CreateFromFileBtn.UseVisualStyleBackColor = false;
            this.CreateFromFileBtn.Click += new System.EventHandler(this.CreateFromFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.CreateFromFileBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChoseFileTxtBox);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.txtFileUploadLbl);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Shifter";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button MoveBoxClockWiseBtn;
        private System.Windows.Forms.TextBox DimensionsTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CircleRadBtn;
        private System.Windows.Forms.RadioButton HexagonRadBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox ColorPBox;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Label choseShapeLbl;
        private System.Windows.Forms.Label animationsLbl;
        private System.Windows.Forms.Button MoveCircleClockwiseBtn;
        private System.Windows.Forms.Label txtFileUploadLbl;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.TextBox ChoseFileTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FasterMoveRateBtn;
        private System.Windows.Forms.Button SlowerMoveRateBtn;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button CreateFromFileBtn;
    }
}

