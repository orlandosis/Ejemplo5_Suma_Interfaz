namespace Suma_Interfaz
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
            txt_numero = new TextBox();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            SumaDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 89);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "Calcular suma de 1 hasta : ";
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(377, 86);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(254, 27);
            txt_numero.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(177, 218);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(454, 204);
            listBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(177, 158);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(187, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Ver resultados parciales";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // SumaDatos
            // 
            SumaDatos.Location = new Point(262, 454);
            SumaDatos.Name = "SumaDatos";
            SumaDatos.Size = new Size(301, 37);
            SumaDatos.TabIndex = 4;
            SumaDatos.Text = "Iniciar";
            SumaDatos.UseVisualStyleBackColor = true;
            SumaDatos.Click += SumaDatos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 526);
            Controls.Add(SumaDatos);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(txt_numero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_numero;
        private ListBox listBox1;
        private CheckBox checkBox1;
        private Button SumaDatos;
    }
}