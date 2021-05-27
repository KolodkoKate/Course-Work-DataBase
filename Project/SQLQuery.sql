create database MyDB

use MyDB

create table Users
(
usr_id int not null identity primary key,
usr_name varchar(40) not null,
usr_username varchar(30) not null,
usr_password nvarchar(30) not null,
usr_phone varchar(15) not null,
usr_email varchar(50) not null,
usr_status tinyint not null default 1
)

create procedure st_insertUser
@name varchar(40),
@username varchar(30),
@password nvarchar(30),
@phone varchar(15),
@email varchar(50),
@status tinyint
as
insert into Users
values (@name, @username, @password, @phone, @email, @status)

create procedure st_updateUser
@name varchar(40),
@username varchar(30),
@password nvarchar(30),
@phone varchar(15),
@email varchar(50),
@status tinyint,
@id int
as
update Users
set
usr_name = @name,
usr_username = @username,
usr_password = @password,
usr_phone = @phone,
usr_email = @email,
usr_status = @status
where
usr_id = @id

create procedure st_deleteUser
@id int
as
delete from Users
where usr_id = @id

create procedure st_getUsersData
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status'
from Users u
order by u.usr_name asc

create procedure st_getUsersDataLike
@data varchar(50)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status'
from Users u
where
u.usr_name like '%'+@data+'%'
or
u.usr_username like '%'+@data+'%'
or
u.usr_phone like '%'+@data+'%'
or
u.usr_email like '%'+@data+'%'
or
u.usr_status like '%'+@data+'%'
order by u.usr_name asc

create procedure st_getUserDetails
@username varchar(30),
@password nvarchar(30)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password' from Users u
where
u.usr_username = @username
and
u.usr_password = @password

create table Categories
(
cat_id int not null identity primary key,
cat_name varchar(50) not null,
cat_status tinyint not null
)

create procedure st_insertCategory
@name varchar(50),
@status tinyint
as
insert into Categories values(@name,@status)

create procedure st_updateCategory
@name varchar(50),
@status tinyint,
@id int
as
update Categories
set
cat_name = @name,
cat_status = @status
where
cat_id = @id

create procedure st_deleteCategory
@id int
as
delete from Categories
where cat_id = @id

create procedure st_getCategoriesList
as
select
c.cat_id as 'ID',
c.cat_name as 'Category'
from Categories c
order by c.cat_name asc

create procedure st_getCategoriesData
as
select
c.cat_id as 'ID',
c.cat_name as 'Category',
case when (c.cat_status = 1) then 'Yes' else 'No' end as 'Status'
from Categories c
order by c.cat_name asc

create procedure st_getCategoriesDataLike
@data varchar(50)
as
select
c.cat_id as 'ID',
c.cat_name as 'Category',
case when (c.cat_status = 1) then 'Yes' else 'No' end as 'Status'
from Categories c
where
c.cat_name like '%'+@data+'%'
or
c.cat_status like '%'+@data+'%'
order by c.cat_name asc

create table Products
(
pro_id bigint not null identity primary key,
pro_name varchar(50) not null,
pro_barcode nvarchar(100) not null,
pro_expiryDate date,
pro_categoryID int not null foreign key references Categories(cat_id)
on delete cascade on update cascade
)

create procedure st_insertProduct
@name varchar(50),
@barcode nvarchar(100),
@expiryDate date,
@categoryID int
as
insert into Products values(@name, @barcode, @expiryDate, @categoryID)

create procedure st_updateProduct
@name varchar(50),
@barcode nvarchar(100),
@expiryDate date,
@categoryID int,
@id bigint
as
update Products
set
pro_name = @name,
pro_barcode = @barcode,
pro_expiryDate = @expiryDate,
pro_categoryID = @categoryID
where
pro_id = @id

create procedure st_deleteProduct
@id int
as
delete from Products
where pro_id = @id

create procedure st_getProductsData
as
select
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
format(p.pro_expiryDate, 'dd.MM.yyyy') as 'Expiry_Date',
c.cat_name as 'Category',
c.cat_id as 'Category_ID'
from Products p
inner join Categories c
on c.cat_id = p.pro_categoryID

