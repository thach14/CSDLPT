--Data
set dateformat dmy;
insert into ChiNhanh(TenCN) values (N'Đà Lạt')
insert into ChiNhanh(TenCN) values (N'TPHCM')
select * from ChiNhanh;

insert into DuAn(IDCN,TenDuAn,NgayBatDau,KinhPhi,ThoiHan, Status) values (1,N'Dự án Web','14-03-2022',1000000,6,0)
insert into DuAn(IDCN,TenDuAn,NgayBatDau,KinhPhi,ThoiHan, Status) values (1,N'Dự án todolist','14-03-2022',2000000,12,0)
insert into DuAn(IDCN,TenDuAn,NgayBatDau,KinhPhi,ThoiHan, Status) values (2,N'Dự án Web thời khóa biểu','14-03-2022',5000000,24,0)
insert into DuAn(IDCN,TenDuAn,NgayBatDau,KinhPhi,ThoiHan, Status) values (2,N'Dự án Web bán đồ ăn','14-03-2022',1000000,8,0)

select * from DuAn;

insert into NhanVien(IDCN,CMND,HoTen,NgaySinh,DiaChi,ChucVu,Status) values (1,'251139041',N'Vũ Đình Phúc','10-04-2000',N'Phạm Hồng Thái - Đà Lạt','Nhân viên',1)
insert into NhanVien(IDCN,CMND,HoTen,NgaySinh,DiaChi,ChucVu,Status) values (1,'251165719',N'Đặng Ngọc Thạch','14-03-2000',N'Phù Đồng Thiên Vương - Đà Lạt','Nhân viên',1)
insert into NhanVien(IDCN,CMND,HoTen,NgaySinh,DiaChi,ChucVu,Status) values (1,'251169043',N'Nguyễn Hồng Phượng','31-07-2000',N'Nguyên Tử Lực - Đà Lạt','Nhân viên',1)
insert into NhanVien(IDCN,CMND,HoTen,NgaySinh,DiaChi,ChucVu,Status) values (2,'251111111',N'Hoàng Vinh Quang','01-04-2000',N'Đà Lạt','Nhân viên',1)
insert into NhanVien(IDCN,CMND,HoTen,NgaySinh,DiaChi,ChucVu,Status) values (2,'251139041',N'Vũ Đình Phúc','01-01-2000',N'Đà Lạt','Nhân viên',1)
insert into NhanVien(IDCN,CMND,HoTen,NgaySinh,DiaChi,ChucVu,Status) values (2,'251139041',N'Vũ Đình Phúc','01-01-2000',N'Đà Lạt','Nhân viên',1)
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
select * from TraLuong;

--Nhan Vien
create proc ThemNhanVien
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
		end;
		else print ('Đã nhập sai chi nhánh');
	end;
END;

create proc suaNhanVien(@id nvarchar(10), @ten nvarchar(50), @ngaySinh date, @diaChi nvarchar(50), @chucVu nvarchar(50), @idCN nvarchar(5)) as
begin
	if(exists(select * from NhanVien where IDNhanVien=@id))
	begin
		if(exists(select * from ChiNhanh where IDChiNhanh=@idCN))
		begin
			update NhanVien set HoTen=@ten, NgaySinh=@ngaySinh, DiaChi = @diaChi, ChucVu=@chucVu, IDChiNhanh=@idCN where IDNhanVien=@id;
			print N'Đã sửa ' + @id + N' trong CSDL thành công!';
		end;
		else
			print N'Không có ' + @idCN + N' tồn tại trong CSDL!';
	end;
	else
		print N'Không có '+ @id + N' tồn tại trong CSDL!';
end;

create proc xoaNhanVien(@id nvarchar(10)) as
begin
	if(exists(select * from PhanCong where IDNhanVien=@id))
		print N'Không thể xoá ' + @id;
	else if(exists(select * from NhanVien where IDNhanVien=@id))
	begin
		delete from NhanVien where IDNhanVien=@id;
		print N'Đã xoá ' + @id + N' trong CSDL thành công!';
	end;
	else
		print N'Không có '+ @id + N' tồn tại trong CSDL!';
end;

--Chi Nhanh
create proc themCN(@id nvarchar(5), @ten nvarchar(50)) as
begin
	if(exists(select * from ChiNhanh where IDChiNhanh=@id))
		print (@id + N' đã tồn tại trong CSDL!');
	else
	begin
		insert into ChiNhanh values (@id, @ten);
		print N'Đã thêm ' + @id + N' vào CSDL thành công!';
	end;
end;

create proc xoaCN(@id nvarchar(5)) as
begin
	if(exists(select * from NhanVien where IDChiNhanh=@id))
		print N'Không thể xoá ' + @id;
	else if(exists(select * from ChiNhanh where IDChiNhanh=@id))
	begin
		delete from ChiNhanh where IDChiNhanh=@id;
		print N'Đã xoá ' + @id + N' trong CSDL thành công!';
	end;
	else
		print N'Không có '+ @id + N' tồn tại trong CSDL!';
