namespace CB.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBannerCommand
    {
        public RemoveBannerCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
