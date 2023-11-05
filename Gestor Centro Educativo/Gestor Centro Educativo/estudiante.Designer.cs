namespace Gestor_Centro_Educativo
{
    partial class estudiante
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
            this.ver_notas_btn = new System.Windows.Forms.Button();
            this.notas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ver_notas_btn
            // 
            this.ver_notas_btn.Location = new System.Drawing.Point(88, 44);
            this.ver_notas_btn.Name = "ver_notas_btn";
            this.ver_notas_btn.Size = new System.Drawing.Size(75, 23);
            this.ver_notas_btn.TabIndex = 0;
            this.ver_notas_btn.Text = "Ver notas";
            this.ver_notas_btn.UseVisualStyleBackColor = true;
            this.ver_notas_btn.Click += new System.EventHandler(this.ver_notas_btn_Click);
            // 
            // notas
            // 
            this.notas.AutoSize = true;
            this.notas.Location = new System.Drawing.Point(171, 219);
            this.notas.Name = "notas";
            this.notas.Size = new System.Drawing.Size(38, 15);
            this.notas.TabIndex = 1;
            this.notas.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notas);
            this.Controls.Add(this.ver_notas_btn);
            this.Name = "estudiante";
            this.Text = "estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ver_notas_btn;
        private Label notas;
        private Label label3;
        private Button button1;
    }
}