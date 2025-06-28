use NeuraSpace;
select * from admin
select * from registered_customer;
select * from sensor_information;
select * from user_recommendation;
select * from user_logs;
select l.log_id, u.username, l.recommendation_text, l.logged_at from user_logs l join registered_customer u on l.id = u.id where u.username = 'zarif';
select s.sensor_id,u.username, s.temperature,s.humidity,s.recorded_at from sensor_information s join registered_customer u on s.id = u.id where u.username = 'zarif';

INSERT INTO registered_customer (FullName, Username, Email, Phone, Password)
VALUES ('Nafiul karim', 'nafiul', 'nafiul@yahoo.com', '012343434', 'password');
insert into admin (username , password) values ('karim','pass');

delete from registered_customer where id in (3,4,5);

INSERT INTO admin (username, password)
VALUES 
('admin1', 'admin1'),
('admin2', 'admin2'),
('admin3', 'admin3');

INSERT INTO sensor_information (id, temperature, humidity)
VALUES 
(1, 36.5, 82.0),
(2, 30.2, 60.0),
(9, 39.0, 85.0); 

INSERT INTO user_recommendation (id, recommendation_text, generated_from_sensor_id)
VALUES 
(1, 'Use sunscreen due to high temperature.', 7),
(1, 'Stay hydrated; humidity is high.', 7),
(9, 'Use sunscreen and drink water.', 9);

INSERT INTO user_logs (id, recommendation_text)
VALUES 
(1, 'Use sunscreen due to high temperature.'),
(1, 'Stay hydrated; humidity is high.'),
(9, 'No recommendations currently.');



CREATE TABLE admin (
    admin_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) UNIQUE NOT NULL,
    password NVARCHAR(255)
);
GO


CREATE TABLE sensor_information (
    sensor_id INT IDENTITY(1,1) PRIMARY KEY,
    id INT FOREIGN KEY REFERENCES  registered_customer(id),
    temperature FLOAT,
    humidity FLOAT,
    recorded_at DATETIME DEFAULT GETDATE()
);
GO


CREATE TABLE user_recommendation (
    recommendation_id INT IDENTITY(1,1) PRIMARY KEY,
    id INT FOREIGN KEY REFERENCES registered_customer(id),
    recommendation_text NVARCHAR(255),
    generated_from_sensor_id INT FOREIGN KEY REFERENCES sensor_information(sensor_id),
    recommended_at DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE user_logs (
    log_id INT IDENTITY(1,1) PRIMARY KEY,
    id INT FOREIGN KEY REFERENCES registered_customer(id),
    recommendation_text NVARCHAR(255),
    logged_at DATETIME DEFAULT GETDATE()
);
GO


CREATE TRIGGER trg_LimitUserLogs
ON user_logs
AFTER INSERT
AS
BEGIN
    DELETE FROM user_logs
    WHERE log_id NOT IN (
        SELECT TOP 5 log_id FROM user_logs
        WHERE user_id IN (SELECT DISTINCT user_id FROM inserted)
        ORDER BY logged_at DESC
    )
    AND user_id IN (SELECT user_id FROM inserted);
END;
GO

////////////////
