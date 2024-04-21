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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FotografiasAlbum));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvFotografias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotografias)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(12, 54);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(512, 206);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // txtDescripcionImagen
            // 
            this.txtDescripcionImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcionImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionImagen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionImagen.Location = new System.Drawing.Point(166, 288);
            this.txtDescripcionImagen.Name = "txtDescripcionImagen";
            this.txtDescripcionImagen.Size = new System.Drawing.Size(236, 17);
            this.txtDescripcionImagen.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDescripcionImagen, "Describa la imagen");
            // 
            // dtFechaEvento
            // 
            this.dtFechaEvento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaEvento.Location = new System.Drawing.Point(544, 132);
            this.dtFechaEvento.Name = "dtFechaEvento";
            this.dtFechaEvento.Size = new System.Drawing.Size(262, 24);
            this.dtFechaEvento.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtFechaEvento, "Seleccione la fecha del evento");
            // 
            // txtLugarEvento
            // 
            this.txtLugarEvento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLugarEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLugarEvento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarEvento.Location = new System.Drawing.Point(821, 132);
            this.txtLugarEvento.Name = "txtLugarEvento";
            this.txtLugarEvento.Size = new System.Drawing.Size(383, 17);
            this.txtLugarEvento.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtLugarEvento, "Escriba el lugar del evento");
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcionEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionEvento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEvento.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionEvento.Location = new System.Drawing.Point(543, 189);
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(660, 71);
            this.txtDescripcionEvento.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtDescripcionEvento, "De una descripción detallada del evento");
            // 
            // lblDescImagen
            // 
            this.lblDescImagen.AutoSize = true;
            this.lblDescImagen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescImagen.Location = new System.Drawing.Point(169, 269);
            this.lblDescImagen.Name = "lblDescImagen";
            this.lblDescImagen.Size = new System.Drawing.Size(155, 16);
            this.lblDescImagen.TabIndex = 5;
            this.lblDescImagen.Text = "Descripción de la imagen";
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEvento.Location = new System.Drawing.Point(547, 114);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(105, 16);
            this.lblFechaEvento.TabIndex = 6;
            this.lblFechaEvento.Text = "Fecha del evento";
            // 
            // lblLugarEvento
            // 
            this.lblLugarEvento.AutoSize = true;
            this.lblLugarEvento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarEvento.Location = new System.Drawing.Point(824, 114);
            this.lblLugarEvento.Name = "lblLugarEvento";
            this.lblLugarEvento.Size = new System.Drawing.Size(105, 16);
            this.lblLugarEvento.TabIndex = 7;
            this.lblLugarEvento.Text = "Lugar del evento";
            // 
            // lblDescEvent
            // 
            this.lblDescEvent.AutoSize = true;
            this.lblDescEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescEvent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescEvent.Location = new System.Drawing.Point(546, 170);
            this.lblDescEvent.Name = "lblDescEvent";
            this.lblDescEvent.Size = new System.Drawing.Size(140, 16);
            this.lblDescEvent.TabIndex = 8;
            this.lblDescEvent.Text = "Descripción del evento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(1149, 54);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(54, 72);
            this.btnGuardar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar registro");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(122, 278);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(37, 21);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnSelect, "Cargar imagen desde PC");
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(13, 98);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(13, 20);
            this.txtFile.TabIndex = 76;
            this.txtFile.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 68);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(13, 20);
            this.txtId.TabIndex = 77;
            this.txtId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(950, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 120;
            this.label13.Text = "Búsqueda";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.DimGray;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.White;
            this.txtBusqueda.Location = new System.Drawing.Point(947, 288);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(256, 20);
            this.txtBusqueda.TabIndex = 119;
            this.toolTip1.SetToolTip(this.txtBusqueda, "Realice la búsqueda");
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dgvFotografias
            // 
            this.dgvFotografias.AllowUserToAddRows = false;
            this.dgvFotografias.AllowUserToDeleteRows = false;
            this.dgvFotografias.AllowUserToResizeColumns = false;
            this.dgvFotografias.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFotografias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFotografias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFotografias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFotografias.BackgroundColor = System.Drawing.Color.White;
            this.dgvFotografias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFotografias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFotografias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFotografias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFotografias.ColumnHeadersHeight = 30;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFotografias.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFotografias.EnableHeadersVisualStyles = false;
            this.dgvFotografias.Location = new System.Drawing.Point(12, 320);
            this.dgvFotografias.Name = "dgvFotografias";
            this.dgvFotografias.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFotografias.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFotografias.RowHeadersVisible = false;
            this.dgvFotografias.RowHeadersWidth = 62;
            this.dgvFotografias.RowTemplate.Height = 30;
            this.dgvFotografias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFotografias.Size = new System.Drawing.Size(1192, 191);
            this.dgvFotografias.TabIndex = 121;
            this.dgvFotografias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFotografias_CellContentClick);
            this.dgvFotografias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvFotografias_CellPainting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(463, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 23);
            this.label1.TabIndex = 122;
            this.label1.Text = "Álbum Fotográfico Empresarial ";
            // 
            // FotografiasAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFotografias);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSelect);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FotografiasAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBusqueda;
        public System.Windows.Forms.DataGridView dgvFotografias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

