using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using variable;
using System.Data;
using System.Data.SqlClient;

namespace BLLL
{
    public class BLL
    {


        public DBC db = new DBC();
        public vari v = new vari();




        public DataTable adminlogin(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Admindb where Username = '" + v.uname + "' and Password = '" + v.password + "'";
            return db.ExeReader(com);
        }
        public DataTable guestlogin(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Guestdb where Username = '" + v.uname + "' and Password = '" + v.password + "'";
            return db.ExeReader(com);
        }

        /*   public DataTable ManagerLogin(info ninfo)
           {
               SqlCommand com = new SqlCommand();
               com.CommandType = CommandType.Text;
               com.CommandText = "select * from manager where id = '" + ninfo.id + "' and password = '" + ninfo.password + "'";
               return ndbc.ExeReader(com);
           }

           public DataTable OwnerLogin(info ninfo)
           {
               SqlCommand com = new SqlCommand();
               com.CommandType = CommandType.Text;
               com.CommandText = "select * from owner where id = '" + ninfo.id + "' and password = '" + ninfo.password + "'";
               return ndbc.ExeReader(com);
           }
           */
        public DataTable newguest(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Guestdb(Username,Password,fname,lname,Address,Gender) values ('" + v.uname + "','" + v.password + "','" + v.fname + "','" + v.lname + "','" + v.address + "','" + v.gender + "')";
            return db.ExeReader(com);
        }

        public DataTable newroom(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Roomdb(Room_Type,Room_Price,No_bed,Room_Floor,Extra_bed) values ('" + v.Type + "','" + v.Price + "','" + v.No_of_bed + "','" + v.Level + "','" + v.Extrabed + "')";
            return db.ExeReader(com);
        }

        public DataTable newemp(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Employee(E_Name,Department,Salary,Available,Address) values ('" + v.name + "','" + v.Department + "','" + v.salary + "','" + v.available + "','" + v.address + "')";
            return db.ExeReader(com);
        }


        /*
        public DataTable NewManager(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into manager (name, password, position, address, mobile) values ('" + ninfo.name + "','" + ninfo.password + "','" + ninfo.position + "','" + ninfo.address + "','" + ninfo.mobile + "')";
            return ndbc.ExeReader(com);
        }


        public DataTable NewOwner(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into owner (name, password, position, address, mobile) values ('" + ninfo.name + "','" + ninfo.password + "','" + ninfo.position + "','" + ninfo.address + "','" + ninfo.mobile + "')";
            return ndbc.ExeReader(com);
        }


    */
        public SqlDataReader Showroomlist()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Roomdb where Booking = '" + "No" + "'";
            return db.sExeReader(com);
        }

        public DataTable BookRoom(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [Roomdb] set Booking = '" + v.Booking + "', G_id = '" + v.gid + "' where id = '" + v.id + "' ";
            return db.ExeReader(com);
        }


        public SqlDataReader ReturnRoomInfo(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Roomdb where Id = '" + v.id + "'";
            return db.sExeReader(com);
        }


        public DataTable placeorder(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into [Order](G_id,Price,Payment,Status,Service,S_id) values ('" + v.gid + "','" + v.Price + "','" + v.Payment + "','" + v.Status + "','" + v.Service + "','" + v.id + "')";
            return db.ExeReader(com);
        }

        public SqlDataReader Orderlist(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from [Order] where G_id = '" + v.gid + "'";
            return db.sExeReader(com);
        }

        public SqlDataReader Servicelist()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from [Service]";
            return db.sExeReader(com);
        }

        public DataTable insertservice(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into [Service] (Service_Name,Price,Description,Available) values ('" + v.name + "','" + v.Price + "','" + v.Description + "','" + v.available + "')";
            return db.ExeReader(com);
        }


        public SqlDataReader View_Booking_List()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from [Order] where Service='" + "Room" + "'";
            return db.sExeReader(com);
        }


        public DataTable ConfirmBooking(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update [Order] set Status='" + v.Status + "'";
            return db.ExeReader(com);
        }


        public SqlDataReader Showemplist()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Employee";
            return db.sExeReader(com);
        }

        public SqlDataReader DShowemplist(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Employee where E_Id='" + v.id + "'";
            return db.sExeReader(com);
        }


        public DataTable Demp(vari d)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from [Employee] where E_Id = '" + d.id + "'";
            return db.ExeReader(com);
        }
        public SqlDataReader rmlist()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Roomdb";
            return db.sExeReader(com);
        }

        public DataTable Droom(vari d)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from [Roomdb] where Id = '" + d.id + "'";
            return db.ExeReader(com);
        }

        public SqlDataReader drmlist(vari d)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Roomdb where Id = '" + d.id + "'";
            return db.sExeReader(com);
        }

        public SqlDataReader DServicelist(vari d)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from [Service] where Id = '" + d.id + "'";
            return db.sExeReader(com);
        }


        public DataTable DService(vari d)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from [Service] where Id = '" + d.id + "'";
            return db.ExeReader(com);
        }


        public DataTable UpdateEmp(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [Employee] set E_Name = '" + v.name + "', Department = '" + v.Department + "',Salary = '" + v.salary + "', Available = '" + v.available + "',Address = '" + v.address + "' where E_Id = '" + v.id + "'";
            return db.ExeReader(com);

        }


        public DataTable UpdateRoom(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [Employee] set Room_Type = '" + v.Type + "', Room_Price = '" + v.Price + "',No_bed = '" + v.No_of_bed + "', Room_Floor = '" + v.Level + "',Booking = '" + v.Booking + "' where E_Id = '" + v.id + "'";
            return db.ExeReader(com);

        }


        public DataTable UpdateService(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [Service] set Service_Name = '" + v.name + "', Price = '" + v.Price + "',Description = '" + v.Description + "', Available = '" + v.available + "' where Id = '" + v.id + "'";
            return db.ExeReader(com);

        }

        public SqlDataReader OrderlistBYid(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from [Order] where Id = '" + v.id + "'";
            return db.sExeReader(com);


        }

        public DataTable PayOrder(vari v)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update [Order] set Payment='" + v.Payment + "' where Id = '" + v.id + "'";
            return db.ExeReader(com);
        }
    }
}
