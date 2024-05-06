using System;
using System.Windows.Forms;
using Nhom11_Quanlybangiay.FormChucNang;
using Nhom11_Quanlybangiay.Khachhang;
using Nhom11_Quanlybangiay.DanhSachCacNhaCungCap;

using Nhom11_Quanlybangiay.NhapHang;
using Nhom11_Quanlybangiay.SanPham;
using Nhom11_Quanlybangiay.ThemSanPham;

namespace Nhom11_Quanlybangiay.FrmLogin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
