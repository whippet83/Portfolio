namespace Calculatrice
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.lblNum = new System.Windows.Forms.Label();
            this.btnAc = new Calculatrice.RoundButton();
            this.btnPlusAndMinus = new Calculatrice.RoundButton();
            this.btnPourcentage = new Calculatrice.RoundButton();
            this.btnDiv = new Calculatrice.RoundButton();
            this.btn7 = new Calculatrice.RoundButton();
            this.btn8 = new Calculatrice.RoundButton();
            this.btn9 = new Calculatrice.RoundButton();
            this.btnMulti = new Calculatrice.RoundButton();
            this.btn4 = new Calculatrice.RoundButton();
            this.btn5 = new Calculatrice.RoundButton();
            this.btn6 = new Calculatrice.RoundButton();
            this.btnMinus = new Calculatrice.RoundButton();
            this.btn1 = new Calculatrice.RoundButton();
            this.btn2 = new Calculatrice.RoundButton();
            this.btn3 = new Calculatrice.RoundButton();
            this.btnPlus = new Calculatrice.RoundButton();
            this.btnEqual = new Calculatrice.RoundButton();
            this.btnPoint = new Calculatrice.RoundButton();
            this.btn0 = new Calculatrice.PillButton();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNum.Location = new System.Drawing.Point(24, 225);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(466, 128);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "0";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // btnAc
            // 
            this.btnAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btnAc.FlatAppearance.BorderSize = 0;
            this.btnAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAc.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAc.Location = new System.Drawing.Point(24, 356);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(112, 105);
            this.btnAc.TabIndex = 1;
            this.btnAc.Text = "AC";
            this.btnAc.UseVisualStyleBackColor = false;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnPlusAndMinus
            // 
            this.btnPlusAndMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btnPlusAndMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusAndMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusAndMinus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlusAndMinus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPlusAndMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlusAndMinus.Image")));
            this.btnPlusAndMinus.Location = new System.Drawing.Point(142, 356);
            this.btnPlusAndMinus.Name = "btnPlusAndMinus";
            this.btnPlusAndMinus.Size = new System.Drawing.Size(112, 105);
            this.btnPlusAndMinus.TabIndex = 2;
            this.btnPlusAndMinus.UseVisualStyleBackColor = false;
            this.btnPlusAndMinus.Click += new System.EventHandler(this.btnPlusAndMinus_Click);
            // 
            // btnPourcentage
            // 
            this.btnPourcentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btnPourcentage.FlatAppearance.BorderSize = 0;
            this.btnPourcentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPourcentage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPourcentage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPourcentage.Image = global::Calculatrice.Properties.Resources.icons8_percentage_50px_1;
            this.btnPourcentage.Location = new System.Drawing.Point(260, 356);
            this.btnPourcentage.Name = "btnPourcentage";
            this.btnPourcentage.Size = new System.Drawing.Size(112, 105);
            this.btnPourcentage.TabIndex = 3;
            this.btnPourcentage.UseVisualStyleBackColor = false;
            this.btnPourcentage.Click += new System.EventHandler(this.btnPourcentage_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(6)))));
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiv.Image = global::Calculatrice.Properties.Resources.icons8_divide_50px;
            this.btnDiv.Location = new System.Drawing.Point(378, 356);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(112, 105);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(24, 477);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(112, 105);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(142, 477);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(112, 105);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.Control;
            this.btn9.Location = new System.Drawing.Point(260, 477);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(112, 105);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(6)))));
            this.btnMulti.FlatAppearance.BorderSize = 0;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMulti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMulti.Image = ((System.Drawing.Image)(resources.GetObject("btnMulti.Image")));
            this.btnMulti.Location = new System.Drawing.Point(378, 477);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(112, 105);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(24, 588);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(112, 105);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(142, 588);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(112, 105);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(260, 588);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(112, 105);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(6)))));
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Image = global::Calculatrice.Properties.Resources.icons8_subtract_50px;
            this.btnMinus.Location = new System.Drawing.Point(378, 588);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(112, 105);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(24, 699);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(112, 105);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(142, 699);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(112, 105);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(260, 699);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(112, 105);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(6)))));
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Image = global::Calculatrice.Properties.Resources.icons8_plus_math_50px_1;
            this.btnPlus.Location = new System.Drawing.Point(378, 699);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(112, 105);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(6)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEqual.Image = global::Calculatrice.Properties.Resources.icons8_equal_sign_50px;
            this.btnEqual.Location = new System.Drawing.Point(378, 810);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(112, 105);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPoint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPoint.Location = new System.Drawing.Point(250, 807);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(112, 105);
            this.btnPoint.TabIndex = 18;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn0.Location = new System.Drawing.Point(24, 810);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(220, 102);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "  0";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(510, 939);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnPourcentage);
            this.Controls.Add(this.btnPlusAndMinus);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.lblNum);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNum;
        private RoundButton btnAc;
        private RoundButton btnPlusAndMinus;
        private RoundButton btnPourcentage;
        private RoundButton btnDiv;
        private RoundButton btn7;
        private RoundButton btn8;
        private RoundButton btn9;
        private RoundButton btnMulti;
        private RoundButton btn4;
        private RoundButton btn5;
        private RoundButton btn6;
        private RoundButton btnMinus;
        private RoundButton btn1;
        private RoundButton btn2;
        private RoundButton btn3;
        private RoundButton btnPlus;
        private RoundButton btnEqual;
        private RoundButton btnPoint;
        private PillButton btn0;
    }
}