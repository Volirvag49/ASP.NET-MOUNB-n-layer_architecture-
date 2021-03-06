﻿namespace MOUNB.DAL.Entities
{
    public class User : BaseEntity
    {
        // Фамилия Имя Отчество
        public string Name { get; set; }
        // Логин
        public string Login { get; set; }
        // Пароль
        public string Password { get; set; }
        // Должность
        public string Position { get; set; }
        // Идентификатор роли
        public UserRole Role { get; set; }
    }

    public enum UserRole : byte
    {
        Нет = 0,
        Администратор = 1,
        Библиотекарь = 2
    }
}
