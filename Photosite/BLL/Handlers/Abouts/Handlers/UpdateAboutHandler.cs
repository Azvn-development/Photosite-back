using AutoMapper;
using Photosite.BLL.DTO.Abouts;
using Photosite.DAL.Entities;
using Photosite.DAL.Repositories.About;

namespace Photosite.BLL.Handlers.Abouts.Handlers
{
    public class UpdateAboutHandler : IBaseHandler<UpdateAboutCommand, UpdateAboutResponse>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public UpdateAboutHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        } // UpdateAboutHandler

        public async Task<UpdateAboutResponse> Handle(UpdateAboutCommand command, CancellationToken token)
        {
            var about = _mapper.Map<AboutEntity>(command.About);

            _aboutRepository.Update(about);
            await _aboutRepository.SaveChangesAsync(token);

            return new UpdateAboutResponse
            {
                Id = about.Id
            };
        } // Handle
    }
}
