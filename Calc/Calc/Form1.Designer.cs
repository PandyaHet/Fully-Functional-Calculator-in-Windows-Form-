namespace Calc
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
            this.txtview = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbview = new System.Windows.Forms.Label();
            this.lboperator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtview
            // 
            this.txtview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtview.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtview.Location = new System.Drawing.Point(10, 58);
            this.txtview.Multiline = true;
            this.txtview.Name = "txtview";
            this.txtview.Size = new System.Drawing.Size(237, 40);
            this.txtview.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(91, 120);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Clear);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(10, 120);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 1;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.Operator_value);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(10, 236);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(172, 120);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Back";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Delete);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(91, 178);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 23);
            this.btn_8.TabIndex = 1;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(10, 178);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 23);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(172, 236);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 1;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(172, 178);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 23);
            this.btn_9.TabIndex = 1;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(91, 149);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 23);
            this.btn_minus.TabIndex = 1;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Operator_value);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(10, 149);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Operator_value);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(91, 236);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(172, 149);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_multiply.TabIndex = 1;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.Operator_value);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(91, 207);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 23);
            this.btn_5.TabIndex = 1;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(10, 207);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 23);
            this.btn_4.TabIndex = 1;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(10, 265);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 23);
            this.btn_0.TabIndex = 1;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(172, 207);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 23);
            this.btn_6.TabIndex = 1;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Numeric_value);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.Location = new System.Drawing.Point(172, 265);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 23);
            this.btn_equal.TabIndex = 1;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.Result_value);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(91, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Numeric_value);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(21, 20);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 20);
            this.lb1.TabIndex = 2;
            // 
            // lbview
            // 
            this.lbview.AutoSize = true;
            this.lbview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbview.Location = new System.Drawing.Point(324, 130);
            this.lbview.Name = "lbview";
            this.lbview.Size = new System.Drawing.Size(0, 16);
            this.lbview.TabIndex = 3;
            // 
            // lboperator
            // 
            this.lboperator.AutoSize = true;
            this.lboperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboperator.Location = new System.Drawing.Point(392, 130);
            this.lboperator.Name = "lboperator";
            this.lboperator.Size = new System.Drawing.Size(0, 16);
            this.lboperator.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 304);
            this.Controls.Add(this.lboperator);
            this.Controls.Add(this.lbview);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txtview);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtview;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbview;
        private System.Windows.Forms.Label lboperator;
    }
}

