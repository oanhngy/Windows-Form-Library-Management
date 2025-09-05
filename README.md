# Windows-Form-Library-Management
## 1. GIỚI THIỆU
Dự án phát triển bằng C# (WinForms) với CSDL SQL Server.
Mô phỏng hệ thống quản lý thư viện, có chức năng mượn-trả sách, quản lý độc giả, quản lý sách, nhân viên.

## 2. MAIN FUNCTION
- Quản lý độc giả: CRUD, tìm thông tin độc giả
- Quản lý sách: Các thông tin chi tiết
- Mượn-Trả sách: Tạo phiếu mượn, cập nhật tình trạng sách
- Quản lý nhân viên: CRUD
- Báo cáo: Thống kê số lượng sách, lượt mượn trả theo thời gian
  
## 3. CÔNG NGHỆ
- Ngôn ngữ: C# (.NET Framework-Windows Forms)
- CSDL: SQL Server
- Mô hình kiến trúc: 3 lớp DAL, BUS, GUI

## 4. CẤU TRÚC DỰ ÁN
- GUI: giao diện người dùng (WinForms)
- DAL: Truy xuất dữ liệu từ SQL Server
- BUS: Xử lý logic nghiệp vụ
- DTO: Định nghĩa các lớp dữ liệu
- Helper: Hàm hỗ trợ
- CSDL_QuanLyThuVien.sql: script tạo CSDL và bảng

## 5. CÀI ĐẶT + CHẠY CHƯƠNG TRÌNH
1. Clone project từ GitHub
2. Mở project bằng Visual Studio
3. Import file CSDL_QuanLyThuVien.sql vào SQL Server để tạo CSDL
4. Cập nhật chuỗi kết nối trong App.config cho phù hợp
5. Chạy chương trình

## 6. HÌNH MINH HỌA
Đăng nhập

<img width="394" height="296" alt="image" src="https://github.com/user-attachments/assets/d32fe3eb-6330-4039-be4f-ce59a8a77fee" />

Giao diện chính

<img width="605" height="366" alt="image" src="https://github.com/user-attachments/assets/892474a1-3e35-4db8-b744-376041580115" />

Quản lý sách

<img width="605" height="366" alt="image" src="https://github.com/user-attachments/assets/7a7ee877-91c3-474b-8600-a25b0a321ca5" />

Quản lý độc giả

<img width="605" height="364" alt="image" src="https://github.com/user-attachments/assets/5ca91040-7708-4f60-8d1b-0b8a3097448a" />

Chức năng mượn- trả sách

<img width="605" height="364" alt="image" src="https://github.com/user-attachments/assets/f3d20566-c7a5-4c82-95de-280cda20baf8" />

<img width="605" height="364" alt="image" src="https://github.com/user-attachments/assets/185015e8-a82d-4c4a-89cc-ff3f111a158d" />

Báo cáo thống kê

<img width="577" height="347" alt="image" src="https://github.com/user-attachments/assets/0937a51a-9b7c-4930-b3e1-ccc2687ca3d3" />
