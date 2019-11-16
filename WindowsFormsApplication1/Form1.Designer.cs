namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.txtExaminar = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvSimbolos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaracteres = new System.Windows.Forms.TextBox();
            this.txtAntes = new System.Windows.Forms.TextBox();
            this.txtDespues = new System.Windows.Forms.TextBox();
            this.chkIndice = new System.Windows.Forms.CheckBox();
            this.chkHijos = new System.Windows.Forms.CheckBox();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.chkNodos = new System.Windows.Forms.CheckBox();
            this.chkCodigo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtTexto.Location = new System.Drawing.Point(13, 13);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(393, 351);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // txtExaminar
            // 
            this.txtExaminar.Location = new System.Drawing.Point(424, 30);
            this.txtExaminar.Name = "txtExaminar";
            this.txtExaminar.Size = new System.Drawing.Size(306, 20);
            this.txtExaminar.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(737, 30);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(31, 19);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archivo";
            // 
            // gdvSimbolos
            // 
            this.gdvSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvSimbolos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gdvSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvSimbolos.Location = new System.Drawing.Point(424, 109);
            this.gdvSimbolos.Name = "gdvSimbolos";
            this.gdvSimbolos.ReadOnly = true;
            this.gdvSimbolos.RowHeadersVisible = false;
            this.gdvSimbolos.Size = new System.Drawing.Size(511, 255);
            this.gdvSimbolos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caracteres leídos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bits sin compresión:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bits con compresión:";
            // 
            // txtCaracteres
            // 
            this.txtCaracteres.Enabled = false;
            this.txtCaracteres.Location = new System.Drawing.Point(424, 76);
            this.txtCaracteres.Name = "txtCaracteres";
            this.txtCaracteres.Size = new System.Drawing.Size(90, 20);
            this.txtCaracteres.TabIndex = 8;
            // 
            // txtAntes
            // 
            this.txtAntes.Enabled = false;
            this.txtAntes.Location = new System.Drawing.Point(545, 76);
            this.txtAntes.Name = "txtAntes";
            this.txtAntes.Size = new System.Drawing.Size(97, 20);
            this.txtAntes.TabIndex = 9;
            // 
            // txtDespues
            // 
            this.txtDespues.Enabled = false;
            this.txtDespues.Location = new System.Drawing.Point(671, 76);
            this.txtDespues.Name = "txtDespues";
            this.txtDespues.Size = new System.Drawing.Size(97, 20);
            this.txtDespues.TabIndex = 10;
            // 
            // chkIndice
            // 
            this.chkIndice.AutoSize = true;
            this.chkIndice.Location = new System.Drawing.Point(424, 370);
            this.chkIndice.Name = "chkIndice";
            this.chkIndice.Size = new System.Drawing.Size(55, 17);
            this.chkIndice.TabIndex = 11;
            this.chkIndice.Text = "Indice";
            this.chkIndice.UseVisualStyleBackColor = true;
            this.chkIndice.CheckedChanged += new System.EventHandler(this.ChkIndice_CheckedChanged);
            // 
            // chkHijos
            // 
            this.chkHijos.AutoSize = true;
            this.chkHijos.Location = new System.Drawing.Point(592, 370);
            this.chkHijos.Name = "chkHijos";
            this.chkHijos.Size = new System.Drawing.Size(49, 17);
            this.chkHijos.TabIndex = 12;
            this.chkHijos.Text = "Hijos";
            this.chkHijos.UseVisualStyleBackColor = true;
            this.chkHijos.CheckedChanged += new System.EventHandler(this.ChkHijos_CheckedChanged);
            // 
            // chkInfo
            // 
            this.chkInfo.AutoSize = true;
            this.chkInfo.Location = new System.Drawing.Point(705, 370);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(63, 17);
            this.chkInfo.TabIndex = 13;
            this.chkInfo.Text = "Info bits";
            this.chkInfo.UseVisualStyleBackColor = true;
            this.chkInfo.CheckedChanged += new System.EventHandler(this.ChkInfo_CheckedChanged);
            // 
            // chkNodos
            // 
            this.chkNodos.AutoSize = true;
            this.chkNodos.Location = new System.Drawing.Point(476, 370);
            this.chkNodos.Name = "chkNodos";
            this.chkNodos.Size = new System.Drawing.Size(110, 17);
            this.chkNodos.TabIndex = 14;
            this.chkNodos.Text = "Nodos agregados";
            this.chkNodos.UseVisualStyleBackColor = true;
            this.chkNodos.CheckedChanged += new System.EventHandler(this.ChkNodos_CheckedChanged);
            // 
            // chkCodigo
            // 
            this.chkCodigo.AutoSize = true;
            this.chkCodigo.Location = new System.Drawing.Point(640, 370);
            this.chkCodigo.Name = "chkCodigo";
            this.chkCodigo.Size = new System.Drawing.Size(59, 17);
            this.chkCodigo.TabIndex = 15;
            this.chkCodigo.Text = "Código";
            this.chkCodigo.UseVisualStyleBackColor = true;
            this.chkCodigo.CheckedChanged += new System.EventHandler(this.ChkCodigo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(938, 396);
            this.Controls.Add(this.chkCodigo);
            this.Controls.Add(this.chkNodos);
            this.Controls.Add(this.chkInfo);
            this.Controls.Add(this.chkHijos);
            this.Controls.Add(this.chkIndice);
            this.Controls.Add(this.txtDespues);
            this.Controls.Add(this.txtAntes);
            this.Controls.Add(this.txtCaracteres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gdvSimbolos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtExaminar);
            this.Controls.Add(this.rtxtTexto);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvSimbolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.TextBox txtExaminar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdvSimbolos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaracteres;
        private System.Windows.Forms.TextBox txtAntes;
        private System.Windows.Forms.TextBox txtDespues;
        private System.Windows.Forms.CheckBox chkIndice;
        private System.Windows.Forms.CheckBox chkHijos;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.CheckBox chkNodos;
        private System.Windows.Forms.CheckBox chkCodigo;
    }
}

