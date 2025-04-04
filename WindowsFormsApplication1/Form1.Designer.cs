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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ClaseNegocioEstadoV2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("InterfaceDaoEstadoV2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_DaoEstadoV2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("MantenimientoGUI_EstadoV2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("EstadoV2", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Controller");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Controller", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Entidad");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Entidad Dto");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Entidad QueryDto");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Entidad Controller", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Admin");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Web-blazor", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("DaoV3");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Entidad V3");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_DaoV3");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("ClaseNegocioV3");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("MantenimientoProcedure");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Procedure", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("V3 SIN BEAN", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode23,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("CrearTable");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("CrearGrid");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Crear Table Procedure");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Crear Grid From Procedure");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("EntidadDTO");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("ClaseNegocioGeneric");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("MantenimientoGUI");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("V4 GENERIC", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode36});
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
            treeNode1.Name = "ClaseNegocioEstadoV2";
            treeNode1.Text = "ClaseNegocioEstadoV2";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Negocio";
            treeNode3.Name = "InterfaceDaoEstadoV2";
            treeNode3.Text = "InterfaceDaoEstadoV2";
            treeNode4.Name = "SqlServer_Tabla_DaoEstadoV2";
            treeNode4.Text = "SqlServer_Tabla_DaoEstadoV2";
            treeNode5.Name = "Nodo3";
            treeNode5.Text = "DAO";
            treeNode6.Name = "MantenimientoGUIEstadoV2";
            treeNode6.Text = "MantenimientoGUI_EstadoV2";
            treeNode7.Name = "Nodo0";
            treeNode7.Text = "GUI";
            treeNode8.Name = "Nodo1";
            treeNode8.Text = "EstadoV2";
            treeNode9.Name = "Controller";
            treeNode9.Text = "Controller";
            treeNode10.Name = "RaizController";
            treeNode10.Text = "Controller";
            treeNode11.Name = "EntidadWeb";
            treeNode11.Text = "Entidad";
            treeNode12.Name = "EntidadDto";
            treeNode12.Text = "Entidad Dto";
            treeNode13.Name = "EntidadQueryDto";
            treeNode13.Text = "Entidad QueryDto";
            treeNode14.Name = "Nodo0";
            treeNode14.Text = "Entidad Controller";
            treeNode15.Name = "Admin";
            treeNode15.Text = "Admin";
            treeNode16.Name = "Nodo7";
            treeNode16.Text = "Negocio";
            treeNode17.Name = "Nodo5";
            treeNode17.Text = "Web-blazor";
            treeNode18.Name = "DaoV3";
            treeNode18.Text = "DaoV3";
            treeNode19.Name = "EntidadV3";
            treeNode19.Text = "Entidad V3";
            treeNode20.Name = "SqlServer_Tabla_DaoV3";
            treeNode20.Text = "SqlServer_Tabla_DaoV3";
            treeNode21.Name = "Nodo1";
            treeNode21.Text = "DAO";
            treeNode22.Name = "ClaseNegocioV3";
            treeNode22.Text = "ClaseNegocioV3";
            treeNode23.Name = "Nodo2";
            treeNode23.Text = "Negocio";
            treeNode24.Name = "MantenimientoProcedure";
            treeNode24.Text = "MantenimientoProcedure";
            treeNode25.Name = "Procedure";
            treeNode25.Text = "Procedure";
            treeNode26.Name = "Nodo0";
            treeNode26.Text = "V3 SIN BEAN";
            treeNode27.Name = "CrearTable";
            treeNode27.Text = "CrearTable";
            treeNode28.Name = "CrearGrid";
            treeNode28.Text = "CrearGrid";
            treeNode29.Name = "CrearTableProcedure";
            treeNode29.Text = "Crear Table Procedure";
            treeNode30.Name = "CrearGridFromProcedure";
            treeNode30.Text = "Crear Grid From Procedure";
            treeNode31.Name = "EntidadDTO";
            treeNode31.Text = "EntidadDTO";
            treeNode32.Name = "Nodo0";
            treeNode32.Text = "GUI";
            treeNode33.Name = "ClaseNegocioGeneric";
            treeNode33.Text = "ClaseNegocioGeneric";
            treeNode34.Name = "Nodo1";
            treeNode34.Text = "Negocio";
            treeNode35.Name = "MantenimientoGUIGeneric";
            treeNode35.Text = "MantenimientoGUI";
            treeNode36.Name = "Nodo0";
            treeNode36.Text = "GUI";
            treeNode37.Name = "V4GENERIC";
            treeNode37.Text = "V4 GENERIC";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode17,
            treeNode26,
            treeNode32,
            treeNode37});
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

