namespace InvPolizas
{
    partial class Polizas
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
            this.DtFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.CmbAEmpleado = new System.Windows.Forms.ComboBox();
            this.CmbSku = new System.Windows.Forms.ComboBox();
            this.TxtIdPoliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvPolzias = new System.Windows.Forms.DataGridView();
            this.IDPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPolzias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.label6);
            this.gbControl.Controls.Add(this.DgvPolzias);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.label4);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Controls.Add(this.TxtCantidad);
            this.gbControl.Controls.Add(this.TxtIdPoliza);
            this.gbControl.Controls.Add(this.CmbSku);
            this.gbControl.Controls.Add(this.CmbAEmpleado);
            this.gbControl.Controls.Add(this.DtFechaAlta);
            this.gbControl.Size = new System.Drawing.Size(732, 351);
            this.gbControl.Controls.SetChildIndex(this.DtFechaAlta, 0);
            this.gbControl.Controls.SetChildIndex(this.CmbAEmpleado, 0);
            this.gbControl.Controls.SetChildIndex(this.CmbSku, 0);
            this.gbControl.Controls.SetChildIndex(this.TxtIdPoliza, 0);
            this.gbControl.Controls.SetChildIndex(this.TxtCantidad, 0);
            this.gbControl.Controls.SetChildIndex(this.label1, 0);
            this.gbControl.Controls.SetChildIndex(this.label2, 0);
            this.gbControl.Controls.SetChildIndex(this.label3, 0);
            this.gbControl.Controls.SetChildIndex(this.label4, 0);
            this.gbControl.Controls.SetChildIndex(this.label5, 0);
            this.gbControl.Controls.SetChildIndex(this.DgvPolzias, 0);
            this.gbControl.Controls.SetChildIndex(this.label6, 0);
            // 
            // DtFechaAlta
            // 
            this.DtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFechaAlta.Location = new System.Drawing.Point(282, 55);
            this.DtFechaAlta.Name = "DtFechaAlta";
            this.DtFechaAlta.Size = new System.Drawing.Size(98, 20);
            this.DtFechaAlta.TabIndex = 1;
            // 
            // CmbAEmpleado
            // 
            this.CmbAEmpleado.FormattingEnabled = true;
            this.CmbAEmpleado.Location = new System.Drawing.Point(310, 23);
            this.CmbAEmpleado.Name = "CmbAEmpleado";
            this.CmbAEmpleado.Size = new System.Drawing.Size(199, 21);
            this.CmbAEmpleado.TabIndex = 2;
            // 
            // CmbSku
            // 
            this.CmbSku.FormattingEnabled = true;
            this.CmbSku.Location = new System.Drawing.Point(592, 23);
            this.CmbSku.Name = "CmbSku";
            this.CmbSku.Size = new System.Drawing.Size(121, 21);
            this.CmbSku.TabIndex = 3;
            this.CmbSku.SelectionChangeCommitted += new System.EventHandler(this.CmbSku_SelectionChangeCommitted);
            // 
            // TxtIdPoliza
            // 
            this.TxtIdPoliza.Location = new System.Drawing.Point(85, 23);
            this.TxtIdPoliza.Name = "TxtIdPoliza";
            this.TxtIdPoliza.Size = new System.Drawing.Size(100, 20);
            this.TxtIdPoliza.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Poliza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asignar Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asignar Sku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Asignar Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha:";
            // 
            // DgvPolzias
            // 
            this.DgvPolzias.AllowUserToAddRows = false;
            this.DgvPolzias.AllowUserToDeleteRows = false;
            this.DgvPolzias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPolzias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPolzias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPolzias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPolzias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPolzias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPoliza,
            this.Empleado,
            this.IDSku,
            this.Cantidad,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPolzias.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPolzias.Location = new System.Drawing.Point(30, 110);
            this.DgvPolzias.Name = "DgvPolzias";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPolzias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPolzias.Size = new System.Drawing.Size(683, 201);
            this.DgvPolzias.TabIndex = 11;
            // 
            // IDPoliza
            // 
            this.IDPoliza.DataPropertyName = "IDPoliza";
            this.IDPoliza.HeaderText = "Poliza";
            this.IDPoliza.Name = "IDPoliza";
            // 
            // Empleado
            // 
            this.Empleado.DataPropertyName = "Empleado";
            this.Empleado.HeaderText = "Nombre Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // IDSku
            // 
            this.IDSku.DataPropertyName = "IDSku";
            this.IDSku.HeaderText = "Sku";
            this.IDSku.Name = "IDSku";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha Creacion";
            this.Fecha.Name = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Polizas:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(123, 55);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(73, 20);
            this.TxtCantidad.TabIndex = 5;
            // 
            // Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 390);
            this.Name = "Polizas";
            this.Text = "Polizas";
            this.Load += new System.EventHandler(this.Polizas_Load);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPolzias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdPoliza;
        private System.Windows.Forms.ComboBox CmbSku;
        private System.Windows.Forms.ComboBox CmbAEmpleado;
        private System.Windows.Forms.DateTimePicker DtFechaAlta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvPolzias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.TextBox TxtCantidad;
    }
}