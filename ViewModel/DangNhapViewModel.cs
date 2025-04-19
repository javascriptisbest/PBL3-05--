using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PBL3.ViewModel
{
    public partial  class DangNhapViewModel : ObservableObject
    {
        // Chứa các string phân quyền 
        string[] source_phan_quyen = { "Người Thuê Trọ","Quản lý", "Nhân Viên" };
        // Chứa ảnh của Nhân Viên , Người thuê, Quản lý 
        string[] source_picture = { "/Picture/Nguoi_Thue.png", "/Picture/Quan_Ly.png", "/Picture/Nhan_Vien.png" };
        // anh_hien_tai là ảnh đang hiển thị lên được binding bên dang_nhap.xaml 
        [ObservableProperty]
        private string anhHienTai;
        // là vị trí ảnh hiện tại như hiện tại ảnh mặc địch là 0 là của người thuê
        int index = 0;
        // email binding tới textbox đăng nhập 
        [ObservableProperty]
        private string email;
        // string phân quyền hiện tại
        [ObservableProperty]
        private string phanQuyen;
        public DangNhapViewModel()
        {
            AnhHienTai = source_picture[index]; // tạo dữ liệu ban đầu cho anh_hien_tai
            PhanQuyen= source_phan_quyen[index]; // dữ liệu string phân quyền
        }

        /// xử lý sự kiện khi ấn vào icon left
       [RelayCommand]
        public void Buttonleft()
        {
            if (--index < 0) index = 2;
            AnhHienTai = source_picture[index];
            PhanQuyen = source_phan_quyen[index];
        }
        [RelayCommand]
        // xử lý sự kiện khi ấn vào icon right
        public void Buttonright()
        {
            if (++index > 2) index = 0;
            AnhHienTai = source_picture[index];
            PhanQuyen = source_phan_quyen[index];
        }
    }
}
