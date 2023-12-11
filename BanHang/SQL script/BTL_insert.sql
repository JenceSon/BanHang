use BTL_db_official


--insert User done
INSERT INTO [User] VALUES ('UID100013', 'son_0175', 'son_0175', '0167502421', 'son_0175@gmail.com', '12345678', 'UID100013', 'CID100013');
INSERT INTO [User] VALUES ('UID100046', 'tong_01', 'tong_01', '0854342531', 'tong_01@gmail.com', '12345678', 'UID100046', 'CID100046');
INSERT INTO [User] VALUES ('UID100049', 'hoangaaa', 'hoangaaa', '0761712741', 'hoangaaa@gmail.com', '12345678', 'UID100049', 'CID100049');
INSERT INTO [User] VALUES ('UID100052', 'tungbbb', 'tiem_giat_ui', '0075948675', 'tungbbb@gmail.com', '12345678', 'UID100052', 'CID100052');
INSERT INTO [User] VALUES ('UID100074', 'huanccc', 'banh_trang_00', '0345138094', 'huanccc@gmail.com', '12345678', 'UID100074', 'CID100074');
INSERT INTO [User] VALUES ('UID100083', 'sonddd', 'secondhand_gau', '0429363132', 'sonddd@gmail.com', '12345678', 'UID100083', 'CID100083');

INSERT INTO [dbo].[User]([user_id], [user_id_contact], [user_name], [nickname], [linking_phone_number], [linking_email], [password], [contact_id]) VALUES 
('UID000001', 'UID000001', 'NguyenHuan', 'huan2114', '0356382638', 'huan1122@gmail.com', 'nothing@@ink', 'CID000001'),
('UID000002', 'UID000002', 'JohnDoe', 'johndoe123', '0234567890', 'john.doe@gmail.com', 'securePass123', 'CID000002'),
('UID000003', 'UID000003', 'AliceSmith', 'ali_smith', '0876543210', 'alice.smith@gmail.com', 'strongPassword', 'CID000003'),
('UID000004', 'UID000004', 'BobJohnson', 'bobJ', '0512345678', 'bob.j@gmail.com', 'pass1234', 'CID000004'),
('UID000005', 'UID000005', 'EmilyJones', 'emily_j', '0367890123', 'emily.jones@gmail.com', 'mySecurePassword', 'CID000005'),
('UID000006', 'UID000006', 'DavidMiller', 'david_m', '0890123456', 'david.miller@gmail.com', 'p@ssw0rd', 'CID000006'),
('UID000007', 'UID000007', 'SophiaBrown', 'sophia_b', '0345678901', 'sophia.brown@gmail.com', 'brownie123', 'CID000007'),
('UID000008', 'UID000008', 'DanielWhite', 'danW', '0765432109', 'daniel.white@gmail.com', 'danielPass', 'CID000008'),
('UID000009', 'UID000009', 'OliviaDavis', 'olivia_d', '0210987654', 'olivia.davis@gmail.com', 'oliviaPassword', 'CID000009'),
('UID000010', 'UID000010', 'WilliamWilson', 'willW', '0087654321', 'william.w@gmail.com', 'wilsonPass', 'CID000010'),
('UID000011', 'UID000011', 'AvaTaylor', 'ava_t', '0357924680', 'ava.taylor@gmail.com', 'taylor123', 'CID000011');

--insert Contact_info done
INSERT INTO Contact_info VALUES ('UID100013', 'CID100013', 'Dong Hoang Son', '0167502421', 'son_0175@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100052', 'CID100052', 'Duy Tung', '0075948675', 'tungbbb@gmail.com', 248, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100074', 'CID100074', 'Ngoc Huan', '0345138094', 'huanccc@gmail.com', 13, 'Tan Lap, khu pho 6', 'Linh Trung', 'Thu Duc', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100046', 'CID100046', 'Dinh Tong', '0854342531', 'tong_01@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100083', 'CID100083', 'Dinh Hong Son', '0429363132', 'sonddd@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100049', 'CID100049', 'Minh Hoang', '0761712741', 'hoangaaa@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100013', 'CID100113', 'Dong Hoang Son', '0273332234', 'son_0175@gmail.com', 1, 'ki tuc xa khu A, khu pho 6', 'Linh Trung', 'Thu Duc', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100013', 'CID100213', 'Dong Hoang Son', '0375024240', 'son_0175@gmail.com', 12, 'Dong Nai', 'phuong 10', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100052', 'CID100152', 'Duy Tung', '0075948675', 'tungbbb@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');

