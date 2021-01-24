
namespace LetterStatistic
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.tbxLetters = new System.Windows.Forms.TextBox();
            this.dtgwStatisticShower = new System.Windows.Forms.DataGridView();
            this.chrLetterStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwStatisticShower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrLetterStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(21, 66);
            this.tbxText.MaxLength = 1000000;
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxText.Size = new System.Drawing.Size(294, 243);
            this.tbxText.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(21, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(97, 48);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Analiz Et";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // tbxLetters
            // 
            this.tbxLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLetters.Location = new System.Drawing.Point(328, 68);
            this.tbxLetters.Multiline = true;
            this.tbxLetters.Name = "tbxLetters";
            this.tbxLetters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxLetters.Size = new System.Drawing.Size(171, 240);
            this.tbxLetters.TabIndex = 2;
            // 
            // dtgwStatisticShower
            // 
            this.dtgwStatisticShower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwStatisticShower.Location = new System.Drawing.Point(505, 68);
            this.dtgwStatisticShower.Name = "dtgwStatisticShower";
            this.dtgwStatisticShower.Size = new System.Drawing.Size(378, 242);
            this.dtgwStatisticShower.TabIndex = 3;
            // 
            // chrLetterStatistic
            // 
            this.chrLetterStatistic.BorderlineColor = System.Drawing.Color.Black;
            this.chrLetterStatistic.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chrLetterStatistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrLetterStatistic.Legends.Add(legend1);
            this.chrLetterStatistic.Location = new System.Drawing.Point(21, 316);
            this.chrLetterStatistic.Name = "chrLetterStatistic";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Metin";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Türkçe Genel";
            this.chrLetterStatistic.Series.Add(series1);
            this.chrLetterStatistic.Series.Add(series2);
            this.chrLetterStatistic.Size = new System.Drawing.Size(862, 285);
            this.chrLetterStatistic.TabIndex = 4;
            this.chrLetterStatistic.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 604);
            this.Controls.Add(this.chrLetterStatistic);
            this.Controls.Add(this.dtgwStatisticShower);
            this.Controls.Add(this.tbxLetters);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.tbxText);
            this.Name = "Form1";
            this.Text = "Türkçe Harf Analizi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgwStatisticShower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrLetterStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox tbxLetters;
        private System.Windows.Forms.DataGridView dtgwStatisticShower;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrLetterStatistic;
    }
}

