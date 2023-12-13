use BTL_db_official

alter table Contact_info drop constraint [FK_user_owner]
insert into Contact_info values
(
'UID123456','CID123456',
N'Dong Hoang Son',
'0911112222',
'son.dongtech@hcmut.edu.vn',
'986','CMT8','5','TB','TPHCM','Vietnam'
)
insert into [User] values
(
'UID123456','Jence','Yatta','0911112222','son.dongtech@hcmut.edu.vn',
'123','UID123456','CID123456'
)
alter table Contact_info add constraint [FK_user_owner] foreign key (user_id) references [User](user_id)

insert into Buyer values('UID123456')

insert into Shop values
(
'SID123456',
'Sell book',
0,1234, 'https://Jence.com', 0,'Jence Book store',default,default
)

insert into Seller values ('UID123456','SID123456')

select dbo.check_login_seller('Jence',null,'123')

insert into Category values('CAT123456','Book',default)

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"To Kill a Mockingbird" by Harper Lee',
@des = 'A timeless classic, "To Kill a Mockingbird" delves into the poignant tale of racial injustice in America. Through the eyes of Scout Finch, the novel explores childhood memories and her father, Atticus Finch''s, legal battle defending an innocent black man.',	
@total_remaining =  100, 
@price	= 150000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"1984" by George Orwell',
@des = 'Orwell''s dystopian masterpiece, "1984," paints a grim picture of a future where government controls every aspect of life and individual consciousness. A thought-provoking exploration of surveillance and totalitarianism.',	
@total_remaining =  200, 
@price	= 200000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"One Hundred Years of Solitude" by Gabriel Garcia Marquez',
@des = 'Set in the extravagant 1920s, "The Great Gatsby" offers a glimpse into a world of opulence and recklessness through the eyes of Nick Carraway. Jay Gatsby, the protagonist, pursues a past love in a tale of unattainable dreams.',	
@total_remaining =  230, 
@price	= 180000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"The Catcher in the Rye" by J.D. Salinger',
@des = 'Marquez''s magnum opus, "One Hundred Years of Solitude," weaves a multi-generational tapestry of the Buendía family in the town of Macondo. Blending reality and magic, the novel explores themes of history, love, and secrets.',	
@total_remaining =  120, 
@price	= 250000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"Sapiens: A Brief History of Humankind" by Yuval Noah Harari',
@des = 'J.D. Salinger''s classic follows the misadventures of Holden Caulfield in New York City as he grapples with issues of growing up and identity. A rebellious teenager''s journey through the challenges of adolescence.',	
@total_remaining = 200, 
@price	=180000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"The Hobbit" by J.R.R. Tolkien',
@des = 'Harari''s insightful exploration, "Sapiens," traces the history of humanity from the era of hunter-gatherers to the modern age, emphasizing cultural, technological, and societal developments.',	
@total_remaining = 300, 
@price	= 300000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"The Alchemist" by Paulo Coelho',
@des = 'Paulo Coelho''s philosophical novel, "The Alchemist," follows the journey of Santiago, a shepherd, in his quest for meaning and the courage to pursue his dreams. A tale of self-discovery and destiny.',	
@total_remaining =  130, 
@price	= 220000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"Brave New World" by Aldous Huxley',
@des = 'Huxley''s futuristic novel, "Brave New World," envisions a society where individuals are controlled through technology and government intervention. A chilling exploration of a dystopian future.',	
@total_remaining = 150, 
@price	= 200000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"The Road" by Cormac McCarthy',
@des = 'McCarthy''s haunting novel, "The Road," depicts the heart-wrenching journey of a father and son through a post-apocalyptic world, facing danger and hardship in search of safety. A powerful narrative of survival and love.',	
@total_remaining = 100, 
@price	=160000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go
declare @newPID varchar(9) = (select dbo.generate_PID() as new);
exec  dbo.insert_product 
@product_id = @newPID,
@name =  '"The Great Gatsby" by F. Scott Fitzgerald',
@des = 'Set in the extravagant 1920s, "The Great Gatsby" offers a glimpse into a world of opulence and recklessness through the eyes of Nick Carraway. Jay Gatsby, the protagonist, pursues a past love in a tale of unattainable dreams.',	
@total_remaining = 200, 
@price	= 190000, 
@cat  = 'CAT123456', 
@sid = 'SID123456', 
@img = null

