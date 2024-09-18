drop database db;
create database if not exists db;
use db;
create table if not exists country_types
(
	id int not null auto_increment,
    name char(255) not null,
    primary key(id)
);

create table if not exists foods_types
(
	id int not null auto_increment,
    name char(255) not null,
    primary key(id)
);

create table if not exists pools_categories
(
	id int not null auto_increment,
    name char(255) not null,
    primary key(id)
);

create table if not exists ageCategory_types
(
	id int not null auto_increment,
    name char(255) not null,
    allowedChildAges char(18) not null,
    primary key(id)
);

create table if not exists region_types
(
	id int not null auto_increment,
    region_name char(255) not null,
    country_id int not null,
    primary key(id),
    foreign key (country_id) references country_types(id) on update cascade on delete cascade						
);

create table if not exists departure_cities
(
	id int not null auto_increment,
    name char(255) not null,
    primary key(id)
);

create table if not exists hotels
(
	id int not null auto_increment,
    region_id int not null,
    foodstype_id int not null,
    agecategory_id int not null,
    pools_category int not null,
    stars_count int not null,
    near_beach bool not null,
    in_center bool not null,
    name char(255) not null,
	foreign key (region_id) references region_types(id) on update cascade on delete cascade,
	foreign key (foodstype_id) references foods_types(id) on update cascade on delete cascade,
	foreign key (agecategory_id) references ageCategory_types(id) on update cascade on delete cascade,
	foreign key (pools_category) references pools_categories(id) on update cascade on delete cascade,
    primary key(id)
);

create table if not exists routes
(
	id int not null auto_increment,
    hotel_id int not null,
    departure_city_id int not null,
    description varchar(10000) not null,
    foreign key (hotel_id) references hotels(id) on update cascade on delete cascade,
    foreign key (departure_city_id) references departure_cities(id) on update cascade on delete cascade,
    primary key(id)
);

create table if not exists tickets
(
	id bigint not null auto_increment,
    persons_count int not null,
    route_id int not null,
    tickets_count int not null,
    nights_count int not null,
    flight_out_time datetime not null,
    return_flight_time datetime not null,
    price_child bigint not null,
    price_adult bigint not null,
    foreign key (route_id) references routes(id) on update cascade on delete cascade,
    primary key(id)
);

