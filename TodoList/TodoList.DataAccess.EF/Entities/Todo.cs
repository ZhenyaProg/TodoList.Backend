﻿namespace TodoList.DataAccess.EF.Entities
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool Success { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}