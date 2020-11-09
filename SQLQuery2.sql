CREATE DATABASE PhoneManagement
GO

USE PhoneManagement
GO
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Kter',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

	 insert dbo.account(userName,displayName,passWord, type) values(N'admin',N'Admin',N'1',1)
	 insert dbo.account(userName,displayName,passWord, type) values(N'staff',N'Staff',N'1',0)

go

select * from	dbo.Account 
go
create Proc USP_Login 
@userName nvarchar(100), @passWord nvarchar(100)
as
Begin
	Select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go

CREATE TABLE NewBill
(
	idNewBill INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bill name',
	status NVARCHAR(100) NOT NULL DEFAULT N'New bill'	-- New bill || Paying
)
GO

insert dbo.NewBill(name,status) values(N'NewBill 1',N'New Bill')
insert dbo.NewBill(name,status) values(N'NewBill 2',N'Paying')

select * from dbo.NewBill
delete dbo.newbill

go
CREATE TABLE StoreCategory
(
	idStore int not null identity PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'NULL'
)
GO

insert dbo.StoreCategory(name) values(N'Moblie Phone')
insert dbo.StoreCategory(name) values(N'Accessories' )


select * from dbo.StoreCategory




CREATE TABLE PhoneCategory
(
	idStore int not null ,
	idPhone int not null identity PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'NULL',
	FOREIGN KEY (idStore) REFERENCES dbo.StoreCategory(idStore) ,
)
go


insert dbo.PhoneCategory(idStore,name) values(1,N'APPLE')
insert dbo.PhoneCategory(idStore,name) values(1,N'SAMSUNG')
insert dbo.PhoneCategory(idStore,name) values(1,N'HUAWEI')
insert dbo.PhoneCategory(idStore,name) values(1,N'XIAOMI')
insert dbo.PhoneCategory(idStore,name) values(1,N'NOKIA')
insert dbo.PhoneCategory(idStore,name) values(1,N'VIVO')
insert dbo.PhoneCategory(idStore,name) values(1,N'OPPO')
insert dbo.PhoneCategory(idStore,name) values(1,N'VSMART')
go

CREATE TABLE Phone
(
	idPhone int not null ,
	
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idItemPhone int not null identity primary key,
	price FLOAT NOT NULL DEFAULT 0,
	
	FOREIGN KEY (idPhone) REFERENCES dbo.PhoneCategory(idPhone) ,
)
GO

insert dbo.Phone(idPhone,name,price) values(1,N'iPhone 7 plus',1400000)
insert dbo.Phone(idPhone,name,price) values(1,N'Air-port s3',1400000)
insert dbo.Phone(idPhone,name,price) values(2 ,N'SamSung galaxy',500000)
insert dbo.Phone(idPhone,name,price) values(2 ,N'Head phone SamSung',500000)

go

go

create proc USP_GetListPhone
as select * from dbo.Phone
go

create proc USP_GetListPhoneCategory
as select * from dbo.PhoneCategory
go

select p.name, p.idPhone, p.price, p.idItemPhone, p.contStart from dbo.Phone p, dbo.PhoneCategory pc where p.idPhone = pc.idPhone and p.idPhone = N'AP'


create proc USP_GetListPhoneCatePhone
as select p.idPhone, p.name, p.idItemPhone, p.price from dbo.Phone p, dbo.PhoneCategory pc where p.idPhone = pc.idPhone
go

--bill
CREATE TABLE Bill
(
	idBill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	idNewBill int not null,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán đủ
	FOREIGN KEY (idNewBill) REFERENCES dbo.NewBill(idNewBill)
)
GO




insert dbo.Bill(idNewBill,DateCheckIn,status) values(5,GETDATE(),1)
insert dbo.Bill(idNewBill,DateCheckIn,status) values(5,GETDATE(),1)
insert dbo.Bill(idNewBill,DateCheckIn,status) values(6,GETDATE(),0)
insert dbo.Bill(idNewBill,DateCheckIn,status) values(6,GETDATE(),0)
select * from dbo.Bill

--bill info
go
create TABLE BillInfo
(	idBillInfo INT IDENTITY PRIMARY KEY,
	idBill int not null,
	idItemPhone int not null default 0  ,
	count INT NOT NULL DEFAULT 0,
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(idBill),
	FOREIGN KEY (idItemPhone) REFERENCES dbo.Phone(idItemPhone)
)
GO



insert dbo.BillInfo(idItemPhone,idBill,count) values(1,1,1)
insert dbo.BillInfo(idItemPhone,idBill,count) values(1,2,2)
insert dbo.BillInfo(idItemPhone,idBill,count) values(1,3,1)
insert dbo.BillInfo(idItemPhone,idBill,count) values(2,4,2)
insert dbo.BillInfo(idItemPhone,idBill,count) values(2,1,2)



select p.name, bi.count, p.price, count*price as TotalPrice  from dbo.BillInfo as bi , dbo.Bill as b, dbo.Phone as P where p.idItemPhone = bi.idItemPhone and bi.idItemPhone = N'IP7Plus'
select * from dbo.BillInfo bi where bi.id = 2 

