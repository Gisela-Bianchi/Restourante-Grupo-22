use master 
go
create database RestauranteBase1
go

use RestauranteBase1
go

create table Usuario(
Id INT IDENTITY(1,1) not null Primary key,
Contraseña varchar(50) not null,
Email varchar(50) not null unique,
TipoUsuario VARCHAR(20) not null CHECK(TipoUsuario='Gerente' OR TipoUsuario='Mesero'),
Activo bit not null default(1),
)
GO
insert into Usuario(ContraseÑa,Email,TipoUsuario)
VALUES ('mecero','mozo1@ejemplo.com','Mesero'),
       ('mecero','mozo2@ejemplo.com','Mesero'),
       ('mecero','mozo3@ejemplo.com','Mesero'),
       ('gerente','gerente@ejemplo.com','Gerente')
GO
create table Mesero(
Id_M INT IDENTITY(1,1) not null Primary key,
Dni_M char(8) not null unique,
Nombre_M varchar(20) not null,
Apellido_M varchar(20) not null,
IdUsuario_M INT not null,
constraint fk_Mesero_Usuario Foreign key(IdUsuario_M) references Usuario (Id)
)
GO
INSERT INTO Mesero(Dni_M,Nombre_M,Apellido_M,IdUsuario_M)
VALUES (11111111,'Jorge','Castro',1),
       (22222222,'Juan','Castro',2),
       (33333333,'Jose','Castro',3)
GO
create table Gerente(
Id_G INT IDENTITY(1,1) not null Primary key,
Dni_G char(8) not null unique,
Nombre_G varchar(20) not null,
Apellido_G varchar(20) not null,
IdUsuario_G INT not null,
constraint fk_Gerente_Usuario Foreign key(IdUsuario_G) references Usuario (Id)
)
GO 
INSERT INTO Gerente(Dni_G,Nombre_G,Apellido_G,IdUsuario_G)
values (44444444,'Jorge','Castro Gerente',4)
GO
create table Mesas(
NumeroMesa_Mesa int not null,--
Id_MeseroMesa int not null,
Capacidad_Mesa int not null,
Estado_Mesa bit not null,
constraint pk_Mesas Primary key (NumeroMesa_Mesa),
constraint fk_Mesas_Mesero Foreign key(Id_MeseroMesa) references Mesero (Id_M )
)
create table Pedido(
NumeroPedido_Pe int identity (1,1)not null,--
Fechapedido_Pe datetime default getdate(),
NumeroMesa_Pe int not null,
EstadoPedido_Pe bit default 1 not null,
Facturado_Pe bit default 0 not null,
constraint pk_Pedido Primary key (NumeroPedido_Pe),
constraint fk_Pedido_Mesas foreign key (NumeroMesa_Pe) references Mesas(NumeroMesa_Mesa), 


)
create table Categoria(
Id_Categoria int identity (1,1)not null,--
Descripcion_Categoria varchar(200)not null,
constraint pk_Categoria Primary key (Id_Categoria )
)
create table TipoInsumo(
Id_TI int identity(1,1) not null,--
Nombre_TI varchar(20) not null,
Descripcion_TI varchar(200) not null,
Estado_TI bit not null,
constraint pk_TipoInsumo Primary key ( Id_TI)
)

create table Insumo(
Id_Insumo int identity(1,1) not null,--
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



create table AsignacionesMesa(
Id_AM int identity(1,1) not null,--
NumeroMesa_AM int not null,
NombreMesero_AM varchar(20)not null,
FechaAsignacion_AM datetime not null,
IdGerente_AM int not null,
constraint pk_AsignacionesMesa Primary key ( Id_AM),
constraint fk_AsignacionesMesa_Gerente foreign key (IdGerente_AM) references Gerente(Id_G)
)

create table Reportes(
Id_Reporte int identity (1,1)not null,--
NombreMesero_Reporte varchar(20) not null,
FechaApertura_Reporte datetime not null,
FechaApertura_Cierre datetime not null,
constraint pk_Reportes Primary key (Id_Reporte)
)
insert into Categoria(Descripcion_Categoria)
select 'Entradas' union
select 'Platos'union
select 'Bebidas' union
select 'Postres'
go

insert into TipoInsumo(Nombre_TI,Descripcion_TI,Estado_TI)
select 'Alcoholico','Pinta de 500CC ',1 union
select 'No Alcoholico','Gaseosa de 500CC',1 union
select  'Vegano','Cambia la proteina por falafel o tofu',1 union
select  'general','todo tipo de carne, vegetales, frutas, legumbres',1
go



insert into Insumo(Nombre_Insumo,PrecioUnitario_Insumo,CantidadEnStock_Insumo,Tipo_Insumo,Id_Categoria_Insumo)
select 'Papas fritas c/cheddar',900,50,'3','1' union
select 'Tortilla ',1300,50,'3','1'union
select 'Milanesa',1500,50,'4','2' 
go



insert into Mesas (NumeroMesa_Mesa,Id_MeseroMesa,Capacidad_Mesa,Estado_Mesa)
select 1,1,4,1 union
select 2,1,4,1 union
select 3,1,4,1 union
select 4,1,4,1 union
select 5,1,5,1 union
select 6,1,4,1
go

alter table Pedido add RecaudacionTotal_Pe decimal(8,2) not null default 0
go

create trigger actualizarRecTotal 
on PedidoXInsumo
after insert as 
begin
set nocount on;

update Pedido set RecaudacionTotal_Pe=RecaudacionTotal_Pe+((select CantVendida_PXI from inserted )*(select PrecioUnitario_PXI from inserted))
where NumeroPedido_Pe=(select NumeroPedido_PXI from inserted)
end
/*

go

select * from PedidoXInsumo
go

select * from Pedido
go

select * from Mesas

delete from PedidoXInsumo
go

delete from Pedido
go

select top 1 NumeroPedido_Pe from Pedido order by NumeroPedido_Pe desc

select top 1 Id_Insumo from Insumo where Nombre_Insumo='milanesa'

select  * from Insumo

select NumeroPedido_Pe from Pedido where CAST(Fechapedido_Pe as date)=CAST(GETDATE() as date)

select Nombre_Insumo from (PedidoXInsumo inner join Insumo on IdInsumo_PXI=Id_Insumo) where NumeroPedido_PXI=1

INSERT INTO PedidoXInsumo ( NumeroPedido_PXI,IdInsumo_PXI, CantVendida_PXI, PrecioUnitario_PXI) VALUES (1,1, 20, '200')

*/