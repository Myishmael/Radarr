using NzbDrone.Core.Messaging.Commands;

namespace NzbDrone.Core.Update.Commands
{
    public class InstallUpdateCommand : Command
    {
        public override bool SendUpdatesToClient => true;
        public override bool IsExclusive => true;

        public override string CompletionMessage => null;
        public UpdatePackage LatestUpdate;
    }
}
