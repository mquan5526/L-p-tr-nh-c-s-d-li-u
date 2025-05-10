# Quản lý Trường học (C# .NET)

## 📌 Mô tả
Đây là một ứng dụng quản lý trường học được phát triển bằng ngôn ngữ C# trên nền tảng .NET. Ứng dụng hỗ trợ các chức năng như quản lý sinh viên, giảng viên, môn học, lớp học và điểm số.

## 🛠️ Công nghệ sử dụng
- **Ngôn ngữ lập trình:** C#
- **Nền tảng:** .NET Framework
- **Kiến trúc:** Phân lớp với các Layer:
  - `PresentationLayer`: Giao diện người dùng
  - `BusinessLayer`: Xử lý nghiệp vụ
  - `DataLayer`: Truy cập dữ liệu
  - `TransferObject`: Đối tượng truyền dữ liệu
- **Cơ sở dữ liệu:** SQL Server (giả định)

## 🚀 Hướng dẫn chạy project

### 1. Clone repository
```bash
git clone https://github.com/mquan5526/L-p-tr-nh-c-s-d-li-u.git
````

### 2. Mở project

* Mở file `LTCSDL.sln` bằng Visual Studio.

### 3. Cấu hình cơ sở dữ liệu

* Cập nhật chuỗi kết nối trong file cấu hình (`App.config` hoặc `Web.config`) để kết nối với cơ sở dữ liệu SQL Server của bạn.
* Tạo và khởi tạo cơ sở dữ liệu nếu cần (bằng script hoặc migration, tùy thiết lập).

### 4. Chạy ứng dụng

* Build solution trong Visual Studio (`Ctrl + Shift + B`).
* Chạy project từ `PresentationLayer`.

## ✅ Các chức năng chính

* [x] Quản lý sinh viên
* [x] Quản lý giảng viên
* [x] Quản lý cán bộ, công nhân viên
* [x] Quản lý học phí
```

---

```
