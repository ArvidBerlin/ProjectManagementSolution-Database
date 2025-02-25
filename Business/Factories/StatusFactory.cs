using Business.Models;
using Data.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Business.Factories;

public static class StatusFactory
{
    public static Status? Map(StatusEntity entity) => entity == null ? null : new Status
    {
        Id = entity.Id,
        StatusName = entity.StatusName
    };
}
