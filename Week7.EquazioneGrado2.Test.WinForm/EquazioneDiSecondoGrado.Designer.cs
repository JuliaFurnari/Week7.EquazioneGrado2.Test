
namespace Week7.EquazioneGrado2.Test.WinForm
{
    partial class EquazioneDiSecondoGrado
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
            this.txtValueA = new System.Windows.Forms.TextBox();
            this.txtValueB = new System.Windows.Forms.TextBox();
            this.txtValueC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValueX1 = new System.Windows.Forms.TextBox();
            this.txtValueX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUguale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValueA
            // 
            this.txtValueA.Location = new System.Drawing.Point(54, 159);
            this.txtValueA.Name = "txtValueA";
            this.txtValueA.Size = new System.Drawing.Size(173, 31);
            this.txtValueA.TabIndex = 0;
            this.txtValueA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValueB
            // 
            this.txtValueB.Location = new System.Drawing.Point(309, 159);
            this.txtValueB.Name = "txtValueB";
            this.txtValueB.Size = new System.Drawing.Size(171, 31);
            this.txtValueB.TabIndex = 1;
            this.txtValueB.TextChanged += new System.EventHandler(this.txtValueB_TextChanged);
            // 
            // txtValueC
            // 
            this.txtValueC.Location = new System.Drawing.Point(570, 159);
            this.txtValueC.Name = "txtValueC";
            this.txtValueC.Size = new System.Drawing.Size(171, 31);
            this.txtValueC.TabIndex = 2;
            this.txtValueC.TextChanged += new System.EventHandler(this.txtValueC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(238, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equazione di Secondo Grado ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtValueX1
            // 
            this.txtValueX1.Location = new System.Drawing.Point(570, 264);
            this.txtValueX1.Name = "txtValueX1";
            this.txtValueX1.ReadOnly = true;
            this.txtValueX1.Size = new System.Drawing.Size(171, 31);
            this.txtValueX1.TabIndex = 9;
            this.txtValueX1.TextChanged += new System.EventHandler(this.txtValueX1_TextChanged);
            // 
            // txtValueX2
            // 
            this.txtValueX2.Location = new System.Drawing.Point(570, 369);
            this.txtValueX2.Name = "txtValueX2";
            this.txtValueX2.ReadOnly = true;
            this.txtValueX2.Size = new System.Drawing.Size(171, 31);
            this.txtValueX2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(642, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "X1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(642, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "X2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnUguale
            // 
            this.btnUguale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUguale.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUguale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUguale.Location = new System.Drawing.Point(317, 293);
            this.btnUguale.Name = "btnUguale";
            this.btnUguale.Size = new System.Drawing.Size(163, 73);
            this.btnUguale.TabIndex = 28;
            this.btnUguale.Text = "Calcola";
            this.btnUguale.UseVisualStyleBackColor = false;
            this.btnUguale.Click += new System.EventHandler(this.btnUguale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(130, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(371, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(642, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "c";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(275, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 29);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "ax^2 + bx + c";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EquazioneDiSecondoGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUguale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValueX2);
            this.Controls.Add(this.txtValueX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValueC);
            this.Controls.Add(this.txtValueB);
            this.Controls.Add(this.txtValueA);
            this.Name = "EquazioneDiSecondoGrado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EquazioneDiSecondoGrado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValueA;
        private System.Windows.Forms.TextBox txtValueB;
        private System.Windows.Forms.TextBox txtValueC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValueX1;
        private System.Windows.Forms.TextBox txtValueX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUguale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

