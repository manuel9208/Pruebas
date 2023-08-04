namespace InvPolizas
{
    partial class Empleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtAPaterno = new System.Windows.Forms.TextBox();
            this.TxtAMaterno = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbPuestos = new System.Windows.Forms.ComboBox();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.DgvEmpleados);
            this.gbControl.Controls.Add(this.CmbPuestos);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.label4);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.Label1);
            this.gbControl.Controls.Add(this.TxtAMaterno);
            this.gbControl.Controls.Add(this.TxtAPaterno);
            this.gbControl.Controls.Add(this.TxtNombres);
            this.gbControl.Controls.Add(this.TxtEmpleado);
            this.gbControl.Size = new System.Drawing.Size(577, 371);
            this.gbControl.Controls.SetChildIndex(this.TxtEmpleado, 0);
            this.gbControl.Controls.SetChildIndex(this.TxtNombres, 0);
            this.gbControl.Controls.SetChildIndex(this.TxtAPaterno, 0);
            this.gbControl.Controls.SetChildIndex(this.TxtAMaterno, 0);
            this.gbControl.Controls.SetChildIndex(this.Label1, 0);
            this.gbControl.Controls.SetChildIndex(this.label2, 0);
            this.gbControl.Controls.SetChildIndex(this.label3, 0);
            this.gbControl.Controls.SetChildIndex(this.label4, 0);
            this.gbControl.Controls.SetChildIndex(this.label5, 0);
            this.gbControl.Controls.SetChildIndex(this.CmbPuestos, 0);
            this.gbControl.Controls.SetChildIndex(this.DgvEmpleados, 0);
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Enabled = false;
            this.TxtEmpleado.Location = new System.Drawing.Point(84, 24);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.TxtEmpleado.TabIndex = 1;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(70, 59);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(114, 20);
            this.TxtNombres.TabIndex = 2;
            // 
            // TxtAPaterno
            // 
            this.TxtAPaterno.Location = new System.Drawing.Point(105, 90);
            this.TxtAPaterno.Name = "TxtAPaterno";
            this.TxtAPaterno.Size = new System.Drawing.Size(110, 20);
            this.TxtAPaterno.TabIndex = 3;
            // 
            // TxtAMaterno
            // 
            this.TxtAMaterno.Location = new System.Drawing.Point(105, 123);
            this.TxtAMaterno.Name = "TxtAMaterno";
            this.TxtAMaterno.Size = new System.Drawing.Size(110, 20);
            this.TxtAMaterno.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Id Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Puesto:";
            // 
            // CmbPuestos
            // 
            this.CmbPuestos.FormattingEnabled = true;
            this.CmbPuestos.Location = new System.Drawing.Point(63, 155);
            this.CmbPuestos.Name = "CmbPuestos";
            this.CmbPuestos.Size = new System.Drawing.Size(121, 21);
            this.CmbPuestos.TabIndex = 11;
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.AllowUserToAddRows = false;
            this.DgvEmpleados.AllowUserToDeleteRows = false;
            this.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.Nombres,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.Puesto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEmpleados.Location = new System.Drawing.Point(15, 193);
            this.DgvEmpleados.Name = "DgvEmpleados";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEmpleados.Size = new System.Drawing.Size(550, 150);
            this.DgvEmpleados.TabIndex = 12;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.DataPropertyName = "IdEmpleado";
            this.IdEmpleado.HeaderText = "ID Empleado";
            this.IdEmpleado.Name = "IdEmpleado";
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.DataPropertyName = "Apellido_Paterno";
            this.Apellido_Paterno.HeaderText = "Apellido Paterno";
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.DataPropertyName = "Apellido_Materno";
            this.Apellido_Materno.HeaderText = "Apellido Materno";
            this.Apellido_Materno.Name = "Apellido_Materno";
            // 
            // Puesto
            // 
            this.Puesto.DataPropertyName = "Puesto";
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 410);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbPuestos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtAMaterno;
        private System.Windows.Forms.TextBox TxtAPaterno;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
    }
}