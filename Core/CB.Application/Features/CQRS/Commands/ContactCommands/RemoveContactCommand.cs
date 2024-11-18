namespace CB.Application.Features.CQRS.Commands.ContactCommands
{
    public class RemoveContactCommand
    {
        public RemoveContactCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
