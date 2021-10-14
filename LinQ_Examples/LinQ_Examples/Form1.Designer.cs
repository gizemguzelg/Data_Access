
namespace LinQ_Examples
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
            this.btnExample1 = new System.Windows.Forms.Button();
            this.btnExample2 = new System.Windows.Forms.Button();
            this.btnExample3 = new System.Windows.Forms.Button();
            this.btnExample4 = new System.Windows.Forms.Button();
            this.btnExample5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(12, 205);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(75, 23);
            this.btnExample1.TabIndex = 1;
            this.btnExample1.Text = "Example1";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(93, 205);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(75, 23);
            this.btnExample2.TabIndex = 1;
            this.btnExample2.Text = "Example2";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // btnExample3
            // 
            this.btnExample3.Location = new System.Drawing.Point(174, 205);
            this.btnExample3.Name = "btnExample3";
            this.btnExample3.Size = new System.Drawing.Size(75, 23);
            this.btnExample3.TabIndex = 1;
            this.btnExample3.Text = "Example3";
            this.btnExample3.UseVisualStyleBackColor = true;
            this.btnExample3.Click += new System.EventHandler(this.btnExample3_Click);
            // 
            // btnExample4
            // 
            this.btnExample4.Location = new System.Drawing.Point(255, 205);
            this.btnExample4.Name = "btnExample4";
            this.btnExample4.Size = new System.Drawing.Size(75, 23);
            this.btnExample4.TabIndex = 1;
            this.btnExample4.Text = "Example4";
            this.btnExample4.UseVisualStyleBackColor = true;
            this.btnExample4.Click += new System.EventHandler(this.btnExample4_Click);
            // 
            // btnExample5
            // 
            this.btnExample5.Location = new System.Drawing.Point(336, 205);
            this.btnExample5.Name = "btnExample5";
            this.btnExample5.Size = new System.Drawing.Size(75, 23);
            this.btnExample5.TabIndex = 1;
            this.btnExample5.Text = "Example5";
            this.btnExample5.UseVisualStyleBackColor = true;
            this.btnExample5.Click += new System.EventHandler(this.btnExample5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExample1);
            this.Controls.Add(this.btnExample2);
            this.Controls.Add(this.btnExample3);
            this.Controls.Add(this.btnExample4);
            this.Controls.Add(this.btnExample5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.Button btnExample3;
        private System.Windows.Forms.Button btnExample4;
        private System.Windows.Forms.Button btnExample5;
    }
}

