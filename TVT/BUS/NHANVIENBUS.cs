﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NHANVIENBUS
    {
        NHANVIENDAO _nhanvienDAO= new NHANVIENDAO();
        public QuanLyNhanVienDTO layTen_Quyen(string maNV)
        {
            return _nhanvienDAO.layTen_Quyen(maNV);
        }

    }
}