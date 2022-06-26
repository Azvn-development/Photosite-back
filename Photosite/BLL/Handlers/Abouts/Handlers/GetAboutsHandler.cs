using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Photosite.BLL.DTO.Abouts;
using Photosite.BLL.Models;
using Photosite.DAL.Repositories.About;

namespace Photosite.BLL.Handlers.Abouts.Handlers
{
    public class GetAboutsHandler: IBaseHandler<GetAboutsQuery, GetAboutsResponse>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public GetAboutsHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        } // GetAllHandler

        public async Task<GetAboutsResponse> Handle(GetAboutsQuery query, CancellationToken token)
        {
            var abouts = await _aboutRepository
                .GetAll()
                .AsNoTracking()
                .ToListAsync(token);

            return new GetAboutsResponse
            {
                Abouts = _mapper.Map<List<AboutModel>>(abouts)
            };
        } // Handle
    }
}
