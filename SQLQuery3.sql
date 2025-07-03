drop table rentals;
drop table cars;
drop table returns;


CREATE TABLE cars (
  regNo VARCHAR(50) PRIMARY KEY,
  brand VARCHAR(50),
  model VARCHAR(50),
  year INT,
  color VARCHAR(30),
  price DECIMAL(10, 2),
  
);

CREATE TABLE rentals (
  rental_id INT PRIMARY KEY,
  customer_id INT,
  regNo VARCHAR(50),
  rental_date DATE,
  return_date DATE,
  rental_price DECIMAL(10, 2),
  FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
  FOREIGN KEY (regNo) REFERENCES CARS(regNo)
);

CREATE TABLE returns (
  return_id INT PRIMARY KEY,
  rental_id INT,
  return_date DATE,
  delay_days INT,
  condition VARCHAR(50),
  FOREIGN KEY (rental_id) REFERENCES rentals(rental_id)
);