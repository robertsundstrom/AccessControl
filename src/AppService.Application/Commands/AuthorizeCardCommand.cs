﻿using System.ComponentModel.DataAnnotations;
using MediatR;

namespace AppService.Application.Commands
{
    public class AuthorizeCardCommand : IRequest<AuthorizeCardResult>
    {
        [Required]
        public string DeviceId { get; set; }

        public byte[] CardNo { get; set; }

        public string Pin { get; set; }
    }
}