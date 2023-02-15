using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using JetBrains.Annotations;

using Volo.Abp;

namespace SampleDemo.Categories
{
    public class Category : FullAuditedAggregateRoot<Guid>
    {
        [NotNull]
        public virtual string Name { get; set; }

        [CanBeNull]
        public virtual string Description { get; set; }

        public Category()
        {

        }

        public Category(Guid id, string name, string description)
        {

            Id = id;
            Check.NotNull(name, nameof(name));
            Name = name;
            Description = description;
        }

    }
}