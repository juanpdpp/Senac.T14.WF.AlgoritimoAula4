namespace WinFormsAppAlgoritimo
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 39);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 0;
            label1.Text = "Numero da Conta";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(15, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "12314";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 39);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 2;
            label2.Text = "Titular da Conta";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Fuchsia;
            textBox2.Location = new Point(306, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(456, 34);
            textBox2.TabIndex = 3;
            textBox2.Text = "Juan Martins";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 113);
            label3.Name = "label3";
            label3.Size = new Size(146, 28);
            label3.TabIndex = 4;
            label3.Text = "Saldo da Conta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 113);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 5;
            label4.Text = "Tipo da Conta";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.SandyBrown;
            textBox3.Location = new Point(17, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 34);
            textBox3.TabIndex = 6;
            textBox3.Text = "1000";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(306, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(456, 34);
            textBox4.TabIndex = 7;
            textBox4.Text = "Corrente";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.MenuHighlight;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(14, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 213);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Cliente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
    }
}
