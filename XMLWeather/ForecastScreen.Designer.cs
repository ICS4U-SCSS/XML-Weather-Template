namespace XMLWeather
{
    partial class ForecastScreen
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
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.day1Outlook = new System.Windows.Forms.Label();
            this.windSpeedOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windOutput = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(213, 21);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(124, 43);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 43);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(148, 138);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 20);
            this.dateLabel.TabIndex = 60;
            this.dateLabel.Text = "label3";
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(24, 138);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(106, 35);
            this.cityOutput.TabIndex = 43;
            this.cityOutput.Text = "City";
            // 
            // day1Outlook
            // 
            this.day1Outlook.BackColor = System.Drawing.Color.White;
            this.day1Outlook.Location = new System.Drawing.Point(259, 333);
            this.day1Outlook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day1Outlook.Name = "day1Outlook";
            this.day1Outlook.Size = new System.Drawing.Size(33, 20);
            this.day1Outlook.TabIndex = 58;
            // 
            // windSpeedOutput
            // 
            this.windSpeedOutput.BackColor = System.Drawing.Color.White;
            this.windSpeedOutput.Location = new System.Drawing.Point(168, 285);
            this.windSpeedOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windSpeedOutput.Name = "windSpeedOutput";
            this.windSpeedOutput.Size = new System.Drawing.Size(170, 20);
            this.windSpeedOutput.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Wind Speed";
            // 
            // windOutput
            // 
            this.windOutput.BackColor = System.Drawing.Color.White;
            this.windOutput.Location = new System.Drawing.Point(168, 250);
            this.windOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windOutput.Name = "windOutput";
            this.windOutput.Size = new System.Drawing.Size(170, 20);
            this.windOutput.TabIndex = 51;
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(24, 250);
            this.windLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(45, 20);
            this.windLabel.TabIndex = 50;
            this.windLabel.Text = "Wind";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(188, 216);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(33, 20);
            this.currentOutput.TabIndex = 49;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(168, 378);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(33, 20);
            this.minOutput.TabIndex = 48;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(24, 378);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(133, 20);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = " Min Temperature";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(168, 333);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(33, 20);
            this.maxOutput.TabIndex = 45;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(24, 333);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(133, 20);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max Temperature";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 41);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.day1Outlook);
            this.Controls.Add(this.windSpeedOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.windOutput);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(375, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label day1Outlook;
        private System.Windows.Forms.Label windSpeedOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label windOutput;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label5;
    }
}
