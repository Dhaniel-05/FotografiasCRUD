namespace Álbum_Fotográfico_Empresarial
{
    partial class FotografiasAlbum
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FotografiasAlbum));
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.txtDescripcionImagen = new System.Windows.Forms.TextBox();
            this.dtFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.txtLugarEvento = new System.Windows.Forms.TextBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.lblDescImagen = new System.Windows.Forms.Label();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.lblLugarEvento = new System.Windows.Forms.Label();
            this.lblDescEvent = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvFotografias = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotografias)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(15, 47);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(280, 141);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // txtDescripcionImagen
            // 
            this.txtDescripcionImagen.Location = new System.Drawing.Point(12, 245);
            this.txtDescripcionImagen.Multiline = true;
            this.txtDescripcionImagen.Name = "txtDescripcionImagen";
            this.txtDescripcionImagen.Size = new System.Drawing.Size(280, 71);
            this.txtDescripcionImagen.TabIndex = 1;
            // 
            // dtFechaEvento
            // 
            this.dtFechaEvento.Location = new System.Drawing.Point(12, 342);
            this.dtFechaEvento.Name = "dtFechaEvento";
            this.dtFechaEvento.Size = new System.Drawing.Size(280, 20);
            this.dtFechaEvento.TabIndex = 2;
            // 
            // txtLugarEvento
            // 
            this.txtLugarEvento.Location = new System.Drawing.Point(12, 386);
            this.txtLugarEvento.Name = "txtLugarEvento";
            this.txtLugarEvento.Size = new System.Drawing.Size(280, 20);
            this.txtLugarEvento.TabIndex = 3;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(9, 433);
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(283, 71);
            this.txtDescripcionEvento.TabIndex = 4;
            // 
            // lblDescImagen
            // 
            this.lblDescImagen.AutoSize = true;
            this.lblDescImagen.Location = new System.Drawing.Point(15, 235);
            this.lblDescImagen.Name = "lblDescImagen";
            this.lblDescImagen.Size = new System.Drawing.Size(126, 13);
            this.lblDescImagen.TabIndex = 5;
            this.lblDescImagen.Text = "Descripción de la imagen";
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Location = new System.Drawing.Point(15, 331);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(90, 13);
            this.lblFechaEvento.TabIndex = 6;
            this.lblFechaEvento.Text = "Fecha del evento";
            // 
            // lblLugarEvento
            // 
            this.lblLugarEvento.AutoSize = true;
            this.lblLugarEvento.Location = new System.Drawing.Point(15, 375);
            this.lblLugarEvento.Name = "lblLugarEvento";
            this.lblLugarEvento.Size = new System.Drawing.Size(87, 13);
            this.lblLugarEvento.TabIndex = 7;
            this.lblLugarEvento.Text = "Lugar del evento";
            // 
            // lblDescEvent
            // 
            this.lblDescEvent.AutoSize = true;
            this.lblDescEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescEvent.Location = new System.Drawing.Point(12, 422);
            this.lblDescEvent.Name = "lblDescEvent";
            this.lblDescEvent.Size = new System.Drawing.Size(116, 13);
            this.lblDescEvent.TabIndex = 8;
            this.lblDescEvent.Text = "Descripción del evento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(331, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(54, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvFotografias
            // 
            this.dgvFotografias.AllowUserToAddRows = false;
            this.dgvFotografias.AllowUserToDeleteRows = false;
            this.dgvFotografias.BackgroundColor = System.Drawing.Color.White;
            this.dgvFotografias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFotografias.Location = new System.Drawing.Point(331, 166);
            this.dgvFotografias.Name = "dgvFotografias";
            this.dgvFotografias.ReadOnly = true;
            this.dgvFotografias.Size = new System.Drawing.Size(516, 150);
            this.dgvFotografias.TabIndex = 10;
            this.dgvFotografias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFotografias_CellContentClick);
            this.dgvFotografias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvFotografias_CellPainting);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(132, 196);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(37, 21);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(331, 138);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(13, 20);
            this.txtFile.TabIndex = 76;
            this.txtFile.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(352, 138);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(13, 20);
            this.txtId.TabIndex = 77;
            this.txtId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label13.Location = new System.Drawing.Point(594, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 120;
            this.label13.Text = "Búsqueda";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(591, 134);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(256, 24);
            this.txtBusqueda.TabIndex = 119;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // FotografiasAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 516);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvFotografias);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescEvent);
            this.Controls.Add(this.lblLugarEvento);
            this.Controls.Add(this.lblFechaEvento);
            this.Controls.Add(this.lblDescImagen);
            this.Controls.Add(this.txtDescripcionEvento);
            this.Controls.Add(this.txtLugarEvento);
            this.Controls.Add(this.dtFechaEvento);
            this.Controls.Add(this.txtDescripcionImagen);
            this.Controls.Add(this.picFoto);
            this.Name = "FotografiasAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FotografiasAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotografias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TextBox txtDescripcionImagen;
        private System.Windows.Forms.DateTimePicker dtFechaEvento;
        private System.Windows.Forms.TextBox txtLugarEvento;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.Label lblDescImagen;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.Label lblLugarEvento;
        private System.Windows.Forms.Label lblDescEvent;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvFotografias;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}

