create database DiemSinhVien
on
(
name ='QLDiemSV',
filename ='E:\.net\adata\QLDiemSV.MDF',
size = 2,
maxsize = 10,
filegrowth = 2
)
log on
(
name ='QLDiemSV_Log',
filename ='E:\.net\adata\QLDiemSV.LDF',
size = 2,
maxsize = 10,
filegrowth = 2
)
 use DiemSinhVien

 select * from DiemHP
 select * from Lops 
  select * from SinhVien
   select * from MonHP
    select * from HocKy


select diemLan1 from DiemHP where LanThi='1'and maSV=''
select * from DiemHP where maSV like=%%
