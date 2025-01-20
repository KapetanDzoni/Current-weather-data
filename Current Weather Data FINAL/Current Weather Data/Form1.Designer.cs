namespace Current_Weather_Data
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
            components = new System.ComponentModel.Container();
            labelDate = new Label();
            labelTime = new Label();
            labelTemp = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            labelDesc = new Label();
            labelWindSpeed = new Label();
            labelClouds = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            labelCity = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(311, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(131, 37);
            labelDate.TabIndex = 1;
            labelDate.Text = "labelDate";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(326, 46);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(133, 37);
            labelTime.TabIndex = 2;
            labelTime.Text = "labelTime";
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemp.Location = new Point(12, 61);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(139, 37);
            labelTemp.TabIndex = 4;
            labelTemp.Text = "labelTemp";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30000;
            timer2.Tick += timer2_Tick;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(20, 200);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(131, 37);
            labelDesc.TabIndex = 5;
            labelDesc.Text = "labelDesc";
            // 
            // labelWindSpeed
            // 
            labelWindSpeed.AutoSize = true;
            labelWindSpeed.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWindSpeed.Location = new Point(397, 200);
            labelWindSpeed.Name = "labelWindSpeed";
            labelWindSpeed.Size = new Size(212, 37);
            labelWindSpeed.TabIndex = 6;
            labelWindSpeed.Text = "labelWindSpeed";
            // 
            // labelClouds
            // 
            labelClouds.AutoSize = true;
            labelClouds.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClouds.Location = new Point(597, 200);
            labelClouds.Name = "labelClouds";
            labelClouds.Size = new Size(157, 37);
            labelClouds.TabIndex = 7;
            labelClouds.Text = "labelClouds";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(178, 392);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 9;
            button1.Text = "Show weather";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 348);
            label1.Name = "label1";
            label1.Size = new Size(410, 25);
            label1.TabIndex = 10;
            label1.Text = "Enter city name than , and 2 letter country code";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCity.Location = new Point(12, 9);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(121, 37);
            labelCity.TabIndex = 3;
            labelCity.Text = "labelCity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 163);
            label2.Name = "label2";
            label2.Size = new Size(149, 37);
            label2.TabIndex = 11;
            label2.Text = "description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 163);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 12;
            label3.Text = "wind speed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(541, 163);
            label4.Name = "label4";
            label4.Size = new Size(247, 37);
            label4.TabIndex = 13;
            label4.Text = "ammount of clouds";
            // 
            // button2
            // 
            button2.Location = new Point(681, 393);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 14;
            button2.Text = "Save and exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(labelClouds);
            Controls.Add(labelWindSpeed);
            Controls.Add(labelDesc);
            Controls.Add(labelTemp);
            Controls.Add(labelCity);
            Controls.Add(labelTime);
            Controls.Add(labelDate);
            Name = "Form1";
            Text = "Current weather data 3.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Label labelTime;
        private Label labelTemp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label labelDesc;
        private Label labelWindSpeed;
        private Label labelClouds;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label labelCity;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
