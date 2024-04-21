namespace GestionEstudiantes
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            AgregarEstudiante = new Button();
            EliminarEstudiante = new Button();
            ListaEstudiantes = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Nombre = new TextBox();
            Apellido = new TextBox();
            Correo = new TextBox();
            Curso = new TextBox();
            Nivel = new TextBox();
            FechaNacimiento = new MaskedTextBox();
            NumeroTelefonico = new MaskedTextBox();
            SuspendLayout();
            // 
            // AgregarEstudiante
            // 
            AgregarEstudiante.Location = new Point(418, 332);
            AgregarEstudiante.Name = "AgregarEstudiante";
            AgregarEstudiante.Size = new Size(145, 23);
            AgregarEstudiante.TabIndex = 1;
            AgregarEstudiante.Text = "Agregar Estudiante";
            AgregarEstudiante.UseVisualStyleBackColor = true;
            AgregarEstudiante.Click += AgregarEstudiante_Click;
            // 
            // EliminarEstudiante
            // 
            EliminarEstudiante.Location = new Point(582, 332);
            EliminarEstudiante.Name = "EliminarEstudiante";
            EliminarEstudiante.Size = new Size(145, 23);
            EliminarEstudiante.TabIndex = 3;
            EliminarEstudiante.Text = "Eliminar Estudiante";
            EliminarEstudiante.UseVisualStyleBackColor = true;
            EliminarEstudiante.Click += EliminarEstudiante_Click;
            // 
            // ListaEstudiantes
            // 
            ListaEstudiantes.Font = new Font("Segoe UI", 9F);
            ListaEstudiantes.FormattingEnabled = true;
            ListaEstudiantes.ItemHeight = 15;
            ListaEstudiantes.Location = new Point(347, 45);
            ListaEstudiantes.Name = "ListaEstudiantes";
            ListaEstudiantes.Size = new Size(839, 244);
            ListaEstudiantes.TabIndex = 4;
            ListaEstudiantes.SelectedIndexChanged += ListaEstudiantes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Showcard Gothic", 20F);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 33);
            label1.TabIndex = 5;
            label1.Text = "Lista de estudiantes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 75);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 140);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Correo";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(203, 140);
            Label5.Name = "Label5";
            Label5.Size = new Size(38, 15);
            Label5.TabIndex = 10;
            Label5.Text = "Curso";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(21, 199);
            Label6.Name = "Label6";
            Label6.Size = new Size(74, 15);
            Label6.TabIndex = 11;
            Label6.Text = "Nivel escolar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 199);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 12;
            label7.Text = "Numero Telefonico";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 270);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 13;
            label8.Text = "Fecha de nacimiento";
            label8.Click += label8_Click;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(21, 93);
            Nombre.Name = "Nombre";
            Nombre.PlaceholderText = "Nombre de esrudiante";
            Nombre.Size = new Size(124, 23);
            Nombre.TabIndex = 14;
            Nombre.TextChanged += Nombre_TextChanged;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(203, 93);
            Apellido.Name = "Apellido";
            Apellido.PlaceholderText = "Apellido del estudiante";
            Apellido.Size = new Size(138, 23);
            Apellido.TabIndex = 15;
            // 
            // Correo
            // 
            Correo.Location = new Point(21, 158);
            Correo.Name = "Correo";
            Correo.PlaceholderText = "ejemplo@hotmail.com";
            Correo.Size = new Size(139, 23);
            Correo.TabIndex = 16;
            // 
            // Curso
            // 
            Curso.Location = new Point(203, 158);
            Curso.Name = "Curso";
            Curso.PlaceholderText = "primero, segundo o etc";
            Curso.Size = new Size(138, 23);
            Curso.TabIndex = 17;
            // 
            // Nivel
            // 
            Nivel.Location = new Point(12, 224);
            Nivel.Name = "Nivel";
            Nivel.PlaceholderText = "Primaria/Secundaria";
            Nivel.Size = new Size(117, 23);
            Nivel.TabIndex = 18;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Location = new Point(12, 303);
            FechaNacimiento.Mask = "00/00/0000";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(101, 23);
            FechaNacimiento.TabIndex = 19;
            FechaNacimiento.ValidatingType = typeof(DateTime);
            // 
            // NumeroTelefonico
            // 
            NumeroTelefonico.Location = new Point(203, 224);
            NumeroTelefonico.Mask = "(999)000-0000";
            NumeroTelefonico.Name = "NumeroTelefonico";
            NumeroTelefonico.Size = new Size(100, 23);
            NumeroTelefonico.TabIndex = 20;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1198, 413);
            Controls.Add(NumeroTelefonico);
            Controls.Add(FechaNacimiento);
            Controls.Add(Nivel);
            Controls.Add(Curso);
            Controls.Add(Correo);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListaEstudiantes);
            Controls.Add(EliminarEstudiante);
            Controls.Add(AgregarEstudiante);
            Name = "principal";
            Text = "Form1";
            Load += principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AgregarEstudiante;
        private Button EliminarEstudiante;
        private ListBox ListaEstudiantes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Label5;
        private Label Label6;
        private Label label7;
        private Label label8;
        private TextBox Nombre;
        private TextBox Apellido;
        private TextBox Correo;
        private TextBox Curso;
        private TextBox Nivel;
        private MaskedTextBox FechaNacimiento;
        private MaskedTextBox NumeroTelefonico;
    }
}
