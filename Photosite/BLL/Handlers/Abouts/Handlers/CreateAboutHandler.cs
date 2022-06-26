using AutoMapper;
using Photosite.BLL.DTO.Abouts;
using Photosite.DAL.Entities;
using Photosite.DAL.Repositories.About;

namespace Photosite.BLL.Handlers.Abouts.Handlers
{
    public class CreateAboutHandler : IBaseHandler<CreateAboutCommand, CreateAboutResponse>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public CreateAboutHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        } // CreateAboutHandler

        public async Task<CreateAboutResponse> Handle(CreateAboutCommand command, CancellationToken token)
        {
            var about = _mapper.Map<AboutEntity>(command.About);

            _aboutRepository.Add(about);
            await _aboutRepository.SaveChangesAsync(token);

            return new CreateAboutResponse
            {
                Id = about.Id
            };
        } // Handle
    }
}
