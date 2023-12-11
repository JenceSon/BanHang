use BTL_db_official_demo

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


Select minimum_price from Product where product_id = 'PID000001'