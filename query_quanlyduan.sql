insert into ChiNhanh values ('CN01',N'Đà Lạt')
insert into ChiNhanh values ('CN02',N'TPHCM')
select * from ChiNhanh;
set dateformat dmy;
insert into DuAn values ('DA01',N'Dự án Web','14-03-2022',1000000)
insert into DuAn values ('DA02',N'Dự án todolist','14-03-2022',2000000)
insert into DuAn values ('DA03',N'Dự án Web thời khóa biểu','14-03-2022',5000000)
insert into DuAn values ('DA04',N'Dự án Web bán đồ ăn','14-03-2022',1000000)
insert into DuAn values ('DA05',N'Dự án Web quần áo','14-03-2022',4000000)
insert into DuAn values ('DA06',N'Dự án Web bán trang sức','14-03-2022',7000000)
insert into DuAn values ('DA07',N'Dự án Game bắn súng','14-03-2022',8000000)
insert into DuAn values ('DA08',N'Dự án Game đối kháng','14-03-2022',1000000)
insert into DuAn values ('DA09',N'Dự án Game liên minh','14-03-2022',1000000)
insert into DuAn values ('DA10',N'Dự án Game empire','14-03-2022',2000000)
select * from DuAn;

insert into NhanVien values ('NV001',N'Vũ Đình Phúc','10-04-2000',N'Phạm Hồng Thái - Đà Lạt','Team Leader','CN01')
insert into NhanVien values ('NV002',N'Đặng Ngọc Thạch','14-03-2000',N'Phù Đổng Thiên Vương - P8 - Đà Lạt','Thư ký','CN01')
insert into NhanVien values ('NV003',N'Nguyễn Hồng Phượng','31-07-2000',N'Phù Đổng Thiên Vương - P8 - Đà Lạt','Coder','CN01')
insert into NhanVien values ('NV004',N'Hoàng Vinh Quang','01-01-2000',N'Phù Đổng Thiên Vương - P8 - Đà Lạt','Coder','CN02')
insert into NhanVien values ('NV005',N'Thomas Gavin','10-04-2000',N'Phù Đổng Thiên Vương - P8 - Đà Lạt','Tester','CN02')
select * from NhanVien;

insert into VaiTro values (N'Team Leader',30000)
insert into VaiTro values (N'Thư ký',1000)
insert into VaiTro values (N'Coder',3000)
insert into VaiTro values (N'Tester',2000)
select * from VaiTro;

insert into PhanCong values ('NV001','DA01',2,'14-03-2022')
insert into PhanCong values ('NV002','DA02',3,'14-03-2022')
insert into PhanCong values ('NV004','DA03',4,'14-03-2022')
insert into PhanCong values ('NV003','DA04',2,'14-03-2022')
insert into PhanCong values ('NV001','DA05',4,'14-03-2022')
insert into PhanCong values ('NV001','DA06',5,'14-03-2022')
select * from PhanCong;

alter proc ThemNhanVien
@id nvarchar(10), @hoten nvarchar(25), @ngaysinh datetime, @dc nvarchar(100),
@chucvu nvarchar(50), @idchinhanh nvarchar(5)
AS
begin
if @id in (select IDNhanVien from NhanVien)
	print('Mã NV đã tồn tại');
else
	begin
		if @idchinhanh in (select IDChiNhanh from ChiNhanh)
		begin
		insert into NhanVien values(@id,@hoten,@ngaysinh,@dc,@chucvu,@idchinhanh);
		print('Thêm NV thành công');
		end
		else print ('Đã nhập sai chi nhánh')
	end

END;
create proc SuaNhanVien
@id nvarchar(10), @hoten nvarchar(25), @ngaysinh datetime, @dc nvarchar(100),
@chucvu nvarchar(50), @idchinhanh nvarchar(5)
AS
BEGIN
	update NhanVien
	set HoTen = @hoten,
		NgaySinh = @ngaysinh,
		DiaChi = @dc,
		ChucVu = @chucvu,
		IDChiNhanh = @idchinhanh
	where IDNhanVien = @id;
END;

alter proc XoaNhanVien
@id nvarchar(10)
AS
BEGIN
	delete from NhanVien
	where IDNhanVien = @id;
END;


exec XoaNhanVien 'NV009'
select * from NhanVien