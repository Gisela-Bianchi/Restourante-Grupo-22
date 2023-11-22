use master 
go
create database Restaurante
go

use Restaurante
go



create table Usuario(
Id int not null,
Contraseña varchar(50) not null,
Usuario varchar(50) not null,
TipoUsuario int not null,
Activo bit not null,
constraint pk_Usuario Primary key(Id)
)

create table Mesero (
Id_M int not null,
Dni_M char(8) not null,
Nombre_M varchar(20) not null,
Apellido_M varchar(20) not null,
IdUsuario_M int not null,
constraint pk_Mesero Primary key (Id_M),
constraint fk_Mesero_Usuario Foreign key(IdUsuario_M) references Usuario (Id)
)

create table Mesas(
NumeroMesa_Mesa int not null,
Id_MeseroMesa int not null,
Capacidad_Mesa int not null,
Estado_Mesa bit not null,
constraint pk_Mesas Primary key (NumeroMesa_Mesa),
constraint fk_Mesas_Mesero Foreign key(Id_MeseroMesa) references Mesero (Id_M )
)
create table Pedido(
NumeroPedido_Pe int identity not null,
Fechapedido_Pe datetime default getdate(),
NumeroMesa_Pe int not null,
EstadoPedido_Pe bit default 1 not null,
Facturado_Pe bit default 0 not null,
constraint pk_Pedido Primary key (NumeroPedido_Pe),
constraint fk_Pedido_Mesas foreign key (NumeroMesa_Pe) references Mesas(NumeroMesa_Mesa) 

)
create table Categoria(
Id_Categoria int not null,
Descripcion_Categoria varchar(200)not null,
constraint pk_Categoria Primary key (Id_Categoria )
)
create table TipoInsumo(
Id_TI int not null,
Nombre_TI varchar(20) not null,
Descripcion_TI varchar(200) not null,
Estado_TI bit not null,
constraint pk_TipoInsumo Primary key ( Id_TI)
)

create table Insumo(
Id_Insumo int not null,
Nombre_Insumo varchar(60) not null,
PrecioUnitario_Insumo money not null,
CantidadEnStock_Insumo int not null,
Tipo_Insumo int not null,
Id_Categoria_Insumo int not null,
constraint pk_Insumo Primary key (Id_Insumo ),
constraint fk_Insumo_Categoria foreign key (Id_Categoria_Insumo) references Categoria(Id_Categoria),
constraint fk_Insumo_TipoInsumo foreign key (Tipo_Insumo) references TipoInsumo(Id_TI)
)


create table PedidoXInsumo(
NumeroPedido_PXI int not null,
IdInsumo_PXI int not null,
CantVendida_PXI int not null,
PrecioUnitario_PXI decimal not null,
constraint pk_PedidoXInsumo Primary key (NumeroPedido_PXI,IdInsumo_PXI ),
constraint fk_PedidoXInsumo_Pedido foreign key (NumeroPedido_PXI) references Pedido(NumeroPedido_Pe),
constraint fk_PedidoXInsumo_Insumo foreign key (IdInsumo_PXI) references Insumo(Id_Insumo)
)



create table Gerente(
Id_G int not null,
Dni_G char(8)not null,
Nombre_G varchar(20) not null,
Apellido_G varchar(20) not null,
constraint pk_Gerente Primary key ( Id_G)

)

create table AsignacionesMesa(
Id_AM int identity not null,
NumeroMesa_AM int not null,
NombreMesero_AM varchar(20)not null,
FechaAsignacion_AM datetime not null,
IdGerente_AM int not null,
constraint pk_AsignacionesMesa Primary key ( Id_AM),
constraint fk_AsignacionesMesa_Gerente foreign key (IdGerente_AM) references Gerente(Id_G)
)

create table Reportes(
Id_Reporte int identity not null,
NombreMesero_Reporte varchar(20) not null,
FechaApertura_Reporte datetime not null,
FechaApertura_Cierre datetime not null,
constraint pk_Reportes Primary key (Id_Reporte)
)
insert into Categoria(Id_Categoria,Descripcion_Categoria)
select '1','Entradas' union
select '2','Platos'union
select '3', 'Bebidas' union
select '4','Postres'
go

insert into TipoInsumo(Id_TI,Nombre_TI,Descripcion_TI,Estado_TI)
select '1','Alcoholico','Pinta de 500CC ',1 union
select '2','No Alcoholico','Gaseosa de 500CC',1 union
select '3', 'Vegano','Cambia la proteina por falafel o tofu',1 union
select '4', 'omnivoro','todo tipo de carne, vegetales, frutas, legumbres',1
go

insert into Usuario(Id,Contraseña,Usuario,TipoUsuario,Activo)
select '1','test','test','1','1' union
select '2','admin','admin','2','1'
go


insert into Insumo(Id_Insumo,Nombre_Insumo,PrecioUnitario_Insumo,CantidadEnStock_Insumo,Tipo_Insumo,Id_Categoria_Insumo)
select '1','PAPAS FRITAS c/cheddar',4500,20,'3','1' union
select '2','2 TORTILLAS DE TRIGO RELLENA.',800,200,'3','1'
go

alter table Pedido add RecaudacionTotal_Pe decimal(8,2) not null default 0
go

