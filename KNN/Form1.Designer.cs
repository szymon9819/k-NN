namespace KNN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.argument1 = new System.Windows.Forms.TextBox();
            this.wprowadzArgumentyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sciezkaPliku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wprowadzSciezkePlikuBtn = new System.Windows.Forms.Button();
            this.klasyfikujBtn = new System.Windows.Forms.Button();
            this.klasyfikujLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioManhattan = new System.Windows.Forms.RadioButton();
            this.radioEuklidesowa = new System.Windows.Forms.RadioButton();
            this.radioCzebyszewa = new System.Windows.Forms.RadioButton();
            this.radioMinkowskiego = new System.Windows.Forms.RadioButton();
            this.radioLogarytmem = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.wybierszPlikBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wprowadzParametrBtn = new System.Windows.Forms.Button();
            this.parametrMetrykiMinkowskiegoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.parametrMetrykiMinkowskiegoBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.wyczyscProbkeBtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.jedenVsResztaBtn = new System.Windows.Forms.Button();
            this.dokladnoscLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // argument1
            // 
            this.argument1.Location = new System.Drawing.Point(14, 254);
            this.argument1.Name = "argument1";
            this.argument1.Size = new System.Drawing.Size(61, 20);
            this.argument1.TabIndex = 0;
            this.argument1.Visible = false;
            this.argument1.TextChanged += new System.EventHandler(this.argument1_TextChanged);
            this.argument1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.argument1_KeyDown);
            this.argument1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.argument1_KeyPress);
            // 
            // wprowadzArgumentyBtn
            // 
            this.wprowadzArgumentyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wprowadzArgumentyBtn.Enabled = false;
            this.wprowadzArgumentyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wprowadzArgumentyBtn.ForeColor = System.Drawing.Color.White;
            this.wprowadzArgumentyBtn.Location = new System.Drawing.Point(81, 250);
            this.wprowadzArgumentyBtn.Name = "wprowadzArgumentyBtn";
            this.wprowadzArgumentyBtn.Size = new System.Drawing.Size(105, 32);
            this.wprowadzArgumentyBtn.TabIndex = 4;
            this.wprowadzArgumentyBtn.Text = "Wprowadź";
            this.wprowadzArgumentyBtn.UseVisualStyleBackColor = false;
            this.wprowadzArgumentyBtn.Visible = false;
            this.wprowadzArgumentyBtn.Click += new System.EventHandler(this.wprowadzArgumentyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wprowadź dane probki";
            this.label1.Visible = false;
            // 
            // sciezkaPliku
            // 
            this.sciezkaPliku.Location = new System.Drawing.Point(14, 48);
            this.sciezkaPliku.Name = "sciezkaPliku";
            this.sciezkaPliku.Size = new System.Drawing.Size(292, 20);
            this.sciezkaPliku.TabIndex = 6;
            this.sciezkaPliku.TextChanged += new System.EventHandler(this.sciezkaPliku_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Podaj sciezke do pliku ze sklasyfikowanymi próbkami.";
            // 
            // wprowadzSciezkePlikuBtn
            // 
            this.wprowadzSciezkePlikuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wprowadzSciezkePlikuBtn.Enabled = false;
            this.wprowadzSciezkePlikuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wprowadzSciezkePlikuBtn.ForeColor = System.Drawing.Color.White;
            this.wprowadzSciezkePlikuBtn.Location = new System.Drawing.Point(452, 39);
            this.wprowadzSciezkePlikuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.wprowadzSciezkePlikuBtn.Name = "wprowadzSciezkePlikuBtn";
            this.wprowadzSciezkePlikuBtn.Size = new System.Drawing.Size(116, 34);
            this.wprowadzSciezkePlikuBtn.TabIndex = 8;
            this.wprowadzSciezkePlikuBtn.TabStop = false;
            this.wprowadzSciezkePlikuBtn.Text = "Zatwierdź";
            this.wprowadzSciezkePlikuBtn.UseVisualStyleBackColor = false;
            this.wprowadzSciezkePlikuBtn.Click += new System.EventHandler(this.wprowadzSciezkePlikuBtn_Click);
            // 
            // klasyfikujBtn
            // 
            this.klasyfikujBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.klasyfikujBtn.Enabled = false;
            this.klasyfikujBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.klasyfikujBtn.ForeColor = System.Drawing.Color.White;
            this.klasyfikujBtn.Location = new System.Drawing.Point(927, 344);
            this.klasyfikujBtn.Margin = new System.Windows.Forms.Padding(2);
            this.klasyfikujBtn.Name = "klasyfikujBtn";
            this.klasyfikujBtn.Size = new System.Drawing.Size(105, 32);
            this.klasyfikujBtn.TabIndex = 11;
            this.klasyfikujBtn.Text = "Klasyfikuj";
            this.klasyfikujBtn.UseVisualStyleBackColor = false;
            this.klasyfikujBtn.Click += new System.EventHandler(this.klasyfikujBtn_Click);
            // 
            // klasyfikujLabel
            // 
            this.klasyfikujLabel.AutoSize = true;
            this.klasyfikujLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.klasyfikujLabel.ForeColor = System.Drawing.Color.White;
            this.klasyfikujLabel.Location = new System.Drawing.Point(1051, 353);
            this.klasyfikujLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.klasyfikujLabel.Name = "klasyfikujLabel";
            this.klasyfikujLabel.Size = new System.Drawing.Size(66, 25);
            this.klasyfikujLabel.TabIndex = 12;
            this.klasyfikujLabel.Text = "Klasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(663, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wprowadzone próbki";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(667, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 170);
            this.dataGridView1.TabIndex = 14;
            // 
            // radioManhattan
            // 
            this.radioManhattan.AutoSize = true;
            this.radioManhattan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioManhattan.ForeColor = System.Drawing.Color.White;
            this.radioManhattan.Location = new System.Drawing.Point(679, 326);
            this.radioManhattan.Name = "radioManhattan";
            this.radioManhattan.Size = new System.Drawing.Size(111, 24);
            this.radioManhattan.TabIndex = 15;
            this.radioManhattan.Text = "Manhhatan";
            this.radioManhattan.UseVisualStyleBackColor = true;
            // 
            // radioEuklidesowa
            // 
            this.radioEuklidesowa.AutoSize = true;
            this.radioEuklidesowa.Checked = true;
            this.radioEuklidesowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioEuklidesowa.ForeColor = System.Drawing.Color.White;
            this.radioEuklidesowa.Location = new System.Drawing.Point(679, 274);
            this.radioEuklidesowa.Name = "radioEuklidesowa";
            this.radioEuklidesowa.Size = new System.Drawing.Size(119, 24);
            this.radioEuklidesowa.TabIndex = 16;
            this.radioEuklidesowa.TabStop = true;
            this.radioEuklidesowa.Text = "Euklidesowa";
            this.radioEuklidesowa.UseVisualStyleBackColor = true;
            // 
            // radioCzebyszewa
            // 
            this.radioCzebyszewa.AutoSize = true;
            this.radioCzebyszewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioCzebyszewa.ForeColor = System.Drawing.Color.White;
            this.radioCzebyszewa.Location = new System.Drawing.Point(679, 300);
            this.radioCzebyszewa.Name = "radioCzebyszewa";
            this.radioCzebyszewa.Size = new System.Drawing.Size(119, 24);
            this.radioCzebyszewa.TabIndex = 17;
            this.radioCzebyszewa.Text = "Czebyszewa";
            this.radioCzebyszewa.UseVisualStyleBackColor = true;
            // 
            // radioMinkowskiego
            // 
            this.radioMinkowskiego.AutoSize = true;
            this.radioMinkowskiego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioMinkowskiego.ForeColor = System.Drawing.Color.White;
            this.radioMinkowskiego.Location = new System.Drawing.Point(679, 248);
            this.radioMinkowskiego.Name = "radioMinkowskiego";
            this.radioMinkowskiego.Size = new System.Drawing.Size(129, 24);
            this.radioMinkowskiego.TabIndex = 18;
            this.radioMinkowskiego.Text = "Minkowskiego";
            this.radioMinkowskiego.UseVisualStyleBackColor = true;
            this.radioMinkowskiego.CheckedChanged += new System.EventHandler(this.radioMinkowskiego_CheckedChanged);
            // 
            // radioLogarytmem
            // 
            this.radioLogarytmem.AutoSize = true;
            this.radioLogarytmem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioLogarytmem.ForeColor = System.Drawing.Color.White;
            this.radioLogarytmem.Location = new System.Drawing.Point(679, 352);
            this.radioLogarytmem.Name = "radioLogarytmem";
            this.radioLogarytmem.Size = new System.Drawing.Size(118, 24);
            this.radioLogarytmem.TabIndex = 19;
            this.radioLogarytmem.Text = "Logarytmem";
            this.radioLogarytmem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(664, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Wybierz metryke";
            // 
            // wybierszPlikBtn
            // 
            this.wybierszPlikBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wybierszPlikBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wybierszPlikBtn.ForeColor = System.Drawing.Color.White;
            this.wybierszPlikBtn.Location = new System.Drawing.Point(321, 39);
            this.wybierszPlikBtn.Margin = new System.Windows.Forms.Padding(0);
            this.wybierszPlikBtn.Name = "wybierszPlikBtn";
            this.wybierszPlikBtn.Size = new System.Drawing.Size(116, 34);
            this.wybierszPlikBtn.TabIndex = 22;
            this.wybierszPlikBtn.Text = "Wybierz Plik";
            this.wybierszPlikBtn.UseVisualStyleBackColor = false;
            this.wybierszPlikBtn.Click += new System.EventHandler(this.wybierszPlikBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(14, 72);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 19);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Czy normalizować probki";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Parametr";
            // 
            // wprowadzParametrBtn
            // 
            this.wprowadzParametrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wprowadzParametrBtn.Enabled = false;
            this.wprowadzParametrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wprowadzParametrBtn.ForeColor = System.Drawing.Color.White;
            this.wprowadzParametrBtn.Location = new System.Drawing.Point(95, 107);
            this.wprowadzParametrBtn.Name = "wprowadzParametrBtn";
            this.wprowadzParametrBtn.Size = new System.Drawing.Size(105, 32);
            this.wprowadzParametrBtn.TabIndex = 26;
            this.wprowadzParametrBtn.Text = "Wprowadź";
            this.wprowadzParametrBtn.UseVisualStyleBackColor = false;
            this.wprowadzParametrBtn.Click += new System.EventHandler(this.wprowadzParametrBtn_Click);
            // 
            // parametrMetrykiMinkowskiegoTextBox
            // 
            this.parametrMetrykiMinkowskiegoTextBox.Location = new System.Drawing.Point(824, 266);
            this.parametrMetrykiMinkowskiegoTextBox.Name = "parametrMetrykiMinkowskiegoTextBox";
            this.parametrMetrykiMinkowskiegoTextBox.Size = new System.Drawing.Size(63, 20);
            this.parametrMetrykiMinkowskiegoTextBox.TabIndex = 27;
            this.parametrMetrykiMinkowskiegoTextBox.Visible = false;
            this.parametrMetrykiMinkowskiegoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parametrMetrykiMinkowskiegoTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(821, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Parametr metryki Minkowskeigo";
            this.label6.Visible = false;
            // 
            // parametrMetrykiMinkowskiegoBtn
            // 
            this.parametrMetrykiMinkowskiegoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.parametrMetrykiMinkowskiegoBtn.Enabled = false;
            this.parametrMetrykiMinkowskiegoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.parametrMetrykiMinkowskiegoBtn.ForeColor = System.Drawing.Color.White;
            this.parametrMetrykiMinkowskiegoBtn.Location = new System.Drawing.Point(918, 260);
            this.parametrMetrykiMinkowskiegoBtn.Name = "parametrMetrykiMinkowskiegoBtn";
            this.parametrMetrykiMinkowskiegoBtn.Size = new System.Drawing.Size(105, 32);
            this.parametrMetrykiMinkowskiegoBtn.TabIndex = 29;
            this.parametrMetrykiMinkowskiegoBtn.Text = "Wprowadź";
            this.parametrMetrykiMinkowskiegoBtn.UseVisualStyleBackColor = false;
            this.parametrMetrykiMinkowskiegoBtn.Visible = false;
            this.parametrMetrykiMinkowskiegoBtn.Click += new System.EventHandler(this.parametrMetrykiMinkowskiegoBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(11, 296);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(554, 69);
            this.dataGridView2.TabIndex = 30;
            // 
            // wyczyscProbkeBtn
            // 
            this.wyczyscProbkeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wyczyscProbkeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wyczyscProbkeBtn.ForeColor = System.Drawing.Color.White;
            this.wyczyscProbkeBtn.Location = new System.Drawing.Point(198, 250);
            this.wyczyscProbkeBtn.Name = "wyczyscProbkeBtn";
            this.wyczyscProbkeBtn.Size = new System.Drawing.Size(142, 32);
            this.wyczyscProbkeBtn.TabIndex = 31;
            this.wyczyscProbkeBtn.Text = "Wyczyść próbke";
            this.wyczyscProbkeBtn.UseVisualStyleBackColor = false;
            this.wyczyscProbkeBtn.Visible = false;
            this.wyczyscProbkeBtn.Click += new System.EventHandler(this.wyczyscProbkeBtn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(17, 568);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(658, 170);
            this.dataGridView3.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "1 vs reszta";
            this.label7.Visible = false;
            // 
            // jedenVsResztaBtn
            // 
            this.jedenVsResztaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.jedenVsResztaBtn.Enabled = false;
            this.jedenVsResztaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.jedenVsResztaBtn.ForeColor = System.Drawing.Color.White;
            this.jedenVsResztaBtn.Location = new System.Drawing.Point(722, 611);
            this.jedenVsResztaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.jedenVsResztaBtn.Name = "jedenVsResztaBtn";
            this.jedenVsResztaBtn.Size = new System.Drawing.Size(180, 55);
            this.jedenVsResztaBtn.TabIndex = 34;
            this.jedenVsResztaBtn.Text = "1 vs Reszta";
            this.jedenVsResztaBtn.UseVisualStyleBackColor = false;
            this.jedenVsResztaBtn.Click += new System.EventHandler(this.jedenVsResztaBtn_Click);
            // 
            // dokladnoscLabel
            // 
            this.dokladnoscLabel.AutoSize = true;
            this.dokladnoscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dokladnoscLabel.ForeColor = System.Drawing.Color.White;
            this.dokladnoscLabel.Location = new System.Drawing.Point(717, 678);
            this.dokladnoscLabel.Name = "dokladnoscLabel";
            this.dokladnoscLabel.Size = new System.Drawing.Size(295, 31);
            this.dokladnoscLabel.TabIndex = 35;
            this.dokladnoscLabel.Text = "Dokładność 1 vs reszta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1241, 756);
            this.Controls.Add(this.dokladnoscLabel);
            this.Controls.Add(this.jedenVsResztaBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.wyczyscProbkeBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.parametrMetrykiMinkowskiegoBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parametrMetrykiMinkowskiegoTextBox);
            this.Controls.Add(this.wprowadzParametrBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.wybierszPlikBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioLogarytmem);
            this.Controls.Add(this.radioMinkowskiego);
            this.Controls.Add(this.radioCzebyszewa);
            this.Controls.Add(this.radioEuklidesowa);
            this.Controls.Add(this.radioManhattan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.klasyfikujLabel);
            this.Controls.Add(this.klasyfikujBtn);
            this.Controls.Add(this.wprowadzSciezkePlikuBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sciezkaPliku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wprowadzArgumentyBtn);
            this.Controls.Add(this.argument1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox argument1;
        private System.Windows.Forms.Button wprowadzArgumentyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sciezkaPliku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wprowadzSciezkePlikuBtn;
        private System.Windows.Forms.Button klasyfikujBtn;
        private System.Windows.Forms.Label klasyfikujLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioManhattan;
        private System.Windows.Forms.RadioButton radioEuklidesowa;
        private System.Windows.Forms.RadioButton radioCzebyszewa;
        private System.Windows.Forms.RadioButton radioMinkowskiego;
        private System.Windows.Forms.RadioButton radioLogarytmem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wybierszPlikBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button wprowadzParametrBtn;
        private System.Windows.Forms.TextBox parametrMetrykiMinkowskiegoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button parametrMetrykiMinkowskiegoBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button wyczyscProbkeBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button jedenVsResztaBtn;
        private System.Windows.Forms.Label dokladnoscLabel;
    }
}