create procedure st_getProductsDataLike
@data varchar(50)
as
select
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
format(p.pro_expiryDate, 'dd.MM.yyyy') as 'Expiry_Date',
c.cat_name as 'Category',
c.cat_id as 'Category_ID'
from Products p
inner join Categories c
on c.cat_id = p.pro_categoryID
where
p.pro_name like '%'+@data+'%'
or
p.pro_barcode like '%'+@data+'%'
or
format(p.pro_expiryDate, 'dd.MM.yyyy') like '%'+@data+'%'
or
c.cat_name like '%'+@data+'%'
order by p.pro_name asc

create table Suppliers
(
sup_id int not null identity primary key,
sup_company varchar(100) not null unique,
sup_contactPerson varchar(50) not null,
sup_phone varchar(15) not null,
sup_address nvarchar(100) not null,
sup_status tinyint not null
)

create procedure st_insertSupplier
@company varchar(100),
@contactPerson varchar(50),
@phone varchar(15),
@address nvarchar(100),
@status tinyint
as
insert into Suppliers
values (@company, @contactPerson, @phone, @address, @status)

create procedure st_updateSupplier
@company varchar(100),
@contactPerson varchar(50),
@phone varchar(15),
@address nvarchar(100),
@status tinyint,
@id int
as
update Suppliers
set
sup_company = @company,
sup_contactPerson = @contactPerson,
sup_phone = @phone,
sup_address = @address,
sup_status = @status
where
sup_id = @id

create procedure st_deleteSupplier
@id int
as
delete from Suppliers where sup_id = @id

create procedure st_getSuppliersList
as
select
s.sup_id as 'ID',
s.sup_company as 'Company'
from Suppliers s
where
s.sup_status = 1
order by s.sup_company asc

create procedure st_getSuppliersData
as
select
s.sup_id as 'ID',
s.sup_company as 'Company',
s.sup_contactPerson as 'Contact_Person',
s.sup_phone as 'Phone',
s.sup_address as 'Address',
case when (sup_status = 1) then 'Active' else 'In-active' end as 'Status'
from Suppliers s
order by s.sup_company asc

create procedure st_getSuppliersDataLike
@data varchar(50)
as
select
s.sup_id as 'ID',
s.sup_company as 'Company',
s.sup_contactPerson as 'Contact_Person',
s.sup_phone as 'Phone',
s.sup_address as 'Address',
case when (sup_status = 1) then 'Active' else 'In-active' end as 'Status'
from Suppliers s
where
s.sup_company like '%'+@data+'%'
or
s.sup_contactPerson like '%'+@data+'%'
or
s.sup_phone like '%'+@data+'%'
or
s.sup_address like '%'+@data+'%'
or
s.sup_status like '%'+@data+'%'
order by s.sup_company asc

create procedure st_getProductByBarcode
@barcode nvarchar(100)
as
select
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode'
from Products p
where p.pro_barcode = @barcode

create procedure st_getProductByBarcode1
@barcode nvarchar(100)
as
select
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
pp.pp_sellingPrice as 'Selling_Price',
pp.pp_sellingPrice * pp.pp_discount/100 'Discount',
pp.pp_sellingPrice - (pp.pp_sellingPrice * pp.pp_discount/100) as 'Final_Selling_Price'
from Products p
inner join ProductPrice pp
on p.pro_id = pp.pp_productID
where p.pro_barcode = @barcode

create table PurchaseInvoice
(
pi_id bigint not null identity primary key,
pi_date date not null,
pi_doneBy int not null foreign key references Users(usr_id)
on delete cascade on update cascade,
pi_supplierID int not null foreign key references Suppliers(sup_id)
on delete cascade on update cascade
)

create procedure st_insertPurchaseInvoice
@date date,
@doneBy int,
@supplierID int
as
insert into PurchaseInvoice values (@date, @doneBy, @supplierID)

