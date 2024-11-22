using RealEstateCrm.APIs.Dtos;
using RealEstateCrm.Infrastructure.Models;

namespace RealEstateCrm.APIs.Extensions;

public static class AgentAssignmentsExtensions
{
    public static AgentAssignment ToDto(this AgentAssignmentDbModel model)
    {
        return new AgentAssignment
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static AgentAssignmentDbModel ToModel(
        this AgentAssignmentUpdateInput updateDto,
        AgentAssignmentWhereUniqueInput uniqueId
    )
    {
        var agentAssignment = new AgentAssignmentDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            agentAssignment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            agentAssignment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return agentAssignment;
    }
}
