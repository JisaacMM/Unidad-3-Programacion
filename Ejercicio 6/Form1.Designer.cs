namespace Ejercicio_6
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(639, 31);
            label1.TabIndex = 0;
            label1.Text = "Imprime números de un rango específico y calcula la suma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 83);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 1;
            label2.Text = "Rango inferior";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 155);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 2;
            label3.Text = "Rango superior";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 347);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 3;
            label4.Text = "suma";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(420, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(207, 298);
            listBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(52, 228);
            button1.Name = "button1";
            button1.Size = new Size(313, 38);
            button1.TabIndex = 5;
            button1.Text = "Imprime";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(240, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(240, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(133, 347);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 34);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 415);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
