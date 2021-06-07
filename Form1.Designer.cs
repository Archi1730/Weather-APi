
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textTemp = new System.Windows.Forms.TextBox();
            this.textTempFeelsLike = new System.Windows.Forms.TextBox();
            this.textHumidity = new System.Windows.Forms.TextBox();
            this.textPressure = new System.Windows.Forms.TextBox();
            this.textMinWindSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMaxWindSpeed = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCloudy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChanceOfRain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura [°C]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prędkość wiatru [km/h]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kierunek wiatru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciśnienie [hPa]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wilgotność [%]";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(239, 9);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(165, 27);
            this.textCity.TabIndex = 6;
            // 
            // textTemp
            // 
            this.textTemp.Location = new System.Drawing.Point(239, 94);
            this.textTemp.Name = "textTemp";
            this.textTemp.Size = new System.Drawing.Size(165, 27);
            this.textTemp.TabIndex = 7;
            // 
            // textTempFeelsLike
            // 
            this.textTempFeelsLike.Location = new System.Drawing.Point(239, 136);
            this.textTempFeelsLike.Name = "textTempFeelsLike";
            this.textTempFeelsLike.Size = new System.Drawing.Size(165, 27);
            this.textTempFeelsLike.TabIndex = 8;
            // 
            // textHumidity
            // 
            this.textHumidity.Location = new System.Drawing.Point(239, 295);
            this.textHumidity.Name = "textHumidity";
            this.textHumidity.Size = new System.Drawing.Size(165, 27);
            this.textHumidity.TabIndex = 9;
            // 
            // textPressure
            // 
            this.textPressure.Location = new System.Drawing.Point(239, 258);
            this.textPressure.Name = "textPressure";
            this.textPressure.Size = new System.Drawing.Size(165, 27);
            this.textPressure.TabIndex = 10;
            // 
            // textMinWindSpeed
            // 
            this.textMinWindSpeed.Location = new System.Drawing.Point(239, 218);
            this.textMinWindSpeed.Name = "textMinWindSpeed";
            this.textMinWindSpeed.Size = new System.Drawing.Size(165, 27);
            this.textMinWindSpeed.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Temperatura odczuwalna [°C]";
            // 
            // textMaxWindSpeed
            // 
            this.textMaxWindSpeed.Location = new System.Drawing.Point(239, 177);
            this.textMaxWindSpeed.Name = "textMaxWindSpeed";
            this.textMaxWindSpeed.Size = new System.Drawing.Size(165, 27);
            this.textMaxWindSpeed.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(561, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 142);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtCloudy
            // 
            this.txtCloudy.AutoSize = true;
            this.txtCloudy.Location = new System.Drawing.Point(561, 60);
            this.txtCloudy.Name = "txtCloudy";
            this.txtCloudy.Size = new System.Drawing.Size(102, 20);
            this.txtCloudy.TabIndex = 15;
            this.txtCloudy.Text = "Zachmurzenie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pokaż obecną pogodę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(25, 42);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(256, 27);
            this.txtCountry.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Szansa na opady [%]\r\n";
            // 
            // txtChanceOfRain
            // 
            this.txtChanceOfRain.Location = new System.Drawing.Point(239, 342);
            this.txtChanceOfRain.Name = "txtChanceOfRain";
            this.txtChanceOfRain.Size = new System.Drawing.Size(165, 27);
            this.txtChanceOfRain.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 717);
            this.Controls.Add(this.txtChanceOfRain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCloudy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textMaxWindSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMinWindSpeed);
            this.Controls.Add(this.textPressure);
            this.Controls.Add(this.textHumidity);
            this.Controls.Add(this.textTempFeelsLike);
            this.Controls.Add(this.textTemp);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prognoza Pogody";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textTemp;
        private System.Windows.Forms.TextBox textTempFeelsLike;
        private System.Windows.Forms.TextBox textHumidity;
        private System.Windows.Forms.TextBox textPressure;
        private System.Windows.Forms.TextBox textMinWindSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMaxWindSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCloudy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChanceOfRain;
    }
}

