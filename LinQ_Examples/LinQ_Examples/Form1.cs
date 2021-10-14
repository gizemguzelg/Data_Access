using LinQ_Examples.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_Examples
{
    public partial class Form1 : Form
    {
        NorthwindEntities db;
        public Form1()
        {
            db = new NorthwindEntities();
            InitializeComponent();
        }

        private void btnExample1_Click(object sender, EventArgs e)
        {
            //Ürünlerin Id'sini,ürün adını,fiyatını getirin.
            #region LinQ Entity 
            dataGridView1.DataSource = db.Products.Select(x => new
            { x.ProductID,
              x.ProductName,
              x.UnitPrice
            }).ToList();

            #endregion

            #region LinQ SQL
            var Products = from x in db.Products
                           select new
                           {
                               x.ProductID,
                               x.ProductName,
                               x.UnitPrice
                           };
            dataGridView1.DataSource = Products.ToList();
               
            #endregion

        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            //Ürünlerin Id'si 5 ile 15 arasında olanların A-Z'ye sıralayınız.
            #region LinQ to Entity
            dataGridView1.DataSource = db.Products.Where(x => x.ProductID >= 2 && x.ProductID<=15)
                                                .OrderBy(x => x.ProductName)
                                                .Select(x => new
                                                {
                                                    x.ProductID,
                                                    x.ProductName,
                                                    x.UnitsInStock
                                                }).ToList();
            #endregion

            #region LinQ to SQL
            var Products = from x in db.Products
                           where x.ProductID >= 5 && x.ProductID <= 15
                           orderby x.ProductID
                           select new
                           {
                               x.ProductID,
                               x.ProductName,
                               x.UnitsInStock
                           };
            dataGridView1.DataSource = Products.ToList();


            #endregion
        }

        private void btnExample3_Click(object sender, EventArgs e)
        {//Soru:50 yaşından büyük olan çalışanları büyükten küçüğe listeleyiniz.
            #region
            dataGridView1.DataSource = db.Employees.Where(x => SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now) > 50)
                                                 .OrderByDescending(x => SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now) >= 50)
                                                 .Select(x => new
                                                 {
                                                     FullName = x.FirstName + "" + x.LastName,
                                                     Age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)
                                                 }).OrderByDescending(x => x.Age)
                                                   .ToList();
            #endregion

            #region LinQ to SQL
            var result = from emp in db.Employees
                         where SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now) > 50
                         orderby SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now) descending
                         select new
                         {
                             Adı = emp.FirstName,
                             Soyadı = emp.LastName,
                             Yas = SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now)
                         };
           dataGridView1.DataSource = result.ToList();
            #endregion
        }

        private void btnExample4_Click(object sender, EventArgs e)
        {
            //Ünvanı Mr ve yaşı 50'den büyük olan çalışanları listeleyiniz.
            #region LİnQ to Entity
            dataGridView1.DataSource = db.Employees.Where(x => x.TitleOfCourtesy == "Mr" && SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now) > 50)
                                                   .ToList();
            #endregion

            #region LinQ to SQL
            var result = from emp in db.Employees
                         where emp.TitleOfCourtesy == "Mr" && SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now) > 50
                         select new
                         {
                             FullName = emp.LastName + "" + emp.FirstName,
                             emp.TitleOfCourtesy
                         };


            dataGridView1.DataSource = result.ToList();
            #endregion

        }

        private void btnExample5_Click(object sender, EventArgs e)
        {
            //Kategorilere göre toplam stok miktarını getiriniz.
            dataGridView1.DataSource = db.Categories
                .Join(db.Products, c => c.CategoryID, p => p.CategoryID, (c, p) => new { c, p })
                .GroupBy(x => x.c.CategoryID)
                .Select(x => new
                {
                    CategoryId = x.Key,
                    count = x.Sum(z => z.p.UnitsInStock)
                })
                .OrderByDescending(x => x.count)
                .ToList();   
        }
    }
}
