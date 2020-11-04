/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [username]
      ,[password]
      ,[email]
  FROM [QLNH].[dbo].[DangNhap]