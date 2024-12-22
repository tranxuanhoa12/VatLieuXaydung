using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using VatLieuXaydung.DataLayer;
using VatLieuXaydung.Entities;

namespace VatLieuXaydung.BusinessLayer
{
    class GiaBLL
    {
        GiaDAL dal = new GiaDAL();
        public DataTable LoadAll()
        { return dal.LoadAll(); }

        public Gia GetByID(decimal id)
        {
            return dal.GetByID(id);
        }
    }
}
