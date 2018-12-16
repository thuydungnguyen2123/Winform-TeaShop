using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.DTO
{
    class BillInfo
    {
        public BillInfo(int id, int idBil, int idMon, int count)
        {
            this.ID = id;
            this.IDBill = idBill;
            this.IDMon = idMon;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idBill"];
            this.IDMon = (int)row["idMon"];
            this.Count = (int)row["count"];
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int idMon;
        public int IDMon
        {
            get { return idMon; }
            set { idMon = value; }
        }

        private int idBill;
        public int IDBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}




