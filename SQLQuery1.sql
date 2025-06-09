CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	email VARCHAR(MAX) NULL,
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	data_register DATE NULL
)

SELECT * FROM users

drop table users