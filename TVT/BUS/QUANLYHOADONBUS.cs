﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class QUANLYHOADONBUS
    {
        QUANLYHOADONDAO _qlHDDAO = new QUANLYHOADONDAO();
        public List<QuanLyHoaDonDTO> LayDSHD()
        {
            return _qlHDDAO.LayDSHD();
        }
    }
}
