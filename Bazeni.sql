create database Bazeni_prodaja_termina
use Bazeni_prodaja_termina

create table Lokacija
(id int primary key identity(1,1),
grad nvarchar(20) not null
)

create table Korisnik
(id int primary key identity(1,1),
ime nvarchar(20) not null,
prezime nvarchar(20) not null,
email nvarchar(40) not null,
pass nvarchar(20) not null
)

create table Tip_karte
(id int primary key identity(1,1),
naziv nvarchar(30) not null,
cena money not null
)

create table Bazeni
(id int primary key identity(1,1),
naziv nvarchar(30) not null,
lokacija_id int foreign key references Lokacija(id)
)

create table Proizvodi
(id int primary key identity(1,1),
naziv nvarchar(30) not null,
cena money not null
)

create table Termini
(id int primary key identity(1,1),
tip_karte_id int foreign key references Tip_Karte(id),
pocetak_termina time not null,
kraj_termina time not null
)

create table Iznajmljivanje
(id int primary key identity(1,1),
korisnik_id int foreign key references Korisnik(id),
termin_id int foreign key references Termini(id),
datum date not null,
bazen_id int foreign key references Bazeni(id)
)

insert into Lokacija
values ('Beograd'),
('Kragujevac'),
('Cacak'),
('Nis'),
('Novi Sad'),
('Vranje')

insert into Korisnik
values('Anastasija', 'Jovanovic', 'ajovanov@gmail.com', 'tudum15'),
('Marina', 'Savic', 'marinas@gmail.com', '1244'),
('Branko', 'Markovic', 'bmark@gmail.com', '128889s'),
('Stefan', 'Antic', 'anstefan@gmail.com', '1111'),
('Andjela', 'Todorovic', 'atodor@gmail.com', '12345'),
('Tamara', 'Stevanovic', 'tstev@gmail.com', '12tam'),
('Mateja', 'Krivokapic', 'mkrivo@gmail.com', '9999'),
('Milos', 'Milosevic', 'milosm@gmail.com', 'ananas'),
('Teodora', 'Nikolic', 'tnikolic@gmail.com', '1288')

insert into Tip_karte
values ('deca do 7 god', 0),
('deca 7-12 god', 100),
('skolarci', 300),
('studenti', 300),
('odrasli', 450),
('penzioneri', 300)

insert into Proizvodi
values ('kapa', 150),
('lezaljka', 200),
('suncobran', 200),
('2 lezaljke + suncobran', 400),
('lezaljka ispod pergole', 250)

insert into Bazeni
values ('25. maj', 1),
('15. april', 6),
('Banjica', 1),
('Cair', 4),
('Tasmajdan', 3),
('Kosutnjak', 5),
('SC Park', 2),
('SPC Vojvodina', 5),
('Diamond Garden', 1)

insert into Termini
values (1, '08:00', '10:00'),
(1, '15:00', '17:00 '),
(2, '09:00', '11:00'),
(2, '15:00', '17:00'),
(3, '07:00', '09:00'),
(3, '18:00', '20:00'),
(4, '10:00', '12:00'),
(4, '18:00', '20:00'),
(5, '08:00', '10:00'),
(5, '15:00', '17:00'),
(5, '18:00', '20:00'),
(6, '07:00', '09:00'),
(6, '15:00', '17:00')