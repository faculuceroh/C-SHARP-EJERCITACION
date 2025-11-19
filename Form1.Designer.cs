namespace CALCULADORA
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
            BTB1 = new Button();
            BTB2 = new Button();
            BTB3 = new Button();
            BTB4 = new Button();
            TXT1 = new TextBox();
            TXT2 = new TextBox();
            LBLRESULTADO = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BTB1
            // 
            BTB1.Location = new Point(112, 314);
            BTB1.Name = "BTB1";
            BTB1.Size = new Size(285, 38);
            BTB1.TabIndex = 0;
            BTB1.Text = "SUMAR";
            BTB1.UseVisualStyleBackColor = true;
            BTB1.Click += BTB1_Click;
            // 
            // BTB2
            // 
            BTB2.Location = new Point(112, 408);
            BTB2.Name = "BTB2";
            BTB2.Size = new Size(281, 36);
            BTB2.TabIndex = 1;
            BTB2.Text = "RESTAR";
            BTB2.UseVisualStyleBackColor = true;
            BTB2.Click += BTB2_Click;
            // 
            // BTB3
            // 
            BTB3.Location = new Point(574, 317);
            BTB3.Name = "BTB3";
            BTB3.Size = new Size(324, 41);
            BTB3.TabIndex = 2;
            BTB3.Text = "MULTIPLICAR";
            BTB3.UseVisualStyleBackColor = true;
            BTB3.Click += BTB3_Click;
            // 
            // BTB4
            // 
            BTB4.Location = new Point(571, 395);
            BTB4.Name = "BTB4";
            BTB4.Size = new Size(326, 37);
            BTB4.TabIndex = 3;
            BTB4.Text = "DIVIDIR";
            BTB4.UseVisualStyleBackColor = true;
            BTB4.Click += BTB4_Click;
            // 
            // TXT1
            // 
            TXT1.Location = new Point(112, 105);
            TXT1.Name = "TXT1";
            TXT1.Size = new Size(194, 23);
            TXT1.TabIndex = 4;
            // 
            // TXT2
            // 
            TXT2.Location = new Point(409, 105);
            TXT2.Name = "TXT2";
            TXT2.Size = new Size(237, 23);
            TXT2.TabIndex = 5;
            // 
            // LBLRESULTADO
            // 
            LBLRESULTADO.AutoSize = true;
            LBLRESULTADO.Location = new Point(719, 60);
            LBLRESULTADO.Name = "LBLRESULTADO";
            LBLRESULTADO.Size = new Size(0, 15);
            LBLRESULTADO.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 73);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 7;
            label1.Text = "Ingrese un Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 73);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 8;
            label2.Text = "Ingrese un Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(640, 60);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "RESULTADO:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 537);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LBLRESULTADO);
            Controls.Add(TXT2);
            Controls.Add(TXT1);
            Controls.Add(BTB4);
            Controls.Add(BTB3);
            Controls.Add(BTB2);
            Controls.Add(BTB1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTB1;
        private Button BTB2;
        private Button BTB3;
        private Button BTB4;
        private TextBox TXT1;
        private TextBox TXT2;
        private Label LBLRESULTADO;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