INSERT INTO [dbo].[Contact_info]([user_id], [contact_id], [full_name], [phone_number], [email], [number], [street], [ward], [district], [city], [country]) VALUES
('UID000001', 'CID000001', 'Nguyen Huan', '0356382638', 'huan1122@gmail.com', 20, 'Ta Quang Buu', 'Dong Hoa', 'Di An', 'Binh Duong', 'Vietnam'),
('UID000002', 'CID000002', 'John Doe', '0234567890', 'john.doe@gmail.com', 25, 'Main St', 'West', 'Central', 'Cityville', 'USA'),
('UID000003', 'CID000003', 'Alice Smith', '0876543210', 'alice.smith@gmail.com', 30, 'Oak Ave', 'East', 'Suburbia', 'Townsville', 'USA'),
('UID000004', 'CID000004', 'Bob Johnson', '0512345675', 'bob.j@gmail.com', 15, 'Elm St', 'North', 'Downtown', 'Metropolis', 'USA'),
('UID000005', 'CID000005', 'Emily Jones', '0367890123', 'emily.jones@gmail.com', 40, 'Maple St', 'South', 'Village', 'Ruraltown', 'USA'),
('UID000006', 'CID000006', 'David Miller', '0890123456', 'david.miller@gmail.com', 10, 'Cedar St', 'West', 'Central', 'Cityville', 'USA'),
('UID000007', 'CID000007', 'Sophia Brown', '0345678901', 'sophia.brown@gmail.com', 35, 'Pine St', 'East', 'Suburbia', 'Townsville', 'USA'),
('UID000008', 'CID000008', 'Daniel White', '0765432109', 'daniel.white@gmail.com', 5, 'Willow St', 'North', 'Downtown', 'Metropolis', 'USA'),
('UID000009', 'CID000009', 'Olivia Davis', '0210987654', 'olivia.davis@gmail.com', 45, 'Birch St', 'South', 'Village', 'Ruraltown', 'USA'),
('UID000010', 'CID000010', 'William Wilson', '0087654321', 'william.w@gmail.com', 15, 'Spruce St', 'West', 'Central', 'Cityville', 'USA'),
('UID000011', 'CID000011', 'Ava Taylor', '0357924680', 'ava.taylor@gmail.com', 50, 'Cherry St', 'East', 'Suburbia', 'Townsville', 'USA');

--insert Follow done
INSERT INTO Follow VALUES ('UID100013','UID100049');
INSERT INTO Follow VALUES ('UID100049','UID100013');
INSERT INTO Follow VALUES ('UID100049','UID100083');
INSERT INTO Follow VALUES ('UID100049','UID100052');
INSERT INTO Follow VALUES ('UID100049','UID100074');
INSERT INTO Follow (follower_id, following_id)
VALUES
('UID000002', 'UID000003'),
('UID000002', 'UID000004'),
('UID000003', 'UID000002'),
('UID000003', 'UID000005'),
('UID000004', 'UID000002'),
('UID000004', 'UID000006'),
('UID000005', 'UID000002'),
('UID000005', 'UID000007'),
('UID000006', 'UID000002'),
('UID000006', 'UID000008'),
('UID000007', 'UID000002'),
('UID000007', 'UID000009'),
('UID000008', 'UID000002'),
('UID000008', 'UID000010'),
('UID000009', 'UID000002'),
('UID000009', 'UID000011'),
('UID000010', 'UID000002'),
('UID000011', 'UID000002'),
('UID000011', 'UID000004');

--insert Buyer done
INSERT INTO Buyer VALUES ('UID100013');
INSERT INTO Buyer VALUES ('UID100046');
INSERT INTO Buyer VALUES ('UID100049');
INSERT INTO Buyer VALUES ('UID100052');
INSERT INTO Buyer VALUES ('UID100074');
INSERT INTO Buyer VALUES ('UID100083');

INSERT INTO Buyer (user_id)
VALUES
('UID000001'),
('UID000002'),
('UID000003'),
('UID000004'),
('UID000005'),
('UID000006'),
('UID000007'),  -- Seller and Buyer
('UID000008'),  -- Seller and Buyer
('UID000009'),  -- Seller and Buyer
('UID000010'),  -- Seller and Buyer
('UID000011');  -- Seller and Buyer

