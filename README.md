# Quan_Ly_HS_GV_THPT
Bài tập thực hành nhóm bài 2
Thành viên: 
- Nhóm trưởng: Hoàng Trọng Bình
- Thành viên: Đỗ Văn Hoàng, Nguyễn Duy Linh, Nguyễn Đình Việt, Nhữ Ngọc Anh, Ma Đình Diện
- Phân công nhiệm vụ bài 2:
		Xây dựng phần mềm quản lý học sinh, giáo viên của trường THPT	
2.1	Xây dựng CSDL học sinh, giáo viên, thông tin giảng dạy (giáo viên - dạy lớp gì, lớp có những học sinh nào)	(Bình Hoàng)
2.2	Thiết kế giao diện cửa sổ chính (màn hình đăng nhập, các menu trỏ đến các module con,…). Xây dựng module quản lý người dùng	(Diện)
2.3	Xây dựng module thêm học sinh mới	(Duy Linh)
2.4	Xây dựng module sửa thông tin học sinh	(Duy Linh)
2.5	Xây dựng module xóa thông tin học sinh	Duy Linh
2.5	Xây dựng module tìm kiếm học sinh	Duy Linh
2.7	Xây dựng module thêm giáo viên mới	(Bình)
2.8	Xây dựng module sửa thông tin giáo viên	(Bình)
2.9	Xây dựng module xóa thông tin giáo viên	(Bình)
2.10	Xây dựng module tìm kiếm giáo viên	(Bình)
2.11	Xây dựng module quản lý thông tin giảng dạy (thêm, sửa, xóa, tìm kiếm)	(Việt)
2.12	Xây dựng module hướng dẫn sử dụng phần mềm (menu Help, F1) chi tiết đến từng chức năng	(Ngọc Anh)
2.13	Xây dựng tài liệu hướng dẫn cài đặt, vận hành	(Ngọc Anh)
2.14	Ghép nối các module để nhận được phần mềm hoàn chỉnh	(Ngọc Anh-Việt)
2.15	Chạy kiểm thử phần mềm kết quả	(Diện)

- Một số quy tắc đặt biến, chạy chương trình:
+Tên biến là một chuỗi kí tự liên tiếp không có khoảng cách, tiếng việt có dấu và chứa kí tự đặc biệt
+Tên biến phải bắt đầu bằng kí tự không phải dạng số hoặc dấu _
+Tên biến không được đặt trùng với từ khóa
+Tên biến phân biệt hoa thường
+Tên biến đặt ngắn gọn, dễ hiểu và mô tả được ý nghĩa của việc sử dụng
- Quy tắc làm việc:
+ Các thành viên trong nhóm hoàn thiện module của mình, commit lên repo và thông báo với trưởng nhóm nếu có lỗi phát sinh
+ Làm việc khẩn trương, nghiêm túc
**************************************************************************************
Khi thành viên clone về chạy chương trình thì sửa file config thành database của mình:(sửa Datasource)
<connectionStrings>
        <add name="Conn" connectionString="Data Source=DESKTOP-6DIRH3U\SQLEXPRESS02;Initial Catalog=QUAN_LY_NHAN_SU;user id=sa;password=123456;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False" providerName="System.Data.SqlClient" />
    </connectionStrings>
