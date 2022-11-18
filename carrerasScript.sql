create	database	DB_Carreras1

create	table	titulo(
id_titulo	int	identity(1,1),
descripcion	varchar(50)
constraint	idtitulo	primary	key(id_titulo))

create	table	carrera(
id_carrera	int	identity(1,1),
nombre_carrera	varchar(50),
id_titulo	int,
constraint	idcarrera	primary	key(id_carrera),
constraint	id_Titulo	foreign	key(id_titulo)
references	titulo(id_titulo))


create	table	materias(
id_materias	int	identity(1,1),
descricion	varchar(50)
constraint	idmateria	primary	key(id_materias))


create	table	detalle_carrera(
id_detalle_carrera	int	identity(1,1),
año_cursado	varchar(50),
cuatrimestre	bit,
id_carrera	int,
id_materias	int
constraint	id_Detalle_Carrera	primary	key(id_detalle_carrera),
constraint	id_Carrera	foreign	key(id_carrera)
references	carrera(id_carrera),
constraint	id_Materias	foreign	key(id_materias)
references	materias(id_materias))

select*from	titulo

insert	into	titulo(descripcion)
values('tecnicatura')
insert	into	titulo(descripcion)
values('licenciatura')
insert	into	titulo(descripcion)
values('ingenieria')
insert	into	titulo(descripcion)
values('posgrado')

insert	into	materias(descricion)
values('matematica')
insert	into	materias(descricion)
values('fisica')
insert	into	materias(descricion)
values('quimica')
insert	into	materias(descricion)
values('estructura	de	datos')
insert	into	materias(descricion)
values('legislacion')
insert	into	materias(descricion)
values('metodologia	de	la	investigacion')

create	procedure	SP_Consultar_Materias
as
	begin
		select	*	from	materias
	end

create	procedure	SP_Consultar_titulos
as
	begin
		select	*	from	titulo
	end


create	procedure	SP_Crear_Carrera
@nombre_carrera	varchar(50),
@id_titulo	int,
@id_carrera	int	output
as
	begin
		insert	into	carrera(nombre_carrera,id_titulo)
		values(@nombre_carrera,@id_titulo)
		SET @id_carrera = SCOPE_IDENTITY();
	end


create	procedure	SP_Crear_Detalle
@año_cursado	varchar(50),
@cuatrimestre	bit,
@id_carrera	int,
@id_materias	int
as
	begin
		insert	into	detalle_carrera(año_cursado,cuatrimestre,id_carrera,id_materias)
		values(@año_cursado,@cuatrimestre,@id_carrera,@id_materias)
	end



insert	into	carrera(nombre_carrera,id_titulo)
	values('programacion',1)


insert	into	detalle_carrera(año_cursado,cuatrimestre,id_carrera,id_materias)
		values('primerAño',0,1,4)
		
insert	into	detalle_carrera(año_cursado,cuatrimestre,id_carrera,id_materias)
		values('primerAño',0,1,1)
		
insert	into	detalle_carrera(año_cursado,cuatrimestre,id_carrera,id_materias)
		values('primerAño',0,1,5)

select	*from	detalle_carrera

select*from	carrera



