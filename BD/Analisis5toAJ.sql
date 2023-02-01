CREATE DATABASE GA1ANJ
USE GA1ANJ;

CREATE TABLE REGISTROS(
             usuario varchar (30) NOT NULL primary key,
			 rol varchar (20),
			 contraseña varchar (20),
			 );
SELECT *FROM REGISTROS;

INSERT INTO REGISTROS VALUES ('Jenni','Administrador','123xd')
INSERT INTO REGISTROS VALUES ('Dania','Secretaria','123xd')
INSERT INTO REGISTROS VALUES ('Cris','Usuario','123xd')