namespace Gestor_Centro_Educativo
{
    partial class docente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docente));
            this.volver_btn = new System.Windows.Forms.PictureBox();
            this.TittleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.estudiantes_box = new System.Windows.Forms.Label();
            this.Materia = new System.Windows.Forms.ComboBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.nombre = new System.Windows.Forms.ColumnHeader();
            this.nota1 = new System.Windows.Forms.ColumnHeader();
            this.nota2 = new System.Windows.Forms.ColumnHeader();
            this.nota3 = new System.Windows.Forms.ColumnHeader();
            this.final = new System.Windows.Forms.ColumnHeader();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.primera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.segunda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tercera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.verificar_id = new System.Windows.Forms.Button();
            this.materia_buscar = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volver_btn)).BeginInit();
            this.TittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // volver_btn
            // 
            this.volver_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.volver_btn.Location = new System.Drawing.Point(12, 12);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(33, 23);
            this.volver_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.volver_btn.TabIndex = 26;
            this.volver_btn.TabStop = false;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // TittleBar
            // 
            this.TittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.TittleBar.Controls.Add(this.pictureBox2);
            this.TittleBar.Controls.Add(this.pictureBox3);
            this.TittleBar.Controls.Add(this.pictureBox1);
            this.TittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittleBar.Location = new System.Drawing.Point(0, 0);
            this.TittleBar.Name = "TittleBar";
            this.TittleBar.Size = new System.Drawing.Size(803, 50);
            this.TittleBar.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestor_Centro_Educativo.Properties.Resources.icons8_macos_minimizar_32__1_;
            this.pictureBox2.Location = new System.Drawing.Point(739, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestor_Centro_Educativo.Properties.Resources.icons8_macos_cerrar_32__1_;
            this.pictureBox3.Location = new System.Drawing.Point(768, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 15);
            this.panel2.TabIndex = 28;
            // 
            // estudiantes_box
            // 
            this.estudiantes_box.AutoSize = true;
            this.estudiantes_box.Location = new System.Drawing.Point(188, 159);
            this.estudiantes_box.Name = "estudiantes_box";
            this.estudiantes_box.Size = new System.Drawing.Size(0, 15);
            this.estudiantes_box.TabIndex = 29;
            // 
            // Materia
            // 
            this.Materia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Materia.FormattingEnabled = true;
            this.Materia.Items.AddRange(new object[] {
            "Matemáticas",
            "Ciencias",
            "Español"});
            this.Materia.Location = new System.Drawing.Point(499, 227);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(121, 23);
            this.Materia.TabIndex = 30;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(242, 98);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(119, 40);
            this.Button1.TabIndex = 31;
            this.Button1.Text = "Estudiantes";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.nota1,
            this.nota2,
            this.nota3,
            this.final});
            this.listView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.listView.Location = new System.Drawing.Point(26, 177);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(417, 202);
            this.listView.TabIndex = 32;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nombre
            // 
            this.nombre.Text = "Estudiantes";
            this.nombre.Width = 145;
            // 
            // nota1
            // 
            this.nota1.Text = "30%";
            this.nota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nota2
            // 
            this.nota2.Text = "30%";
            this.nota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nota3
            // 
            this.nota3.Text = "40%";
            this.nota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // final
            // 
            this.final.Text = "Nota final";
            this.final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.final.Width = 90;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(499, 119);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(182, 19);
            this.txt_nombre.TabIndex = 33;
            this.txt_nombre.Text = "NOMBRE DE ESTUDIANTE";
            this.txt_nombre.Enter += new System.EventHandler(this.nombre_enter);
            this.txt_nombre.Leave += new System.EventHandler(this.nombre_leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(499, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "_______________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(499, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "SELECCIONE LA MATERIA";
            // 
            // primera
            // 
            this.primera.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.primera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.primera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.primera.ForeColor = System.Drawing.Color.Black;
            this.primera.Location = new System.Drawing.Point(499, 309);
            this.primera.Name = "primera";
            this.primera.Size = new System.Drawing.Size(35, 19);
            this.primera.TabIndex = 36;
            this.primera.Text = "30%";
            this.primera.Enter += new System.EventHandler(this.primer_enter);
            this.primera.Leave += new System.EventHandler(this.primer_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(499, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "_____";
            // 
            // segunda
            // 
            this.segunda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.segunda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.segunda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.segunda.ForeColor = System.Drawing.Color.Black;
            this.segunda.Location = new System.Drawing.Point(604, 309);
            this.segunda.Name = "segunda";
            this.segunda.Size = new System.Drawing.Size(35, 19);
            this.segunda.TabIndex = 38;
            this.segunda.Text = "30%";
            this.segunda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.segunda.Enter += new System.EventHandler(this.segundo_enter);
            this.segunda.Leave += new System.EventHandler(this.segundo_leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(604, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "_____";
            // 
            // tercera
            // 
            this.tercera.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tercera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tercera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tercera.ForeColor = System.Drawing.Color.Black;
            this.tercera.Location = new System.Drawing.Point(704, 309);
            this.tercera.Name = "tercera";
            this.tercera.Size = new System.Drawing.Size(35, 19);
            this.tercera.TabIndex = 40;
            this.tercera.Text = "40%";
            this.tercera.Enter += new System.EventHandler(this.tercera_enter);
            this.tercera.Leave += new System.EventHandler(this.tercera_leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(704, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "_____";
            // 
            // verificar_id
            // 
            this.verificar_id.BackColor = System.Drawing.Color.LightSlateGray;
            this.verificar_id.FlatAppearance.BorderSize = 0;
            this.verificar_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.verificar_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verificar_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verificar_id.ForeColor = System.Drawing.Color.White;
            this.verificar_id.Location = new System.Drawing.Point(580, 359);
            this.verificar_id.Name = "verificar_id";
            this.verificar_id.Size = new System.Drawing.Size(91, 30);
            this.verificar_id.TabIndex = 42;
            this.verificar_id.Text = "Guardar";
            this.verificar_id.UseVisualStyleBackColor = false;
            this.verificar_id.Click += new System.EventHandler(this.verificar_id_Click_1);
            // 
            // materia_buscar
            // 
            this.materia_buscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materia_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materia_buscar.FormattingEnabled = true;
            this.materia_buscar.Items.AddRange(new object[] {
            "Matemáticas",
            "Ciencias",
            "Español"});
            this.materia_buscar.Location = new System.Drawing.Point(54, 98);
            this.materia_buscar.Name = "materia_buscar";
            this.materia_buscar.Size = new System.Drawing.Size(121, 23);
            this.materia_buscar.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(116, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 25);
            this.button2.TabIndex = 44;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.materia_buscar);
            this.Controls.Add(this.verificar_id);
            this.Controls.Add(this.tercera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.segunda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.primera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Materia);
            this.Controls.Add(this.estudiantes_box);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TittleBar);
            this.Controls.Add(this.volver_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "docente";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "docente";
            this.Load += new System.EventHandler(this.docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volver_btn)).EndInit();
            this.TittleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox volver_btn;
        private Panel TittleBar;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label estudiantes_box;
        private ComboBox Materia;
        private Button Button1;
        private ListView listView;
        private ColumnHeader nombre;
        private TextBox txt_nombre;
        private Label label3;
        private Label label1;
        private TextBox primera;
        private Label label2;
        private TextBox segunda;
        private Label label4;
        private TextBox tercera;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ColumnHeader nota1;
        private ColumnHeader nota2;
        private ColumnHeader nota3;
        private Button verificar_id;
        private ColumnHeader final;
        private ComboBox materia_buscar;
        private Button button2;
    }
}