create database techdata;
use techdata;

create table users (id int primary key auto_increment, name varchar(40), email varchar(40), password longtext, type int, status varchar(1) default "A");

create table teachers (id int primary key auto_increment, user_id int, status varchar(1) default "A", foreign key (user_id) references users(id));

create table charge (id int primary key auto_increment, date datetime, file longblob, user_id int, status varchar(1) default "A", foreign key (user_id) references users(id));

create table columns (id int primary key auto_increment, name longtext, charge_id int, status varchar(1) default "A", foreign key (charge_id) references charge(id));

create table line (id_linha int primary key auto_increment, content longtext, column_id int, status varchar(1) default "A", foreign key (column_id) references columns(id));

create table students (id int primary key auto_increment, RA varchar(40), user_id int, status varchar(1) default "A", foreign key (user_id) references users(id));

