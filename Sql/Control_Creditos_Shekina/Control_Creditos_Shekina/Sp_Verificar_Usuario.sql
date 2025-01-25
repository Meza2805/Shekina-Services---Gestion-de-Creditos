ALTER PROC dbo.Sp_Verificar_Usuario
(
    @Usuario NVARCHAR(450),
    @Salida INT OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM dbo.Usuarios WHERE Nombre_Usuario = @Usuario)
        BEGIN
            SET @Salida = 1; -- Usuario encontrado
        END
        ELSE
        BEGIN
            SET @Salida = 0; -- Usuario no encontrado
        END
    END TRY
    BEGIN CATCH
        SET @Salida = 0; -- Error en la consulta
    END CATCH;
END;
GO
