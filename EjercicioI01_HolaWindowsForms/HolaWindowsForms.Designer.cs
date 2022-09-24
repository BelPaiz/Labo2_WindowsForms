namespace EjercicioI01_HolaWindowsForms
{
    partial class frm_HolaWindowsForms
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
            this.btn_saludar = new System.Windows.Forms.Button();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.lbl_nomre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.cmb_materiaFavorita = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_saludar
            // 
            this.btn_saludar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_saludar.Location = new System.Drawing.Point(489, 274);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(190, 40);
            this.btn_saludar.TabIndex = 0;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // txb_nombre
            // 
            this.txb_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_nombre.Location = new System.Drawing.Point(41, 111);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Ingrese nombre";
            this.txb_nombre.Size = new System.Drawing.Size(277, 29);
            this.txb_nombre.TabIndex = 1;
            // 
            // txb_apellido
            // 
            this.txb_apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_apellido.Location = new System.Drawing.Point(454, 111);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.PlaceholderText = "Ingrese apellido";
            this.txb_apellido.Size = new System.Drawing.Size(277, 29);
            this.txb_apellido.TabIndex = 2;
            // 
            // lbl_nomre
            // 
            this.lbl_nomre.AutoSize = true;
            this.lbl_nomre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomre.Location = new System.Drawing.Point(41, 66);
            this.lbl_nomre.Name = "lbl_nomre";
            this.lbl_nomre.Size = new System.Drawing.Size(73, 19);
            this.lbl_nomre.TabIndex = 3;
            this.lbl_nomre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.Location = new System.Drawing.Point(454, 66);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(75, 19);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido";
            // 
            // cmb_materiaFavorita
            // 
            this.cmb_materiaFavorita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_materiaFavorita.Items.AddRange(new object[] {
            "Programacion I",
            "Laboratorio I",
            "Matematica",
            "SPD",
            "Ingles I",
            "Programacion II",
            "Laboratorio II",
            "Estadistica",
            "Aquitectura y Sistemas Operativos",
            "Ingles II",
            "Metodologia de la Investigacion"});
            this.cmb_materiaFavorita.Location = new System.Drawing.Point(41, 207);
            this.cmb_materiaFavorita.Name = "cmb_materiaFavorita";
            this.cmb_materiaFavorita.Size = new System.Drawing.Size(690, 29);
            this.cmb_materiaFavorita.TabIndex = 5;
            this.cmb_materiaFavorita.Text = "Seleccionar";
            // 
            // frm_HolaWindowsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.cmb_materiaFavorita);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nomre);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.btn_saludar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HolaWindowsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_saludar;
        private TextBox txb_nombre;
        private TextBox txb_apellido;
        private Label lbl_nomre;
        private Label lbl_apellido;
        private ComboBox cmb_materiaFavorita;
    }
}