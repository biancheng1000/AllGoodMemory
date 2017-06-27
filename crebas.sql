/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2017/6/6 16:19:44                            */
/*==============================================================*/


drop table if exists Dariy;

drop table if exists PhotoGroup;

drop table if exists Photos;

drop table if exists Video;

/*==============================================================*/
/* Table: Dariy                                                 */
/*==============================================================*/
create table Dariy
(
   ID                   int not null,
   Title                char(50),
   Writer               char(50),
   Content              text,
   primary key (ID)
);

/*==============================================================*/
/* Table: PhotoGroup                                            */
/*==============================================================*/
create table PhotoGroup
(
   ID                   int not null,
   GroupName            char(50),
   GroupData            datetime,
   Description          text,
   primary key (ID)
);

/*==============================================================*/
/* Table: Photos                                                */
/*==============================================================*/
create table Photos
(
   PotoName             varchar(50) binary,
   PotoData             datetime,
   GroupID              int,
   Content              longblob,
   ID                   int not null,
   primary key (ID)
);

/*==============================================================*/
/* Table: Video                                                 */
/*==============================================================*/
create table Video
(
   ID                   int not null,
   VideoName            char(50),
   VideoPath            text,
   primary key (ID)
);

