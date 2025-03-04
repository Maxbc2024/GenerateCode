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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ClaseNegocio");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("InterfaceDao");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_Dao");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("BeanEntidad");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("MantenimientoProcedure");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Procedure", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("MantenimientoGUI");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Estado v1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode8,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ClaseNegocioEstadoV2");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("InterfaceDaoEstadoV2");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_DaoEstadoV2");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("MantenimientoGUI_EstadoV2");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("EstadoV2", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Controller");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Controller", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Entidad");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Entidad Dto");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Entidad QueryDto");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Entidad Controller", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Admin");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Web-blazor", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode25,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("DaoV3");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Entidad V3");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_DaoV3");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("ClaseNegocioV3");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("V3 SIN BEAN", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("CrearTable");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("CrearGrid");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Crear Table Procedure");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Crear Grid From Procedure");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("EntidadDTO");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("ClaseNegocioGeneric");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("V4 GENERIC", new System.Windows.Forms.TreeNode[] {
            treeNode43});
            this.cmbTablasBD = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbProcedures = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTablasBD
            // 
            this.cmbTablasBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablasBD.FormattingEnabled = true;
            this.cmbTablasBD.Location = new System.Drawing.Point(208, 23);
            this.cmbTablasBD.Name = "cmbTablasBD";
            this.cmbTablasBD.Size = new System.Drawing.Size(213, 21);
            this.cmbTablasBD.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label2.Location = new System.Drawing.Point(154, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Tabla";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 84);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "ClaseNegocio";
            treeNode1.Text = "ClaseNegocio";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Negocio";
            treeNode3.Name = "InterfaceDao";
            treeNode3.Text = "InterfaceDao";
            treeNode4.Name = "SqlServer_Tabla_Dao";
            treeNode4.Text = "SqlServer_Tabla_Dao";
            treeNode5.Name = "BeanEntidad";
            treeNode5.Text = "BeanEntidad";
            treeNode6.Name = "Nodo2";
            treeNode6.Text = "DAO";
            treeNode7.Name = "MantenimientoProcedure";
            treeNode7.Text = "MantenimientoProcedure";
            treeNode8.Name = "Procedure";
            treeNode8.Text = "Procedure";
            treeNode9.Name = "MantenimientoGUI";
            treeNode9.Text = "MantenimientoGUI";
            treeNode10.Name = "GUI";
            treeNode10.Text = "GUI";
            treeNode11.Name = "Nodo4";
            treeNode11.Text = "Estado v1";
            treeNode12.Name = "ClaseNegocioEstadoV2";
            treeNode12.Text = "ClaseNegocioEstadoV2";
            treeNode13.Name = "Nodo2";
            treeNode13.Text = "Negocio";
            treeNode14.Name = "InterfaceDaoEstadoV2";
            treeNode14.Text = "InterfaceDaoEstadoV2";
            treeNode15.Name = "SqlServer_Tabla_DaoEstadoV2";
            treeNode15.Text = "SqlServer_Tabla_DaoEstadoV2";
            treeNode16.Name = "Nodo3";
            treeNode16.Text = "DAO";
            treeNode17.Name = "MantenimientoGUIEstadoV2";
            treeNode17.Text = "MantenimientoGUI_EstadoV2";
            treeNode18.Name = "Nodo0";
            treeNode18.Text = "GUI";
            treeNode19.Name = "Nodo1";
            treeNode19.Text = "EstadoV2";
            treeNode20.Name = "Controller";
            treeNode20.Text = "Controller";
            treeNode21.Name = "RaizController";
            treeNode21.Text = "Controller";
            treeNode22.Name = "EntidadWeb";
            treeNode22.Text = "Entidad";
            treeNode23.Name = "EntidadDto";
            treeNode23.Text = "Entidad Dto";
            treeNode24.Name = "EntidadQueryDto";
            treeNode24.Text = "Entidad QueryDto";
            treeNode25.Name = "Nodo0";
            treeNode25.Text = "Entidad Controller";
            treeNode26.Name = "Admin";
            treeNode26.Text = "Admin";
            treeNode27.Name = "Nodo7";
            treeNode27.Text = "Negocio";
            treeNode28.Name = "Nodo5";
            treeNode28.Text = "Web-blazor";
            treeNode29.Name = "DaoV3";
            treeNode29.Text = "DaoV3";
            treeNode30.Name = "EntidadV3";
            treeNode30.Text = "Entidad V3";
            treeNode31.Name = "SqlServer_Tabla_DaoV3";
            treeNode31.Text = "SqlServer_Tabla_DaoV3";
            treeNode32.Name = "Nodo1";
            treeNode32.Text = "DAO";
            treeNode33.Name = "ClaseNegocioV3";
            treeNode33.Text = "ClaseNegocioV3";
            treeNode34.Name = "Nodo2";
            treeNode34.Text = "Negocio";
            treeNode35.Name = "Nodo0";
            treeNode35.Text = "V3 SIN BEAN";
            treeNode36.Name = "CrearTable";
            treeNode36.Text = "CrearTable";
            treeNode37.Name = "CrearGrid";
            treeNode37.Text = "CrearGrid";
            treeNode38.Name = "CrearTableProcedure";
            treeNode38.Text = "Crear Table Procedure";
            treeNode39.Name = "CrearGridFromProcedure";
            treeNode39.Text = "Crear Grid From Procedure";
            treeNode40.Name = "EntidadDTO";
            treeNode40.Text = "EntidadDTO";
            treeNode41.Name = "Nodo0";
            treeNode41.Text = "GUI";
            treeNode42.Name = "ClaseNegocioGeneric";
            treeNode42.Text = "ClaseNegocioGeneric";
            treeNode43.Name = "Nodo1";
            treeNode43.Text = "Negocio";
            treeNode44.Name = "V4GENERIC";
            treeNode44.Text = "V4 GENERIC";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode19,
            treeNode28,
            treeNode35,
            treeNode41,
            treeNode44});
            this.treeView1.Size = new System.Drawing.Size(181, 686);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(199, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(990, 686);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // cmbProcedures
            // 
            this.cmbProcedures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcedures.FormattingEnabled = true;
            this.cmbProcedures.Location = new System.Drawing.Point(585, 23);
            this.cmbProcedures.Name = "cmbProcedures";
            this.cmbProcedures.Size = new System.Drawing.Size(430, 21);
            this.cmbProcedures.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(509, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Procedure:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 770);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProcedures);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cmbTablasBD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Codigo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTablasBD;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmbProcedures;
        internal System.Windows.Forms.Label label1;
    }
}

