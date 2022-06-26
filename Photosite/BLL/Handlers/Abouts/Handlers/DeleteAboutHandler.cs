using AutoMapper;
using Photosite.BLL.DTO.Abouts;
using Photosite.DAL.Entities;
using Photosite.DAL.Repositories.About;

namespace Photosite.BLL.Handlers.Abouts.Handlers
{
    public class DeleteAboutHandler : IBaseHandler<DeleteAboutCommand, long>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public DeleteAboutHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        } // DeleteAboutHandler

        public async Task<long> Handle(DeleteAboutCommand command, CancellationToken token)
        {
            var about = await _aboutRepository.GetOne(command.Id, token);

            _aboutRepository.Remove(about);
            await _aboutRepository.SaveChangesAsync(token);

            return command.Id;
        } // Handle
    }
}
