

-- 1. Database Master Key (DMK) � una sola vez por base
CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'P@ssword_DMKey_2025!';

-- 2. Certificado que proteger� la llave sim�trica
CREATE CERTIFICATE Cert_Usuarios
    WITH SUBJECT = 'Cert para cifrado de contrase�as de usuarios';

-- 3. Llave sim�trica (AES 256) protegida por el certificado
CREATE SYMMETRIC KEY SK_Usuarios
    WITH ALGORITHM = AES_256
    ENCRYPTION BY CERTIFICATE Cert_Usuarios;