end;

create proc suaCN(@id nvarchar(5), @ten nvarchar(50)) as
begin
	if(exists(select * from ChiNhanh where IDChiNhanh=@id))
	begin
		update ChiNhanh set TenChiNhanh = @ten where IDChiNhanh=@id;
		print N'Đã sửa ' + @id + N' trong CSDL thành công!';
	end;
	else
		print N'Không có '+ @id + N' tồn tại trong CSDL!';
end;

--Du An
create proc themDA(@id nvarchar(5), @ten nvarchar(50), @ngayBD date, @phi decimal(18,0)) as
begin
	if(exists(select * from DuAn where IDDuAn=@id))
		print (@id + N' đã tồn tại trong CSDL!');
	else
	begin
		insert into DuAn values (@id, @ten, @ngayBD, @phi);
		print N'Đã thêm ' + @id + N' vào CSDL thành công!';
	end;
end;

create proc xoaDA(@id nvarchar(5)) as
begin
	if(exists(select * from PhanCong where IDDuAn=@id))
		print N'Không thể xoá ' + @id;
	else if(exists(select * from DuAn where IDDuAn=@id))
	begin
		delete from DuAn where IDDuAn=@id;
		print N'Đã xoá ' + @id + N' trong CSDL thành công!';
	end;
	else
		print N'Không có '+ @id + N' tồn tại trong CSDL!';
end;

create proc suaDA(@id nvarchar(5), @ten nvarchar(50), @ngayBD date, @phi decimal(18,0)) as
begin
	if(exists(select * from DuAn where IDDuAn=@id))
	begin
		update DuAn set TenDuAn=@ten, NgayBatDau=@ngayBD, KinhPhi=@phi where IDDuAn=@id;
		print N'Đã sửa ' + @id + N' trong CSDL thành công!';
	end;
	else
		print N'Không có '+ @id + N' tồn tại trong CSDL!';
end;

--VaiTro
create proc themVT(@vaiTro nvarchar(50), @luong decimal(18,0)) as
begin
	if(exists(select * from VaiTro where VaiTro=@vaiTro))
		print (@vaiTro + N' đã tồn tại trong CSDL!');
	else
	begin
		insert into VaiTro(VaiTro,Luong) values (@vaiTro, @luong);
		print N'Đã thêm ' + @vaiTro + N' vào CSDL thành công!';
	end;
end;

create proc xoaVT(@id int) as
begin
	if(exists(select * from PhanCong where IDVaiTro=@id))
		print N'Không thể xoá';
	else if(exists(select * from VaiTro where IDVaiTro=@id))
	begin
		delete from VaiTro where IDVaiTro=@id;
		print N'Đã xoá vai trò có ID' + str(@id,3) + N' trong CSDL thành công!';
	end;
	else
		print N'Không có vai trò ID' + str(@id,3) + N' tồn tại trong CSDL!';
end;

create proc suaVT(@id int, @vaiTro nvarchar(50), @luong decimal(18,0)) as
begin
	if(exists(select * from VaiTro where VaiTro=@vaiTro))
	begin
		update VaiTro set VaiTro=@vaiTro, Luong=@luong where IDVaiTro=@id;
		print N'Đã sửa vai trò có ID' + str(@id,3) + N' trong CSDL thành công!';
	end;
	else
		print N'Không có vai trò có ID'+ str(@id,3) + N' tồn tại trong CSDL!';
end;

--Phan Cong
create proc themPC(@idNV nvarchar(10), @idDA nvarchar(5), @idVT int, @ngayTG date) as
begin
	if(exists(select * from PhanCong where IDNhanVien=@idNV and IDDuAn=@idDA and IDVaiTro=@idVT))
		print N'Đã tồn tại dữ liệu phân công!';
	else
	begin
		if(exists(select * from NhanVien where IDNhanVien=@idNV))
		begin
			if(exists(select * from DuAn where IDDuAn=@idDA))
			begin
				if(exists(select * from VaiTro where IDVaiTro=@idVT))
				begin
					insert into PhanCong values (@idNV, @idDA, @idVT, @ngayTG);
					print N'Đã thêm vào CSDL thành công!';
				end;
				else
					print N'Không có '+ @idVT + N' tồn tại trong CSDL!';
			end;
			else
				print N'Không có '+ @idDA + N' tồn tại trong CSDL!';
		end;
		else
			print N'Không có '+ @idNV + N' tồn tại trong CSDL!';
	end;
end;

create proc xoaPC(@idNV nvarchar(10), @idDA nvarchar(5), @idVT int) as
begin
	if(exists(select * from PhanCong where IDNhanVien=@idNV and IDDuAn=@idDA and IDVaiTro=@idVT))
	begin
		delete from PhanCong where IDNhanVien=@idNV and IDDuAn=@idDA and IDVaiTro=@idVT;
		print N'Đã xoá dữ liệu phân công thành công!';
	end;
	else
		print N'Không có dữ liệu phân công tồn tại trong CSDL!';
end;