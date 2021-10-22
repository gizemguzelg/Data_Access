using DapperExample.Entities;
using DapperExample.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperExample
{
    public partial class Form1 : Form
    {
        PhoneNumberRepository getPhoneNumberRepository;
        Phone getPhone;
        int _Id;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fillGrid();
            }
            catch (Exception ex)
            {

                throw new Exception("Sql bağlantınızı kontrol ediniz." + ex.Message.ToString());
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                getPhone = new Phone()
                {
                    Id = _Id,
                    FullName = txtFullName.Text,
                    PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text),
                };



                if (_Id == 0)
                {
                    getPhoneNumberRepository = new PhoneNumberRepository();
                    getPhoneNumberRepository.Save(getPhone);
                }
                else //Update
                {
                    getPhoneNumberRepository = new PhoneNumberRepository();
                    getPhoneNumberRepository.Update(getPhone);
                }
            }

            catch (Exception ex)
            {

                throw new Exception("Kayıt değiştirildi." + ex.Message.ToString());
            }

            fillGrid();
        
        }
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                getPhone = new Phone()
                {
                    Id = _Id
                    
                };
                getPhoneNumberRepository = new PhoneNumberRepository();
                getPhoneNumberRepository.Delete(getPhone);
                MessageBox.Show("Silme işlemi tamamlandı.");
            }
            catch (Exception ex)
            {

                throw new Exception("Kayıt başarıyla tamamlandı." + ex.Message.ToString());
            }
            fillGrid();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.CurrentRow.Index != -1)
                {
                    _Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    txtFullName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtPhoneNumber.Text =dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    btnDelete.Enabled = true;
                    btnInsert.Text = "Update";
                }


            }
            catch (Exception)
            {

                throw new Exception("Id bulunamadı.");
            }

        }
        void fillGrid()
        {
            getPhoneNumberRepository = new PhoneNumberRepository();
            var list = getPhoneNumberRepository.GetAll();
            dataGridView1.DataSource = list;

        }

    }
}


