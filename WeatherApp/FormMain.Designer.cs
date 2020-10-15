namespace WeatherApp
{
    partial class FormMain
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonFindPlace = new System.Windows.Forms.Button();
            this.buttonLocationDetails = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelInstractions = new System.Windows.Forms.Label();
            this.buttonCheckWeather = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, -4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buttonFindPlace);
            this.splitContainer.Panel1.Controls.Add(this.buttonLocationDetails);
            this.splitContainer.Panel1.Controls.Add(this.textBox1);
            this.splitContainer.Panel1.Controls.Add(this.labelInstractions);
            this.splitContainer.Panel1.Controls.Add(this.buttonCheckWeather);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gMap);
            this.splitContainer.Size = new System.Drawing.Size(1059, 517);
            this.splitContainer.SplitterDistance = 358;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonFindPlace
            // 
            this.buttonFindPlace.Location = new System.Drawing.Point(12, 186);
            this.buttonFindPlace.Name = "buttonFindPlace";
            this.buttonFindPlace.Size = new System.Drawing.Size(143, 30);
            this.buttonFindPlace.TabIndex = 4;
            this.buttonFindPlace.Text = "Find This Place";
            this.buttonFindPlace.UseVisualStyleBackColor = true;
            // 
            // buttonLocationDetails
            // 
            this.buttonLocationDetails.Location = new System.Drawing.Point(12, 131);
            this.buttonLocationDetails.Name = "buttonLocationDetails";
            this.buttonLocationDetails.Size = new System.Drawing.Size(143, 30);
            this.buttonLocationDetails.TabIndex = 3;
            this.buttonLocationDetails.Text = "Location Info";
            this.buttonLocationDetails.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 2;
            // 
            // labelInstractions
            // 
            this.labelInstractions.AutoSize = true;
            this.labelInstractions.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstractions.Location = new System.Drawing.Point(3, 13);
            this.labelInstractions.Name = "labelInstractions";
            this.labelInstractions.Size = new System.Drawing.Size(336, 25);
            this.labelInstractions.TabIndex = 1;
            this.labelInstractions.Text = "Please Choose Location On The Map";
            // 
            // buttonCheckWeather
            // 
            this.buttonCheckWeather.Location = new System.Drawing.Point(12, 77);
            this.buttonCheckWeather.Name = "buttonCheckWeather";
            this.buttonCheckWeather.Size = new System.Drawing.Size(169, 30);
            this.buttonCheckWeather.TabIndex = 0;
            this.buttonCheckWeather.Text = "Check The Weather";
            this.buttonCheckWeather.UseVisualStyleBackColor = true;
            this.buttonCheckWeather.Click += new System.EventHandler(this.buttonCheckWeather_Click);
            // 
            // gMap
            // 
            this.gMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(9, 3);
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
            this.gMap.Size = new System.Drawing.Size(694, 514);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1060, 512);
            this.Controls.Add(this.splitContainer);
            this.Name = "FormMain";
            this.Text = "Check Weather";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelInstractions;
        private System.Windows.Forms.Button buttonCheckWeather;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Button buttonLocationDetails;
        private System.Windows.Forms.Button buttonFindPlace;
    }
}

