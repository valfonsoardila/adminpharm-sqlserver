﻿
namespace Presentacion
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelHeaderbar = new System.Windows.Forms.Panel();
            this.btnWindowMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnWindowRestore = new FontAwesome.Sharp.IconPictureBox();
            this.btnWindowCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnWindowMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelSelectionUsuarios = new System.Windows.Forms.Panel();
            this.panelSelectionProducto = new System.Windows.Forms.Panel();
            this.panelSelectionCaja = new System.Windows.Forms.Panel();
            this.subMenuUsuarios = new System.Windows.Forms.Panel();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnGestionUsuarios = new FontAwesome.Sharp.IconButton();
            this.subMenuProductos = new System.Windows.Forms.Panel();
            this.btnBodega = new FontAwesome.Sharp.IconButton();
            this.btnEstantes = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnGestionProductos = new FontAwesome.Sharp.IconButton();
            this.btnGestionCaja = new FontAwesome.Sharp.IconButton();
            this.panelLogoContainer = new System.Windows.Forms.Panel();
            this.panelSidebarClose = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenSidebar = new FontAwesome.Sharp.IconPictureBox();
            this.btnCloseSidebar = new FontAwesome.Sharp.IconPictureBox();
            this.labelLogoName = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeaderRuta = new System.Windows.Forms.Label();
            this.iconThemeSun = new FontAwesome.Sharp.IconPictureBox();
            this.iconThemeMoon = new FontAwesome.Sharp.IconPictureBox();
            this.labelHeaderTheme = new System.Windows.Forms.Label();
            this.btnModeLight = new FontAwesome.Sharp.IconPictureBox();
            this.btnModeDark = new FontAwesome.Sharp.IconPictureBox();
            this.panelContenedorInterno = new System.Windows.Forms.Panel();
            this.labelAvsio = new System.Windows.Forms.Label();
            this.panelHeaderbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowMinimize)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.subMenuUsuarios.SuspendLayout();
            this.subMenuProductos.SuspendLayout();
            this.panelLogoContainer.SuspendLayout();
            this.panelSidebarClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconThemeSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconThemeMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModeLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModeDark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderbar
            // 
            this.panelHeaderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelHeaderbar.Controls.Add(this.btnWindowMaximize);
            this.panelHeaderbar.Controls.Add(this.btnWindowRestore);
            this.panelHeaderbar.Controls.Add(this.btnWindowCerrar);
            this.panelHeaderbar.Controls.Add(this.btnWindowMinimize);
            this.panelHeaderbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderbar.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderbar.Name = "panelHeaderbar";
            this.panelHeaderbar.Size = new System.Drawing.Size(970, 27);
            this.panelHeaderbar.TabIndex = 1;
            // 
            // btnWindowMaximize
            // 
            this.btnWindowMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnWindowMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnWindowMaximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowMaximize.IconSize = 20;
            this.btnWindowMaximize.Location = new System.Drawing.Point(917, 4);
            this.btnWindowMaximize.Name = "btnWindowMaximize";
            this.btnWindowMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnWindowMaximize.TabIndex = 4;
            this.btnWindowMaximize.TabStop = false;
            this.btnWindowMaximize.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnWindowRestore
            // 
            this.btnWindowRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnWindowRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnWindowRestore.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowRestore.IconSize = 20;
            this.btnWindowRestore.Location = new System.Drawing.Point(918, 4);
            this.btnWindowRestore.Name = "btnWindowRestore";
            this.btnWindowRestore.Size = new System.Drawing.Size(20, 20);
            this.btnWindowRestore.TabIndex = 5;
            this.btnWindowRestore.TabStop = false;
            this.btnWindowRestore.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnWindowCerrar
            // 
            this.btnWindowCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnWindowCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowCerrar.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnWindowCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowCerrar.IconSize = 20;
            this.btnWindowCerrar.Location = new System.Drawing.Point(941, 4);
            this.btnWindowCerrar.Name = "btnWindowCerrar";
            this.btnWindowCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnWindowCerrar.TabIndex = 3;
            this.btnWindowCerrar.TabStop = false;
            this.btnWindowCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnWindowMinimize
            // 
            this.btnWindowMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnWindowMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnWindowMinimize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowMinimize.IconSize = 20;
            this.btnWindowMinimize.Location = new System.Drawing.Point(895, 4);
            this.btnWindowMinimize.Name = "btnWindowMinimize";
            this.btnWindowMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnWindowMinimize.TabIndex = 1;
            this.btnWindowMinimize.TabStop = false;
            this.btnWindowMinimize.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSidebar.Controls.Add(this.panelSelectionUsuarios);
            this.panelSidebar.Controls.Add(this.panelSelectionProducto);
            this.panelSidebar.Controls.Add(this.panelSelectionCaja);
            this.panelSidebar.Controls.Add(this.subMenuUsuarios);
            this.panelSidebar.Controls.Add(this.btnGestionUsuarios);
            this.panelSidebar.Controls.Add(this.subMenuProductos);
            this.panelSidebar.Controls.Add(this.btnGestionProductos);
            this.panelSidebar.Controls.Add(this.btnGestionCaja);
            this.panelSidebar.Controls.Add(this.panelLogoContainer);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 27);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(186, 473);
            this.panelSidebar.TabIndex = 2;
            // 
            // panelSelectionUsuarios
            // 
            this.panelSelectionUsuarios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSelectionUsuarios.Location = new System.Drawing.Point(0, 284);
            this.panelSelectionUsuarios.Name = "panelSelectionUsuarios";
            this.panelSelectionUsuarios.Size = new System.Drawing.Size(6, 37);
            this.panelSelectionUsuarios.TabIndex = 8;
            this.panelSelectionUsuarios.Visible = false;
            // 
            // panelSelectionProducto
            // 
            this.panelSelectionProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSelectionProducto.Location = new System.Drawing.Point(0, 136);
            this.panelSelectionProducto.Name = "panelSelectionProducto";
            this.panelSelectionProducto.Size = new System.Drawing.Size(6, 37);
            this.panelSelectionProducto.TabIndex = 7;
            this.panelSelectionProducto.Visible = false;
            // 
            // panelSelectionCaja
            // 
            this.panelSelectionCaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSelectionCaja.Location = new System.Drawing.Point(0, 100);
            this.panelSelectionCaja.Name = "panelSelectionCaja";
            this.panelSelectionCaja.Size = new System.Drawing.Size(6, 37);
            this.panelSelectionCaja.TabIndex = 0;
            this.panelSelectionCaja.Visible = false;
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.subMenuUsuarios.Controls.Add(this.btnEmpleados);
            this.subMenuUsuarios.Controls.Add(this.btnClientes);
            this.subMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuUsuarios.Location = new System.Drawing.Point(0, 322);
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(186, 76);
            this.subMenuUsuarios.TabIndex = 6;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 10;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 37);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(186, 37);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 10;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(186, 37);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGestionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnGestionUsuarios.IconColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionUsuarios.IconSize = 22;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(0, 285);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(186, 37);
            this.btnGestionUsuarios.TabIndex = 5;
            this.btnGestionUsuarios.Text = "   Gestion de usuarios";
            this.btnGestionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.Controls.Add(this.btnBodega);
            this.subMenuProductos.Controls.Add(this.btnEstantes);
            this.subMenuProductos.Controls.Add(this.btnProductos);
            this.subMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProductos.Location = new System.Drawing.Point(0, 174);
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(186, 111);
            this.subMenuProductos.TabIndex = 4;
            // 
            // btnBodega
            // 
            this.btnBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBodega.FlatAppearance.BorderSize = 0;
            this.btnBodega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBodega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBodega.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnBodega.IconColor = System.Drawing.Color.White;
            this.btnBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBodega.IconSize = 10;
            this.btnBodega.Location = new System.Drawing.Point(0, 74);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(186, 37);
            this.btnBodega.TabIndex = 6;
            this.btnBodega.Text = "Bodega";
            this.btnBodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBodega.UseVisualStyleBackColor = false;
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // btnEstantes
            // 
            this.btnEstantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnEstantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstantes.FlatAppearance.BorderSize = 0;
            this.btnEstantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEstantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEstantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstantes.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnEstantes.IconColor = System.Drawing.Color.White;
            this.btnEstantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstantes.IconSize = 10;
            this.btnEstantes.Location = new System.Drawing.Point(0, 37);
            this.btnEstantes.Name = "btnEstantes";
            this.btnEstantes.Size = new System.Drawing.Size(186, 37);
            this.btnEstantes.TabIndex = 5;
            this.btnEstantes.Text = "Estantes";
            this.btnEstantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstantes.UseVisualStyleBackColor = false;
            this.btnEstantes.Click += new System.EventHandler(this.btnEstantes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnProductos.IconColor = System.Drawing.Color.White;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 10;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(186, 37);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnGestionProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionProductos.FlatAppearance.BorderSize = 0;
            this.btnGestionProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGestionProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnGestionProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionProductos.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.btnGestionProductos.IconColor = System.Drawing.Color.White;
            this.btnGestionProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionProductos.IconSize = 22;
            this.btnGestionProductos.Location = new System.Drawing.Point(0, 137);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(186, 37);
            this.btnGestionProductos.TabIndex = 3;
            this.btnGestionProductos.Text = "   Gestion de Producto";
            this.btnGestionProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionProductos.UseVisualStyleBackColor = false;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // btnGestionCaja
            // 
            this.btnGestionCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnGestionCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionCaja.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGestionCaja.FlatAppearance.BorderSize = 0;
            this.btnGestionCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGestionCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnGestionCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnGestionCaja.IconColor = System.Drawing.Color.White;
            this.btnGestionCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionCaja.IconSize = 22;
            this.btnGestionCaja.Location = new System.Drawing.Point(0, 100);
            this.btnGestionCaja.Name = "btnGestionCaja";
            this.btnGestionCaja.Size = new System.Drawing.Size(186, 37);
            this.btnGestionCaja.TabIndex = 1;
            this.btnGestionCaja.Text = "Gestion de Caja";
            this.btnGestionCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionCaja.UseVisualStyleBackColor = false;
            this.btnGestionCaja.Click += new System.EventHandler(this.btnGestionCaja_Click);
            // 
            // panelLogoContainer
            // 
            this.panelLogoContainer.Controls.Add(this.panelSidebarClose);
            this.panelLogoContainer.Controls.Add(this.btnOpenSidebar);
            this.panelLogoContainer.Controls.Add(this.btnCloseSidebar);
            this.panelLogoContainer.Controls.Add(this.labelLogoName);
            this.panelLogoContainer.Controls.Add(this.pictureLogo);
            this.panelLogoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoContainer.Location = new System.Drawing.Point(0, 0);
            this.panelLogoContainer.Name = "panelLogoContainer";
            this.panelLogoContainer.Size = new System.Drawing.Size(186, 100);
            this.panelLogoContainer.TabIndex = 0;
            // 
            // panelSidebarClose
            // 
            this.panelSidebarClose.Controls.Add(this.labelMenu);
            this.panelSidebarClose.Controls.Add(this.pictureBox1);
            this.panelSidebarClose.Location = new System.Drawing.Point(0, 31);
            this.panelSidebarClose.Name = "panelSidebarClose";
            this.panelSidebarClose.Size = new System.Drawing.Size(52, 69);
            this.panelSidebarClose.TabIndex = 6;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(3, 47);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(38, 13);
            this.labelMenu.TabIndex = 7;
            this.labelMenu.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenSidebar
            // 
            this.btnOpenSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSidebar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnOpenSidebar.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            this.btnOpenSidebar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnOpenSidebar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenSidebar.IconSize = 30;
            this.btnOpenSidebar.Location = new System.Drawing.Point(152, 3);
            this.btnOpenSidebar.Name = "btnOpenSidebar";
            this.btnOpenSidebar.Size = new System.Drawing.Size(31, 30);
            this.btnOpenSidebar.TabIndex = 5;
            this.btnOpenSidebar.TabStop = false;
            this.btnOpenSidebar.Click += new System.EventHandler(this.btnOpenSidebar_Click);
            // 
            // btnCloseSidebar
            // 
            this.btnCloseSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSidebar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnCloseSidebar.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.btnCloseSidebar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnCloseSidebar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseSidebar.IconSize = 30;
            this.btnCloseSidebar.Location = new System.Drawing.Point(152, 3);
            this.btnCloseSidebar.Name = "btnCloseSidebar";
            this.btnCloseSidebar.Size = new System.Drawing.Size(31, 30);
            this.btnCloseSidebar.TabIndex = 4;
            this.btnCloseSidebar.TabStop = false;
            this.btnCloseSidebar.Click += new System.EventHandler(this.btnCloseSidebar_Click);
            // 
            // labelLogoName
            // 
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogoName.Location = new System.Drawing.Point(30, 78);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(99, 16);
            this.labelLogoName.TabIndex = 1;
            this.labelLogoName.Text = "Admin Pharm";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(33, 6);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(95, 69);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelAvsio);
            this.panelHeader.Controls.Add(this.labelHeaderRuta);
            this.panelHeader.Controls.Add(this.iconThemeSun);
            this.panelHeader.Controls.Add(this.iconThemeMoon);
            this.panelHeader.Controls.Add(this.labelHeaderTheme);
            this.panelHeader.Controls.Add(this.btnModeLight);
            this.panelHeader.Controls.Add(this.btnModeDark);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(186, 27);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 25);
            this.panelHeader.TabIndex = 3;
            // 
            // labelHeaderRuta
            // 
            this.labelHeaderRuta.AutoSize = true;
            this.labelHeaderRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderRuta.Location = new System.Drawing.Point(6, 4);
            this.labelHeaderRuta.Name = "labelHeaderRuta";
            this.labelHeaderRuta.Size = new System.Drawing.Size(45, 16);
            this.labelHeaderRuta.TabIndex = 10;
            this.labelHeaderRuta.Text = "Inicio";
            // 
            // iconThemeSun
            // 
            this.iconThemeSun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconThemeSun.BackColor = System.Drawing.SystemColors.Control;
            this.iconThemeSun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.iconThemeSun.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconThemeSun.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.iconThemeSun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconThemeSun.IconSize = 24;
            this.iconThemeSun.Location = new System.Drawing.Point(756, 0);
            this.iconThemeSun.Name = "iconThemeSun";
            this.iconThemeSun.Size = new System.Drawing.Size(24, 25);
            this.iconThemeSun.TabIndex = 9;
            this.iconThemeSun.TabStop = false;
            // 
            // iconThemeMoon
            // 
            this.iconThemeMoon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconThemeMoon.BackColor = System.Drawing.SystemColors.Control;
            this.iconThemeMoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.iconThemeMoon.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.iconThemeMoon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.iconThemeMoon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconThemeMoon.IconSize = 24;
            this.iconThemeMoon.Location = new System.Drawing.Point(756, 0);
            this.iconThemeMoon.Name = "iconThemeMoon";
            this.iconThemeMoon.Size = new System.Drawing.Size(24, 25);
            this.iconThemeMoon.TabIndex = 8;
            this.iconThemeMoon.TabStop = false;
            // 
            // labelHeaderTheme
            // 
            this.labelHeaderTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderTheme.AutoSize = true;
            this.labelHeaderTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTheme.Location = new System.Drawing.Point(668, 5);
            this.labelHeaderTheme.Name = "labelHeaderTheme";
            this.labelHeaderTheme.Size = new System.Drawing.Size(60, 16);
            this.labelHeaderTheme.TabIndex = 6;
            this.labelHeaderTheme.Text = "Theme:";
            // 
            // btnModeLight
            // 
            this.btnModeLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModeLight.BackColor = System.Drawing.SystemColors.Control;
            this.btnModeLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnModeLight.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.btnModeLight.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnModeLight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModeLight.IconSize = 24;
            this.btnModeLight.Location = new System.Drawing.Point(729, 0);
            this.btnModeLight.Name = "btnModeLight";
            this.btnModeLight.Size = new System.Drawing.Size(24, 25);
            this.btnModeLight.TabIndex = 6;
            this.btnModeLight.TabStop = false;
            this.btnModeLight.Click += new System.EventHandler(this.btnLightMode_Click);
            // 
            // btnModeDark
            // 
            this.btnModeDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModeDark.BackColor = System.Drawing.SystemColors.Control;
            this.btnModeDark.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnModeDark.IconColor = System.Drawing.Color.White;
            this.btnModeDark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModeDark.IconSize = 24;
            this.btnModeDark.Location = new System.Drawing.Point(729, 0);
            this.btnModeDark.Name = "btnModeDark";
            this.btnModeDark.Size = new System.Drawing.Size(24, 25);
            this.btnModeDark.TabIndex = 7;
            this.btnModeDark.TabStop = false;
            this.btnModeDark.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // panelContenedorInterno
            // 
            this.panelContenedorInterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorInterno.Location = new System.Drawing.Point(186, 52);
            this.panelContenedorInterno.Name = "panelContenedorInterno";
            this.panelContenedorInterno.Size = new System.Drawing.Size(784, 448);
            this.panelContenedorInterno.TabIndex = 4;
            // 
            // labelAvsio
            // 
            this.labelAvsio.AutoSize = true;
            this.labelAvsio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvsio.Location = new System.Drawing.Point(106, 7);
            this.labelAvsio.Name = "labelAvsio";
            this.labelAvsio.Size = new System.Drawing.Size(91, 13);
            this.labelAvsio.TabIndex = 11;
            this.labelAvsio.Text = "!!!Advertencia:";
            this.labelAvsio.Visible = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(970, 500);
            this.Controls.Add(this.panelContenedorInterno);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeaderbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(899, 500);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.panelHeaderbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowMinimize)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.subMenuUsuarios.ResumeLayout(false);
            this.subMenuProductos.ResumeLayout(false);
            this.panelLogoContainer.ResumeLayout(false);
            this.panelLogoContainer.PerformLayout();
            this.panelSidebarClose.ResumeLayout(false);
            this.panelSidebarClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconThemeSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconThemeMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModeLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModeDark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderbar;
        private FontAwesome.Sharp.IconPictureBox btnWindowCerrar;
        private FontAwesome.Sharp.IconPictureBox btnWindowMinimize;
        private FontAwesome.Sharp.IconPictureBox btnWindowRestore;
        private FontAwesome.Sharp.IconPictureBox btnWindowMaximize;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogoContainer;
        private System.Windows.Forms.PictureBox pictureLogo;
        private FontAwesome.Sharp.IconPictureBox btnCloseSidebar;
        private FontAwesome.Sharp.IconPictureBox btnOpenSidebar;
        private System.Windows.Forms.Label labelLogoName;
        private FontAwesome.Sharp.IconButton btnGestionCaja;
        private FontAwesome.Sharp.IconButton btnGestionUsuarios;
        private FontAwesome.Sharp.IconButton btnGestionProductos;
        private System.Windows.Forms.Panel panelSelectionUsuarios;
        private System.Windows.Forms.Panel panelSelectionProducto;
        private System.Windows.Forms.Panel panelSelectionCaja;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconPictureBox iconThemeSun;
        private FontAwesome.Sharp.IconPictureBox iconThemeMoon;
        private System.Windows.Forms.Label labelHeaderTheme;
        private FontAwesome.Sharp.IconPictureBox btnModeLight;
        private FontAwesome.Sharp.IconPictureBox btnModeDark;
        private System.Windows.Forms.Panel panelContenedorInterno;
        private System.Windows.Forms.Label labelHeaderRuta;
        private System.Windows.Forms.Panel subMenuUsuarios;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.Panel subMenuProductos;
        private FontAwesome.Sharp.IconButton btnEstantes;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnBodega;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel panelSidebarClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAvsio;
    }
}