go

--add variant for first 5 product(special + normal) 
insert into Variant(product_id,variant_name,price,remaining_amount,details)
values
('PID000000','normal',150000,50,'Normal'),
('PID000000','special',200000,30,'Special'),
('PID000016','normal',200000,40,'Normal'),
('PID000016','special',300000,20,'Special'),
('PID000017','normal',180000,100,'Normal'),
('PID000017','special',300000,50,'Special'),
('PID000018','normal',250000,40,'Normal'),
('PID000018','special',400000,10,'Special'),
('PID000019','normal',400000,80,'Normal'),
('PID000019','special',600000,40,'Special')

--add instance (UI)


--add review for first 5 product
insert into Review(review_id,no_stars,content,product_id,user_id)
values
('RID300000',1,'This book is such a mess.','PID000000','UID000001'),
('RID300001',2,'The topic should be considered again.','PID000016','UID000001'),
('RID300002',3,'No offence but this book gives no inspiration.','PID000017','UID000001'),
('RID300003',4,'Reading this book recalls my memory vaguely about my childhood.','PID000018','UID000001'),
('RID300004',5,'This book is outstanding. The publisher should print more of this book.','PID000019','UID000001')
--add order (add order -> add is_contained (many instances) -> add places)
insert into [Order](order_id,[status],no_product,ID_payment,delivery_id)
values
('ORD30000000001','Confirming',1,'PAY000001','DEL000001'),
('ORD30000000002','Confirming',1,'PAY000001','DEL000001'),
('ORD30000000003','Waiting pickup',1,'PAY000001','DEL000002'),
('ORD30000000004','Waiting pickup',1,'PAY000001','DEL000002'),
('ORD30000000005','Delivering',1,'PAY000001','DEL000004'),
('ORD30000000006','Delivering',1,'PAY000001','DEL000004'),
('ORD30000000007','Done',1,'PAY000001','DEL000003'),
('ORD30000000008','Done',1,'PAY000001','DEL000003'),
('ORD30000000009','Cancelled',1,'PAY000001','DEL000005'),
('ORD30000000010','Cancelled',1,'PAY000001','DEL000005'),
('ORD30000000011','Refund',1,'PAY000001','DEL000011'),
('ORD30000000012','Refund',1,'PAY000001','DEL000011')

insert into Is_contained
values
('IID000033','ORD30000000001'),
('IID000040','ORD30000000001'),
('IID000041','ORD30000000002'),
('IID000050','ORD30000000002'),
('IID000051','ORD30000000003'),
('IID000060','ORD30000000003'),
('IID000061','ORD30000000004'),
('IID000072','ORD30000000004'),
('IID000073','ORD30000000005'),
('IID000031','ORD30000000005'),
('IID000042','ORD30000000006'),
('IID000062','ORD30000000006'),
('IID000035','ORD30000000007'),
('IID000045','ORD30000000007'),
('IID000046','ORD30000000008'),
('IID000055','ORD30000000008'),
('IID000056','ORD30000000009'),
('IID000065','ORD30000000009'),
('IID000066','ORD30000000010'),
('IID000077','ORD30000000010'),
('IID000078','ORD30000000011'),
('IID000036','ORD30000000011'),
('IID000047','ORD30000000012'),
('IID000067','ORD30000000012')

insert into Places(order_id,user_id_cart,number)
values
('ORD30000000001','UID000001',1),
('ORD30000000002','UID000001',1),
('ORD30000000003','UID000001',1),
('ORD30000000004','UID000001',1),
('ORD30000000005','UID000001',1),
('ORD30000000006','UID000001',1),
('ORD30000000007','UID000001',1),
('ORD30000000008','UID000001',1),
('ORD30000000009','UID000001',1),
('ORD30000000010','UID000001',1),
('ORD30000000011','UID000001',1),
('ORD30000000012','UID000001',1)

exec dbo.best_selling_store @no_sales_min = 50,@no_product_min = 2

select * from dbo.list_order('UID000001','2022-01-01','2023-12-13')

select * from dbo.sum_revenue('SID123456','2022-01-01','2023-12-13')