--insert Shopping_cart done
INSERT INTO Shopping_cart VALUES ('UID100013', 1, 0, CONVERT(datetime, '14-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100046', 1, 0, CONVERT(datetime, '15-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100049', 1, 0, CONVERT(datetime, '16-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100052', 1, 0, CONVERT(datetime, '18-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100074', 1, 0, CONVERT(datetime, '19-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100083', 1, 0, CONVERT(datetime, '14-06-2023', 105));

INSERT INTO Shopping_cart (user_id, number, no_product)
VALUES
('UID000001', 1, 0),
('UID000002', 2, 0),
('UID000003', 3, 0),
('UID000004', 4, 0),
('UID000005', 5, 0);


--insert Shop done
--delete Shop
INSERT INTO Shop VALUES ('SID100052', 'Sell something to wash clothes', 0, 0, 'https://Tiemgiatui.com', 0, 'Tiem giat ui', '2023-02-15',default);
INSERT INTO Shop VALUES ('SID100074', 'Super yummy thing called banh trang cuon bo tu Viet Nam', 0, 0, 'https://Banhtrang.com', 0, 'Banh trang', '2023-03-20',default);
INSERT INTO Shop VALUES ('SID100083', 'Moniso official secondhand', 0, 0, 'https://secondHandShop.com', 0, 'Cua hang second hand','2023-05-05',default);
INSERT INTO Shop VALUES ('SIDffffff', default, 0, 0, 'https://ignore.com', 0, 'ALL SHOPS',default,default); --ignore row


INSERT INTO Shop (shop_id, bio, no_following, no_follower, url_link, rating, name, date_joined,no_product)
VALUES
('SID000001', 'Fashion paradise offering the latest trends.', 100, 500, 'https://ChicBoutique.com', 4.5, 'Chic Boutique', '2023-01-01',default),
('SID000002', 'Handcrafted treasures for your home.', 150, 300, 'https://ArtisanHaven.com', 3.8, 'Artisan Haven', '2023-02-15',default),
('SID000003', 'Explore tech innovations at our electronic hub.', 200, 700, 'https://GadgetGalaxy.com', 4.2, 'Gadget Galaxy', '2023-03-20',default),
('SID000004', 'Books, coffee, and cozy corners - your reading escape.', 50, 100, 'https://BookNook.com', 4.0, 'Book Nook', '2023-04-10',default),
('SID000005', 'Outdoor gear and adventure essentials.', 80, 200, 'https://AdventureOut.com', 4.8, 'Adventure Out', '2023-05-05',default);


--insert Seller done
INSERT INTO Seller VALUES ('UID100052', 'SID100052');
INSERT INTO Seller VALUES ('UID100074', 'SID100074');
INSERT INTO Seller VALUES ('UID100083', 'SID100083');
INSERT INTO Seller (user_id, shop_id)
VALUES
('UID000002', 'SID000001'),
('UID000003', 'SID000002'),
('UID000004', 'SID000003'),
('UID000005', 'SID000004'),
('UID000006', 'SID000005');

--insert Shop_phone_number done
INSERT INTO Shop_phone_number VALUES ('SID100052', '0075948675');
INSERT INTO Shop_phone_number VALUES ('SID100074', '0345138094');
INSERT INTO Shop_phone_number VALUES ('SID100083', '0429363132');

INSERT INTO Shop_phone_number (shop_id, phone_number)
VALUES
('SID000001', '0234567890'),
('SID000002', '0876543210'),
('SID000003', '0512345675'),
('SID000004', '0512345678'),
('SID000005', '0890123456');


--insert Shop_address done
INSERT INTO Shop_address VALUES ('SID100052', 248, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Shop_address VALUES ('SID100074', 13, 'Tan Lap, khu pho 6', 'Linh Trung', 'Thu Duc', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Shop_address VALUES ('SID100083', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');

INSERT INTO Shop_address (shop_id, number, street, ward, district, city, country)
VALUES
('SID000001', 20, 'Main St', 'Downtown', 'Central', 'Cityville', 'USA'),
('SID000002', 30, 'Oak Ave', 'Suburbia', 'East', 'Townsville', 'USA'),
('SID000003', 15, 'Elm St', 'Downtown', 'North', 'Metropolis', 'USA'),
('SID000004', 40, 'Maple St', 'Village', 'South', 'Ruraltown', 'USA'),
('SID000005', 10, 'Cedar St', 'Central', 'West', 'Cityville', 'USA');



--insert Category done
INSERT INTO Category VALUES('CAT000010', 'Household',default);
INSERT INTO Category VALUES('CAT000011', 'Market',default);
INSERT INTO Category VALUES('CAT000012', 'Beauty',default);
INSERT INTO Category VALUES('CAT000013', 'Women Clothes',default);
INSERT INTO Category VALUES('CAT000014', 'Men Clothes',default);
INSERT INTO Category VALUES('CATffffff', 'ALL CATEGORIES',default); --ignore row

INSERT INTO Category (category_id, category_name)
VALUES
('CAT000001', 'Footwear'),
('CAT000002', 'Apparel'),
('CAT000003', 'Electronics'),
('CAT000004', 'Home Decor'),
('CAT000005', 'Outdoor Gear'),
('CAT000006', 'Jewelry');

--insert Product_name done
--delete Product
INSERT INTO Product VALUES ('PID144103', default, 'Nuoc xa Domy', 0, 0, 47000, 47000, 'CAT000010', 'SID100052', null);
INSERT INTO Product VALUES ('PID110464', default, 'Nuoc xa Comfo', 0, 0, 52000, 69000, 'CAT000010', 'SID100052', null);
INSERT INTO Product VALUES ('PID138894', default, 'Bot giat Omo', 0, 0, 14000, 14000, 'CAT000010', 'SID100052', null);
INSERT INTO Product VALUES ('PID186682', default, 'Banh trang', 0, 0, 24000, 112000, 'CAT000011', 'SID100074', null);
INSERT INTO Product VALUES ('PID163853', default, 'Bo beo', 0, 0, 5000, 20000, 'CAT000011', 'SID100074', null);

INSERT INTO Product (product_id, description, name, total_remaining, no_sales, minimum_price, maximum_price, category_id, shop_id)
VALUES
('PID000001', 'Stylish and comfortable.', 'Comfort Shoes', 100, 50, 29000.99, 69000.99, 'CAT000001', 'SID000001'),
('PID000002', 'A classic addition to your wardrobe.', 'Casual Shirt', 80, 30, 19000.95, 49000.95, 'CAT000002', 'SID000002'),
('PID000003', 'High-performance electronics.', 'Smartphone', 150, 100, 89000.99, 199000.99, 'CAT000003', 'SID000003'),
('PID000004', 'Perfect for cozy evenings.', 'Candle Holder', 50, 20, 9000.99, 24000.99, 'CAT000004', 'SID000004'),
('PID000005', 'Outdoor adventure essentials.', 'Camping Gear', 120, 70, 49000.99, 99000.99, 'CAT000005', 'SID000005'),
('PID000006', 'Unique and stylish design.', 'Necklace', 60, 40, 34000.99, 74000.99, 'CAT000006', 'SID000001'),
('PID000007', 'A modern twist on a classic.', 'Leather Wallet', 90, 60, 24000.95, 59000.95, 'CAT000002', 'SID000002'),
('PID000008', 'Efficient and reliable.', 'Laptop', 110, 80, 19000.99, 1449000.99, 'CAT000003', 'SID000003'),
('PID000009', 'Elegant and functional.', 'Table Lamp', 40, 15, 44000.99, 89000.99, 'CAT000004', 'SID000004'),
('PID000010', 'Stay hydrated on the go.', 'Water Bottle', 70, 25, 9000.99, 29000.99, 'CAT000005', 'SID000005'),
('PID000011', 'Perfect for everyday wear.', 'Sneakers', 90, 60, 39000.99, 79000.99, 'CAT000001', 'SID000001'),
('PID000012', 'A versatile addition to any outfit.', 'Denim Jeans', 120, 80, 29000.95, 69000.95, 'CAT000002', 'SID000002'),
('PID000013', 'Capture every moment.', 'Digital Camera', 30, 15, 149000.99, 499000.99, 'CAT000003', 'SID000003'),
('PID000014', 'Create a cozy atmosphere.', 'Throw Blanket', 65, 35, 14000.99, 34000.99, 'CAT000004', 'SID000004'),
('PID000015', 'Gear up for your next adventure.', 'Hiking Boots', 100, 50, 59000.99, 119000.99, 'CAT000005', 'SID000005');

--update Product_name
--set minimum_price = 0, maximum_price = 0

--insert Variant done
--delete Variant
INSERT INTO Variant VALUES ('PID110464', '500g', 52000, 2, default,null);
INSERT INTO Variant VALUES ('PID110464', '1kg', 69000, 3, default, null);
INSERT INTO Variant VALUES ('PID186682', 'Combo1', 24000, 4, default, null);
INSERT INTO Variant VALUES ('PID186682', 'Combo2', 112000, 5, default, null);
INSERT INTO Variant VALUES ('PID163853', '100g', 5000, 5, default,null);
INSERT INTO Variant VALUES ('PID163853', '500g', 20000, 8, default, null);

INSERT INTO Variant (product_id, Variant_name, price, remaining_amount, details)
VALUES
('PID000001', 'Standard', 49000.99, 50, 'Standard Variant of Comfort Shoes.'),
('PID000001', 'Premium', 69000.99, 30, 'Premium Variant with extra comfort features.'),
('PID000002', 'Classic Fit', 29000.95, 40, 'Classic fit Casual Shirt for everyday wear.'),
('PID000002', 'Slim Fit', 49000.95, 20, 'Slim fit Casual Shirt for a modern look.'),
('PID000003', '32GB', 89000.99, 100, '32GB Variant of Smartphone with advanced features.'),
('PID000003', '64GB', 119000.99, 50, '64GB Variant with extended storage capacity.'),
('PID000004', 'Copper', 14000.99, 30, 'Copper Candle Holder for a rustic touch.'),
('PID000004', 'Silver', 24000.99, 20, 'Silver Candle Holder for a sleek look.'),
('PID000005', 'Basic Kit', 49000.99, 80, 'Basic Camping Gear for outdoor enthusiasts.'),
('PID000005', 'Deluxe Kit', 99000.99, 40, 'Deluxe Camping Gear with additional features.'),
('PID000006', 'Statement Piece', 34000.99, 25, 'Statement Necklace with unique design.'),
('PID000006', 'Classic', 74000.99, 15, 'Classic Elegance Necklace for formal occasions.'),
('PID000007', 'Bifold', 24000.95, 50, 'Bifold Leather Wallet for everyday use.'),
('PID000007', 'Trifold', 59000.95, 30, 'Trifold Leather Wallet with multiple compartments.'),
('PID000008', 'Basic Model', 19000.99, 70, 'Basic Laptop for everyday tasks.'),
('PID000008', 'Pro Model', 1449000.99, 20, 'Pro Laptop with advanced specifications.'),
('PID000009', 'Modern Design', 44000.99, 15, 'Modern Table Lamp for contemporary spaces.'),
('PID000009', 'Vintage Style', 89000.99, 25, 'Vintage Style Lamp for a touch of nostalgia.'),
('PID000010', 'Classic Blue', 9000.99, 45, 'Classic Blue Water Bottle for on-the-go hydration.'),
('PID000010', 'Stainless Steel', 29000.99, 25, 'Stainless Steel Water Bottle for durability.'),
('PID000011', 'Athletic Style', 39000.99, 30, 'Athletic Style Sneakers for active lifestyles.'),
('PID000011', 'Casual Comfort', 79000.99, 20, 'Casual Comfort Sneakers for everyday wear.'),
('PID000012', 'Relaxed Fit', 29000.95, 35, 'Relaxed Fit Denim Jeans for comfortable style.'),
('PID000012', 'Skinny Fit', 69000.95, 15, 'Skinny Fit Denim Jeans for a modern look.'),
('PID000013', 'Pro Camera', 149000.99, 10, 'Pro Digital Camera for professional photography.'),
('PID000013', 'Compact Camera', 499000.99, 20, 'Compact Digital Camera for on-the-go shooting.'),
('PID000014', 'Cozy Plaid', 14000.99, 15, 'Cozy Plaid Throw Blanket for chilly evenings.'),
('PID000014', 'Luxury Velvet', 34000.99, 10, 'Luxury Velvet Throw Blanket for added comfort.'),
('PID000015', 'Trailblazer', 59000.99, 25, 'Trailblazer Hiking Boots for outdoor adventures.'),
('PID000015', 'Explorer', 119000.99, 15, 'Explorer Hiking Boots for the adventurous spirit.');


--insert Product_instance done
INSERT INTO Product_instance VALUES ('IID080466', 47000, 'PID144103');
INSERT INTO Product_instance VALUES ('IID080467', 47000, 'PID144103');
INSERT INTO Product_instance VALUES ('IID080468', 47000, 'PID144103');
INSERT INTO Product_instance VALUES ('IID080469', 47000, 'PID144103');
INSERT INTO Product_instance VALUES ('IID080460', 47000, 'PID144103');
INSERT INTO Product_instance VALUES ('IID684325', 52000, 'PID110464');
INSERT INTO Product_instance VALUES ('IID694971', 69000, 'PID110464');
INSERT INTO Product_instance VALUES ('IID691489', 14000, 'PID138894');
INSERT INTO Product_instance VALUES ('IID339757', 24000, 'PID186682');
INSERT INTO Product_instance VALUES ('IID270747', 112000, 'PID186682');
INSERT INTO Product_instance VALUES ('IID774582', 5000, 'PID163853');
INSERT INTO Product_instance VALUES ('IID757288', 20000, 'PID163853');

INSERT INTO Product_instance (instance_id, current_price, product_id)
VALUES
-- Existing rows
('IID000001', 49000.99, 'PID000001'),
('IID000002', 29000.95, 'PID000002'),
('IID000003', 99000.99, 'PID000003'),
('IID000004', 14000.99, 'PID000004'),
('IID000005', 79000.99, 'PID000005'),
-- Additional rows for Belong_to
('IID000006', 39000.99, 'PID000006'),
('IID000007', 59000.95, 'PID000007'),
('IID000008', 19000.99, 'PID000008'),
('IID000009', 44000.99, 'PID000009'),
('IID000010', 69000.99, 'PID000010'),
('IID000011', 34000.99, 'PID000011'),
('IID000012', 24000.95, 'PID000012'),
('IID000013', 89000.99, 'PID000013'),
('IID000014', 54000.99, 'PID000014'),
('IID000015', 49000.99, 'PID000015'),
('IID000016', 69000.99, 'PID000001'), -- Adjusted price for 'Premium' version
('IID000017', 29000.95, 'PID000002'), -- Adjusted price for 'Classic Fit' version
('IID000018', 49000.95, 'PID000002'), -- Adjusted price for 'Slim Fit' version
('IID000019', 89000.99, 'PID000003'), -- Adjusted price for '32GB' version
('IID000020', 119000.99, 'PID000003'), -- Adjusted price for '64GB' version
('IID000021', 14000.99, 'PID000004'), -- Adjusted price for 'Copper' version
('IID000022', 24000.99, 'PID000004'), -- Adjusted price for 'Silver' version
('IID000023', 49000.99, 'PID000005'), -- Adjusted price for 'Basic Kit' version
('IID000024', 99000.99, 'PID000005'), -- Adjusted price for 'Deluxe Kit' version
('IID000025', 34000.99, 'PID000006'), -- Adjusted price for 'Statement Piece' version
('IID000026', 74000.99, 'PID000006'), -- Adjusted price for 'Classic Elegance' version
('IID000027', 24000.95, 'PID000007'), -- Adjusted price for 'Bifold' version
('IID000028', 59000.95, 'PID000007'), -- Adjusted price for 'Trifold' version
('IID000029', 19000.99, 'PID000008'), -- Adjusted price for 'Basic Model' version
('IID000030', 1449000.99, 'PID000008'); -- Adjusted price for 'Pro Model' version


--Insert Belong_to done
INSERT INTO Belong_to VALUES ('IID684325', 'PID110464', '500g');
INSERT INTO Belong_to VALUES ('IID694971', 'PID110464', '1kg');
INSERT INTO Belong_to VALUES ('IID339757', 'PID186682', 'Combo1');
INSERT INTO Belong_to VALUES ('IID270747', 'PID186682', 'Combo2');
INSERT INTO Belong_to VALUES ('IID774582', 'PID163853', '100g');
INSERT INTO Belong_to VALUES ('IID757288', 'PID163853', '500g');


INSERT INTO Belong_to (instance_id, product_id, variant_name)
VALUES
('IID000001', 'PID000001', 'Standard'),
('IID000002', 'PID000001', 'Premium'),
('IID000003', 'PID000002', 'Classic Fit'),
('IID000004', 'PID000002', 'Slim Fit'),
('IID000005', 'PID000003', '32GB'),
('IID000006', 'PID000003', '64GB'),
('IID000007', 'PID000004', 'Copper'),
('IID000008', 'PID000004', 'Silver'),
('IID000009', 'PID000005', 'Basic Kit'),
('IID000010', 'PID000005', 'Deluxe Kit'),
('IID000011', 'PID000006', 'Statement Piece'),
('IID000012', 'PID000006', 'Classic'),
('IID000013', 'PID000007', 'Bifold'),
('IID000014', 'PID000007', 'Trifold'),
('IID000015', 'PID000008', 'Basic Model'),
('IID000016', 'PID000008', 'Pro Model'),
('IID000017', 'PID000009', 'Modern Design'),
('IID000018', 'PID000009', 'Vintage Style'),
('IID000019', 'PID000010', 'Classic Blue'),
('IID000020', 'PID000010', 'Stainless Steel'),
('IID000021', 'PID000011', 'Athletic Style'),
('IID000022', 'PID000011', 'Casual Comfort'),
('IID000023', 'PID000012', 'Relaxed Fit'),
('IID000024', 'PID000012', 'Skinny Fit'),
('IID000025', 'PID000013', 'Pro Camera'),
('IID000026', 'PID000013', 'Compact Camera'),
('IID000027', 'PID000014', 'Cozy Plaid'),
('IID000028', 'PID000014', 'Luxury Velvet'),
('IID000029', 'PID000015', 'Trailblazer'),
('IID000030', 'PID000015', 'Explorer');

--Insert Voucher done
INSERT INTO Voucher VALUES ('VCH000010', 20, 8000, 0, CONVERT(datetime, '14-11-2023', 105), null, 'For products', null, null);

INSERT INTO Voucher (voucher_id, quantity, discount, lowest_applied_price, start_time, end_time, [type], maximum_cash_discount, [percent])
VALUES
('VCH000001', 50, NULL, 10000.0, '2023-01-01 00:00:00', '2023-02-01 00:00:00', 'For delivery', 10000.0, 0.05),
('VCH000002', 100, 20000.0, 50000.0, '2023-02-15 00:00:00', '2023-03-15 00:00:00', 'For products', 12000.5, 0.1),
('VCH000003', 30, NULL, 15000.0, '2023-03-01 00:00:00', '2023-04-01 00:00:00', 'For products', 5000.0, 0.3),
('VCH000004', 80, 25000.0, 100000.0, '2023-04-15 00:00:00', '2023-05-15 00:00:00', 'For delivery', null, null),
('VCH000005', 20, NULL, 30000.0, '2023-05-01 00:00:00', '2023-06-01 00:00:00', 'For delivery', 8000.0, 0.6),
('VCH000006', 40, NULL, 25000.0, '2023-06-15 00:00:00', '2023-07-15 00:00:00', 'For products', 10000.0, 0.2),
('VCH000007', 60, 15000.0, 70000.0, '2023-07-01 00:00:00', '2023-08-01 00:00:00', 'For delivery', 13000.0, 0.08),
('VCH000008', 25, NULL, 20000.0, '2023-08-15 00:00:00', '2023-09-15 00:00:00', 'For products', 5000.0, 0.5),
('VCH000009', 70, 30000.0, 120000.0, '2023-09-01 00:00:00', '2023-10-01 00:00:00', 'For delivery', null, null),
('VCH000011', 15, NULL, 40000.0, '2023-10-15 00:00:00', '2023-11-15 00:00:00', 'For products', 12000.0, 0.19);

--Insert Payment done
-- seller 52 74 83 02->06

INSERT INTO Payment VALUES ('PAY001013', 'Dong Hoang Son', 'UID100013'); --e wallet
INSERT INTO Payment VALUES ('PAY001113', 'Dong Hoang Son', 'UID100013'); --card payment
INSERT INTO Payment VALUES ('PAY001213', 'Dong Hoang Son', 'UID100013'); -- cod
INSERT INTO Payment VALUES ('PAY001052', 'Duy Tung', 'UID100052'); -- e wallet
INSERT INTO Payment VALUES ('PAY002052', 'Duy Tung', 'UID100052'); -- Cod
INSERT INTO Payment VALUES ('PAY001074', 'Ngoc Huan', 'UID100074'); -- banking
INSERT INTO Payment VALUES ('PAY002074', 'Ngoc Huan', 'UID100074'); -- cod
INSERT INTO Payment VALUES ('PAY001046', 'Dinh Tong', 'UID100046'); -- banking
INSERT INTO Payment VALUES ('PAY002046', 'Dinh Tong', 'UID100046'); -- cod
INSERT INTO Payment VALUES ('PAY001049', 'Minh Hoang', 'UID100049'); -- cod
INSERT INTO Payment VALUES ('PAY001083', 'Dinh Hong Son', 'UID100083'); -- cod
INSERT INTO Payment VALUES ('PAY002083', 'Dinh Hong Son', 'UID100083'); -- e wallet

--cod all done
--delete Payment
INSERT INTO Payment (ID_payment, owner_name, user_id)
VALUES
('PAY000001', 'Nguyen Huan', 'UID000001'),
('PAY000002', 'John Doe', 'UID000002'),
('PAY000003', 'Alice Smith', 'UID000003'),
('PAY000004', 'Alice Smith', 'UID000004'),
('PAY000005', 'Emily Jones', 'UID000005'),
('PAY000006', 'David Miller', 'UID000006'),
('PAY000007', 'Sophia Brown', 'UID000007'),
('PAY000008', 'Daniel White', 'UID000008'),
('PAY000009', 'Olivia Davis', 'UID000009'),
('PAY000010', 'William Wilson', 'UID000010'),
('PAY000011', 'Ava Taylor', 'UID000011');
INSERT INTO Payment (ID_payment, owner_name, user_id)values('PAY002011', 'Ava Taylor', 'UID000011'); -- card payment

INSERT INTO Payment (ID_payment, owner_name, user_id) -- banking
VALUES
('PAY001002', 'John Doe', 'UID000002'),
('PAY001003', 'Alice Smith', 'UID000003'),
('PAY001004', 'Alice Smith', 'UID000004'),
('PAY001005', 'Emily Jones', 'UID000005'),
('PAY001006', 'David Miller', 'UID000006');

--Insert E_wallet done
--delete Internet_banking where ID_payment like 'PAYID%'
INSERT INTO E_wallet VALUES ('PAY001013', '01231231232323');
INSERT INTO E_wallet VALUES ('PAY001052', '01231231232324');
INSERT INTO E_wallet VALUES ('PAY002083', '01231231232325'); -- e wallet

--Insert Card_payment done
INSERT INTO Card_payment VALUES ('PAY001113', '0987654321123456', 'Debit');
INSERT INTO Card_payment VALUES ('PAY002011', '0987654321123477', 'Napas');

--Insert Internet_banking done
INSERT INTO Internet_banking VALUES ('PAY001046', '03551234123321');
INSERT INTO Internet_banking VALUES ('PAY001074', '0824483533'); -- banking

INSERT INTO Internet_banking (ID_payment, account_number) -- banking
VALUES
('PAY001002','0924483533'),
('PAY001003', '28243483533'),
('PAY001004','06244832524' ),
('PAY001005','9524483545'),
('PAY001006', '89224583533');

--Insert COD done
--delete COD
INSERT INTO COD VALUES ('PAY001213');
INSERT INTO COD VALUES ('PAY001049');
INSERT INTO COD VALUES ('PAY001083');
INSERT INTO COD VALUES ('PAY002052'); -- Cod
INSERT INTO COD VALUES ('PAY002074'); -- cod
INSERT INTO COD VALUES ('PAY002046'); -- cod

INSERT INTO COD (ID_payment)
VALUES
('PAY000001'),
('PAY000002'),
('PAY000003'),
('PAY000004'),
('PAY000005'),
('PAY000006'),
('PAY000007'),
('PAY000008'),
('PAY000009'),
('PAY000010'),
('PAY000011');

--insert Add done use for cart
--delete [Add]
INSERT INTO [Add] VALUES ('PID000007', 'UID100013', 1,1);
INSERT INTO [Add] VALUES ('PID000008', 'UID100046', 1,1);
INSERT INTO [Add] VALUES ('PID000009', 'UID100049', 1,1);
INSERT INTO [Add] VALUES ('PID000010', 'UID100052', 1,1);
INSERT INTO [Add] VALUES ('PID000002', 'UID100052', 1,2);

INSERT INTO [Add] (product_id, user_id, number,quantity)
VALUES
('PID000001', 'UID000001', 1,1),
('PID000011', 'UID000002', 2,1),
('PID000012', 'UID000003', 3,1),
('PID000013', 'UID000004', 4,1),
('PID000014', 'UID000005', 5,1);

--insert Review done
--delete Review
INSERT INTO Review VALUES ('RID399786', 4, 'Good. Sau khi phoi con co mui thom', CONVERT(datetime, '14-11-2023', 105), 'PID144103', 'UID100013');
INSERT INTO Review VALUES ('RID411285', 5, 'Binh luan mang tinh chat nhan xu', CONVERT(datetime, '14-11-2023', 105), 'PID144103', 'UID100046');

INSERT INTO Review (review_id, no_stars, content, time_created, product_id, user_id)
VALUES
('RID000001', 4, 'Great product! Very comfortable and stylish.', '2023-01-15 08:30:00', 'PID000001', 'UID000001'),
('RID000002', 5, 'Excellent service and fast delivery!', '2023-02-02 12:45:00', 'PID000002', 'UID000002'),
('RID000003', 3, 'Average quality, expected more.', '2023-03-10 15:20:00', 'PID000003', 'UID000003'),
('RID000004', 5, 'Love it! Best purchase ever.', '2023-04-05 09:10:00', 'PID000004', 'UID000004'),
('RID000005', 2, 'Not satisfied with the product. Poor design.', '2023-05-20 14:55:00', 'PID000005', 'UID000005'),
('RID000006', 4, 'Impressive product quality. Would recommend!', '2023-06-12 11:25:00', 'PID000006', 'UID000006'),
('RID000007', 3, 'Decent price for the features provided.', '2023-07-18 08:40:00', 'PID000007', 'UID000007'),
('RID000008', 5, 'Absolutely love the design. A+++', '2023-08-23 13:15:00', 'PID000008', 'UID000008'),
('RID000009', 2, 'Disappointed with the shipping time.', '2023-09-30 17:30:00', 'PID000009', 'UID000009'),
('RID000010', 4, 'Good value for the money. Happy with the purchase.', '2023-10-05 09:55:00', 'PID000010', 'UID000010'),
('RID000011', 1, 'Terrible experience. The product broke within a week.', '2023-11-11 14:20:00', 'PID000011', 'UID000011'),
('RID000012', 5, 'Exactly what I was looking for. Great product!', '2023-12-15 10:45:00', 'PID000012', 'UID100013'),
('RID000013', 3, 'Average product. Nothing special.', '2023-01-20 16:10:00', 'PID000013', 'UID100013'),
('RID000014', 5, 'Amazing customer service. Quick response to queries.', '2023-02-25 12:35:00', 'PID000014', 'UID000001'),
('RID000015', 2, 'Not as described. Misleading product information.', '2023-03-03 08:00:00', 'PID000015', 'UID000002'),
('RID000016', 4, 'Sturdy construction. Happy with the durability.', '2023-04-08 13:25:00', 'PID000001', 'UID000003'),
('RID000017', 1, 'Waste of money. Poor quality material.', '2023-05-15 17:50:00', 'PID000002', 'UID000004'),
('RID000018', 5, 'Excellent packaging. Product arrived in perfect condition.', '2023-06-20 11:15:00', 'PID000003', 'UID000005'),
('RID000019', 3, 'Satisfactory purchase. Could be better.', '2023-07-25 16:40:00', 'PID000004', 'UID000006'),
('RID000020', 4, 'Good product overall. Met my expectations.', '2023-08-30 12:05:00', 'PID000005', 'UID000007'),
('RID000021', 2, 'Unpleasant odor from the product. Disappointed.', '2023-09-05 08:30:00', 'PID000006', 'UID000011'),
('RID000022', 5, 'Outstanding performance. Worth every penny.', '2023-10-10 13:55:00', 'PID000007', 'UID100083'),
('RID000023', 3, 'Not user-friendly. Complicated to operate.', '2023-11-15 17:20:00', 'PID000008', 'UID000006'),
('RID000024', 5, 'Exceptional design. Adds elegance to my space.', '2023-12-20 11:45:00', 'PID000009', 'UID100049'),
('RID000025', 4, 'Reliable and efficient. Happy with the purchase.', '2023-01-25 16:10:00', 'PID000010', 'UID100074');



--insert Delivery_service done
INSERT INTO Delivery_service VALUES ('DEL000011', 'GHN', 27000, 2);
INSERT INTO Delivery_service VALUES ('DEL000012', 'GHTK', 15000, 4);

INSERT INTO Delivery_service (delivery_id, name, price, estimated_time)
VALUES
('DEL000001', 'Standard Deli', 5000.0, 3),
('DEL000002', 'Express Deli', 10000.0, 2),
('DEL000003', 'Next-Day Deli', 15000.0, 1),
('DEL000004', 'Free Pickup', 0.0, 0),
('DEL000005', 'Two-Day Ship', 8000.0, 2);

--insert Order done
--delete [Order]
INSERT INTO [Order] VALUES ('ORD00000000031', 'Done', 1,  CONVERT(datetime, '14-11-2023', 105), 'PAY001013', 'DEL000011');
INSERT INTO [Order] VALUES ('ORD00000000032', 'Done', 1, CONVERT(datetime, '14-11-2023', 105), 'PAY001074', 'DEL000011');
INSERT INTO [Order] VALUES ('ORD00000000033', 'Confirming', 1, CONVERT(datetime, '14-11-2023', 105), 'PAY001074', 'DEL000011');

INSERT INTO [Order] (order_id, status, no_product, ID_payment, delivery_id)
VALUES
('ORD00000000001', 'Confirming', 1, 'PAY000001', 'DEL000001'),
('ORD00000000002', 'Waiting pickup', 1, 'PAY000002', 'DEL000002'),
('ORD00000000003', 'Delivering', 1, 'PAY000003', 'DEL000003'),
('ORD00000000004', 'Done', 1, 'PAY000004', 'DEL000004'),
('ORD00000000005', 'Cancelled', 1, 'PAY000005', 'DEL000005');

--insert Is_contained done
--delete Is_contained
--update [Order] set no_productname = 1
INSERT INTO Is_contained VALUES ('IID080466', 'ORD00000000031');
INSERT INTO Is_contained VALUES ('IID080467', 'ORD00000000032');
INSERT INTO Is_contained VALUES ('IID080468', 'ORD00000000033');

INSERT INTO Is_contained (instance_id, order_id)
VALUES
('IID000001', 'ORD00000000001'),
('IID000002', 'ORD00000000001'),
('IID000006', 'ORD00000000001'),
('IID000003', 'ORD00000000002'),
('IID000004', 'ORD00000000002'),
('IID000005', 'ORD00000000003'),
('IID000026', 'ORD00000000004'),
('IID000027', 'ORD00000000004'),
('IID000028', 'ORD00000000004'),
('IID000029', 'ORD00000000004'),
('IID000021', 'ORD00000000005'),
('IID000030', 'ORD00000000005');

--insert Can_apply dione
--delete Can_apply
INSERT INTO Can_apply VALUES ('CATffffff', 'VCH000010', 'SID100052');

INSERT INTO Can_apply (category_id, voucher_id, shop_id)
VALUES
('CAT000001', 'VCH000006', 'SID000001'),
('CAT000004', 'VCH000007', 'SIDffffff'),
('CAT000005', 'VCH000008', 'SID000005'),
('CAT000006', 'VCH000009', 'SID000001'),
('CATffffff', 'VCH000010', 'SID000004');

--insert Applies done
--delete Applies
INSERT INTO Applies VALUES ('ORD00000000031', 'VCH000010');
INSERT INTO Applies VALUES ('ORD00000000032', 'VCH000010');

INSERT INTO Applies (order_id, voucher_id)
VALUES
('ORD00000000001', 'VCH000006'),
('ORD00000000002', 'VCH000007'),
('ORD00000000003', 'VCH000008'),
('ORD00000000004', 'VCH000009'),
('ORD00000000005', 'VCH000010');

--insert Places
INSERT INTO Places VALUES ('ORD00000000031', 'UID100013', null, null);
INSERT INTO Places VALUES ('ORD00000000032', 'UID100074', null, null);
INSERT INTO Places VALUES ('ORD00000000033', 'UID100074', null, null);

INSERT INTO Places (order_id, user_id, user_id_cart, number)
VALUES
('ORD00000000001', 'UID000001', NULL, NULL),
('ORD00000000002', NULL, 'UID000002', 2),
('ORD00000000003', 'UID000003', NULL, NULL),
('ORD00000000004', NULL, 'UID000004', 4),
('ORD00000000005', 'UID000005', NULL, NULL);

-- add default key to delete
insert into Product values (
	'PIDffffff',
	'This product name has been deleted !',
	'Unknown',
	default,
	default,
	0,
	0,
	null,
	'SIDffffff',
	null
)
