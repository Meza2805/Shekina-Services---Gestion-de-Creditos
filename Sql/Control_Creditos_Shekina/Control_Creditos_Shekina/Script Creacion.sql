

SELECT * FROM dbo.Permisos
GO


INSERT INTO dbo.Usuarios
(
    Id_Permiso,
    Nombre_Usuario,
    Contrasenia,
    FechaCreacion,
    UsuarioCrea,
    FechaModificacion,
    UsuarioModifica,
    Estado
)
VALUES
(   2, -- Id_Permiso - int
    'Marvin Meza', -- Nombre_Usuario - nvarchar(450)
    EncryptByPassPhrase('Mezapineda1993', 'Jabalisesenpaz1993'), -- Contrasenia - varbinary(max)
    GETDATE(), -- FechaCreacion - datetime
    2, -- UsuarioCrea - int
    NULL, -- FechaModificacion - datetime
    NULL, -- UsuarioModifica - int
    1  -- Estado - bit
    )

	GO

	SELECT Nombre_Usuario,  CONVERT(NVARCHAR(500),DecryptByPassPhrase('Mezapineda1993',Contrasenia))  FROM dbo.Usuarios

	SELECT Nombre_Usuario, 
       CONVERT(NVARCHAR(500), CONVERT(VARCHAR(MAX), DecryptByPassPhrase('Mezapineda1993', Contrasenia))) 
       AS ContraseniaDesencriptada
FROM dbo.Usuarios;