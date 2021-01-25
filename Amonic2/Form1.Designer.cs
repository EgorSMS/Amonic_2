namespace Amonic2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fromlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tolabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.flnumberBox = new System.Windows.Forms.TextBox();
            this.sortBy = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.fromBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fromlabel
            // 
            this.fromlabel.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromlabel.Location = new System.Drawing.Point(12, 51);
            this.fromlabel.Name = "fromlabel";
            this.fromlabel.Size = new System.Drawing.Size(93, 33);
            this.fromlabel.TabIndex = 0;
            this.fromlabel.Text = "From";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "OutBound";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(356, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flight number";
            // 
            // tolabel
            // 
            this.tolabel.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tolabel.Location = new System.Drawing.Point(356, 51);
            this.tolabel.Name = "tolabel";
            this.tolabel.Size = new System.Drawing.Size(93, 37);
            this.tolabel.TabIndex = 3;
            this.tolabel.Text = "To";
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(619, 51);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 33);
            this.label.TabIndex = 4;
            this.label.Text = "Sort by";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(131, 136);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(123, 22);
            this.dateBox.TabIndex = 6;
            // 
            // flnumberBox
            // 
            this.flnumberBox.Location = new System.Drawing.Point(518, 136);
            this.flnumberBox.Name = "flnumberBox";
            this.flnumberBox.Size = new System.Drawing.Size(123, 22);
            this.flnumberBox.TabIndex = 8;
            // 
            // sortBy
            // 
            this.sortBy.FormattingEnabled = true;
            this.sortBy.Location = new System.Drawing.Point(718, 56);
            this.sortBy.Name = "sortBy";
            this.sortBy.Size = new System.Drawing.Size(142, 24);
            this.sortBy.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(760, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(907, 243);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(17, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel Flight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(390, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Edit Flight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(718, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "Import Changes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toBox
            // 
            this.toBox.FormattingEnabled = true;
            this.toBox.Location = new System.Drawing.Point(409, 56);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(142, 24);
            this.toBox.TabIndex = 7;
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Location = new System.Drawing.Point(113, 59);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(142, 24);
            this.fromBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 606);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortBy);
            this.Controls.Add(this.flnumberBox);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tolabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tolabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox flnumberBox;
        private System.Windows.Forms.ComboBox sortBy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.ComboBox fromBox;
    }
}

