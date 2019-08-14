namespace Taller3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtB_Direccion = new System.Windows.Forms.TextBox();
            this.primerPanel = new System.Windows.Forms.Panel();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.listaEleccion = new System.Windows.Forms.ListBox();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.listaSeleccion = new System.Windows.Forms.ListBox();
            this.lbl_ptosWifi = new System.Windows.Forms.Label();
            this.btn_Ubicar = new System.Windows.Forms.Button();
            this.lbl_municipios = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.primerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_Direccion
            // 
            this.txtB_Direccion.Enabled = false;
            this.txtB_Direccion.Location = new System.Drawing.Point(97, 62);
            this.txtB_Direccion.Name = "txtB_Direccion";
            this.txtB_Direccion.Size = new System.Drawing.Size(160, 20);
            this.txtB_Direccion.TabIndex = 0;
            // 
            // primerPanel
            // 
            this.primerPanel.Controls.Add(this.btn_Abrir);
            this.primerPanel.Controls.Add(this.btn_Buscar);
            this.primerPanel.Controls.Add(this.label2);
            this.primerPanel.Controls.Add(this.label1);
            this.primerPanel.Controls.Add(this.txtB_Direccion);
            this.primerPanel.Location = new System.Drawing.Point(27, 29);
            this.primerPanel.Name = "primerPanel";
            this.primerPanel.Size = new System.Drawing.Size(373, 141);
            this.primerPanel.TabIndex = 1;
            this.primerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrimerPanel_Paint);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abrir.Location = new System.Drawing.Point(218, 96);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(81, 32);
            this.btn_Abrir.TabIndex = 4;
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.Btn_Abrir_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(62, 96);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(89, 32);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección del archivo";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Búsqueda de archivo";
            // 
            // gMap
            // 
            this.gMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.Enabled = false;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(685, 35);
            this.gMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(421, 440);
            this.gMap.TabIndex = 2;
            this.gMap.Visible = false;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.GMap_Load);
            // 
            // listaEleccion
            // 
            this.listaEleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaEleccion.Enabled = false;
            this.listaEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEleccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listaEleccion.FormattingEnabled = true;
            this.listaEleccion.ItemHeight = 17;
            this.listaEleccion.Location = new System.Drawing.Point(433, 35);
            this.listaEleccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaEleccion.Name = "listaEleccion";
            this.listaEleccion.Size = new System.Drawing.Size(248, 225);
            this.listaEleccion.TabIndex = 3;
            this.listaEleccion.Visible = false;
            this.listaEleccion.SelectedIndexChanged += new System.EventHandler(this.ListaEleccion_SelectedIndexChanged);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Enabled = false;
            this.btn_Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Seleccionar.Location = new System.Drawing.Point(459, 277);
            this.btn_Seleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(200, 28);
            this.btn_Seleccionar.TabIndex = 4;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Visible = false;
            this.btn_Seleccionar.Click += new System.EventHandler(this.Btn_Seleccionar_Click);
            // 
            // listaSeleccion
            // 
            this.listaSeleccion.Enabled = false;
            this.listaSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSeleccion.FormattingEnabled = true;
            this.listaSeleccion.ItemHeight = 20;
            this.listaSeleccion.Location = new System.Drawing.Point(433, 369);
            this.listaSeleccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaSeleccion.Name = "listaSeleccion";
            this.listaSeleccion.Size = new System.Drawing.Size(248, 144);
            this.listaSeleccion.TabIndex = 5;
            this.listaSeleccion.Visible = false;
            // 
            // lbl_ptosWifi
            // 
            this.lbl_ptosWifi.AutoSize = true;
            this.lbl_ptosWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ptosWifi.Location = new System.Drawing.Point(492, 343);
            this.lbl_ptosWifi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ptosWifi.Name = "lbl_ptosWifi";
            this.lbl_ptosWifi.Size = new System.Drawing.Size(114, 24);
            this.lbl_ptosWifi.TabIndex = 6;
            this.lbl_ptosWifi.Text = "Puntos Wifi";
            this.lbl_ptosWifi.Visible = false;
            this.lbl_ptosWifi.Click += new System.EventHandler(this.Label3_Click);
            // 
            // btn_Ubicar
            // 
            this.btn_Ubicar.Enabled = false;
            this.btn_Ubicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ubicar.Location = new System.Drawing.Point(459, 521);
            this.btn_Ubicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ubicar.Name = "btn_Ubicar";
            this.btn_Ubicar.Size = new System.Drawing.Size(200, 36);
            this.btn_Ubicar.TabIndex = 7;
            this.btn_Ubicar.Text = "Ubicar";
            this.btn_Ubicar.UseVisualStyleBackColor = true;
            this.btn_Ubicar.Visible = false;
            this.btn_Ubicar.Click += new System.EventHandler(this.Btn_Ubicar_Click);
            // 
            // lbl_municipios
            // 
            this.lbl_municipios.AutoSize = true;
            this.lbl_municipios.Enabled = false;
            this.lbl_municipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_municipios.Location = new System.Drawing.Point(492, 9);
            this.lbl_municipios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_municipios.Name = "lbl_municipios";
            this.lbl_municipios.Size = new System.Drawing.Size(101, 24);
            this.lbl_municipios.TabIndex = 8;
            this.lbl_municipios.Text = "Municipio";
            this.lbl_municipios.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 190);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(373, 366);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 568);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.lbl_municipios);
            this.Controls.Add(this.btn_Ubicar);
            this.Controls.Add(this.lbl_ptosWifi);
            this.Controls.Add(this.listaSeleccion);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.listaEleccion);
            this.Controls.Add(this.primerPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.primerPanel.ResumeLayout(false);
            this.primerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_Direccion;
        private System.Windows.Forms.Panel primerPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Abrir;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.ListBox listaSeleccion;
        private System.Windows.Forms.Label lbl_ptosWifi;
        private System.Windows.Forms.Button btn_Ubicar;
        private System.Windows.Forms.Label lbl_municipios;
        private System.Windows.Forms.ListBox listaEleccion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

