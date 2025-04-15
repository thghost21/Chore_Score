CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL PRIMARY KEY COMMENT 'primary key',
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255) COMMENT 'User Name',
  email VARCHAR(255) UNIQUE COMMENT 'User Email',
  picture VARCHAR(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE chores(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  isComplete BOOLEAN DEFAULT false
  -- ADD YOUR OWN ADDITIONAL PROPERTIES! TRY OUT LOTS OF DIFFERENT DATA TYPES!
);
INSERT INTO 
chores(name, description)
VALUES("Walk the raccoons", "Don't go to the dog park, we are banned for life.");
SELECT * FROM chores;