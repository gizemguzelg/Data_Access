using E_Commercial_Db.Context;
using E_Commercial_Db.Model.Entities.Abstract;
using E_Commercial_Db.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commercial_Db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ApplicationDbContext db = new ApplicationDbContext();
        //void Eraser(GroupBox grpCreateCategory)
        //{
        //    foreach (Control item in grpCreateCategory.Controls)
        //    {
        //        if (item is TextBox)
        //        { item.Text = string.Empty; }

        //    }
        //}

        //List<Category> GetCategories() => db.Categories.Where(x => x.status!=Status.Delete).ToList();
        //private void btnCreate_Click(object sender, EventArgs e)
        //{
        //    Category category = new Category();
        //    category.CategoryName = txtCreateName.Text;
        //    category.Description = txtCreateDescription.Text;
        //    category.status = Status.Active;
        //    db.Categories.Add(category);
        //    db.SaveChanges();
        //    Eraser(grp_Create);
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = GetCategories();
        //}
        //Category category;
        //private void btnFindById_Click(object sender, EventArgs e)
        //{
        //    category = db.Categories.Find(int.Parse(txtFindById.Text));

        //    txtUpdateName.Text = category.CategoryName;
        //    txtUpdateDescription.Text = category.Description;
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    category.CategoryName = txtUpdateName.Text;
        //    category.Description = txtUpdateDescription.Text;
        //    category.UpdateDate = DateTime.Now;
        //    category.status = Status.Modified;
        //    db.SaveChanges();
        //    dataGridView1.DataSource = GetCategories();
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{

        //    Category category = db.Categories.Find(int.Parse(txtDeleteId.Text));
        //    category.DeleteDate = DateTime.Now;
        //    category.status = Status.Delete;
        //    db.SaveChanges();
        //    dataGridView1.DataSource = GetCategories();
        //    Eraser(grpDelete);
        //}
    }
}
