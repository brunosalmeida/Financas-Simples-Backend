﻿namespace FS.Domain.Model
{
    using System;
    using FS.Utils.Enums;

    public class Moviment : Base
    {
        public decimal Value { get; private set; }
        public string Description { get; private set; }
        public EMovementCategory Category { get; private set; }
        public EMovementType Type { get; private set; }
        public Guid AccountId { get; }
        
        public Guid UserId { get; }

        public Moviment(decimal value, string description, EMovementCategory category, EMovementType type,
            Guid accountId, Guid userId)
            : base()
        {
            Value = value;
            Description = description;
            Category = category;
            Type = type;
            AccountId = accountId;
            UserId = userId;
        }

        public Moviment(Guid id, decimal value, string description, EMovementCategory category, EMovementType type,
            Guid accountId, Guid userId, DateTime createdOn, DateTime? updatedOn) 
            : base(id, createdOn, updatedOn)
        {
            Value = value;
            Description = description;
            Category = category;
            Type = type;
            AccountId = accountId;
            UserId = userId;
        }

        public void SetCategory(EMovementCategory category) => this.Category = category;
        public void SetExpenseType(EMovementType type) => this.Type = type;
        public void SetValue(decimal value) => this.Value = value;
        public void SetDescription(string description) => this.Description = description;
    }
}