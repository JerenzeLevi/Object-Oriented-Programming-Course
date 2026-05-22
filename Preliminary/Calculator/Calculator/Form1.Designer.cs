namespace Calculator
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.Color.Silver;
            this.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(71, 40);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(377, 56);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            this.txtNum1.DoubleClick += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNum1.Enter += new System.EventHandler(this.txtNum1_Enter);
            this.txtNum1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNum1_MouseDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(251, 206);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(197, 54);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.Silver;
            this.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum2.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(71, 136);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(377, 56);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum2.Click += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged_1);
            this.txtNum2.DoubleClick += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNum2_MouseDown);
            this.txtNum2.MouseEnter += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Location = new System.Drawing.Point(28, 276);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(138, 80);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Lime;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Location = new System.Drawing.Point(172, 276);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(132, 80);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Lime;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Location = new System.Drawing.Point(308, 276);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(140, 80);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Lime;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Location = new System.Drawing.Point(28, 362);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(138, 80);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Lime;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Location = new System.Drawing.Point(172, 362);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(132, 80);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Lime;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Location = new System.Drawing.Point(308, 362);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(140, 80);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Lime;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Location = new System.Drawing.Point(28, 448);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(138, 80);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Lime;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Location = new System.Drawing.Point(172, 448);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(130, 80);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Lime;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Location = new System.Drawing.Point(308, 448);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(140, 80);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Lime;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.Location = new System.Drawing.Point(28, 534);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(138, 80);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.Lime;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddition.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddition.Location = new System.Drawing.Point(172, 534);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(130, 80);
            this.btnAddition.TabIndex = 14;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.Color.Lime;
            this.btnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtraction.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtraction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubtraction.Location = new System.Drawing.Point(308, 534);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(140, 80);
            this.btnSubtraction.TabIndex = 15;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.Lime;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMultiplication.Location = new System.Drawing.Point(28, 620);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(202, 80);
            this.btnMultiplication.TabIndex = 16;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Lime;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivision.Location = new System.Drawing.Point(236, 620);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(212, 80);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Lime;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEqual.Location = new System.Drawing.Point(172, 706);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(276, 80);
            this.btnEqual.TabIndex = 18;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 19;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.BackColor = System.Drawing.Color.Black;
            this.lblOperator.Font = new System.Drawing.Font("Rockwell Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.White;
            this.lblOperator.Location = new System.Drawing.Point(12, 68);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(38, 56);
            this.lblOperator.TabIndex = 20;
            this.lblOperator.Text = ".";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblOperator.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(28, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 80);
            this.button1.TabIndex = 21;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(469, 832);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button button1;
    }
}

