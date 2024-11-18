namespace CB.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public RemoveAboutCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
