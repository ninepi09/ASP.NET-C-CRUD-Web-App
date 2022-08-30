CREATE table clients (
	id INT NOT NULL PRIMARY KEY IDENTITY,
	name VARCHAR (100) NOT NULL,
	email VARCHAR (100) NOT NULL,
	phone VARCHAR (20) NOT NULL,
	address VARCHAR (100) NOT NULL,
	created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO clients (name, email, phone, address)
values 
('Bill Gates', 'bill@gmail.com', '+187', 'New York, USA'),
('Elon Musk', 'elon@gmail.com', '+1890', 'New Yarshike, USA'),
('Will Gates', 'will@gmail.com', '+189', 'Spurs, USA'),
('Bob Marley', 'bob@gmail.com', '+186', 'California, USA'),
('Moslem Ronaldo', 'moslem@gmail.com', '+8987', 'Los Angeles, USA'),
('Borris Johnson', 'jhin@gmail.com', '+9087', 'London, USA');