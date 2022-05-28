# Клиент-серверное приложение Менеджер паролей

## Установка базы данных на SQL Server

## Если SQL Server не установлен

  1. Скачать (SQL Server)[https://www.microsoft.com/ru-RU/download/details.aspx?id=101064] и (SQL Server Managemnet Studio)[https://aka.ms/ssmsfullsetup]
  2. Установить их

## Если установлен
1. Выполнить sql-скрипт PasswwordManager.sql

## В исходном коде программе
1. в файле PasswordManager.Core/Data/PasswordManagerContext.cs сделать следующие изменения:<br/>
Изменить optionsBuilder.UseSqlServer("Server=192.168.33.47\\\\\\\\SQLEXPRESS,1433;Database=PasswordManager;User Id=Administrator;Password=AdminPassword01;");<br/>
на optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PasswordManager;Trusted_Connection=True;");

**Перед демонстраций приложения на дипломной комииссии, свяжитесь со мной, чтобы убедиться, что оно запустится**

При любых вопросах обращаться по электронной почте: kusov.anatoly@gmail.com и в телеграме @KusovAnatoly
