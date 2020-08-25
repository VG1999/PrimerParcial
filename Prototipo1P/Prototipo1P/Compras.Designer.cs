namespace Prototipo1P
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtIDFactura = new System.Windows.Forms.TextBox();
            this.lblIDFactura = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pnlContenedorGrid = new System.Windows.Forms.Panel();
            this.dgridDetalleFactura = new System.Windows.Forms.DataGridView();
            this.pnlEncabezadoCompra = new System.Windows.Forms.Panel();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbVideo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            this.pnlContenedorGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDetalleFactura)).BeginInit();
            this.pnlEncabezadoCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlBarra.Controls.Add(this.picSalir);
            this.pnlBarra.Controls.Add(this.picMinimizar);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(774, 41);
            this.pnlBarra.TabIndex = 1;
            // 
            // picSalir
            // 
            this.picSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Image = ((System.Drawing.Image)(resources.GetObject("picSalir.Image")));
            this.picSalir.Location = new System.Drawing.Point(738, 10);
            this.picSalir.Margin = new System.Windows.Forms.Padding(2);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(24, 24);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSalir.TabIndex = 4;
            this.picSalir.TabStop = false;
            // 
            // picMinimizar
            // 
            this.picMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(703, 10);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(24, 24);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimizar.TabIndex = 3;
            this.picMinimizar.TabStop = false;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.lblEtiqueta);
            this.pnlCuerpo.Controls.Add(this.txtIDFactura);
            this.pnlCuerpo.Controls.Add(this.lblIDFactura);
            this.pnlCuerpo.Controls.Add(this.lblTotal);
            this.pnlCuerpo.Controls.Add(this.btnRegistrar);
            this.pnlCuerpo.Controls.Add(this.pnlContenedorGrid);
            this.pnlCuerpo.Controls.Add(this.pnlEncabezadoCompra);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 41);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(774, 582);
            this.pnlCuerpo.TabIndex = 2;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(27, 591);
            this.lblEtiqueta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(53, 21);
            this.lblEtiqueta.TabIndex = 7;
            this.lblEtiqueta.Text = "Total:";
            // 
            // txtIDFactura
            // 
            this.txtIDFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIDFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFactura.Location = new System.Drawing.Point(146, 9);
            this.txtIDFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDFactura.Name = "txtIDFactura";
            this.txtIDFactura.Size = new System.Drawing.Size(90, 27);
            this.txtIDFactura.TabIndex = 6;
            // 
            // lblIDFactura
            // 
            this.lblIDFactura.AutoSize = true;
            this.lblIDFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFactura.Location = new System.Drawing.Point(20, 11);
            this.lblIDFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDFactura.Name = "lblIDFactura";
            this.lblIDFactura.Size = new System.Drawing.Size(105, 21);
            this.lblIDFactura.TabIndex = 4;
            this.lblIDFactura.Text = "No. Compra";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(79, 591);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 21);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(587, 574);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 53);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar Compra";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // pnlContenedorGrid
            // 
            this.pnlContenedorGrid.Controls.Add(this.dgridDetalleFactura);
            this.pnlContenedorGrid.Location = new System.Drawing.Point(22, 179);
            this.pnlContenedorGrid.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenedorGrid.Name = "pnlContenedorGrid";
            this.pnlContenedorGrid.Size = new System.Drawing.Size(697, 375);
            this.pnlContenedorGrid.TabIndex = 1;
            // 
            // dgridDetalleFactura
            // 
            this.dgridDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbVideo,
            this.txtCantidad,
            this.txtPrecio,
            this.txtSubtotal});
            this.dgridDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridDetalleFactura.Location = new System.Drawing.Point(0, 0);
            this.dgridDetalleFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dgridDetalleFactura.Name = "dgridDetalleFactura";
            this.dgridDetalleFactura.RowTemplate.Height = 24;
            this.dgridDetalleFactura.Size = new System.Drawing.Size(697, 375);
            this.dgridDetalleFactura.TabIndex = 0;
            // 
            // pnlEncabezadoCompra
            // 
            this.pnlEncabezadoCompra.BackColor = System.Drawing.Color.White;
            this.pnlEncabezadoCompra.Controls.Add(this.dpFecha);
            this.pnlEncabezadoCompra.Controls.Add(this.txtNIT);
            this.pnlEncabezadoCompra.Controls.Add(this.lblNIT);
            this.pnlEncabezadoCompra.Controls.Add(this.lblFecha);
            this.pnlEncabezadoCompra.Controls.Add(this.cmbProveedor);
            this.pnlEncabezadoCompra.Controls.Add(this.lblProveedor);
            this.pnlEncabezadoCompra.Location = new System.Drawing.Point(22, 41);
            this.pnlEncabezadoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEncabezadoCompra.Name = "pnlEncabezadoCompra";
            this.pnlEncabezadoCompra.Size = new System.Drawing.Size(697, 117);
            this.pnlEncabezadoCompra.TabIndex = 0;
            // 
            // dpFecha
            // 
            this.dpFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.Location = new System.Drawing.Point(172, 74);
            this.dpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(176, 27);
            this.dpFecha.TabIndex = 6;
            // 
            // txtNIT
            // 
            this.txtNIT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNIT.Enabled = false;
            this.txtNIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIT.Location = new System.Drawing.Point(502, 24);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(176, 27);
            this.txtNIT.TabIndex = 5;
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIT.Location = new System.Drawing.Point(370, 25);
            this.lblNIT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(119, 21);
            this.lblNIT.TabIndex = 4;
            this.lblNIT.Text = "NIT Proveedor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(17, 80);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(128, 21);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha Compra";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(172, 24);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(176, 29);
            this.cmbProveedor.TabIndex = 1;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(17, 24);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(90, 21);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cmbVideo
            // 
            this.cmbVideo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbVideo.HeaderText = "ID Producto";
            this.cmbVideo.Name = "cmbVideo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCantidad.HeaderText = "Cantidad";
            this.txtCantidad.Name = "txtCantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPrecio.HeaderText = "Precio Unitario";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSubtotal.HeaderText = "Subtotal";
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 623);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.pnlContenedorGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDetalleFactura)).EndInit();
            this.pnlEncabezadoCompra.ResumeLayout(false);
            this.pnlEncabezadoCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtIDFactura;
        private System.Windows.Forms.Label lblIDFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel pnlContenedorGrid;
        private System.Windows.Forms.DataGridView dgridDetalleFactura;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubtotal;
        private System.Windows.Forms.Panel pnlEncabezadoCompra;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
    }
}