create	database	DB_Carreras

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
id_carrera	int
constraint	id_Detalle_Carrera	primary	key(id_detalle_carrera),
constraint	id_Carrera	foreign	key(id_carrera)
references	carrera(id_carrera))



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

