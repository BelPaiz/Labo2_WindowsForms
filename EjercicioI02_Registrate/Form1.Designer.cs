namespace EjercicioI02_Registrate
{
    partial class frm_registro
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
            this.gpb_detallesUsuario = new System.Windows.Forms.GroupBox();
            this.nud_edad = new System.Windows.Forms.NumericUpDown();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.gpb_genero = new System.Windows.Forms.GroupBox();
            this.rdbtn_nBinar = new System.Windows.Forms.RadioButton();
            this.rdbtn_femenino = new System.Windows.Forms.RadioButton();
            this.rdbtn_masculino = new System.Windows.Forms.RadioButton();
            this.gpb_cursos = new System.Windows.Forms.GroupBox();
            this.ckb_jS = new System.Windows.Forms.CheckBox();
            this.ckb_cMasMas = new System.Windows.Forms.CheckBox();
            this.ckb_cSharp = new System.Windows.Forms.CheckBox();
            this.lstb_paises = new System.Windows.Forms.ListBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.gpb_detallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).BeginInit();
            this.gpb_genero.SuspendLayout();
            this.gpb_cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_detallesUsuario
            // 
            this.gpb_detallesUsuario.Controls.Add(this.nud_edad);
            this.gpb_detallesUsuario.Controls.Add(this.lbl_edad);
            this.gpb_detallesUsuario.Controls.Add(this.lbl_direccion);
            this.gpb_detallesUsuario.Controls.Add(this.txb_direccion);
            this.gpb_detallesUsuario.Controls.Add(this.lbl_nombre);
            this.gpb_detallesUsuario.Controls.Add(this.txb_nombre);
            this.gpb_detallesUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpb_detallesUsuario.Location = new System.Drawing.Point(61, 38);
            this.gpb_detallesUsuario.Name = "gpb_detallesUsuario";
            this.gpb_detallesUsuario.Size = new System.Drawing.Size(270, 204);
            this.gpb_detallesUsuario.TabIndex = 0;
            this.gpb_detallesUsuario.TabStop = false;
            this.gpb_detallesUsuario.Text = "Detalles del usuario";
            // 
            // nud_edad
            // 
            this.nud_edad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_edad.Location = new System.Drawing.Point(122, 138);
            this.nud_edad.Name = "nud_edad";
            this.nud_edad.Size = new System.Drawing.Size(120, 29);
            this.nud_edad.TabIndex = 5;
            this.nud_edad.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_edad.Location = new System.Drawing.Point(26, 140);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(44, 21);
            this.lbl_edad.TabIndex = 4;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_direccion.Location = new System.Drawing.Point(26, 91);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(75, 21);
            this.lbl_direccion.TabIndex = 3;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_direccion.Location = new System.Drawing.Point(122, 88);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.PlaceholderText = "direccion";
            this.txb_direccion.Size = new System.Drawing.Size(119, 29);
            this.txb_direccion.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(26, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 21);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_nombre.Location = new System.Drawing.Point(119, 37);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "nombre";
            this.txb_nombre.Size = new System.Drawing.Size(119, 29);
            this.txb_nombre.TabIndex = 0;
            // 
            // gpb_genero
            // 
            this.gpb_genero.Controls.Add(this.rdbtn_nBinar);
            this.gpb_genero.Controls.Add(this.rdbtn_femenino);
            this.gpb_genero.Controls.Add(this.rdbtn_masculino);
            this.gpb_genero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpb_genero.Location = new System.Drawing.Point(376, 37);
            this.gpb_genero.Name = "gpb_genero";
            this.gpb_genero.Size = new System.Drawing.Size(200, 182);
            this.gpb_genero.TabIndex = 1;
            this.gpb_genero.TabStop = false;
            this.gpb_genero.Text = "Género";
            // 
            // rdbtn_nBinar
            // 
            this.rdbtn_nBinar.AutoSize = true;
            this.rdbtn_nBinar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn_nBinar.Location = new System.Drawing.Point(35, 137);
            this.rdbtn_nBinar.Name = "rdbtn_nBinar";
            this.rdbtn_nBinar.Size = new System.Drawing.Size(102, 25);
            this.rdbtn_nBinar.TabIndex = 2;
            this.rdbtn_nBinar.TabStop = true;
            this.rdbtn_nBinar.Text = "No binario";
            this.rdbtn_nBinar.UseVisualStyleBackColor = true;
            // 
            // rdbtn_femenino
            // 
            this.rdbtn_femenino.AutoSize = true;
            this.rdbtn_femenino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn_femenino.Location = new System.Drawing.Point(35, 88);
            this.rdbtn_femenino.Name = "rdbtn_femenino";
            this.rdbtn_femenino.Size = new System.Drawing.Size(97, 25);
            this.rdbtn_femenino.TabIndex = 1;
            this.rdbtn_femenino.TabStop = true;
            this.rdbtn_femenino.Text = "Femenino";
            this.rdbtn_femenino.UseVisualStyleBackColor = true;
            // 
            // rdbtn_masculino
            // 
            this.rdbtn_masculino.AutoSize = true;
            this.rdbtn_masculino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn_masculino.Location = new System.Drawing.Point(35, 37);
            this.rdbtn_masculino.Name = "rdbtn_masculino";
            this.rdbtn_masculino.Size = new System.Drawing.Size(99, 25);
            this.rdbtn_masculino.TabIndex = 0;
            this.rdbtn_masculino.TabStop = true;
            this.rdbtn_masculino.Text = "Masculino";
            this.rdbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_cursos
            // 
            this.gpb_cursos.Controls.Add(this.ckb_jS);
            this.gpb_cursos.Controls.Add(this.ckb_cMasMas);
            this.gpb_cursos.Controls.Add(this.ckb_cSharp);
            this.gpb_cursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpb_cursos.Location = new System.Drawing.Point(376, 235);
            this.gpb_cursos.Name = "gpb_cursos";
            this.gpb_cursos.Size = new System.Drawing.Size(200, 169);
            this.gpb_cursos.TabIndex = 2;
            this.gpb_cursos.TabStop = false;
            this.gpb_cursos.Text = "Cursos";
            // 
            // ckb_jS
            // 
            this.ckb_jS.AutoSize = true;
            this.ckb_jS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckb_jS.Location = new System.Drawing.Point(35, 109);
            this.ckb_jS.Name = "ckb_jS";
            this.ckb_jS.Size = new System.Drawing.Size(115, 29);
            this.ckb_jS.TabIndex = 2;
            this.ckb_jS.Text = "JavaScript";
            this.ckb_jS.UseVisualStyleBackColor = true;
            // 
            // ckb_cMasMas
            // 
            this.ckb_cMasMas.AutoSize = true;
            this.ckb_cMasMas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckb_cMasMas.Location = new System.Drawing.Point(35, 67);
            this.ckb_cMasMas.Name = "ckb_cMasMas";
            this.ckb_cMasMas.Size = new System.Drawing.Size(66, 29);
            this.ckb_cMasMas.TabIndex = 1;
            this.ckb_cMasMas.Text = "c++";
            this.ckb_cMasMas.UseVisualStyleBackColor = true;
            // 
            // ckb_cSharp
            // 
            this.ckb_cSharp.AutoSize = true;
            this.ckb_cSharp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckb_cSharp.Location = new System.Drawing.Point(35, 25);
            this.ckb_cSharp.Name = "ckb_cSharp";
            this.ckb_cSharp.Size = new System.Drawing.Size(51, 29);
            this.ckb_cSharp.TabIndex = 0;
            this.ckb_cSharp.Text = "c#";
            this.ckb_cSharp.UseVisualStyleBackColor = true;
            // 
            // lstb_paises
            // 
            this.lstb_paises.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstb_paises.FormattingEnabled = true;
            this.lstb_paises.ItemHeight = 21;
            this.lstb_paises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lstb_paises.Location = new System.Drawing.Point(64, 316);
            this.lstb_paises.Name = "lstb_paises";
            this.lstb_paises.Size = new System.Drawing.Size(267, 151);
            this.lstb_paises.TabIndex = 3;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pais.Location = new System.Drawing.Point(63, 284);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(37, 21);
            this.lbl_pais.TabIndex = 4;
            this.lbl_pais.Text = "País";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.Location = new System.Drawing.Point(430, 432);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(146, 35);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // frm_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 507);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lstb_paises);
            this.Controls.Add(this.gpb_cursos);
            this.Controls.Add(this.gpb_genero);
            this.Controls.Add(this.gpb_detallesUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.gpb_detallesUsuario.ResumeLayout(false);
            this.gpb_detallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).EndInit();
            this.gpb_genero.ResumeLayout(false);
            this.gpb_genero.PerformLayout();
            this.gpb_cursos.ResumeLayout(false);
            this.gpb_cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gpb_detallesUsuario;
        private NumericUpDown nud_edad;
        private Label lbl_edad;
        private Label lbl_direccion;
        private TextBox txb_direccion;
        private Label lbl_nombre;
        private TextBox txb_nombre;
        private GroupBox gpb_genero;
        private RadioButton rdbtn_nBinar;
        private RadioButton rdbtn_femenino;
        private RadioButton rdbtn_masculino;
        private GroupBox gpb_cursos;
        private CheckBox ckb_jS;
        private CheckBox ckb_cMasMas;
        private CheckBox ckb_cSharp;
        private ListBox lstb_paises;
        private Label lbl_pais;
        private Button btn_ingresar;
    }
}