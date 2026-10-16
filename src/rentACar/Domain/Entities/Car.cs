using NArchitecture.Core.Persistence.Repositories;
using System;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
    public string BrandName { get; set; }
}
