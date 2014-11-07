namespace Teleobservacion_Captura
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.gpboxImagenes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpboxDatosBasicos = new System.Windows.Forms.GroupBox();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.tbxResolucionEspacial = new System.Windows.Forms.TextBox();
            this.tbxArchivo = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtrlOtros = new System.Windows.Forms.TabControl();
            this.tabPgCoordenadas = new System.Windows.Forms.TabPage();
            this.txtBoxLongitudMax = new TextBoxConFormato.FormattedTextBox();
            this.txtBoxLongitudMin = new TextBoxConFormato.FormattedTextBox();
            this.txtBoxLatitudMax = new TextBoxConFormato.FormattedTextBox();
            this.txtBoxLatitudMin = new TextBoxConFormato.FormattedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPgMuestraGrafica = new System.Windows.Forms.TabPage();
            this.btnExaminarMG = new System.Windows.Forms.Button();
            this.txtBoxMuestraGrafica = new System.Windows.Forms.TextBox();
            this.picBoxMuestraGrafica = new System.Windows.Forms.PictureBox();
            this.tabPgProcesos = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txbProcesamiento = new System.Windows.Forms.TextBox();
            this.tabpgObservaciones = new System.Windows.Forms.TabPage();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.gpboxImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpboxDatosBasicos.SuspendLayout();
            this.tabCtrlOtros.SuspendLayout();
            this.tabPgCoordenadas.SuspendLayout();
            this.tabPgMuestraGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMuestraGrafica)).BeginInit();
            this.tabPgProcesos.SuspendLayout();
            this.tabpgObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxImagenes
            // 
            this.gpboxImagenes.Controls.Add(this.dataGridView1);
            this.gpboxImagenes.Location = new System.Drawing.Point(16, 45);
            this.gpboxImagenes.Name = "gpboxImagenes";
            this.gpboxImagenes.Size = new System.Drawing.Size(294, 222);
            this.gpboxImagenes.TabIndex = 0;
            this.gpboxImagenes.TabStop = false;
            this.gpboxImagenes.Text = "Imagenes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(287, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // gpboxDatosBasicos
            // 
            this.gpboxDatosBasicos.Controls.Add(this.btnArchivo);
            this.gpboxDatosBasicos.Controls.Add(this.dateTimePickerFecha);
            this.gpboxDatosBasicos.Controls.Add(this.tbxArea);
            this.gpboxDatosBasicos.Controls.Add(this.tbxResolucionEspacial);
            this.gpboxDatosBasicos.Controls.Add(this.tbxArchivo);
            this.gpboxDatosBasicos.Controls.Add(this.cbxTipo);
            this.gpboxDatosBasicos.Controls.Add(this.tbxNombre);
            this.gpboxDatosBasicos.Controls.Add(this.label6);
            this.gpboxDatosBasicos.Controls.Add(this.label5);
            this.gpboxDatosBasicos.Controls.Add(this.label4);
            this.gpboxDatosBasicos.Controls.Add(this.label3);
            this.gpboxDatosBasicos.Controls.Add(this.label2);
            this.gpboxDatosBasicos.Controls.Add(this.label1);
            this.gpboxDatosBasicos.Location = new System.Drawing.Point(316, 45);
            this.gpboxDatosBasicos.Name = "gpboxDatosBasicos";
            this.gpboxDatosBasicos.Size = new System.Drawing.Size(350, 247);
            this.gpboxDatosBasicos.TabIndex = 1;
            this.gpboxDatosBasicos.TabStop = false;
            this.gpboxDatosBasicos.Text = "Datos Básicos";
            // 
            // btnArchivo
            // 
            this.btnArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.Location = new System.Drawing.Point(312, 71);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(29, 20);
            this.btnArchivo.TabIndex = 12;
            this.btnArchivo.Text = "...";
            this.btnArchivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(123, 157);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerFecha.TabIndex = 11;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(123, 130);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(180, 20);
            this.tbxArea.TabIndex = 10;
            // 
            // tbxResolucionEspacial
            // 
            this.tbxResolucionEspacial.Location = new System.Drawing.Point(123, 103);
            this.tbxResolucionEspacial.Name = "tbxResolucionEspacial";
            this.tbxResolucionEspacial.Size = new System.Drawing.Size(180, 20);
            this.tbxResolucionEspacial.TabIndex = 9;
            // 
            // tbxArchivo
            // 
            this.tbxArchivo.Enabled = false;
            this.tbxArchivo.Location = new System.Drawing.Point(123, 72);
            this.tbxArchivo.Name = "tbxArchivo";
            this.tbxArchivo.Size = new System.Drawing.Size(180, 20);
            this.tbxArchivo.TabIndex = 8;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(123, 44);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(180, 21);
            this.cbxTipo.TabIndex = 7;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(123, 19);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(180, 20);
            this.tbxNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resolución Espacial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tabCtrlOtros
            // 
            this.tabCtrlOtros.Controls.Add(this.tabPgCoordenadas);
            this.tabCtrlOtros.Controls.Add(this.tabPgMuestraGrafica);
            this.tabCtrlOtros.Controls.Add(this.tabPgProcesos);
            this.tabCtrlOtros.Controls.Add(this.tabpgObservaciones);
            this.tabCtrlOtros.Location = new System.Drawing.Point(16, 298);
            this.tabCtrlOtros.Name = "tabCtrlOtros";
            this.tabCtrlOtros.SelectedIndex = 0;
            this.tabCtrlOtros.Size = new System.Drawing.Size(650, 197);
            this.tabCtrlOtros.TabIndex = 2;
            // 
            // tabPgCoordenadas
            // 
            this.tabPgCoordenadas.Controls.Add(this.txtBoxLongitudMax);
            this.tabPgCoordenadas.Controls.Add(this.txtBoxLongitudMin);
            this.tabPgCoordenadas.Controls.Add(this.txtBoxLatitudMax);
            this.tabPgCoordenadas.Controls.Add(this.txtBoxLatitudMin);
            this.tabPgCoordenadas.Controls.Add(this.label10);
            this.tabPgCoordenadas.Controls.Add(this.label9);
            this.tabPgCoordenadas.Controls.Add(this.label8);
            this.tabPgCoordenadas.Controls.Add(this.label7);
            this.tabPgCoordenadas.Location = new System.Drawing.Point(4, 22);
            this.tabPgCoordenadas.Name = "tabPgCoordenadas";
            this.tabPgCoordenadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgCoordenadas.Size = new System.Drawing.Size(642, 171);
            this.tabPgCoordenadas.TabIndex = 0;
            this.tabPgCoordenadas.Text = "Coordenadas";
            this.tabPgCoordenadas.UseVisualStyleBackColor = true;
            // 
            // txtBoxLongitudMax
            // 
            this.txtBoxLongitudMax.Decimals = ((byte)(0));
            this.txtBoxLongitudMax.DecSeparator = '.';
            this.txtBoxLongitudMax.Format = TextBoxConFormato.tbFormats.SignedFloatingPointNumber;
            this.txtBoxLongitudMax.Location = new System.Drawing.Point(340, 102);
            this.txtBoxLongitudMax.Name = "txtBoxLongitudMax";
            this.txtBoxLongitudMax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLongitudMax.TabIndex = 7;
            this.txtBoxLongitudMax.UserValues = "";
            // 
            // txtBoxLongitudMin
            // 
            this.txtBoxLongitudMin.Decimals = ((byte)(0));
            this.txtBoxLongitudMin.DecSeparator = '.';
            this.txtBoxLongitudMin.Format = TextBoxConFormato.tbFormats.SignedFloatingPointNumber;
            this.txtBoxLongitudMin.Location = new System.Drawing.Point(222, 102);
            this.txtBoxLongitudMin.Name = "txtBoxLongitudMin";
            this.txtBoxLongitudMin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLongitudMin.TabIndex = 6;
            this.txtBoxLongitudMin.UserValues = "";
            // 
            // txtBoxLatitudMax
            // 
            this.txtBoxLatitudMax.Decimals = ((byte)(0));
            this.txtBoxLatitudMax.DecSeparator = '.';
            this.txtBoxLatitudMax.Format = TextBoxConFormato.tbFormats.SignedFloatingPointNumber;
            this.txtBoxLatitudMax.Location = new System.Drawing.Point(340, 72);
            this.txtBoxLatitudMax.Name = "txtBoxLatitudMax";
            this.txtBoxLatitudMax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLatitudMax.TabIndex = 5;
            this.txtBoxLatitudMax.UserValues = "";
            // 
            // txtBoxLatitudMin
            // 
            this.txtBoxLatitudMin.Decimals = ((byte)(0));
            this.txtBoxLatitudMin.DecSeparator = '.';
            this.txtBoxLatitudMin.Format = TextBoxConFormato.tbFormats.SignedFloatingPointNumber;
            this.txtBoxLatitudMin.Location = new System.Drawing.Point(223, 72);
            this.txtBoxLatitudMin.Name = "txtBoxLatitudMin";
            this.txtBoxLatitudMin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLatitudMin.TabIndex = 4;
            this.txtBoxLatitudMin.UserValues = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Máxima";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mínima";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Longitud:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Latitud:";
            // 
            // tabPgMuestraGrafica
            // 
            this.tabPgMuestraGrafica.Controls.Add(this.btnExaminarMG);
            this.tabPgMuestraGrafica.Controls.Add(this.txtBoxMuestraGrafica);
            this.tabPgMuestraGrafica.Controls.Add(this.picBoxMuestraGrafica);
            this.tabPgMuestraGrafica.Location = new System.Drawing.Point(4, 22);
            this.tabPgMuestraGrafica.Name = "tabPgMuestraGrafica";
            this.tabPgMuestraGrafica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgMuestraGrafica.Size = new System.Drawing.Size(642, 171);
            this.tabPgMuestraGrafica.TabIndex = 1;
            this.tabPgMuestraGrafica.Text = "Muestra Gráfica";
            this.tabPgMuestraGrafica.UseVisualStyleBackColor = true;
            // 
            // btnExaminarMG
            // 
            this.btnExaminarMG.Location = new System.Drawing.Point(463, 82);
            this.btnExaminarMG.Name = "btnExaminarMG";
            this.btnExaminarMG.Size = new System.Drawing.Size(75, 23);
            this.btnExaminarMG.TabIndex = 2;
            this.btnExaminarMG.Text = "Examinar";
            this.btnExaminarMG.UseVisualStyleBackColor = true;
            this.btnExaminarMG.Click += new System.EventHandler(this.btnExaminarMG_Click);
            // 
            // txtBoxMuestraGrafica
            // 
            this.txtBoxMuestraGrafica.Location = new System.Drawing.Point(402, 56);
            this.txtBoxMuestraGrafica.Name = "txtBoxMuestraGrafica";
            this.txtBoxMuestraGrafica.Size = new System.Drawing.Size(203, 20);
            this.txtBoxMuestraGrafica.TabIndex = 1;
            // 
            // picBoxMuestraGrafica
            // 
            this.picBoxMuestraGrafica.Location = new System.Drawing.Point(74, 6);
            this.picBoxMuestraGrafica.Name = "picBoxMuestraGrafica";
            this.picBoxMuestraGrafica.Size = new System.Drawing.Size(280, 159);
            this.picBoxMuestraGrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMuestraGrafica.TabIndex = 0;
            this.picBoxMuestraGrafica.TabStop = false;
            // 
            // tabPgProcesos
            // 
            this.tabPgProcesos.Controls.Add(this.label11);
            this.tabPgProcesos.Controls.Add(this.txbProcesamiento);
            this.tabPgProcesos.Location = new System.Drawing.Point(4, 22);
            this.tabPgProcesos.Name = "tabPgProcesos";
            this.tabPgProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgProcesos.Size = new System.Drawing.Size(642, 171);
            this.tabPgProcesos.TabIndex = 2;
            this.tabPgProcesos.Text = "Procesamiento";
            this.tabPgProcesos.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Procesamiento";
            // 
            // txbProcesamiento
            // 
            this.txbProcesamiento.Location = new System.Drawing.Point(123, 6);
            this.txbProcesamiento.Multiline = true;
            this.txbProcesamiento.Name = "txbProcesamiento";
            this.txbProcesamiento.Size = new System.Drawing.Size(513, 159);
            this.txbProcesamiento.TabIndex = 0;
            // 
            // tabpgObservaciones
            // 
            this.tabpgObservaciones.Controls.Add(this.txbObservaciones);
            this.tabpgObservaciones.Location = new System.Drawing.Point(4, 22);
            this.tabpgObservaciones.Name = "tabpgObservaciones";
            this.tabpgObservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgObservaciones.Size = new System.Drawing.Size(642, 171);
            this.tabpgObservaciones.TabIndex = 3;
            this.tabpgObservaciones.Text = "Observaciones";
            this.tabpgObservaciones.UseVisualStyleBackColor = true;
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Location = new System.Drawing.Point(6, 9);
            this.txbObservaciones.Multiline = true;
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(630, 156);
            this.txbObservaciones.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Location = new System.Drawing.Point(16, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 25);
            this.panel1.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(294, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(20, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(38, 38);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaAvanzada.Image")));
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(64, 6);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(38, 38);
            this.btnBusquedaAvanzada.TabIndex = 5;
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(108, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(628, 6);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(38, 38);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(521, 298);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(0, 13);
            this.lblProceso.TabIndex = 8;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 511);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCtrlOtros);
            this.Controls.Add(this.gpboxDatosBasicos);
            this.Controls.Add(this.gpboxImagenes);
            this.Name = "Principal";
            this.Text = "Modulo de Captura Teleinformación";
            this.gpboxImagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpboxDatosBasicos.ResumeLayout(false);
            this.gpboxDatosBasicos.PerformLayout();
            this.tabCtrlOtros.ResumeLayout(false);
            this.tabPgCoordenadas.ResumeLayout(false);
            this.tabPgCoordenadas.PerformLayout();
            this.tabPgMuestraGrafica.ResumeLayout(false);
            this.tabPgMuestraGrafica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMuestraGrafica)).EndInit();
            this.tabPgProcesos.ResumeLayout(false);
            this.tabPgProcesos.PerformLayout();
            this.tabpgObservaciones.ResumeLayout(false);
            this.tabpgObservaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxImagenes;
        private System.Windows.Forms.GroupBox gpboxDatosBasicos;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.TextBox tbxResolucionEspacial;
        private System.Windows.Forms.TextBox tbxArchivo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCtrlOtros;
        private System.Windows.Forms.TabPage tabPgCoordenadas;
        private System.Windows.Forms.TabPage tabPgMuestraGrafica;
        private System.Windows.Forms.TabPage tabPgProcesos;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private TextBoxConFormato.FormattedTextBox txtBoxLongitudMax;
        private TextBoxConFormato.FormattedTextBox txtBoxLongitudMin;
        private TextBoxConFormato.FormattedTextBox txtBoxLatitudMax;
        private TextBoxConFormato.FormattedTextBox txtBoxLatitudMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExaminarMG;
        private System.Windows.Forms.TextBox txtBoxMuestraGrafica;
        private System.Windows.Forms.PictureBox picBoxMuestraGrafica;
        private System.Windows.Forms.TextBox txbProcesamiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabpgObservaciones;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.TextBox txbObservaciones;
    }
}