create procedure st_getLastPurchaseID
as
select top 1 pii.pi_id from PurchaseInvoice pii order by pii.pi_id desc

create table PurchaseInvoiceDetails
(
pid_id bigint not null identity primary key,
pid_purchaseID bigint not null foreign key references PurchaseInvoice(pi_id)
on delete cascade on update cascade,
pid_productID bigint not null foreign key references Products(pro_id)
on delete cascade on update cascade,
pid_quantity int not null,
pid_totalPrice money not null
)

create procedure st_insertPurchaseInvoiceDetails
@purchaseID bigint,
@productID bigint,
@quantity int,
@totalPrice money
as
insert into PurchaseInvoiceDetails values (@purchaseID, @productID, @quantity, @totalPrice)

create procedure st_getPurchaseInvoiceList
@month int,
@year int
as
select
pii.pi_id as 'ID',
su.sup_company+' '+format(pii.pi_date,'dd.MM.yyyy') as 'Company'
from PurchaseInvoice pii
inner join Suppliers su
on su.sup_id = pii.pi_supplierID
where month(pii.pi_date) = @month and year(pii.pi_date) = @year

create procedure st_getPurchaseInvoiceDitails
@pid bigint
as
select
pid.pid_id as 'mPID',
pid.pid_productID as 'Product_ID',
p.pro_name as 'Product',
pid.pid_quantity as 'Quantity',
pid.pid_totalPrice as 'Total_Price',
pp.pp_buyingPrice as 'Per_Unit_Price'
from PurchaseInvoice pii
inner join PurchaseInvoiceDetails pid
inner join Products p on p.pro_id = pid.pid_productID
on pii.pi_id = pid.pid_purchaseID
inner join ProductPrice pp
on p.pro_id = pp.pp_productID
where pii.pi_id = @pid

create table Stock
(
st_productID bigint not null unique foreign key references Products(pro_id)
on delete cascade on update cascade,
st_quantity int not null
)

create procedure st_insertStock
@productID bigint,
@quantity int
as
insert into Stock values (@productID,@quantity)

create procedure st_updateStock
@productID int,
@quantity int
as
update Stock
set st_quantity = @quantity
where
st_productID = @productID

create procedure st_getProductQuantity
@productID bigint
as
select s.st_quantity as 'Quantity' from Stock s where s.st_productID = @productID

create table TrackDeletedItemsPI
(
pi_id bigint not null,
usr_id int not null,
pro_id bigint not null foreign key references Products(pro_id)
on delete cascade on update cascade,
pro_quantity int not null,
del_date date not null
)

create procedure st_insertDeletedItemPI
@pi bigint,
@userID int,
@productID bigint,
@quantity int,
@date date
as
insert into TrackDeletedItemsPI values (@pi, @userID, @productID, @quantity, @date)

create procedure st_deleteProductFromPID
@mPID bigint
as
delete from PurchaseInvoiceDetails
where pid_id = @mPID

create procedure st_getAllStock
as
select
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
format(p.pro_expiryDate, 'dd.MM.yyyy') as 'Expiry_Date',
pp.pp_buyingPrice as 'Buying_Price',
pp.pp_sellingPrice as 'Selling_Price',
c.cat_name as 'Category',
s.st_quantity as 'Available_Stock',
case when (s.st_quantity < 50) then 'Low' else case when (s.st_quantity < 100 and s.st_quantity >= 50) then 'Average' else case when (s.st_quantity >= 100) then
'High' end end end as 'Status',
pp.pp_buyingPrice * s.st_quantity as 'Total_Amount'
from Stock s
inner join Products p
on p.pro_id = s.st_productID
inner join Categories c
on c.cat_id = p.pro_categoryID
inner join ProductPrice pp
on p.pro_id = pp.pp_productID

