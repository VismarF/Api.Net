﻿namespace Domain.Entity
{
    public class BaseEntity<T>
    {
        public T Id { get; init; } = default!;
    }
}