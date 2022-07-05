
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_simulacion = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gb_metricas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_espera_max = new System.Windows.Forms.Label();
            this.lbl_cola_max = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_parametros = new System.Windows.Forms.GroupBox();
            this.nud_tiempo_entre_limp = new System.Windows.Forms.NumericUpDown();
            this.lbl_tiempo_entre_limp = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.nud_total_filas = new System.Windows.Forms.NumericUpDown();
            this.lbl_mostrar_hasta = new System.Windows.Forms.Label();
            this.nud_minuto_desde = new System.Windows.Forms.NumericUpDown();
            this.lbl_mostrar_desde = new System.Windows.Forms.Label();
            this.nud_duracion_limp = new System.Windows.Forms.NumericUpDown();
            this.lbl_duracion_limp = new System.Windows.Forms.Label();
            this.nud_tiempo_entre_susp = new System.Windows.Forms.NumericUpDown();
            this.nud_total_minutos = new System.Windows.Forms.NumericUpDown();
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
            this.tab_rk = new System.Windows.Forms.TabPage();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_runge_kutta = new System.Windows.Forms.DataGridView();
            this.tab_info = new System.Windows.Forms.TabPage();
            this.lbl_enunciado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tab_simulacion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gb_metricas.SuspendLayout();
            this.gb_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tiempo_entre_limp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_total_filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minuto_desde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_limp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tiempo_entre_susp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_total_minutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.tab_rk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_runge_kutta)).BeginInit();
            this.tab_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_simulacion);
            this.tabControl1.Controls.Add(this.tab_rk);
            this.tabControl1.Controls.Add(this.tab_info);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1469, 703);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_simulacion
            // 
            this.tab_simulacion.Controls.Add(this.tableLayoutPanel1);
            this.tab_simulacion.Location = new System.Drawing.Point(4, 25);
            this.tab_simulacion.Name = "tab_simulacion";
            this.tab_simulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_simulacion.Size = new System.Drawing.Size(1461, 674);
            this.tab_simulacion.TabIndex = 0;
            this.tab_simulacion.Text = "Simulación";
            this.tab_simulacion.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1455, 668);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.panel2.Size = new System.Drawing.Size(431, 627);
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
            this.gb_metricas.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiempo de espera máxima en cola:";
            // 
            // lbl_espera_max
            // 
            this.lbl_espera_max.AutoSize = true;
            this.lbl_espera_max.Location = new System.Drawing.Point(318, 69);
            this.lbl_espera_max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_espera_max.Name = "lbl_espera_max";
            this.lbl_espera_max.Size = new System.Drawing.Size(16, 17);
            this.lbl_espera_max.TabIndex = 5;
            this.lbl_espera_max.Text = "0";
            // 
            // lbl_cola_max
            // 
            this.lbl_cola_max.AutoSize = true;
            this.lbl_cola_max.Location = new System.Drawing.Point(318, 37);
            this.lbl_cola_max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cola_max.Name = "lbl_cola_max";
            this.lbl_cola_max.Size = new System.Drawing.Size(16, 17);
            this.lbl_cola_max.TabIndex = 4;
            this.lbl_cola_max.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad máxima de personas en cola:";
            // 
            // gb_parametros
            // 
            this.gb_parametros.Controls.Add(this.nud_tiempo_entre_limp);
            this.gb_parametros.Controls.Add(this.lbl_tiempo_entre_limp);
            this.gb_parametros.Controls.Add(this.lbl_b);
            this.gb_parametros.Controls.Add(this.nud_total_filas);
            this.gb_parametros.Controls.Add(this.lbl_mostrar_hasta);
            this.gb_parametros.Controls.Add(this.nud_minuto_desde);
            this.gb_parametros.Controls.Add(this.lbl_mostrar_desde);
            this.gb_parametros.Controls.Add(this.nud_duracion_limp);
            this.gb_parametros.Controls.Add(this.lbl_duracion_limp);
            this.gb_parametros.Controls.Add(this.nud_tiempo_entre_susp);
            this.gb_parametros.Controls.Add(this.nud_total_minutos);
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
            // nud_tiempo_entre_limp
            // 
            this.nud_tiempo_entre_limp.Location = new System.Drawing.Point(279, 295);
            this.nud_tiempo_entre_limp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_tiempo_entre_limp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_tiempo_entre_limp.Name = "nud_tiempo_entre_limp";
            this.nud_tiempo_entre_limp.Size = new System.Drawing.Size(100, 22);
            this.nud_tiempo_entre_limp.TabIndex = 6;
            this.nud_tiempo_entre_limp.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nud_tiempo_entre_limp.Click += new System.EventHandler(this.numActive);
            this.nud_tiempo_entre_limp.Enter += new System.EventHandler(this.numActive);
            // 
            // lbl_tiempo_entre_limp
            // 
            this.lbl_tiempo_entre_limp.AutoSize = true;
            this.lbl_tiempo_entre_limp.Location = new System.Drawing.Point(52, 297);
            this.lbl_tiempo_entre_limp.Name = "lbl_tiempo_entre_limp";
            this.lbl_tiempo_entre_limp.Size = new System.Drawing.Size(221, 17);
            this.lbl_tiempo_entre_limp.TabIndex = 65;
            this.lbl_tiempo_entre_limp.Text = "Tiempo entre limpiezas (minutos):";
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
            // nud_total_filas
            // 
            this.nud_total_filas.Location = new System.Drawing.Point(279, 124);
            this.nud_total_filas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_total_filas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_total_filas.Name = "nud_total_filas";
            this.nud_total_filas.Size = new System.Drawing.Size(100, 22);
            this.nud_total_filas.TabIndex = 2;
            this.nud_total_filas.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nud_total_filas.Click += new System.EventHandler(this.numActive);
            this.nud_total_filas.Enter += new System.EventHandler(this.numActive);
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
            // nud_minuto_desde
            // 
            this.nud_minuto_desde.Location = new System.Drawing.Point(279, 80);
            this.nud_minuto_desde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_minuto_desde.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_minuto_desde.Name = "nud_minuto_desde";
            this.nud_minuto_desde.Size = new System.Drawing.Size(100, 22);
            this.nud_minuto_desde.TabIndex = 1;
            this.nud_minuto_desde.Click += new System.EventHandler(this.numActive);
            this.nud_minuto_desde.Enter += new System.EventHandler(this.numActive);
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
            // nud_duracion_limp
            // 
            this.nud_duracion_limp.Location = new System.Drawing.Point(279, 339);
            this.nud_duracion_limp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_duracion_limp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_duracion_limp.Name = "nud_duracion_limp";
            this.nud_duracion_limp.Size = new System.Drawing.Size(100, 22);
            this.nud_duracion_limp.TabIndex = 7;
            this.nud_duracion_limp.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_duracion_limp.Click += new System.EventHandler(this.numActive);
            this.nud_duracion_limp.Enter += new System.EventHandler(this.numActive);
            // 
            // lbl_duracion_limp
            // 
            this.lbl_duracion_limp.AutoSize = true;
            this.lbl_duracion_limp.Location = new System.Drawing.Point(51, 341);
            this.lbl_duracion_limp.Name = "lbl_duracion_limp";
            this.lbl_duracion_limp.Size = new System.Drawing.Size(222, 17);
            this.lbl_duracion_limp.TabIndex = 56;
            this.lbl_duracion_limp.Text = "Duración de la limpieza (minutos):";
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
            40,
            0,
            0,
            0});
            this.nud_tiempo_entre_susp.Click += new System.EventHandler(this.numActive);
            this.nud_tiempo_entre_susp.Enter += new System.EventHandler(this.numActive);
            // 
            // nud_total_minutos
            // 
            this.nud_total_minutos.Location = new System.Drawing.Point(279, 36);
            this.nud_total_minutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_total_minutos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_total_minutos.Name = "nud_total_minutos";
            this.nud_total_minutos.Size = new System.Drawing.Size(100, 22);
            this.nud_total_minutos.TabIndex = 0;
            this.nud_total_minutos.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nud_total_minutos.Click += new System.EventHandler(this.numActive);
            this.nud_total_minutos.Enter += new System.EventHandler(this.numActive);
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(95, 209);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(21, 17);
            this.lbl_a.TabIndex = 3;
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
            20,
            0,
            0,
            0});
            this.nud_b.Name = "nud_b";
            this.nud_b.Size = new System.Drawing.Size(100, 22);
            this.nud_b.TabIndex = 4;
            this.nud_b.Value = new decimal(new int[] {
            375,
            0,
            0,
            131072});
            this.nud_b.Click += new System.EventHandler(this.numActive);
            this.nud_b.Enter += new System.EventHandler(this.numActive);
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
            this.lbl_intervalo_llegadas.Location = new System.Drawing.Point(25, 164);
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
            20,
            0,
            0,
            0});
            this.nud_a.Name = "nud_a";
            this.nud_a.Size = new System.Drawing.Size(100, 22);
            this.nud_a.TabIndex = 3;
            this.nud_a.Value = new decimal(new int[] {
            225,
            0,
            0,
            131072});
            this.nud_a.Click += new System.EventHandler(this.numActive);
            this.nud_a.Enter += new System.EventHandler(this.numActive);
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
            this.btn_restablecer.Enabled = false;
            this.btn_restablecer.Location = new System.Drawing.Point(8, 418);
            this.btn_restablecer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restablecer.Name = "btn_restablecer";
            this.btn_restablecer.Size = new System.Drawing.Size(204, 53);
            this.btn_restablecer.TabIndex = 1;
            this.btn_restablecer.Text = "Restablecer";
            this.btn_restablecer.UseVisualStyleBackColor = true;
            this.btn_restablecer.Click += new System.EventHandler(this.btn_restablecer_Click);
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
            this.panel4.Size = new System.Drawing.Size(1009, 664);
            this.panel4.TabIndex = 67;
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.AllowUserToAddRows = false;
            this.dgv_simulacion.AllowUserToDeleteRows = false;
            this.dgv_simulacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_simulacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_simulacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_simulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_simulacion.ColumnHeadersHeight = 80;
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_simulacion.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_simulacion.Location = new System.Drawing.Point(7, 19);
            this.dgv_simulacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.ReadOnly = true;
            this.dgv_simulacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_simulacion.RowHeadersVisible = false;
            this.dgv_simulacion.RowHeadersWidth = 51;
            this.dgv_simulacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_simulacion.RowTemplate.Height = 24;
            this.dgv_simulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_simulacion.ShowCellErrors = false;
            this.dgv_simulacion.ShowCellToolTips = false;
            this.dgv_simulacion.ShowEditingIcon = false;
            this.dgv_simulacion.ShowRowErrors = false;
            this.dgv_simulacion.Size = new System.Drawing.Size(993, 638);
            this.dgv_simulacion.TabIndex = 62;
            // 
            // tab_rk
            // 
            this.tab_rk.Controls.Add(this.lbl_tiempo);
            this.tab_rk.Controls.Add(this.label4);
            this.tab_rk.Controls.Add(this.label3);
            this.tab_rk.Controls.Add(this.dgv_runge_kutta);
            this.tab_rk.Location = new System.Drawing.Point(4, 25);
            this.tab_rk.Name = "tab_rk";
            this.tab_rk.Padding = new System.Windows.Forms.Padding(3);
            this.tab_rk.Size = new System.Drawing.Size(1461, 674);
            this.tab_rk.TabIndex = 1;
            this.tab_rk.Text = "Runge Kutta";
            this.tab_rk.UseVisualStyleBackColor = true;
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo.Location = new System.Drawing.Point(437, 104);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(15, 19);
            this.lbl_tiempo.TabIndex = 66;
            this.lbl_tiempo.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Tiempo que demora cada persona en deslizarse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Longitud de la alfombra mágica: 100 mts";
            // 
            // dgv_runge_kutta
            // 
            this.dgv_runge_kutta.AllowUserToAddRows = false;
            this.dgv_runge_kutta.AllowUserToDeleteRows = false;
            this.dgv_runge_kutta.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_runge_kutta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_runge_kutta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_runge_kutta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_runge_kutta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_runge_kutta.ColumnHeadersHeight = 30;
            this.dgv_runge_kutta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_runge_kutta.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_runge_kutta.Location = new System.Drawing.Point(556, 23);
            this.dgv_runge_kutta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_runge_kutta.Name = "dgv_runge_kutta";
            this.dgv_runge_kutta.ReadOnly = true;
            this.dgv_runge_kutta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_runge_kutta.RowHeadersVisible = false;
            this.dgv_runge_kutta.RowHeadersWidth = 51;
            this.dgv_runge_kutta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_runge_kutta.RowTemplate.Height = 24;
            this.dgv_runge_kutta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_runge_kutta.ShowCellErrors = false;
            this.dgv_runge_kutta.ShowCellToolTips = false;
            this.dgv_runge_kutta.ShowEditingIcon = false;
            this.dgv_runge_kutta.ShowRowErrors = false;
            this.dgv_runge_kutta.Size = new System.Drawing.Size(897, 638);
            this.dgv_runge_kutta.TabIndex = 63;
            // 
            // tab_info
            // 
            this.tab_info.Controls.Add(this.lbl_enunciado);
            this.tab_info.Controls.Add(this.pictureBox1);
            this.tab_info.Location = new System.Drawing.Point(4, 25);
            this.tab_info.Name = "tab_info";
            this.tab_info.Size = new System.Drawing.Size(1461, 674);
            this.tab_info.TabIndex = 2;
            this.tab_info.Text = "Información";
            this.tab_info.UseVisualStyleBackColor = true;
            // 
            // lbl_enunciado
            // 
            this.lbl_enunciado.AutoSize = true;
            this.lbl_enunciado.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enunciado.Location = new System.Drawing.Point(8, 16);
            this.lbl_enunciado.Name = "lbl_enunciado";
            this.lbl_enunciado.Size = new System.Drawing.Size(241, 22);
            this.lbl_enunciado.TabIndex = 2;
            this.lbl_enunciado.Text = "Enunciado Ejercicio 229:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabajo_Practico_Final.Properties.Resources.datos1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 743);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 703);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_principal";
            this.Text = "Trabajo Práctico 7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tab_simulacion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gb_metricas.ResumeLayout(false);
            this.gb_metricas.PerformLayout();
            this.gb_parametros.ResumeLayout(false);
            this.gb_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tiempo_entre_limp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_total_filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minuto_desde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion_limp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tiempo_entre_susp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_total_minutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            this.tab_rk.ResumeLayout(false);
            this.tab_rk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_runge_kutta)).EndInit();
            this.tab_info.ResumeLayout(false);
            this.tab_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_simulacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gb_metricas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_espera_max;
        private System.Windows.Forms.Label lbl_cola_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_parametros;
        private System.Windows.Forms.NumericUpDown nud_tiempo_entre_limp;
        private System.Windows.Forms.Label lbl_tiempo_entre_limp;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.NumericUpDown nud_total_filas;
        private System.Windows.Forms.Label lbl_mostrar_hasta;
        private System.Windows.Forms.NumericUpDown nud_minuto_desde;
        private System.Windows.Forms.Label lbl_mostrar_desde;
        private System.Windows.Forms.NumericUpDown nud_duracion_limp;
        private System.Windows.Forms.Label lbl_duracion_limp;
        private System.Windows.Forms.NumericUpDown nud_tiempo_entre_susp;
        private System.Windows.Forms.NumericUpDown nud_total_minutos;
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
        private System.Windows.Forms.TabPage tab_rk;
        private System.Windows.Forms.DataGridView dgv_runge_kutta;
        private System.Windows.Forms.TabPage tab_info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_enunciado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.Label label4;
    }
}