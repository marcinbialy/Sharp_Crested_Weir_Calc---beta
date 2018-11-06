namespace PrzelewUI
{
    partial class PrzelewViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzelewViewerForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ObliczButton = new System.Windows.Forms.Button();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GenerujButton = new System.Windows.Forms.Button();
            this.PgValue = new System.Windows.Forms.TextBox();
            this.bValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.przelewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przelewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przelew o ostrej krawędzi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(16, 92);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(242, 200);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dane wejściowe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(16, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(135, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "[m]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(135, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "[m]";
            // 
            // ObliczButton
            // 
            this.ObliczButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ObliczButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.ObliczButton.FlatAppearance.BorderSize = 2;
            this.ObliczButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ObliczButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ObliczButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObliczButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObliczButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ObliczButton.Location = new System.Drawing.Point(168, 416);
            this.ObliczButton.Name = "ObliczButton";
            this.ObliczButton.Size = new System.Drawing.Size(110, 35);
            this.ObliczButton.TabIndex = 11;
            this.ObliczButton.Text = "OBLICZ";
            this.ObliczButton.UseVisualStyleBackColor = true;
            this.ObliczButton.Click += new System.EventHandler(this.ObliczButton_Click);
            // 
            // Wykres
            // 
            chartArea1.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(313, 16);
            this.Wykres.MaximumSize = new System.Drawing.Size(600, 300);
            this.Wykres.MinimumSize = new System.Drawing.Size(600, 300);
            this.Wykres.Name = "Wykres";
            this.Wykres.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Wydatek";
            series1.ShadowColor = System.Drawing.Color.White;
            this.Wykres.Series.Add(series1);
            this.Wykres.Size = new System.Drawing.Size(600, 300);
            this.Wykres.TabIndex = 12;
            this.Wykres.Text = "Krzywa konsumcyjna (wydatku)";
            title1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            title1.Name = "Krzyw konsumcyjna (wydatku)";
            title1.Text = "Krzyw konsumcyjna (wydatku)";
            this.Wykres.Titles.Add(title1);
            this.Wykres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Wykres_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(577, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Q [m3/s]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Location = new System.Drawing.Point(300, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "H [m]";
            this.label8.Paint += new System.Windows.Forms.PaintEventHandler(this.label8_Paint);
            // 
            // GenerujButton
            // 
            this.GenerujButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerujButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.GenerujButton.FlatAppearance.BorderSize = 2;
            this.GenerujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.GenerujButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GenerujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerujButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerujButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerujButton.Location = new System.Drawing.Point(378, 407);
            this.GenerujButton.Name = "GenerujButton";
            this.GenerujButton.Size = new System.Drawing.Size(265, 39);
            this.GenerujButton.TabIndex = 15;
            this.GenerujButton.Text = "GENERUJ PLIK WYNIKOWY";
            this.GenerujButton.UseVisualStyleBackColor = true;
            this.GenerujButton.Click += new System.EventHandler(this.GenerujButton_Click);
            // 
            // PgValue
            // 
            this.PgValue.Location = new System.Drawing.Point(47, 406);
            this.PgValue.Name = "PgValue";
            this.PgValue.Size = new System.Drawing.Size(82, 20);
            this.PgValue.TabIndex = 16;
            // 
            // bValue
            // 
            this.bValue.Location = new System.Drawing.Point(47, 433);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(82, 20);
            this.bValue.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.MaximumSize = new System.Drawing.Size(260, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 45);
            this.label9.TabIndex = 18;
            this.label9.Text = "Niezatopiony prostokątny, czołowy, o ścianie pionowej i ostrej krawędzi. Brak dła" +
    "wienia bocznego.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(15, 299);
            this.label10.MaximumSize = new System.Drawing.Size(260, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 64);
            this.label10.TabIndex = 19;
            this.label10.Text = "Oznaczenia:                                          b - szerokość przelewu, gdzi" +
    "e b>0,15m  Pg - wysokość progu, gdzie Pg>0,10m  H - wys. warstwy wody przelewowe" +
    "j [m]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(709, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "H [m]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(712, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Q [m3/s]";
            // 
            // przelewModelBindingSource
            // 
            this.przelewModelBindingSource.DataSource = typeof(WydatekLibrary.PrzelewModel);
            // 
            // PrzelewViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 474);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.PgValue);
            this.Controls.Add(this.GenerujButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Wykres);
            this.Controls.Add(this.ObliczButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrzelewViewerForm";
            this.Text = "Przelew ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przelewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ObliczButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GenerujButton;
        private System.Windows.Forms.TextBox PgValue;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource przelewModelBindingSource;
    }
}