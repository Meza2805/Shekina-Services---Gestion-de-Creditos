alter PROC Sp_Acceder_Sistema
(	@Usuario NVARCHAR(450),
	@Contra NVARCHAR(max),
	@Salida INT OUTPUT)
	AS
    BEGIN

		IF EXISTS (SELECT Nombre_Usuario FROM dbo.Usuarios WHERE Nombre_Usuario = @Usuario)
			BEGIN
				DECLARE @Contra_DB NVARCHAR(MAX) = (SELECT TOP 1  CONVERT(NVARCHAR(500), CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('Mezapineda1993', Contrasenia)))FROM dbo.Usuarios WHERE Nombre_Usuario = @Usuario);
				IF (@Contra = @Contra_DB) 
					BEGIN
						SET @Salida = 1;
					END
				ELSE	
					BEGIN
						SET @Salida = 0;
					END
			END
		ELSE
			BEGIN
				SET @Salida = 0;
			END

	END
GO



ALTER PROC Sp_Acceder_Sistema
(
    @Usuario NVARCHAR(450),
    @Contra NVARCHAR(MAX),
    @Salida INT OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        DECLARE @Contra_DB NVARCHAR(MAX);

        -- Obtener la contraseña desencriptada en una sola consulta
        SELECT @Contra_DB = CONVERT(NVARCHAR(500), 
                         CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('Mezapineda1993', Contrasenia)))
        FROM dbo.Usuarios 
        WHERE Nombre_Usuario = @Usuario;

        -- Verificamos si el usuario existe y la contraseña coincide
        IF @Contra_DB IS NOT NULL AND @Contra = @Contra_DB
            SET @Salida = 1;
        ELSE
            SET @Salida = 0;
        
    END TRY
    BEGIN CATCH
        -- Si hay un error, devolvemos 0 para indicar que el acceso falló
        SET @Salida = 0;
    END CATCH;
END;
GO


DECLARE @Salida INT;
EXEC dbo.Sp_Acceder_Sistema @Usuario = N'meza',          -- nvarchar(450)
                            @Contra = N'Jabalisesenpaz1993',           -- nvarchar(max)
                            @Salida = @Salida OUTPUT -- int
SELECT @Salida ;