go

	 ---proc
	 create proc USP_InsertBill
	 @idNewBill int
	 as
	 begin 
		insert dbo.Bill(DateCheckIn,idNewBill,status,discount) values(Getdate(),@idNewBill,0,0)
		
	 end 
	 go

	
	 
		insert dbo.BillInfo(idBill,idItemPhone,count) values(22,100,2)
		insert dbo.BillInfo(idBill,idItemPhone,count) values(26,100,2)


  go

  create proc USP_InsertBillInfo3
	 @idBill int, @idItemPhone int, @count int
	 as 
	 begin

		declare @isExitsBillInfo int;
		declare @phoneCount  int  = 1
		select @isExitsBillInfo = idBillInfo, @phoneCount = b.count  
		from dbo.BillInfo as b 
		where idBill = @idBill and idItemPhone = @idItemPhone

		if(@isExitsBillInfo > 0 )
		begin
			declare @newCount int = @phoneCount + @count 
			if(@newCount > 0 ) 
			update dbo.BillInfo set count = @phoneCount + @count where idItemPhone = @idItemPhone
			else
			delete dbo.BillInfo where idBill = @idBill and idItemPhone = @idItemPhone
		end

		else
			begin
				insert dbo.BillInfo(idBill,idItemPhone,count) values (@idBill,@idItemPhone,@count)
			end 
		end
	 go

  
	 go


	 --triiger
	 create trigger UTG_UpdateBillInfo
	 on dbo.BillInfo for insert, update 
	 as
	 begin
		declare @idBill int
		select @idBill = idBill from inserted
		declare  @idNewBill int
		select @idNewBill = idNewBill from dbo.Bill where idBill = @idBill and status = 0
		update NewBill set status = N'Paying' where idNewBill = @idNewBill
	 end

	 go
	 --
	create trigger UTG_UpdateBill
	 on dbo.Bill for update 
	 as 
	 begin
		declare @idBill int
		select @idBill = idBill from inserted
		declare  @idNewBill int
		select @idNewBill = idNewBill from dbo.Bill where idBill = @idBill 
		declare @count int = 0
		select @count = count(*) from dbo.Bill where idNewBill = @idNewBill and status = 0
		if(@count = 0)
		update dbo.NewBill set status = N'New Bill' where idNewBill = @idNewBill
	 end 
	 go

	 SELECT * FROM dbo.Bill WHERE idNewBill = 23 AND status = 0
	 delete dbo.BillInfo
	 delete dbo.Bill

	 reate proc USP_InsertBillInfo
	 @idBill int, @idFood int, @count int
	 as 
	 begin
		insert dbo.BillInfo(idBill,idFood,count) values (@idBill,@idFood,@count)
	 end
	 go



	 go
	 ----
	

	 select * from dbo.NewBill

	 go
	 alter table dbo.bill
	 add discount int 

	 update dbo.bill set discount  = 0;

	 select * from dbo.Bill

	 select * from dbo.BillInfo

	 go

	 alter table dbo.bill add totalPrice float
	select * from dbo.Bill


	 go
	create  proc USP_GetListBillByDate
	@checkIn date
	as
	begin 
		select n.name as [NewBill 1] , b.totalPrice as [total Price] ,DateCheckIn as [Date Check In], discount  as [discount]
		from dbo.Bill as b,dbo.NewBill as n
		where dateCheckIn > = @checkIn and b.status = 1 and n.idNewBill = b.idNewBill
	end
	 go

	 select * from dbo.bill where datecheckin > = '20201107'

	 select * from dbo.account 
	  
	go
	---
	create proc USP_UpdateAccount
	 @userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
	 as
	 begin
		declare @isRightPass int  = 0
		select @isRightPass = count(*) from dbo.Account where UserName = @userName and PassWord = @password

		if(@isRightPass = 1)
		begin
			if(@newPassword = null or @newPassword = '') 
				begin
					update dbo.Account set DisplayName = @displayName where UserName = @userName
				end
			else
				update dbo.Account set DisplayName =  @displayName, PassWord = @newpassword where UserName = @userName
		end

	 end

go


	 create FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) )
	 RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput 
	 IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) 
	 DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' 
	 +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	 DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
	 BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

	 go

create PROC USP_GetListBillByDateAndPage
@checkIn date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows;
	
	WITH BillShow AS( SELECT b.idBill, n.name AS [Name new bill], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.NewBill AS n
	WHERE DateCheckIn >= @checkIn  AND b.status = 1 AND n.idNewBill = b.idNewBill)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE idBill NOT IN (SELECT TOP (@exceptRows) idBill FROM BillShow)
END
GO


create PROC USP_GetNumBillByDate
@checkIn date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.NewBill AS n
	WHERE DateCheckIn >= @checkIn  AND b.status = 1
	AND n.idNewBill = b.idNewBill
END
GO

select * from dbo.Phone as p, dbo.Bill as b, dbo.BillInfo bi where p.idPhone = bi.idItemPhone  group by p.name

select * from dbo.Phone as p , dbo.BillInfo as bi where p.idItemPhone = bi.idItemPhone group by p.idItemPhone

GO
alter proc USP_GetCountQuanlity
	as
	begin 

						SELECT Phone.name ,sum(BillInfo.count) AS COUNTQUALITY, sum(phone.price) as TotalPrice FROM dbo.BillInfo
						LEFT JOIN dbo.Phone ON Phone.idItemPhone = BillInfo.idItemPhone 
						GROUP BY Phone.name ORDER BY COUNT(BillInfo.count) DESC
	end
 go


 select * from dbo.BillInfo
 select * from dbo.bill
 update 





