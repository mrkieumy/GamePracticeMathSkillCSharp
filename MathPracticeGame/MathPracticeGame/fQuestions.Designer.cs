namespace MathPracticeGame
{
    partial class fQuestions
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.lblResultFalse = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResultTrue = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.lblmilisecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(119, 121);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(127, 91);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "15";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(399, 121);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(127, 91);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "20";
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(284, 121);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(86, 91);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 91);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // txtRes
            // 
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.Location = new System.Drawing.Point(683, 114);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(166, 98);
            this.txtRes.TabIndex = 4;
            this.txtRes.TextChanged += new System.EventHandler(this.txtRes_TextChanged);
            this.txtRes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRes_KeyDown);
            // 
            // lblResultFalse
            // 
            this.lblResultFalse.AutoSize = true;
            this.lblResultFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFalse.ForeColor = System.Drawing.Color.Red;
            this.lblResultFalse.Location = new System.Drawing.Point(506, 286);
            this.lblResultFalse.Name = "lblResultFalse";
            this.lblResultFalse.Size = new System.Drawing.Size(272, 69);
            this.lblResultFalse.TabIndex = 5;
            this.lblResultFalse.Text = "Wrong: 0";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.ForeColor = System.Drawing.Color.Olive;
            this.lblResult2.Location = new System.Drawing.Point(188, 394);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(456, 55);
            this.lblResult2.TabIndex = 6;
            this.lblResult2.Text = "Result: 15 + 20 = 35";
            this.lblResult2.Click += new System.EventHandler(this.lblResult2_Click);
            // 
            // lblResultTrue
            // 
            this.lblResultTrue.AutoSize = true;
            this.lblResultTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTrue.ForeColor = System.Drawing.Color.Blue;
            this.lblResultTrue.Location = new System.Drawing.Point(66, 286);
            this.lblResultTrue.Name = "lblResultTrue";
            this.lblResultTrue.Size = new System.Drawing.Size(219, 69);
            this.lblResultTrue.TabIndex = 7;
            this.lblResultTrue.Text = "True: 0";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecond.Location = new System.Drawing.Point(374, 22);
            this.lblsecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(51, 39);
            this.lblsecond.TabIndex = 9;
            this.lblsecond.Text = "30";
            // 
            // lblmilisecond
            // 
            this.lblmilisecond.AutoSize = true;
            this.lblmilisecond.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmilisecond.Location = new System.Drawing.Point(429, 31);
            this.lblmilisecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmilisecond.Name = "lblmilisecond";
            this.lblmilisecond.Size = new System.Drawing.Size(30, 22);
            this.lblmilisecond.TabIndex = 8;
            this.lblmilisecond.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 538);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblmilisecond);
            this.Controls.Add(this.lblResultTrue);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResultFalse);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Questions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fQuestions_FormClosed);
            this.Load += new System.EventHandler(this.fQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label lblResultFalse;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResultTrue;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Label lblmilisecond;
        private System.Windows.Forms.Timer timer1;
    }
}