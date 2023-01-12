-- 1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).

USE DISCOS_DB

select * From DISCOS

Select Titulo, FechaLanzamiento from DISCOS

SELECT * FROM ESTILOS

Select D.Titulo "Nombre de Disco", D.FechaLanzamiento "Fecha de Lanzamiento", E.Descripcion Estilo  from DISCOS D, ESTILOS E			-- D y E son alias
Where D.IdEstilo=E.Id

-- pongo el alias de las columnas con"" para que me tome el string de espacio, en la columna Descripción el alias va sin "" porque es una palabra sola

-- ==================================================================================================================

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

Select * From TIPOSEDICION
Select * From ESTILOS

Insert into TIPOSEDICION Values ('Cassette')
Insert into ESTILOS Values('Reggae')
Insert into ESTILOS Values('Metal')

-- ==================================================================================================================

--3. Insertar al menos dos discos nuevos cargando correctamente su información.

Select * From DISCOS

Insert into DISCOS Values
('The Wall', '1979-12-08',26, 'https://upload.wikimedia.org/wikipedia/commons/b/b1/The_Wall_Cover.svg',3,1 )
Insert into DISCOS Values
('Hagan Correr la Voz', '2006-04-13',14, 'https://www.cmtv.com.ar/discos_letras/show.php?bnid=1623&banda=Nonpalidece&DS_DS=3889&disco=HAGAN_CORRER_LA_VOZ',5,2)

-- ==================================================================================================================

--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.
Select * From DISCOS
Update DISCOS set CantidadCanciones=26 where id=3
Update DISCOS set FechaLanzamiento='1979-12-8' Where id=3

-- ==================================================================================================================

--5. Borrar un disco a elección.

select * from DISCOS
Delete From DISCOS Where id=4

-- ==================================================================================================================

--6. Traer todos los estilos que estén asociados a algún disco.

select * from DISCOS
select * from ESTILOS

Select D.Titulo, D.FechaLanzamiento 'Fecha de Lanzamiento', D.CantidadCanciones 'Cantidad de Canciones', D.UrlImagenTapa 'Imagen de la Tapa', E.Descripcion From DISCOS D, ESTILOS E 
Where D.IdEstilo=E.Id and D.IdEstilo=3

-- ==================================================================================================================

--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).
Select * from DISCOS
Select * from ESTILOS
Select * from TIPOSEDICION

Select D.Titulo Nombre, E.Descripcion Estilo, T.Descripcion Edicion From DISCOS D, ESTILOS E, TIPOSEDICION T
Where D.IdEstilo=E.Id and D.IdTipoEdicion=T.Id

-- ==================================================================================================================

--8. Traer todos los discos que contengan en su nombre la sílaba "ho".

Select Titulo from DISCOS
Where  Titulo Like '%ho%'		--% es usado como comodín, o sea empieza con cualquier caracter y termina con cualquier caracter
								--si queresmos seleccionar acorde a la posicion, usamos "_", Ej:'_e%' (selecciona cadenas que empiecen con cualquier caracter
								-- y el segundo caracter sea una e