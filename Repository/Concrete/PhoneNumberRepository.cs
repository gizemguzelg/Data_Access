using Dapper;
using DapperExample.Entities;
using DapperExample.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperExample.Repository.Concrete
{
    public class PhoneNumberRepository : IBaseRepository<Phone>
    {
        SqlConnection db = new SqlConnection(@"Data Source = GIZEM; Initial Catalog = DapperExample; Integrated Security = True");

        public bool Delete(Phone item)
        {
            try
            {
                sqlOpen();
                db.Query<Phone>(@"DELETE FROM [dbo].[Phone] where Id=@id", item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        public List<Phone> GetAll()
        {
            try
            {
                sqlOpen();

                List<Phone> list = db.Query<Phone>("SELECT * FROM  [dbo].[Phone]").ToList();
                return list;
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        internal void Save(Phone getPhone)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Phone item)
        {
            try
            {
                sqlOpen();
                db.Query<Phone>(@"INSERT INTO  [dbo].[Phone]([Id],[FullName],[PhoneNumber]) VALUES (@Id,@FullName,@PhoneNumber)",item);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Insert hatası "+ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        public bool Update(Phone item)
        {
            try
            {
                sqlOpen();
                db.Query<Phone>(@"UPDATE [dbo].[Phone] SET 
                                         [Id]=@Id,
                                         [FullName]=@FullName,
                                         [PhoneNumber]=@PhoneNumber", item);
                
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }
        public void sqlOpen()
        {
            if (db.State == System.Data.ConnectionState.Closed)
                db.Open();
        }
        public void sqlClose()
        {
            if (db.State == System.Data.ConnectionState.Open)
                db.Close();
        }

    }
}
