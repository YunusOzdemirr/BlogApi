﻿using System;
namespace CmnSoftwareBackend.Entities.Dtos.UserOperationClaimDtos
{
    public class UserOperationClaimUpdateDto
    {
        public Guid UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
