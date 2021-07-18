
namespace Weather_APi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textTemp = new System.Windows.Forms.TextBox();
            this.textTempFeelsLike = new System.Windows.Forms.TextBox();
            this.textHumidity = new System.Windows.Forms.TextBox();
            this.textPressure = new System.Windows.Forms.TextBox();
            this.textWindDirection = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMaxWindSpeed = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCloudy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSunrise = new System.Windows.Forms.TextBox();
            this.txtSunset = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "°C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wind kph";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pressure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Humidity";
            // 
            // textCity
            // 
            this.textCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textCity.Location = new System.Drawing.Point(66, 12);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(165, 27);
            this.textCity.TabIndex = 6;
            // 
            // textTemp
            // 
            this.textTemp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textTemp.Enabled = false;
            this.textTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTemp.Location = new System.Drawing.Point(25, 94);
            this.textTemp.Name = "textTemp";
            this.textTemp.Size = new System.Drawing.Size(54, 34);
            this.textTemp.TabIndex = 7;
            this.textTemp.Visible = false;
            // 
            // textTempFeelsLike
            // 
            this.textTempFeelsLike.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textTempFeelsLike.Enabled = false;
            this.textTempFeelsLike.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTempFeelsLike.Location = new System.Drawing.Point(25, 139);
            this.textTempFeelsLike.Name = "textTempFeelsLike";
            this.textTempFeelsLike.Size = new System.Drawing.Size(54, 34);
            this.textTempFeelsLike.TabIndex = 8;
            this.textTempFeelsLike.Visible = false;
            // 
            // textHumidity
            // 
            this.textHumidity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textHumidity.Enabled = false;
            this.textHumidity.Location = new System.Drawing.Point(207, 297);
            this.textHumidity.Name = "textHumidity";
            this.textHumidity.Size = new System.Drawing.Size(63, 27);
            this.textHumidity.TabIndex = 9;
            this.textHumidity.Visible = false;
            // 
            // textPressure
            // 
            this.textPressure.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textPressure.Enabled = false;
            this.textPressure.Location = new System.Drawing.Point(207, 260);
            this.textPressure.Name = "textPressure";
            this.textPressure.Size = new System.Drawing.Size(63, 27);
            this.textPressure.TabIndex = 10;
            this.textPressure.Visible = false;
            // 
            // textWindDirection
            // 
            this.textWindDirection.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textWindDirection.Enabled = false;
            this.textWindDirection.Location = new System.Drawing.Point(276, 214);
            this.textWindDirection.Name = "textWindDirection";
            this.textWindDirection.Size = new System.Drawing.Size(73, 27);
            this.textWindDirection.TabIndex = 11;
            this.textWindDirection.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(85, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "°C Feels like";
            // 
            // textMaxWindSpeed
            // 
            this.textMaxWindSpeed.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textMaxWindSpeed.Enabled = false;
            this.textMaxWindSpeed.Location = new System.Drawing.Point(207, 214);
            this.textMaxWindSpeed.Name = "textMaxWindSpeed";
            this.textMaxWindSpeed.Size = new System.Drawing.Size(63, 27);
            this.textMaxWindSpeed.TabIndex = 13;
            this.textMaxWindSpeed.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(247, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 85);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtCloudy
            // 
            this.txtCloudy.AutoSize = true;
            this.txtCloudy.Location = new System.Drawing.Point(247, 86);
            this.txtCloudy.Name = "txtCloudy";
            this.txtCloudy.Size = new System.Drawing.Size(55, 20);
            this.txtCloudy.TabIndex = 15;
            this.txtCloudy.Text = "Cloudy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "Show Forecast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(66, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(928, 138);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Visible = false;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCountry.Enabled = false;
            this.txtCountry.Location = new System.Drawing.Point(329, 16);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(256, 27);
            this.txtCountry.TabIndex = 18;
            this.txtCountry.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sunrise";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sunset";
            // 
            // txtSunrise
            // 
            this.txtSunrise.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSunrise.Enabled = false;
            this.txtSunrise.Location = new System.Drawing.Point(460, 51);
            this.txtSunrise.Name = "txtSunrise";
            this.txtSunrise.Size = new System.Drawing.Size(125, 27);
            this.txtSunrise.TabIndex = 23;
            this.txtSunrise.Visible = false;
            // 
            // txtSunset
            // 
            this.txtSunset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSunset.Enabled = false;
            this.txtSunset.Location = new System.Drawing.Point(676, 51);
            this.txtSunset.Name = "txtSunset";
            this.txtSunset.Size = new System.Drawing.Size(125, 27);
            this.txtSunset.TabIndex = 24;
            this.txtSunset.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 883);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Forecast for 3 days";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Country:";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 953);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSunset);
            this.Controls.Add(this.txtSunrise);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCloudy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textMaxWindSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textWindDirection);
            this.Controls.Add(this.textPressure);
            this.Controls.Add(this.textHumidity);
            this.Controls.Add(this.textTempFeelsLike);
            this.Controls.Add(this.textTemp);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather API";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textTemp;
        private System.Windows.Forms.TextBox textTempFeelsLike;
        private System.Windows.Forms.TextBox textHumidity;
        private System.Windows.Forms.TextBox textPressure;
        private System.Windows.Forms.TextBox textWindDirection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMaxWindSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCloudy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSunrise;
        private System.Windows.Forms.TextBox txtSunset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

