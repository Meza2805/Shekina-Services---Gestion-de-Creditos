


OPEN SYMMETRIC KEY SK_Usuarios
DECRYPTION BY CERTIFICATE Cert_Usuarios;

SELECT perB.Cedula,
       dbo.LetraCapital(CONCAT( perB.PrimerNombre, ' ',perB.SegundoNombre,' ',  perB.PrimerApellido, ' ', perB.SegundoApellido,' '
                              )
                       ) NombreCompleto, 
       tipo_p.Id AS Id_Tipo_Persona,
	   tipo_p.Descripcion AS Tipo_Persona,
	   perm.Id AS Id_Permiso,
	   perm.Descripcion Permisos,
	   u.Id AS Id_Usuario,
       u.Nombre_Usuario,
       CAST(DECRYPTBYKEY(u.Contraseña) AS NVARCHAR(200)) AS ContrasenaDescifrada
FROM dbo.Usuario u
    INNER JOIN dbo.Persona per
        ON per.Id = u.Id_Persona
    INNER JOIN dbo.Persona_Base perB
        ON per.Id_Persona_Base = perB.Id
	INNER JOIN dbo.Permiso perm ON perm.Id = u.Id_Permiso
	INNER JOIN dbo.Persona_Tipo tipo_p ON tipo_p.Id = per.Id_Tipo_Persona

CLOSE SYMMETRIC KEY SK_Usuarios;