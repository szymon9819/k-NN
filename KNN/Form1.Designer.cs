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
            this.argument1 = new System.Windows.Forms.TextBox();
            this.argument2 = new System.Windows.Forms.TextBox();
            this.argument3 = new System.Windows.Forms.TextBox();
            this.argument4 = new System.Windows.Forms.TextBox();
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
            this.obliczBtn = new System.Windows.Forms.Button();
            this.wybierszPlikBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // argument1
            // 
            this.argument1.Location = new System.Drawing.Point(36, 366);
            this.argument1.Margin = new System.Windows.Forms.Padding(4);
            this.argument1.Name = "argument1";
            this.argument1.Size = new System.Drawing.Size(44, 22);
            this.argument1.TabIndex = 0;
            this.argument1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.argument1_KeyPress);
            // 
            // argument2
            // 
            this.argument2.Location = new System.Drawing.Point(89, 366);
            this.argument2.Margin = new System.Windows.Forms.Padding(4);
            this.argument2.Name = "argument2";
            this.argument2.Size = new System.Drawing.Size(44, 22);
            this.argument2.TabIndex = 1;
            this.argument2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.argument2_KeyPress);
            // 
            // argument3
            // 
            this.argument3.Location = new System.Drawing.Point(143, 366);
            this.argument3.Margin = new System.Windows.Forms.Padding(4);
            this.argument3.Name = "argument3";
            this.argument3.Size = new System.Drawing.Size(44, 22);
            this.argument3.TabIndex = 2;
            this.argument3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.argument3_KeyPress);
            // 
            // argument4
            // 
            this.argument4.Location = new System.Drawing.Point(196, 366);
            this.argument4.Margin = new System.Windows.Forms.Padding(4);
            this.argument4.Name = "argument4";
            this.argument4.Size = new System.Drawing.Size(44, 22);
            this.argument4.TabIndex = 3;
            this.argument4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.argument4_KeyPress);
            // 
            // wprowadzArgumentyBtn
            // 
            this.wprowadzArgumentyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wprowadzArgumentyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wprowadzArgumentyBtn.ForeColor = System.Drawing.Color.White;
            this.wprowadzArgumentyBtn.Location = new System.Drawing.Point(276, 358);
            this.wprowadzArgumentyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.wprowadzArgumentyBtn.Name = "wprowadzArgumentyBtn";
            this.wprowadzArgumentyBtn.Size = new System.Drawing.Size(140, 40);
            this.wprowadzArgumentyBtn.TabIndex = 4;
            this.wprowadzArgumentyBtn.Text = "Wprowadź";
            this.wprowadzArgumentyBtn.UseVisualStyleBackColor = false;
            this.wprowadzArgumentyBtn.Click += new System.EventHandler(this.wprowadzArgumentyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wprowadź dane probki";
            // 
            // sciezkaPliku
            // 
            this.sciezkaPliku.Location = new System.Drawing.Point(17, 32);
            this.sciezkaPliku.Margin = new System.Windows.Forms.Padding(4);
            this.sciezkaPliku.Name = "sciezkaPliku";
            this.sciezkaPliku.Size = new System.Drawing.Size(388, 22);
            this.sciezkaPliku.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Podaj sciezke do pliku ze sklasyfikowanymi próbkami";
            // 
            // wprowadzSciezkePlikuBtn
            // 
            this.wprowadzSciezkePlikuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wprowadzSciezkePlikuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wprowadzSciezkePlikuBtn.ForeColor = System.Drawing.Color.White;
            this.wprowadzSciezkePlikuBtn.Location = new System.Drawing.Point(601, 21);
            this.wprowadzSciezkePlikuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.wprowadzSciezkePlikuBtn.Name = "wprowadzSciezkePlikuBtn";
            this.wprowadzSciezkePlikuBtn.Size = new System.Drawing.Size(155, 42);
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
            this.klasyfikujBtn.Location = new System.Drawing.Point(276, 659);
            this.klasyfikujBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klasyfikujBtn.Name = "klasyfikujBtn";
            this.klasyfikujBtn.Size = new System.Drawing.Size(140, 40);
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
            this.klasyfikujLabel.Location = new System.Drawing.Point(439, 669);
            this.klasyfikujLabel.Name = "klasyfikujLabel";
            this.klasyfikujLabel.Size = new System.Drawing.Size(51, 20);
            this.klasyfikujLabel.TabIndex = 12;
            this.klasyfikujLabel.Text = "Klasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
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
            this.dataGridView1.Location = new System.Drawing.Point(17, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 209);
            this.dataGridView1.TabIndex = 14;
            // 
            // radioManhattan
            // 
            this.radioManhattan.AutoSize = true;
            this.radioManhattan.Checked = true;
            this.radioManhattan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioManhattan.ForeColor = System.Drawing.Color.White;
            this.radioManhattan.Location = new System.Drawing.Point(36, 454);
            this.radioManhattan.Margin = new System.Windows.Forms.Padding(4);
            this.radioManhattan.Name = "radioManhattan";
            this.radioManhattan.Size = new System.Drawing.Size(92, 20);
            this.radioManhattan.TabIndex = 15;
            this.radioManhattan.TabStop = true;
            this.radioManhattan.Text = "Manhhatan";
            this.radioManhattan.UseVisualStyleBackColor = true;
            // 
            // radioEuklidesowa
            // 
            this.radioEuklidesowa.AutoSize = true;
            this.radioEuklidesowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioEuklidesowa.ForeColor = System.Drawing.Color.White;
            this.radioEuklidesowa.Location = new System.Drawing.Point(36, 486);
            this.radioEuklidesowa.Margin = new System.Windows.Forms.Padding(4);
            this.radioEuklidesowa.Name = "radioEuklidesowa";
            this.radioEuklidesowa.Size = new System.Drawing.Size(103, 20);
            this.radioEuklidesowa.TabIndex = 16;
            this.radioEuklidesowa.Text = "Euklidesowa";
            this.radioEuklidesowa.UseVisualStyleBackColor = true;
            // 
            // radioCzebyszewa
            // 
            this.radioCzebyszewa.AutoSize = true;
            this.radioCzebyszewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioCzebyszewa.ForeColor = System.Drawing.Color.White;
            this.radioCzebyszewa.Location = new System.Drawing.Point(36, 518);
            this.radioCzebyszewa.Margin = new System.Windows.Forms.Padding(4);
            this.radioCzebyszewa.Name = "radioCzebyszewa";
            this.radioCzebyszewa.Size = new System.Drawing.Size(102, 20);
            this.radioCzebyszewa.TabIndex = 17;
            this.radioCzebyszewa.Text = "Czebyszewa";
            this.radioCzebyszewa.UseVisualStyleBackColor = true;
            // 
            // radioMinkowskiego
            // 
            this.radioMinkowskiego.AutoSize = true;
            this.radioMinkowskiego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioMinkowskiego.ForeColor = System.Drawing.Color.White;
            this.radioMinkowskiego.Location = new System.Drawing.Point(36, 550);
            this.radioMinkowskiego.Margin = new System.Windows.Forms.Padding(4);
            this.radioMinkowskiego.Name = "radioMinkowskiego";
            this.radioMinkowskiego.Size = new System.Drawing.Size(112, 20);
            this.radioMinkowskiego.TabIndex = 18;
            this.radioMinkowskiego.Text = "Minkowskiego";
            this.radioMinkowskiego.UseVisualStyleBackColor = true;
            // 
            // radioLogarytmem
            // 
            this.radioLogarytmem.AutoSize = true;
            this.radioLogarytmem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioLogarytmem.ForeColor = System.Drawing.Color.White;
            this.radioLogarytmem.Location = new System.Drawing.Point(36, 582);
            this.radioLogarytmem.Margin = new System.Windows.Forms.Padding(4);
            this.radioLogarytmem.Name = "radioLogarytmem";
            this.radioLogarytmem.Size = new System.Drawing.Size(101, 20);
            this.radioLogarytmem.TabIndex = 19;
            this.radioLogarytmem.Text = "Logarytmem";
            this.radioLogarytmem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Wybierz metryke";
            // 
            // obliczBtn
            // 
            this.obliczBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.obliczBtn.Enabled = false;
            this.obliczBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.obliczBtn.ForeColor = System.Drawing.Color.White;
            this.obliczBtn.Location = new System.Drawing.Point(205, 562);
            this.obliczBtn.Margin = new System.Windows.Forms.Padding(4);
            this.obliczBtn.Name = "obliczBtn";
            this.obliczBtn.Size = new System.Drawing.Size(178, 40);
            this.obliczBtn.TabIndex = 21;
            this.obliczBtn.Text = "Oblicz odległości";
            this.obliczBtn.UseVisualStyleBackColor = false;
            this.obliczBtn.Click += new System.EventHandler(this.obliczBtn_Click);
            // 
            // wybierszPlikBtn
            // 
            this.wybierszPlikBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.wybierszPlikBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.wybierszPlikBtn.ForeColor = System.Drawing.Color.White;
            this.wybierszPlikBtn.Location = new System.Drawing.Point(426, 21);
            this.wybierszPlikBtn.Margin = new System.Windows.Forms.Padding(0);
            this.wybierszPlikBtn.Name = "wybierszPlikBtn";
            this.wybierszPlikBtn.Size = new System.Drawing.Size(155, 42);
            this.wybierszPlikBtn.TabIndex = 22;
            this.wybierszPlikBtn.Text = "Wybierz Plik";
            this.wybierszPlikBtn.UseVisualStyleBackColor = false;
            this.wybierszPlikBtn.Click += new System.EventHandler(this.wybierszPlikBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 769);
            this.Controls.Add(this.wybierszPlikBtn);
            this.Controls.Add(this.obliczBtn);
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
            this.Controls.Add(this.argument4);
            this.Controls.Add(this.argument3);
            this.Controls.Add(this.argument2);
            this.Controls.Add(this.argument1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox argument1;
        private System.Windows.Forms.TextBox argument2;
        private System.Windows.Forms.TextBox argument3;
        private System.Windows.Forms.TextBox argument4;
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
        private System.Windows.Forms.Button obliczBtn;
        private System.Windows.Forms.Button wybierszPlikBtn;
    }
}

