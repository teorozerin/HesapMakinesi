namespace HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnClosed = new Button();
            label1 = new Label();
            label2 = new Label();
            lblPanel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            button22 = new Button();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(318, 381);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(lblPanel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(312, 108);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(btnClosed, 2, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(306, 26);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnClosed
            // 
            btnClosed.Location = new Point(277, 3);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(26, 20);
            btnClosed.TabIndex = 0;
            btnClosed.Text = "X";
            btnClosed.UseVisualStyleBackColor = true;
            btnClosed.Click += btnClosed_Click;
            btnClosed.MouseLeave += btnClosed_MouseLeave;
            btnClosed.MouseHover += button23_MouseHover;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Image = Resources.Resources.calculator;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 26);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(33, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 26);
            label2.TabIndex = 2;
            label2.Click += SayiveVirgul;
            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            // 
            // lblPanel
            // 
            lblPanel.BorderStyle = BorderStyle.FixedSingle;
            lblPanel.Dock = DockStyle.Fill;
            lblPanel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanel.Location = new Point(3, 32);
            lblPanel.Name = "lblPanel";
            lblPanel.Size = new Size(306, 76);
            lblPanel.TabIndex = 1;
            lblPanel.Text = "0";
            lblPanel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(button22, 3, 4);
            tableLayoutPanel4.Controls.Add(button21, 2, 4);
            tableLayoutPanel4.Controls.Add(button20, 1, 4);
            tableLayoutPanel4.Controls.Add(button19, 0, 4);
            tableLayoutPanel4.Controls.Add(button18, 3, 3);
            tableLayoutPanel4.Controls.Add(button17, 2, 3);
            tableLayoutPanel4.Controls.Add(button16, 1, 3);
            tableLayoutPanel4.Controls.Add(button15, 0, 3);
            tableLayoutPanel4.Controls.Add(button14, 3, 2);
            tableLayoutPanel4.Controls.Add(button13, 2, 2);
            tableLayoutPanel4.Controls.Add(button12, 1, 2);
            tableLayoutPanel4.Controls.Add(button11, 0, 2);
            tableLayoutPanel4.Controls.Add(button10, 3, 1);
            tableLayoutPanel4.Controls.Add(button9, 2, 1);
            tableLayoutPanel4.Controls.Add(button8, 1, 1);
            tableLayoutPanel4.Controls.Add(button7, 0, 1);
            tableLayoutPanel4.Controls.Add(button6, 3, 0);
            tableLayoutPanel4.Controls.Add(button5, 2, 0);
            tableLayoutPanel4.Controls.Add(button2, 1, 0);
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 117);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(312, 261);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // button22
            // 
            button22.BackColor = Color.Orchid;
            button22.Dock = DockStyle.Fill;
            button22.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button22.Location = new Point(237, 211);
            button22.Name = "button22";
            button22.Size = new Size(72, 47);
            button22.TabIndex = 19;
            button22.Text = "=";
            button22.UseVisualStyleBackColor = false;
            button22.Click += btnEqual_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.PaleVioletRed;
            button21.Dock = DockStyle.Fill;
            button21.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button21.Location = new Point(159, 211);
            button21.Name = "button21";
            button21.Size = new Size(72, 47);
            button21.TabIndex = 18;
            button21.Text = ",";
            button21.UseVisualStyleBackColor = false;
            button21.Click += SayiveVirgul;
            // 
            // button20
            // 
            button20.BackColor = Color.PaleVioletRed;
            button20.Dock = DockStyle.Fill;
            button20.Location = new Point(81, 211);
            button20.Name = "button20";
            button20.Size = new Size(72, 47);
            button20.TabIndex = 17;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = false;
            button20.Click += SayiveVirgul;
            // 
            // button19
            // 
            button19.BackColor = Color.PaleVioletRed;
            button19.Dock = DockStyle.Fill;
            button19.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button19.Location = new Point(3, 211);
            button19.Name = "button19";
            button19.Size = new Size(72, 47);
            button19.TabIndex = 16;
            button19.Text = "+/-";
            button19.UseVisualStyleBackColor = false;
            button19.Click += btnNegative_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.PaleVioletRed;
            button18.Dock = DockStyle.Fill;
            button18.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(237, 159);
            button18.Name = "button18";
            button18.Size = new Size(72, 46);
            button18.TabIndex = 15;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = false;
            button18.Click += Islemler;
            // 
            // button17
            // 
            button17.BackColor = Color.PaleVioletRed;
            button17.Dock = DockStyle.Fill;
            button17.Location = new Point(159, 159);
            button17.Name = "button17";
            button17.Size = new Size(72, 46);
            button17.TabIndex = 14;
            button17.Text = "3";
            button17.UseVisualStyleBackColor = false;
            button17.Click += SayiveVirgul;
            // 
            // button16
            // 
            button16.BackColor = Color.PaleVioletRed;
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(81, 159);
            button16.Name = "button16";
            button16.Size = new Size(72, 46);
            button16.TabIndex = 13;
            button16.Text = "2";
            button16.UseVisualStyleBackColor = false;
            button16.Click += SayiveVirgul;
            // 
            // button15
            // 
            button15.BackColor = Color.PaleVioletRed;
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(3, 159);
            button15.Name = "button15";
            button15.Size = new Size(72, 46);
            button15.TabIndex = 12;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = false;
            button15.Click += SayiveVirgul;
            // 
            // button14
            // 
            button14.BackColor = Color.PaleVioletRed;
            button14.Dock = DockStyle.Fill;
            button14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(237, 107);
            button14.Name = "button14";
            button14.Size = new Size(72, 46);
            button14.TabIndex = 11;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += Islemler;
            // 
            // button13
            // 
            button13.BackColor = Color.PaleVioletRed;
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(159, 107);
            button13.Name = "button13";
            button13.Size = new Size(72, 46);
            button13.TabIndex = 10;
            button13.Text = "6";
            button13.UseVisualStyleBackColor = false;
            button13.Click += SayiveVirgul;
            // 
            // button12
            // 
            button12.BackColor = Color.PaleVioletRed;
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(81, 107);
            button12.Name = "button12";
            button12.Size = new Size(72, 46);
            button12.TabIndex = 9;
            button12.Text = "5";
            button12.UseVisualStyleBackColor = false;
            button12.Click += SayiveVirgul;
            // 
            // button11
            // 
            button11.BackColor = Color.PaleVioletRed;
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(3, 107);
            button11.Name = "button11";
            button11.Size = new Size(72, 46);
            button11.TabIndex = 8;
            button11.Text = "4";
            button11.UseVisualStyleBackColor = false;
            button11.Click += SayiveVirgul;
            // 
            // button10
            // 
            button10.BackColor = Color.PaleVioletRed;
            button10.Dock = DockStyle.Fill;
            button10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(237, 55);
            button10.Name = "button10";
            button10.Size = new Size(72, 46);
            button10.TabIndex = 7;
            button10.Text = "x";
            button10.UseVisualStyleBackColor = false;
            button10.Click += Islemler;
            // 
            // button9
            // 
            button9.BackColor = Color.PaleVioletRed;
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(159, 55);
            button9.Name = "button9";
            button9.Size = new Size(72, 46);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += SayiveVirgul;
            // 
            // button8
            // 
            button8.BackColor = Color.PaleVioletRed;
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(81, 55);
            button8.Name = "button8";
            button8.Size = new Size(72, 46);
            button8.TabIndex = 5;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += SayiveVirgul;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleVioletRed;
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(3, 55);
            button7.Name = "button7";
            button7.Size = new Size(72, 46);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += SayiveVirgul;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleVioletRed;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(237, 3);
            button6.Name = "button6";
            button6.Size = new Size(72, 46);
            button6.TabIndex = 3;
            button6.Text = "÷";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Islemler;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleVioletRed;
            button5.Dock = DockStyle.Fill;
            button5.Image = Resources.Resources._001_backspace;
            button5.Location = new Point(159, 3);
            button5.Name = "button5";
            button5.Size = new Size(72, 46);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnBackSpace_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(81, 3);
            button2.Name = "button2";
            button2.Size = new Size(72, 46);
            button2.TabIndex = 1;
            button2.Text = "C";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Clear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(72, 46);
            button1.TabIndex = 0;
            button1.Text = "CE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnClearEntity_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(button3, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(53, 3);
            button3.Name = "button3";
            button3.Size = new Size(44, 14);
            button3.TabIndex = 1;
            button3.Text = "CE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleVioletRed;
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(44, 46);
            button4.TabIndex = 0;
            button4.Text = "CE";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(318, 381);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button3;
        private Button button4;
        private Button btnClosed;
        private Label label1;
        private Label label2;
    }
}