create procedure st_getStocksDataLike
@data varchar(50)
as
select
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
format(p.pro_expiryDate, 'dd.MM.yyyy') as 'Expiry_Date',
pp.pp_buyingPrice as 'Buying_Price',
pp.pp_sellingPrice as 'Selling_Price',
c.cat_name as 'Category',
s.st_quantity as 'Available_Stock',
case when (s.st_quantity < 50) then 'Low' else case when (s.st_quantity < 100 and s.st_quantity >= 50) then 'Average' else case when (s.st_quantity >= 100) then
'High' end end end as 'Status',
pp.pp_buyingPrice * s.st_quantity as 'Total_Amount'
from Stock s
inner join Products p
on p.pro_id = s.st_productID
inner join Categories c
on c.cat_id = p.pro_categoryID
inner join ProductPrice pp
on p.pro_id = pp.pp_productID
where
p.pro_name like '%'+@data+'%'
or
p.pro_barcode like '%'+@data+'%'
or
format(p.pro_expiryDate, 'dd.MM.yyyy') like '%'+@data+'%'
or
pp.pp_buyingPrice like '%'+@data+'%'
or
pp.pp_sellingPrice like '%'+@data+'%'
or
c.cat_name like '%'+@data+'%'
or
s.st_quantity like '%'+@data+'%'
or
case when (s.st_quantity < 50) then 'Low' else case when (s.st_quantity < 100 and s.st_quantity >= 50) then 'Average' else case when (s.st_quantity >= 100) then
'High' end end end like '%'+@data+'%'
or
pp.pp_buyingPrice * s.st_quantity like '%'+@data+'%'
order by p.pro_name asc

create table ProductPrice
(
pp_productID bigint not null unique foreign key references Products(pro_id)
on delete cascade on update cascade,
pp_buyingPrice money not null,
pp_sellingPrice money,
pp_discount float,
pp_profitPercentage float
)

create procedure st_insertProductPrice
@productID bigint,
@buyingPrice money
as
insert into ProductPrice (pp_productID, pp_buyingPrice) values (@productID, @buyingPrice)

create procedure st_updateProductPrice
@productID bigint,
@buyingPrice money,
@sellingPrice money,
@discount float,
@profitPercentage float
as
update ProductPrice
set
pp_buyingPrice = @buyingPrice,
pp_sellingPrice = @sellingPrice,
pp_discount = @discount,
pp_profitPercentage = @profitPercentage
where
pp_productID = @productID

create procedure st_getProductsWRTCategory
@categoryID int
as
select
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
pp.pp_buyingPrice as 'Buying_Price',
case when (pp.pp_sellingPrice is null) then 0 else pp.pp_sellingPrice end as 'Selling_Price',
case when (pp.pp_discount is null) then 0 else pp.pp_discount end as 'Discount',
case when (pp.pp_profitPercentage is null) then 0 else pp.pp_profitPercentage end as 'Profit_Percentage'
from Products p
inner join ProductPrice pp
on p.pro_id = pp.pp_productID
inner join Categories c
on c.cat_id = p.pro_categoryID
where c.cat_id = @categoryID

create procedure st_checkProductPriceExist
@productID bigint
as
select * from ProductPrice where pp_productID = @productID

create procedure st_updateProductPrice1
@productID bigint,
@buyingPrice money
as
update ProductPrice
set
pp_buyingPrice = @buyingPrice
where
pp_productID = @productID

create procedure getProductStockWRTProID
@productID int
as
select s.st_quantity from Stock s where s.st_productID = @productID

create table Sales
(
sal_id bigint not null identity primary key,
sal_doneBy int not null foreign key references Users(usr_id),
sal_date datetime not null,
sal_totalAmount float not null,
sal_totalDiscount float not null,
sal_amountGiven float not null,
sal_amountReturned float not null,
sal_payType tinyint not null
)

create procedure st_insertSales
@doneBy int,
@date datetime,
@totalAmount float,
@totalDiscount float,
@amountGiven float,
@amountReturned float,
@payType tinyint
as
insert into Sales values (@doneBy, @date, @totalAmount, @totalDiscount, @amountGiven, @amountReturned, @payType)

create procedure st_getSalesID
as
select top 1 s.sal_id as 'Sale_ID' from Sales s order by s.sal_id desc

