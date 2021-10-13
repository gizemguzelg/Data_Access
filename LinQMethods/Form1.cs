using LinQMethods.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void btnExample1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice >= 40 && x.UnitPrice <= 60).ToList();
        }

        private void btnExample3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=db.Products.Where(x => x.UnitPrice >= 40 && x.UnitPrice <= 60)
                                                 .Select(x=> new
                                                 {
                                                     x.ProductID,
                                                     x.ProductName,
                                                     x.UnitPrice,
                                                     x.UnitsInStock
                                                 })
                                                 .ToList();
        }

        private void btnExample4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20)
                                      .OrderByDescending(x => x.ProductID)
                                      .Select(x => new
                                      {   x.ProductID,
                                          x.ProductName,
                                          x.UnitPrice,
                                          x.UnitsInStock
                                      })
                                      .ToList();
                                      
        }

        private void btnExample5_Click(object sender, EventArgs e)
        {
            
            try
            {
                Products products = db.Products.First(x => x.ProductID == 5);
                MessageBox.Show($"Product Id:{products.ProductID}");


            }
            catch (Exception)
            {
                MessageBox.Show("Aradığınız veri bulunamadı.");
            }

        }

        

       

        private void btnExample6_Click(object sender, EventArgs e)
        {
            Employees employees = db.Employees.FirstOrDefault(x => x.EmployeeID > 1);
            if (employees == null)
                MessageBox.Show("Aradığınız çalışan bulunmamaktadır.");
            else
                MessageBox.Show($"Aradğınız çalışanın adı:{employees.LastName}");
        }

        private void btnExample7_Click(object sender, EventArgs e)
        {
            Categories categories = db.Categories.Find(5);
            if (categories == null)
                MessageBox.Show("Aradığınız kategori bulunmamaktadır.");
            else
                MessageBox.Show($"Aradığınız kategori:{categories.CategoryName}");
        }

        private void btnExample8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => x.EmployeeID > 5)
                                       .OrderByDescending(x => x.EmployeeID)
                                       .Select(x => new
                                       {
                                           x.EmployeeID,
                                           x.LastName,
                                           x.Title
                                       }).Take(3)
                                         .ToList();
        }

        private void btnExample9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice >= 30 && x.UnitPrice <= 50)
                                       .OrderByDescending(x => x.UnitPrice)
                                       .Select(x => new
                                       {   x.ProductID,
                                           x.ProductName,
                                           x.UnitsInStock,
                                           x.UnitPrice
                                       }).Skip(5)
                                         .Take(5)
                                         .ToList();                             
        }

        private void btnExample10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.Contains("y"))
                                                 .OrderByDescending(x => x.FirstName)
                                                 .Select(x => new
                                                 {
                                                     x.EmployeeID,
                                                     x.FirstName,
                                                     x.LastName,
                                                     x.Title
                                                 }).ToList();
        }

        private void btnExample11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.StartsWith("C")).ToList();
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.EndsWith("y")).ToList();
        }

        private void btnExample12_Click(object sender, EventArgs e)
        {
            bool sonuc = db.Shippers.Any(x => x.CompanyName.StartsWith("A"));
            MessageBox.Show(sonuc.ToString());
        }

        private void btnExample13_Click(object sender, EventArgs e)
        {
            int calisanSayisi = db.Employees.Count();
            MessageBox.Show("Çalışan Sayısı:" + calisanSayisi);
        }

        private void btnExample14_Click(object sender, EventArgs e)
        {
            int? toplamUrun = db.Products.Sum(x => x.UnitsInStock);
            MessageBox.Show($"Toplam ürün sayısı:{toplamUrun}");
        }

        private void btnExample15_Click(object sender, EventArgs e)
        {
            decimal? maxStok = db.Products.Min(x => x.UnitsInStock);
            decimal? minStok = db.Products.Max(x => x.UnitsInStock);
            MessageBox.Show($"En az stok:{maxStok}\nEn fazla stok:{minStok}");
        }

        private void btnExample16_Click(object sender, EventArgs e)
        {
           List<string> Customers = db.Customers.Select(x => x.Address).Distinct().ToList();
            foreach(var item in Customers)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btn_Example17_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.GroupBy(x => x.LastName)
                                                 .Select(x => x.Key).ToList();                       
        }
    }

    
}
