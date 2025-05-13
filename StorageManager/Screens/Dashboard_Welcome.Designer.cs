namespace StorageManager.Screens
{
    partial class Dashboard_Welcome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Produits inflammables", new object[] { 30D }, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Produits métalliques", new object[] { 100D }, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("Produits électroniques", new object[] { 80D }, 2);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("Produits chimiques", new object[] { 45D }, 3);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            productTransferBindingSource1 = new BindingSource(components);
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            productTransferBindingSource = new BindingSource(components);
            chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)productTransferBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productTransferBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).BeginInit();
            SuspendLayout();
            // 
            // productTransferBindingSource1
            // 
            productTransferBindingSource1.DataSource = typeof(Data.Entities.ProductTransfer);
            // 
            // chartControl1
            // 
            chartControl1.DataSource = productTransferBindingSource;
            xyDiagram1.AxisX.Label.TextPattern = "Dates";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.Tag = "Nombre de transferts";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            chartControl1.Diagram = xyDiagram1;
            chartControl1.Legend.Tag = "Dates";
            chartControl1.Location = new Point(230, 15);
            chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series2.DataSource = productTransferBindingSource1;
            series2.Name = "Series 2";
            series2.SeriesID = 2;
            chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series1,
    series2
    };
            chartControl1.Size = new Size(360, 234);
            chartControl1.TabIndex = 0;
            // 
            // productTransferBindingSource
            // 
            productTransferBindingSource.DataSource = typeof(Data.Entities.ProductTransfer);
            // 
            // chartControl2
            // 
            chartControl2.Location = new Point(22, 255);
            chartControl2.Name = "chartControl2";
            series3.Name = "Catégories";
            seriesPoint1.ColorSerializable = "#F00000";
            seriesPoint2.ColorSerializable = "#366092";
            seriesPoint3.ColorSerializable = "#E36C09";
            seriesPoint4.ColorSerializable = "#FFC000";
            series3.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4 });
            series3.SeriesID = 0;
            series3.View = pieSeriesView1;
            chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series3
    };
            chartControl2.Size = new Size(375, 250);
            chartControl2.TabIndex = 1;
            // 
            // Dashboard_Welcome
            // 
            AccessibleName = "produit métallique";
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chartControl2);
            Controls.Add(chartControl1);
            Name = "Dashboard_Welcome";
            Size = new Size(809, 680);
            Load += Dashboard_Welcome_Load;
            ((System.ComponentModel.ISupportInitialize)productTransferBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productTransferBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private BindingSource productTransferBindingSource;
        private BindingSource productTransferBindingSource1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
    }
}
