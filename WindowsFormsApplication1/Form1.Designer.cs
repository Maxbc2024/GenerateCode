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
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("ClaseNegocio");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("InterfaceDao");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_Dao");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("BeanEntidad");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode78,
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("MantenimientoProcedure");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Procedure", new System.Windows.Forms.TreeNode[] {
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("MantenimientoGUI");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("CrearTable");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("CrearGrid");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode83,
            treeNode84,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Estado v1", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode80,
            treeNode82,
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("ClaseNegocioEstadoV2");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("InterfaceDaoEstadoV2");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_DaoEstadoV2");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("MantenimientoGUI_EstadoV2");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("EstadoV2", new System.Windows.Forms.TreeNode[] {
            treeNode89,
            treeNode92,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Controller");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Controller", new System.Windows.Forms.TreeNode[] {
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Entidad");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Entidad Dto");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Entidad QueryDto");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Entidad Controller", new System.Windows.Forms.TreeNode[] {
            treeNode98,
            treeNode99,
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Admin");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Web-blazor", new System.Windows.Forms.TreeNode[] {
            treeNode97,
            treeNode101,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("DaoV3");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Entidad V3");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("SqlServer_Tabla_DaoV3");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("DAO", new System.Windows.Forms.TreeNode[] {
            treeNode105,
            treeNode106,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("ClaseNegocioV3");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("V3 SIN BEAN", new System.Windows.Forms.TreeNode[] {
            treeNode108,
            treeNode110});
            this.cmbTablasBD = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbTablasBD
            // 
            this.cmbTablasBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablasBD.FormattingEnabled = true;
            this.cmbTablasBD.Location = new System.Drawing.Point(208, 30);
            this.cmbTablasBD.Name = "cmbTablasBD";
            this.cmbTablasBD.Size = new System.Drawing.Size(213, 21);
            this.cmbTablasBD.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label2.Location = new System.Drawing.Point(154, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 23);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Tabla";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 84);
            this.treeView1.Name = "treeView1";
            treeNode75.Name = "ClaseNegocio";
            treeNode75.Text = "ClaseNegocio";
            treeNode76.Name = "Nodo1";
            treeNode76.Text = "Negocio";
            treeNode77.Name = "InterfaceDao";
            treeNode77.Text = "InterfaceDao";
            treeNode78.Name = "SqlServer_Tabla_Dao";
            treeNode78.Text = "SqlServer_Tabla_Dao";
            treeNode79.Name = "BeanEntidad";
            treeNode79.Text = "BeanEntidad";
            treeNode80.Name = "Nodo2";
            treeNode80.Text = "DAO";
            treeNode81.Name = "MantenimientoProcedure";
            treeNode81.Text = "MantenimientoProcedure";
            treeNode82.Name = "Procedure";
            treeNode82.Text = "Procedure";
            treeNode83.Name = "MantenimientoGUI";
            treeNode83.Text = "MantenimientoGUI";
            treeNode84.Name = "CrearTable";
            treeNode84.Text = "CrearTable";
            treeNode85.Name = "CrearGrid";
            treeNode85.Text = "CrearGrid";
            treeNode86.Name = "GUI";
            treeNode86.Text = "GUI";
            treeNode87.Name = "Nodo4";
            treeNode87.Text = "Estado v1";
            treeNode88.Name = "ClaseNegocioEstadoV2";
            treeNode88.Text = "ClaseNegocioEstadoV2";
            treeNode89.Name = "Nodo2";
            treeNode89.Text = "Negocio";
            treeNode90.Name = "InterfaceDaoEstadoV2";
            treeNode90.Text = "InterfaceDaoEstadoV2";
            treeNode91.Name = "SqlServer_Tabla_DaoEstadoV2";
            treeNode91.Text = "SqlServer_Tabla_DaoEstadoV2";
            treeNode92.Name = "Nodo3";
            treeNode92.Text = "DAO";
            treeNode93.Name = "MantenimientoGUIEstadoV2";
            treeNode93.Text = "MantenimientoGUI_EstadoV2";
            treeNode94.Name = "Nodo0";
            treeNode94.Text = "GUI";
            treeNode95.Name = "Nodo1";
            treeNode95.Text = "EstadoV2";
            treeNode96.Name = "Controller";
            treeNode96.Text = "Controller";
            treeNode97.Name = "RaizController";
            treeNode97.Text = "Controller";
            treeNode98.Name = "EntidadWeb";
            treeNode98.Text = "Entidad";
            treeNode99.Name = "EntidadDto";
            treeNode99.Text = "Entidad Dto";
            treeNode100.Name = "EntidadQueryDto";
            treeNode100.Text = "Entidad QueryDto";
            treeNode101.Name = "Nodo0";
            treeNode101.Text = "Entidad Controller";
            treeNode102.Name = "Admin";
            treeNode102.Text = "Admin";
            treeNode103.Name = "Nodo7";
            treeNode103.Text = "Negocio";
            treeNode104.Name = "Nodo5";
            treeNode104.Text = "Web-blazor";
            treeNode105.Name = "DaoV3";
            treeNode105.Text = "DaoV3";
            treeNode106.Name = "EntidadV3";
            treeNode106.Text = "Entidad V3";
            treeNode107.Name = "SqlServer_Tabla_DaoV3";
            treeNode107.Text = "SqlServer_Tabla_DaoV3";
            treeNode108.Name = "Nodo1";
            treeNode108.Text = "DAO";
            treeNode109.Name = "ClaseNegocioV3";
            treeNode109.Text = "ClaseNegocioV3";
            treeNode110.Name = "Nodo2";
            treeNode110.Text = "Negocio";
            treeNode111.Name = "Nodo0";
            treeNode111.Text = "V3 SIN BEAN";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode95,
            treeNode104,
            treeNode111});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 770);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cmbTablasBD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Codigo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTablasBD;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

