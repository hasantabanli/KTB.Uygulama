===Test Uygulaması===

Asp.Net Core MVC Katmanlı Mimaride geliştirilmiş bir web projesidir.
Entity Framework kullanılmıştır.
OOP ve SOLID kavramlarına dikkat edilmiştir.
Entities Katmanında Veri Tabanındaki Tabloları temsil eden Class tanımlanmıştır.
Dal (Data Access Layer) Katmanında verilere ulaşmak için kullanılan metodlar yazılmıştır.
Bll (Business) Katmanında ise verileri işleyecek metodlar service mantığında yazılmıştır.

Web Projemizde MVC projesi olup Bll katmanındaki Managerımızı Controllerda injection yaparak çağırıp 
ön yüzde ekleme ve listeleme işlemleri yapılmıştır.

>>Projenin çalışması için önemli!!!

Proje localde MsSql Server da kullanıcı adı ve şifresi olmayan bir serverdan ulaşılabilen
db adı ve tablo adı Personel olan bir veri tabanı içermektedir.
Bu yüzden Dal katmanında PersonelDbContext classında OnConfiguring metodu override edilip--

    base.OnConfiguring(optionsBuilder);
    optionsBuilder.UseSqlServer("Server=DESKTOP-3AEIA9M; Database=Personel;Trusted_Connection=True;MultipleActiveResultSets=True;");

şeklinde yazılmıştır. Sizin bağlandığınız server'ın ismine göre yukarıda değişiklik yapmanız gerekmektedir.
Server'a bağlandıktan sonra Adı Personel olan ve Personel tablosu içeren bir veritabanınız olduğunda projeniz
çalışacaktır.

Personel Tablosu scripti

USE [Personel]
GO

/****** Object:  Table [dbo].[Personel]    Script Date: 22.06.2021 00:19:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO