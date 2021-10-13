
namespace LinQMethods
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExample3 = new System.Windows.Forms.Button();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.btnExample2 = new System.Windows.Forms.Button();
            this.btnExample8 = new System.Windows.Forms.Button();
            this.btnExample4 = new System.Windows.Forms.Button();
            this.btnExample5 = new System.Windows.Forms.Button();
            this.btnExample6 = new System.Windows.Forms.Button();
            this.btnExample7 = new System.Windows.Forms.Button();
            this.btn_Example17 = new System.Windows.Forms.Button();
            this.btnExample9 = new System.Windows.Forms.Button();
            this.btnExample10 = new System.Windows.Forms.Button();
            this.btnExample11 = new System.Windows.Forms.Button();
            this.btnExample12 = new System.Windows.Forms.Button();
            this.btnExample13 = new System.Windows.Forms.Button();
            this.btnExample14 = new System.Windows.Forms.Button();
            this.btnExample15 = new System.Windows.Forms.Button();
            this.btnExample16 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExample3
            // 
            this.btnExample3.Location = new System.Drawing.Point(174, 177);
            this.btnExample3.Name = "btnExample3";
            this.btnExample3.Size = new System.Drawing.Size(75, 23);
            this.btnExample3.TabIndex = 1;
            this.btnExample3.Text = "Select";
            this.btnExample3.UseVisualStyleBackColor = true;
            this.btnExample3.Click += new System.EventHandler(this.btnExample3_Click);
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(12, 177);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(75, 23);
            this.btnExample1.TabIndex = 1;
            this.btnExample1.Text = "To List";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(93, 177);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(75, 23);
            this.btnExample2.TabIndex = 1;
            this.btnExample2.Text = "Where";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // btnExample8
            // 
            this.btnExample8.Location = new System.Drawing.Point(93, 206);
            this.btnExample8.Name = "btnExample8";
            this.btnExample8.Size = new System.Drawing.Size(75, 23);
            this.btnExample8.TabIndex = 2;
            this.btnExample8.Text = "Take";
            this.btnExample8.UseVisualStyleBackColor = true;
            this.btnExample8.Click += new System.EventHandler(this.btnExample8_Click);
            // 
            // btnExample4
            // 
            this.btnExample4.Location = new System.Drawing.Point(255, 177);
            this.btnExample4.Name = "btnExample4";
            this.btnExample4.Size = new System.Drawing.Size(75, 23);
            this.btnExample4.TabIndex = 2;
            this.btnExample4.Text = "Order By";
            this.btnExample4.UseVisualStyleBackColor = true;
            this.btnExample4.Click += new System.EventHandler(this.btnExample4_Click);
            // 
            // btnExample5
            // 
            this.btnExample5.Location = new System.Drawing.Point(336, 177);
            this.btnExample5.Name = "btnExample5";
            this.btnExample5.Size = new System.Drawing.Size(75, 23);
            this.btnExample5.TabIndex = 2;
            this.btnExample5.Text = "First";
            this.btnExample5.UseVisualStyleBackColor = true;
            this.btnExample5.Click += new System.EventHandler(this.btnExample5_Click);
            // 
            // btnExample6
            // 
            this.btnExample6.Location = new System.Drawing.Point(417, 177);
            this.btnExample6.Name = "btnExample6";
            this.btnExample6.Size = new System.Drawing.Size(85, 23);
            this.btnExample6.TabIndex = 2;
            this.btnExample6.Text = "FirstOrDefault";
            this.btnExample6.UseVisualStyleBackColor = true;
            this.btnExample6.Click += new System.EventHandler(this.btnExample6_Click);
            // 
            // btnExample7
            // 
            this.btnExample7.Location = new System.Drawing.Point(12, 206);
            this.btnExample7.Name = "btnExample7";
            this.btnExample7.Size = new System.Drawing.Size(75, 23);
            this.btnExample7.TabIndex = 2;
            this.btnExample7.Text = "Find";
            this.btnExample7.UseVisualStyleBackColor = true;
            this.btnExample7.Click += new System.EventHandler(this.btnExample7_Click);
            // 
            // btn_Example17
            // 
            this.btn_Example17.Location = new System.Drawing.Point(336, 235);
            this.btn_Example17.Name = "btn_Example17";
            this.btn_Example17.Size = new System.Drawing.Size(75, 23);
            this.btn_Example17.TabIndex = 3;
            this.btn_Example17.Text = "GroupBy";
            this.btn_Example17.UseVisualStyleBackColor = true;
            this.btn_Example17.Click += new System.EventHandler(this.btn_Example17_Click);
            // 
            // btnExample9
            // 
            this.btnExample9.Location = new System.Drawing.Point(174, 206);
            this.btnExample9.Name = "btnExample9";
            this.btnExample9.Size = new System.Drawing.Size(75, 23);
            this.btnExample9.TabIndex = 3;
            this.btnExample9.Text = "Skip";
            this.btnExample9.UseVisualStyleBackColor = true;
            this.btnExample9.Click += new System.EventHandler(this.btnExample9_Click);
            // 
            // btnExample10
            // 
            this.btnExample10.Location = new System.Drawing.Point(255, 206);
            this.btnExample10.Name = "btnExample10";
            this.btnExample10.Size = new System.Drawing.Size(75, 23);
            this.btnExample10.TabIndex = 3;
            this.btnExample10.Text = "Contains";
            this.btnExample10.UseVisualStyleBackColor = true;
            this.btnExample10.Click += new System.EventHandler(this.btnExample10_Click);
            // 
            // btnExample11
            // 
            this.btnExample11.Location = new System.Drawing.Point(336, 206);
            this.btnExample11.Name = "btnExample11";
            this.btnExample11.Size = new System.Drawing.Size(83, 23);
            this.btnExample11.TabIndex = 3;
            this.btnExample11.Text = "StartWithEndWith";
            this.btnExample11.UseVisualStyleBackColor = true;
            this.btnExample11.Click += new System.EventHandler(this.btnExample11_Click);
            // 
            // btnExample12
            // 
            this.btnExample12.Location = new System.Drawing.Point(425, 206);
            this.btnExample12.Name = "btnExample12";
            this.btnExample12.Size = new System.Drawing.Size(75, 23);
            this.btnExample12.TabIndex = 3;
            this.btnExample12.Text = "Any";
            this.btnExample12.UseVisualStyleBackColor = true;
            this.btnExample12.Click += new System.EventHandler(this.btnExample12_Click);
            // 
            // btnExample13
            // 
            this.btnExample13.Location = new System.Drawing.Point(12, 235);
            this.btnExample13.Name = "btnExample13";
            this.btnExample13.Size = new System.Drawing.Size(75, 23);
            this.btnExample13.TabIndex = 3;
            this.btnExample13.Text = "Count";
            this.btnExample13.UseVisualStyleBackColor = true;
            this.btnExample13.Click += new System.EventHandler(this.btnExample13_Click);
            // 
            // btnExample14
            // 
            this.btnExample14.Location = new System.Drawing.Point(93, 235);
            this.btnExample14.Name = "btnExample14";
            this.btnExample14.Size = new System.Drawing.Size(75, 23);
            this.btnExample14.TabIndex = 3;
            this.btnExample14.Text = "Sum";
            this.btnExample14.UseVisualStyleBackColor = true;
            this.btnExample14.Click += new System.EventHandler(this.btnExample14_Click);
            // 
            // btnExample15
            // 
            this.btnExample15.Location = new System.Drawing.Point(174, 235);
            this.btnExample15.Name = "btnExample15";
            this.btnExample15.Size = new System.Drawing.Size(75, 23);
            this.btnExample15.TabIndex = 3;
            this.btnExample15.Text = "Min-Max";
            this.btnExample15.UseVisualStyleBackColor = true;
            this.btnExample15.Click += new System.EventHandler(this.btnExample15_Click);
            // 
            // btnExample16
            // 
            this.btnExample16.Location = new System.Drawing.Point(255, 235);
            this.btnExample16.Name = "btnExample16";
            this.btnExample16.Size = new System.Drawing.Size(75, 23);
            this.btnExample16.TabIndex = 3;
            this.btnExample16.Text = "Distinct";
            this.btnExample16.UseVisualStyleBackColor = true;
            this.btnExample16.Click += new System.EventHandler(this.btnExample16_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 82);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExample9);
            this.Controls.Add(this.btnExample10);
            this.Controls.Add(this.btnExample11);
            this.Controls.Add(this.btnExample12);
            this.Controls.Add(this.btnExample13);
            this.Controls.Add(this.btnExample14);
            this.Controls.Add(this.btnExample15);
            this.Controls.Add(this.btnExample16);
            this.Controls.Add(this.btn_Example17);
            this.Controls.Add(this.btnExample4);
            this.Controls.Add(this.btnExample5);
            this.Controls.Add(this.btnExample6);
            this.Controls.Add(this.btnExample7);
            this.Controls.Add(this.btnExample8);
            this.Controls.Add(this.btnExample1);
            this.Controls.Add(this.btnExample2);
            this.Controls.Add(this.btnExample3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExample3;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.Button btnExample8;
        private System.Windows.Forms.Button btnExample4;
        private System.Windows.Forms.Button btnExample5;
        private System.Windows.Forms.Button btnExample6;
        private System.Windows.Forms.Button btnExample7;
        private System.Windows.Forms.Button btn_Example17;
        private System.Windows.Forms.Button btnExample9;
        private System.Windows.Forms.Button btnExample10;
        private System.Windows.Forms.Button btnExample11;
        private System.Windows.Forms.Button btnExample12;
        private System.Windows.Forms.Button btnExample13;
        private System.Windows.Forms.Button btnExample14;
        private System.Windows.Forms.Button btnExample15;
        private System.Windows.Forms.Button btnExample16;
        private System.Windows.Forms.ListBox listBox1;
    }
}

