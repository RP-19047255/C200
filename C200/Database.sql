CREATE TABLE DataRecord (
   Field1      VARCHAR(40) PRIMARY KEY,
   Field2      VARCHAR(40),
   Field3      INT,
   Field4      FLOAT,
   Field5      BIT,
   Field6      DATETIME
);

INSERT INTO DataRecord(Field1,Field2,Field3,Field4,Field5,Field6) VALUES
('Batman',      'Bruce Wayne',  123, 81.3,  'false', '2010-12-31T13:11:33'),
('WonderWoman', 'Diana Prince', 456, 122.7, 'false', '2010-12-31T13:11:33'),
('Superman',    'Clark Kent',   789, 452.3, 'true',  '2010-12-31T13:11:33');


DELETE DataRecord;