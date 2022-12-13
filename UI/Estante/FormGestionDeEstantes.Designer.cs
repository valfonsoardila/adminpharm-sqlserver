﻿
namespace Presentacion
{
    partial class FormGestionDeEstantes
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
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorGestionProductos = new System.Windows.Forms.Panel();
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.textTotalFarmacos = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.dataGridFarmacos = new System.Windows.Forms.DataGridView();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRegistroDeProductos = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTituloDeRegistroProductos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            this.textReferencia = new System.Windows.Forms.TextBox();
            this.labelReferencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombreFarmaceutico = new System.Windows.Forms.TextBox();
            this.panelContenedorGestionProductos.SuspendLayout();
            this.panelConsultaDeProductos.SuspendLayout();
            this.panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            this.panelRegistroDeProductos.SuspendLayout();
            this.panelTituloDeRegistroProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.btnVolver.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(19, 6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 35);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelBarraVolver
            // 
            this.panelBarraVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelBarraVolver.Location = new System.Drawing.Point(8, 6);
            this.panelBarraVolver.Name = "panelBarraVolver";
            this.panelBarraVolver.Size = new System.Drawing.Size(7, 35);
            this.panelBarraVolver.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestionar Estantes";
            // 
            // panelContenedorGestionProductos
            // 
            this.panelContenedorGestionProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorGestionProductos.Controls.Add(this.panelConsultaDeProductos);
            this.panelContenedorGestionProductos.Controls.Add(this.panelRegistroDeProductos);
            this.panelContenedorGestionProductos.Location = new System.Drawing.Point(12, 47);
            this.panelContenedorGestionProductos.Name = "panelContenedorGestionProductos";
            this.panelContenedorGestionProductos.Size = new System.Drawing.Size(767, 395);
            this.panelContenedorGestionProductos.TabIndex = 53;
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Controls.Add(this.panelSubDataGridFarmacos);
            this.panelConsultaDeProductos.Controls.Add(this.dataGridFarmacos);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(3, 3);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(750, 248);
            this.panelConsultaDeProductos.TabIndex = 49;
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalFarmacos);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalFarmacos);
            this.panelSubDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(0, 226);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(750, 22);
            this.panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // textTotalFarmacos
            // 
            this.textTotalFarmacos.Location = new System.Drawing.Point(95, 0);
            this.textTotalFarmacos.Name = "textTotalFarmacos";
            this.textTotalFarmacos.Size = new System.Drawing.Size(47, 20);
            this.textTotalFarmacos.TabIndex = 49;
            // 
            // labelTotalFarmacos
            // 
            this.labelTotalFarmacos.AutoSize = true;
            this.labelTotalFarmacos.Location = new System.Drawing.Point(4, 5);
            this.labelTotalFarmacos.Name = "labelTotalFarmacos";
            this.labelTotalFarmacos.Size = new System.Drawing.Size(93, 13);
            this.labelTotalFarmacos.TabIndex = 49;
            this.labelTotalFarmacos.Text = "Total Registrados:";
            // 
            // dataGridFarmacos
            // 
            this.dataGridFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFarmacos.Location = new System.Drawing.Point(0, 24);
            this.dataGridFarmacos.Name = "dataGridFarmacos";
            this.dataGridFarmacos.Size = new System.Drawing.Size(750, 224);
            this.dataGridFarmacos.TabIndex = 50;
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboBox1);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltro);
            this.panelTituloDataGridFarmacos.Controls.Add(this.label4);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(750, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(223, 6);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(32, 13);
            this.labelFiltro.TabIndex = 50;
            this.labelFiltro.Text = "Filtro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Consultar Estantes";
            // 
            // panelRegistroDeProductos
            // 
            this.panelRegistroDeProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistroDeProductos.Controls.Add(this.iconButton1);
            this.panelRegistroDeProductos.Controls.Add(this.panelTituloDeRegistroProductos);
            this.panelRegistroDeProductos.Controls.Add(this.btnAbrirCaja);
            this.panelRegistroDeProductos.Controls.Add(this.textReferencia);
            this.panelRegistroDeProductos.Controls.Add(this.labelReferencia);
            this.panelRegistroDeProductos.Controls.Add(this.label2);
            this.panelRegistroDeProductos.Controls.Add(this.textNombreFarmaceutico);
            this.panelRegistroDeProductos.Location = new System.Drawing.Point(3, 252);
            this.panelRegistroDeProductos.Name = "panelRegistroDeProductos";
            this.panelRegistroDeProductos.Size = new System.Drawing.Size(611, 143);
            this.panelRegistroDeProductos.TabIndex = 48;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(377, 74);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(110, 35);
            this.iconButton1.TabIndex = 51;
            this.iconButton1.Text = "   Modificar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panelTituloDeRegistroProductos
            // 
            this.panelTituloDeRegistroProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDeRegistroProductos.Controls.Add(this.label3);
            this.panelTituloDeRegistroProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDeRegistroProductos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDeRegistroProductos.Name = "panelTituloDeRegistroProductos";
            this.panelTituloDeRegistroProductos.Size = new System.Drawing.Size(609, 24);
            this.panelTituloDeRegistroProductos.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Registrar Estantes";
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnAbrirCaja.IconColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirCaja.IconSize = 30;
            this.btnAbrirCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaja.Location = new System.Drawing.Point(377, 33);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(110, 35);
            this.btnAbrirCaja.TabIndex = 50;
            this.btnAbrirCaja.Text = "   Registrar";
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            // 
            // textReferencia
            // 
            this.textReferencia.Location = new System.Drawing.Point(118, 41);
            this.textReferencia.Name = "textReferencia";
            this.textReferencia.Size = new System.Drawing.Size(144, 20);
            this.textReferencia.TabIndex = 33;
            // 
            // labelReferencia
            // 
            this.labelReferencia.AutoSize = true;
            this.labelReferencia.Location = new System.Drawing.Point(20, 44);
            this.labelReferencia.Name = "labelReferencia";
            this.labelReferencia.Size = new System.Drawing.Size(98, 13);
            this.labelReferencia.TabIndex = 32;
            this.labelReferencia.Text = "Codigo del estante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Numero del Estante:";
            // 
            // textNombreFarmaceutico
            // 
            this.textNombreFarmaceutico.Location = new System.Drawing.Point(118, 67);
            this.textNombreFarmaceutico.Name = "textNombreFarmaceutico";
            this.textNombreFarmaceutico.Size = new System.Drawing.Size(144, 20);
            this.textNombreFarmaceutico.TabIndex = 35;
            // 
            // FormGestionDeEstantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.panelContenedorGestionProductos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBarraVolver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionDeEstantes";
            this.Text = "FormGestionDeEstantes";
            this.panelContenedorGestionProductos.ResumeLayout(false);
            this.panelConsultaDeProductos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            this.panelRegistroDeProductos.ResumeLayout(false);
            this.panelRegistroDeProductos.PerformLayout();
            this.panelTituloDeRegistroProductos.ResumeLayout(false);
            this.panelTituloDeRegistroProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedorGestionProductos;
        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.TextBox textTotalFarmacos;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.DataGridView dataGridFarmacos;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelRegistroDeProductos;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelTituloDeRegistroProductos;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private System.Windows.Forms.TextBox textReferencia;
        private System.Windows.Forms.Label labelReferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombreFarmaceutico;
    }
}