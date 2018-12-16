using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime?dateCheckOut,int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill( DataRow row)
        {
            this.ID = (int) row["id"];
            this.DateCheckIn = (DateTime)row["dateCheckIn"];

            //var dateCheckOutTemp;
            this.DateCheckOut = (DateTime)row["dateCheckOut"];
            this.Status = (int)row["status"];
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime? dateCheckIn;
        private DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        } 
        private DateTime? dateCheckOut;
        private DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

    }
}
