
namespace Trabajo_Practico_Final.Presentacion
{
    partial class frm_principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gb_metricas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_espera_max = new System.Windows.Forms.Label();
            this.lbl_cola_max = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_parametros = new System.Windows.Forms.GroupBox();
            this.nud_mostrar_hasta = new System.Windows.Forms.NumericUpDown();
            this.lbl_mostrar_hasta = new System.Windows.Forms.Label();
            this.nud_mostrar_desde = new System.Windows.Forms.NumericUpDown();
            this.lbl_mostrar_desde = new System.Windows.Forms.Label();
            this.nud_cant_alfombras = new System.Windows.Forms.NumericUpDown();
            this.lbl_cant_alfombras = new System.Windows.Forms.Label();
            this.nud_duracion_susp = new System.Windows.Forms.NumericUpDown();
            this.lbl_duracion_susp = new System.Windows.Forms.Label();
            this.nud_tiempo_entre_susp = new System.Windows.Forms.NumericUpDown();
            this.nud_cant_simulaciones = new System.Windows.Forms.NumericUpDown();
            this.lbl_a = new System.Windows.Forms.Label();
            this.nud_b = new System.Windows.Forms.NumericUpDown();
            this.lbl_tiempo_entre_susp = new System.Windows.Forms.Label();
            this.lbl_intervalo_llegadas = new System.Windows.Forms.Label();
            this.lbl_cant_min = new System.Windows.Forms.Label();
            this.nud_a = new System.Windows.Forms.NumericUpDown();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_restablecer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_simulacion = new System.Windows.Forms.DataGridView();
            this.lbl_b = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gb_metricas.SuspendLayout();
            this.gb_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mostrar_hasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mostrar_desde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_alfombras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_susp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tiempo_entre_susp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_simulaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1469, 670);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gb_metricas);
            this.panel2.Controls.Add(this.gb_parametros);
            this.panel2.Controls.Add(this.btn_generar);
            this.panel2.Controls.Add(this.btn_restablecer);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 662);
            this.panel2.TabIndex = 63;
            // 
            // gb_metricas
            // 
            this.gb_metricas.Controls.Add(this.label2);
            this.gb_metricas.Controls.Add(this.lbl_espera_max);
            this.gb_metricas.Controls.Add(this.lbl_cola_max);
            this.gb_metricas.Controls.Add(this.label1);
            this.gb_metricas.Location = new System.Drawing.Point(8, 481);
            this.gb_metricas.Margin = new System.Windows.Forms.Padding(4);
            this.gb_metricas.Name = "gb_metricas";
            this.gb_metricas.Padding = new System.Windows.Forms.Padding(4);
            this.gb_metricas.Size = new System.Drawing.Size(417, 109);
            this.gb_metricas.TabIndex = 63;
            this.gb_metricas.TabStop = false;
            this.gb_metricas.Text = "Métricas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiempo de espera máxima en cola:";
            // 
            // lbl_espera_max
            // 
            this.lbl_espera_max.AutoSize = true;
            this.lbl_espera_max.Location = new System.Drawing.Point(281, 69);
            this.lbl_espera_max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_espera_max.Name = "lbl_espera_max";
            this.lbl_espera_max.Size = new System.Drawing.Size(16, 17);
            this.lbl_espera_max.TabIndex = 5;
            this.lbl_espera_max.Text = "0";
            // 
            // lbl_cola_max
            // 
            this.lbl_cola_max.AutoSize = true;
            this.lbl_cola_max.Location = new System.Drawing.Point(281, 37);
            this.lbl_cola_max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cola_max.Name = "lbl_cola_max";
            this.lbl_cola_max.Size = new System.Drawing.Size(16, 17);
            this.lbl_cola_max.TabIndex = 4;
            this.lbl_cola_max.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad máxima de personas en cola:";
            // 
            // gb_parametros
            // 
            this.gb_parametros.Controls.Add(this.lbl_b);
            this.gb_parametros.Controls.Add(this.nud_mostrar_hasta);
            this.gb_parametros.Controls.Add(this.lbl_mostrar_hasta);
            this.gb_parametros.Controls.Add(this.nud_mostrar_desde);
            this.gb_parametros.Controls.Add(this.lbl_mostrar_desde);
            this.gb_parametros.Controls.Add(this.nud_cant_alfombras);
            this.gb_parametros.Controls.Add(this.lbl_cant_alfombras);
            this.gb_parametros.Controls.Add(this.nud_duracion_susp);
            this.gb_parametros.Controls.Add(this.lbl_duracion_susp);
            this.gb_parametros.Controls.Add(this.nud_tiempo_entre_susp);
            this.gb_parametros.Controls.Add(this.nud_cant_simulaciones);
            this.gb_parametros.Controls.Add(this.lbl_a);
            this.gb_parametros.Controls.Add(this.nud_b);
            this.gb_parametros.Controls.Add(this.lbl_tiempo_entre_susp);
            this.gb_parametros.Controls.Add(this.lbl_intervalo_llegadas);
            this.gb_parametros.Controls.Add(this.lbl_cant_min);
            this.gb_parametros.Controls.Add(this.nud_a);
            this.gb_parametros.Location = new System.Drawing.Point(8, 10);
            this.gb_parametros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_parametros.Name = "gb_parametros";
            this.gb_parametros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_parametros.Size = new System.Drawing.Size(417, 392);
            this.gb_parametros.TabIndex = 0;
            this.gb_parametros.TabStop = false;
            this.gb_parametros.Text = "Parámetros";
            // 
            // nud_mostrar_hasta
            // 
            this.nud_mostrar_hasta.Location = new System.Drawing.Point(279, 124);
            this.nud_mostrar_hasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_mostrar_hasta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_mostrar_hasta.Name = "nud_mostrar_hasta";
            this.nud_mostrar_hasta.Size = new System.Drawing.Size(100, 22);
            this.nud_mostrar_hasta.TabIndex = 2;
            this.nud_mostrar_hasta.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // lbl_mostrar_hasta
            // 
            this.lbl_mostrar_hasta.AutoSize = true;
            this.lbl_mostrar_hasta.Location = new System.Drawing.Point(92, 126);
            this.lbl_mostrar_hasta.Name = "lbl_mostrar_hasta";
            this.lbl_mostrar_hasta.Size = new System.Drawing.Size(181, 17);
            this.lbl_mostrar_hasta.TabIndex = 62;
            this.lbl_mostrar_hasta.Text = "Cantidad de filas a mostrar:";
            this.lbl_mostrar_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nud_mostrar_desde
            // 
            this.nud_mostrar_desde.Location = new System.Drawing.Point(279, 80);
            this.nud_mostrar_desde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_mostrar_desde.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_mostrar_desde.Name = "nud_mostrar_desde";
            this.nud_mostrar_desde.Size = new System.Drawing.Size(100, 22);
            this.nud_mostrar_desde.TabIndex = 1;
            // 
            // lbl_mostrar_desde
            // 
            this.lbl_mostrar_desde.AutoSize = true;
            this.lbl_mostrar_desde.Location = new System.Drawing.Point(109, 82);
            this.lbl_mostrar_desde.Name = "lbl_mostrar_desde";
            this.lbl_mostrar_desde.Size = new System.Drawing.Size(164, 17);
            this.lbl_mostrar_desde.TabIndex = 60;
            this.lbl_mostrar_desde.Text = "Mostrar desde el minuto:";
            this.lbl_mostrar_desde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nud_cant_alfombras
            // 
            this.nud_cant_alfombras.Location = new System.Drawing.Point(279, 339);
            this.nud_cant_alfombras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_cant_alfombras.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_cant_alfombras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cant_alfombras.Name = "nud_cant_alfombras";
            this.nud_cant_alfombras.Size = new System.Drawing.Size(100, 22);
            this.nud_cant_alfombras.TabIndex = 7;
            this.nud_cant_alfombras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_cant_alfombras
            // 
            this.lbl_cant_alfombras.AutoSize = true;
            this.lbl_cant_alfombras.Location = new System.Drawing.Point(119, 341);
            this.lbl_cant_alfombras.Name = "lbl_cant_alfombras";
            this.lbl_cant_alfombras.Size = new System.Drawing.Size(154, 17);
            this.lbl_cant_alfombras.TabIndex = 58;
            this.lbl_cant_alfombras.Text = "Cantidad de alfombras:";
            // 
            // nud_duracion_susp
            // 
            this.nud_duracion_susp.Location = new System.Drawing.Point(279, 295);
            this.nud_duracion_susp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_duracion_susp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_duracion_susp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_duracion_susp.Name = "nud_duracion_susp";
            this.nud_duracion_susp.Size = new System.Drawing.Size(100, 22);
            this.nud_duracion_susp.TabIndex = 6;
            this.nud_duracion_susp.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lbl_duracion_susp
            // 
            this.lbl_duracion_susp.AutoSize = true;
            this.lbl_duracion_susp.Location = new System.Drawing.Point(30, 297);
            this.lbl_duracion_susp.Name = "lbl_duracion_susp";
            this.lbl_duracion_susp.Size = new System.Drawing.Size(243, 17);
            this.lbl_duracion_susp.TabIndex = 56;
            this.lbl_duracion_susp.Text = "Duración de la suspensión (minutos):";
            // 
            // nud_tiempo_entre_susp
            // 
            this.nud_tiempo_entre_susp.Location = new System.Drawing.Point(279, 251);
            this.nud_tiempo_entre_susp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_tiempo_entre_susp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_tiempo_entre_susp.Name = "nud_tiempo_entre_susp";
            this.nud_tiempo_entre_susp.Size = new System.Drawing.Size(100, 22);
            this.nud_tiempo_entre_susp.TabIndex = 5;
            this.nud_tiempo_entre_susp.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // nud_cant_simulaciones
            // 
            this.nud_cant_simulaciones.Location = new System.Drawing.Point(279, 36);
            this.nud_cant_simulaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_cant_simulaciones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_cant_simulaciones.Name = "nud_cant_simulaciones";
            this.nud_cant_simulaciones.Size = new System.Drawing.Size(100, 22);
            this.nud_cant_simulaciones.TabIndex = 0;
            this.nud_cant_simulaciones.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(95, 209);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(21, 17);
            this.lbl_a.TabIndex = 51;
            this.lbl_a.Text = "A:";
            // 
            // nud_b
            // 
            this.nud_b.DecimalPlaces = 2;
            this.nud_b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_b.Location = new System.Drawing.Point(279, 207);
            this.nud_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_b.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_b.Name = "nud_b";
            this.nud_b.Size = new System.Drawing.Size(100, 22);
            this.nud_b.TabIndex = 3;
            this.nud_b.Value = new decimal(new int[] {
            345,
            0,
            0,
            131072});
            // 
            // lbl_tiempo_entre_susp
            // 
            this.lbl_tiempo_entre_susp.AutoSize = true;
            this.lbl_tiempo_entre_susp.Location = new System.Drawing.Point(23, 253);
            this.lbl_tiempo_entre_susp.Name = "lbl_tiempo_entre_susp";
            this.lbl_tiempo_entre_susp.Size = new System.Drawing.Size(250, 17);
            this.lbl_tiempo_entre_susp.TabIndex = 52;
            this.lbl_tiempo_entre_susp.Text = "Tiempo entre suspensiones (minutos):";
            // 
            // lbl_intervalo_llegadas
            // 
            this.lbl_intervalo_llegadas.AutoSize = true;
            this.lbl_intervalo_llegadas.Location = new System.Drawing.Point(25, 168);
            this.lbl_intervalo_llegadas.Name = "lbl_intervalo_llegadas";
            this.lbl_intervalo_llegadas.Size = new System.Drawing.Size(354, 17);
            this.lbl_intervalo_llegadas.TabIndex = 50;
            this.lbl_intervalo_llegadas.Text = "Tiempo entre llegadas de personas (minutos) - U(A; B)";
            this.lbl_intervalo_llegadas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_cant_min
            // 
            this.lbl_cant_min.AutoSize = true;
            this.lbl_cant_min.Location = new System.Drawing.Point(42, 38);
            this.lbl_cant_min.Name = "lbl_cant_min";
            this.lbl_cant_min.Size = new System.Drawing.Size(231, 17);
            this.lbl_cant_min.TabIndex = 53;
            this.lbl_cant_min.Text = "Cantidad de minutos de simulación:";
            // 
            // nud_a
            // 
            this.nud_a.DecimalPlaces = 2;
            this.nud_a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_a.Location = new System.Drawing.Point(122, 207);
            this.nud_a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_a.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_a.Name = "nud_a";
            this.nud_a.Size = new System.Drawing.Size(100, 22);
            this.nud_a.TabIndex = 4;
            this.nud_a.Value = new decimal(new int[] {
            225,
            0,
            0,
            131072});
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(221, 418);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(204, 53);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar Simulación";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_restablecer
            // 
            this.btn_restablecer.Location = new System.Drawing.Point(8, 418);
            this.btn_restablecer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restablecer.Name = "btn_restablecer";
            this.btn_restablecer.Size = new System.Drawing.Size(204, 53);
            this.btn_restablecer.TabIndex = 1;
            this.btn_restablecer.Text = "Restablecer";
            this.btn_restablecer.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgv_simulacion);
            this.panel4.Location = new System.Drawing.Point(443, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1023, 666);
            this.panel4.TabIndex = 67;
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.AllowUserToAddRows = false;
            this.dgv_simulacion.AllowUserToDeleteRows = false;
            this.dgv_simulacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_simulacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_simulacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_simulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_simulacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_simulacion.Location = new System.Drawing.Point(7, 19);
            this.dgv_simulacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.ReadOnly = true;
            this.dgv_simulacion.RowHeadersVisible = false;
            this.dgv_simulacion.RowHeadersWidth = 51;
            this.dgv_simulacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_simulacion.RowTemplate.Height = 24;
            this.dgv_simulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_simulacion.Size = new System.Drawing.Size(1007, 640);
            this.dgv_simulacion.TabIndex = 62;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(252, 209);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(21, 17);
            this.lbl_b.TabIndex = 63;
            this.lbl_b.Text = "B:";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 670);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_principal";
            this.Text = "Trabajo Práctico 7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gb_metricas.ResumeLayout(false);
            this.gb_metricas.PerformLayout();
            this.gb_parametros.ResumeLayout(false);
            this.gb_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mostrar_hasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mostrar_desde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_alfombras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_susp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tiempo_entre_susp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_simulaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gb_metricas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_espera_max;
        private System.Windows.Forms.Label lbl_cola_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_parametros;
        private System.Windows.Forms.NumericUpDown nud_mostrar_hasta;
        private System.Windows.Forms.Label lbl_mostrar_hasta;
        private System.Windows.Forms.NumericUpDown nud_mostrar_desde;
        private System.Windows.Forms.Label lbl_mostrar_desde;
        private System.Windows.Forms.NumericUpDown nud_cant_alfombras;
        private System.Windows.Forms.Label lbl_cant_alfombras;
        private System.Windows.Forms.NumericUpDown nud_duracion_susp;
        private System.Windows.Forms.Label lbl_duracion_susp;
        private System.Windows.Forms.NumericUpDown nud_tiempo_entre_susp;
        private System.Windows.Forms.NumericUpDown nud_cant_simulaciones;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.NumericUpDown nud_b;
        private System.Windows.Forms.Label lbl_tiempo_entre_susp;
        private System.Windows.Forms.Label lbl_intervalo_llegadas;
        private System.Windows.Forms.Label lbl_cant_min;
        private System.Windows.Forms.NumericUpDown nud_a;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_restablecer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_simulacion;
        private System.Windows.Forms.Label lbl_b;
    }
}