create table SalesDetails
(
sd_saleID bigint not null foreign key references Sales(sal_id)
on delete no action on update no action,
sd_productID bigint not null,
sd_quantity int,
sd_sellingPrice money,
sd_discount float
)

create procedure st_insertSalesDetails
@saleID bigint,
@productID bigint,
@quantity int,
@sellingPrice money,
@discount float
as
insert into SalesDetails values (@saleID, @productID, @quantity, @sellingPrice, @discount)

create procedure st_getSalesReceipt
@user int
as
select
s.sal_id as 'Sale_ID',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product',
sd.sd_quantity as 'Quantity',
sd.sd_sellingPrice as 'Product_Price',
sd.sd_discount*sd.sd_quantity as 'Total_Per_Product_Discount',
(sd.sd_sellingPrice*sd.sd_quantity) as 'Per_Product_Total',
s.sal_totalDiscount as 'Total_Discount',
s.sal_totalAmount as 'Total_Amount',
s.sal_amountGiven as 'Amount_Given',
s.sal_amountReturned as 'Amount_Returned',
format(s.sal_date, 'dd.MM.yyyy hh:mm:ss tt') as 'Date',
u.usr_name as 'User',
case when (s.sal_payType = 0) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_payType = 2) then 'Credit Card' end end end as 'Pay_Type'
from Sales s inner join
SalesDetails sd
on s.sal_id = sd.sd_saleID
inner join Products p
on p.pro_id = sd.sd_productID
inner join ProductPrice pp
on pp.pp_productID = p.pro_id
inner join Users u
on u.usr_id = s.sal_doneBy
where s.sal_id = (select top 1 ss.sal_id from Sales ss order by ss.sal_id desc)
and u.usr_id = @user
order by s.sal_id desc

create table RefundsReturns
(
ref_saleID bigint not null foreign key references Sales(sal_id)
on delete no action on update no action,
ref_date datetime not null,
ref_doneBy int not null,
ref_productID bigint not null,
ref_quantity tinyint not null,
ref_amount money not null
)

create procedure st_insertReturnRefund
@saleID bigint,
@date datetime,
@doneBy int,
@productID bigint,
@quantity tinyint,
@amount money
as
insert into RefundsReturns
values (@saleID, @date, @doneBy, @productID, @quantity, @amount)

create procedure st_getDailySales
@date date
as
select distinct
s.sal_id as 'Sale_ID',
s.sal_totalAmount as 'Total_Amount',
s.sal_amountGiven as 'Amount_Given',
s.sal_amountReturned as 'Returned_Amount',
u.usr_name as 'User',
u.usr_id as 'User_ID',
s.sal_totalDiscount as 'Total_Discount'
from Sales s
inner join SalesDetails sd
on s.sal_id = sd.sd_saleID
inner join Users u
on u.usr_id = s.sal_doneBy
where convert(date, s.sal_date) = @date

create procedure st_getSalesReceiptWRTSalesID
@saleID bigint
as
select
s.sal_id as 'Sale_ID',
p.pro_barcode as 'Barcode',
p.pro_id as 'Product_ID',
p.pro_name as 'Product',
sd.sd_quantity as 'Quantity',
round(sd.sd_sellingPrice,0) as 'Product_Price',
round(sd.sd_discount,0) as 'Product_Discount',
round(sd.sd_discount,0) as 'Total_Per_Product_Discount',
round((sd.sd_sellingPrice*sd.sd_quantity),0) as 'Per_Product_Total',
s.sal_totalDiscount as 'Total_Discount',
s.sal_totalAmount as 'Total_Amount',
s.sal_amountGiven as 'Amount_Given',
s.sal_amountReturned as 'Amount_Returned',
format(s.sal_date, 'dd.MM.yyyy hh:mm:ss tt') as 'Date',
u.usr_name as 'User',
case when (s.sal_payType = 0) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_payType = 2) then 'Credit Card' end end end as 'Pay_Type'
from Sales s
inner join SalesDetails sd
on s.sal_id = sd.sd_saleID
inner join Products p
on p.pro_id = sd.sd_productID
inner join ProductPrice pp
on pp.pp_productID = p.pro_id
inner join Users u
on u.usr_id = s.sal_doneBy
where s.sal_id = @saleID
order by s.sal_id desc

