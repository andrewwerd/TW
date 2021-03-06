﻿using AutoMapper;
using DbCard.Infrastructure.Dto.Partner;

namespace DbCard.Infrastructure.Profiles.Partners
{
    public class PartnerProfile : Profile
    {
        public PartnerProfile()
        {
            CreateMap<Domain.Partner, Partner>();
            CreateMap<PartnerForRegistration, Domain.Partner>();
        }
    }
}
