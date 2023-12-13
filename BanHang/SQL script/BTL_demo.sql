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

--add order (add order -> add is_contained (many instances) -> add places)