namespace pj_Navegador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tf_direccion = new System.Windows.Forms.TextBox();
            this.box_favoritos = new System.Windows.Forms.ComboBox();
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_agregarFavoritos = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.tf_direccion);
            this.panel1.Controls.Add(this.box_favoritos);
            this.panel1.Controls.Add(this.btn_ir);
            this.panel1.Controls.Add(this.btn_atras);
            this.panel1.Controls.Add(this.btn_agregarFavoritos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 46);
            this.panel1.TabIndex = 0;
            // 
            // tf_direccion
            // 
            this.tf_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tf_direccion.ForeColor = System.Drawing.SystemColors.Info;
            this.tf_direccion.Location = new System.Drawing.Point(48, 12);
            this.tf_direccion.Name = "tf_direccion";
            this.tf_direccion.Size = new System.Drawing.Size(454, 20);
            this.tf_direccion.TabIndex = 4;
            this.tf_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tf_direccion_KeyPress);
            // 
            // box_favoritos
            // 
            this.box_favoritos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_favoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.box_favoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_favoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_favoritos.ForeColor = System.Drawing.SystemColors.Info;
            this.box_favoritos.FormattingEnabled = true;
            this.box_favoritos.Location = new System.Drawing.Point(922, 12);
            this.box_favoritos.Name = "box_favoritos";
            this.box_favoritos.Size = new System.Drawing.Size(230, 21);
            this.box_favoritos.TabIndex = 3;
            this.box_favoritos.SelectedIndexChanged += new System.EventHandler(this.box_favoritos_SelectedIndexChanged);
            // 
            // btn_ir
            // 
            this.btn_ir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ir.Location = new System.Drawing.Point(508, 10);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(75, 23);
            this.btn_ir.TabIndex = 1;
            this.btn_ir.Text = "Ir";
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.btn_ir_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btn_atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_atras.Image")));
            this.btn_atras.Location = new System.Drawing.Point(4, -1);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(44, 44);
            this.btn_atras.TabIndex = 0;
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_agregarFavoritos
            // 
            this.btn_agregarFavoritos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregarFavoritos.AutoSize = true;
            this.btn_agregarFavoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarFavoritos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btn_agregarFavoritos.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregarFavoritos.Image")));
            this.btn_agregarFavoritos.Location = new System.Drawing.Point(873, 1);
            this.btn_agregarFavoritos.Name = "btn_agregarFavoritos";
            this.btn_agregarFavoritos.Size = new System.Drawing.Size(44, 44);
            this.btn_agregarFavoritos.TabIndex = 2;
            this.btn_agregarFavoritos.UseVisualStyleBackColor = true;
            this.btn_agregarFavoritos.Click += new System.EventHandler(this.btn_agregarFavoritos_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1164, 480);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1164, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 16);
            this.toolStripProgressBar1.Value = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1164, 544);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "KhahoryNavegador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agregarFavoritos;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.TextBox tf_direccion;
        private System.Windows.Forms.ComboBox box_favoritos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