create procedure st_getRefundInvoice
@saleID bigint
as
set @saleID = (select top 1 r.ref_saleID from RefundReturns r order by r.ref_date desc)
select distinct
s.sal_id as 'Sale_ID',
p.pro_name as 'Product',
round(sd.sd_sellingPrice,0) as 'Selling_Price',
round(sd.sd_discount,0) as 'Discount',
r.ref_quantity as 'Quantity',
r.ref_amount as 'Amount_Refund',
u.usr_name as 'User',
format(r.ref_date, 'dd.MM.yyyy hh:mm:ss tt') as 'Date'
from RefundsReturns r
inner join Products p
on p.pro_id = r.ref_productID
inner join Sales s
on s.sal_id = r.ref_saleID
inner join Users u
on u.usr_id = r.ref_doneBy
inner join SalesDetails sd
on p.pro_id = sd.sd_productID
where r.ref_saleID = @saleID

create procedure st_updateQuantityInSalesDetails
@quantity tinyint,
@saleID bigint
as
update SalesDetails
set
sd_quantity = @quantity
where
sd_saleID = @saleID

create procedure st_getCompleteSalesDetails
@date date = null,
@month tinyint = null,
@year int = null
as
if(@date is not null and @month is null and @year is null)
begin
select s.sal_id as 'Sale_ID',
s.sal_totalAmount as 'Total_Amount',
u.usr_name as 'User',
format(s.sal_date, 'dd.MM.yyyy') as 'Date',
case when(s.sal_payType = 0) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_payType = 2) then 'Credit Card' end end end as 'Payment_Type',
s.sal_amountGiven as 'Amount_Recieved',
s.sal_amountReturned as 'Amount_Return'
from Sales s
inner join SalesDetails sd
on s.sal_id = sd.sd_saleID
inner join Users u
on u.usr_id = s.sal_doneBy
where
s.sal_date = @date
group by s.sal_id, u.usr_name, s.sal_date, s.sal_payType, s.sal_amountGiven, s.sal_amountReturned, s.sal_totalAmount
end
else if(@date is null and @month is not null and @year is not null)
begin
select s.sal_id as 'Sale_ID',
s.sal_totalAmount as 'Total_Amount',
u.usr_name as 'User',
format(s.sal_date, 'dd.MM.yyyy') as 'Date',
case when(s.sal_payType = 0) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_payType = 2) then 'Credit Card' end end end as 'Payment_Type',
s.sal_amountGiven as 'Amount_Recieved',
s.sal_amountReturned as 'Amount_Return'
from Sales s
inner join SalesDetails sd
on s.sal_id = sd.sd_saleID
inner join Users u
on u.usr_id = s.sal_doneBy
where
month(s.sal_date) = @month
and
year(s.sal_date) = @year
group by s.sal_id, u.usr_name, s.sal_date, s.sal_payType, s.sal_amountGiven, s.sal_amountReturned, s.sal_totalAmount
end
else if(@date is null and @month is null and @year is not null)
begin
select s.sal_id as 'Sale_ID',
s.sal_totalAmount as 'Total_Amount',
u.usr_name as 'User',
format(s.sal_date, 'dd.MM.yyyy') as 'Date',
case when(s.sal_payType = 0) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_payType = 2) then 'Credit Card' end end end as 'Payment_Type',
s.sal_amountGiven as 'Amount_Recieved',
s.sal_amountReturned as 'Amount_Return'
from Sales s
inner join SalesDetails sd
on s.sal_id = sd.sd_saleID
inner join Users u
on u.usr_id = s.sal_doneBy
where
year(s.sal_date) = @year
group by s.sal_id, u.usr_name, s.sal_date, s.sal_payType, s.sal_amountGiven, s.sal_amountReturned, s.sal_totalAmount
end