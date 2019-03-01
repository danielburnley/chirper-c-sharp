using Chirper.Gateway;
using Chirper.UseCase.Response;

namespace Chirper.UseCase
{
    public class GetTimelineUseCase : IGetTimeline
    {
        private IChirpGetter _getAllChirpsGateway;

        public GetTimelineUseCase(IChirpGetter getAllChirpsGateway)
        {
            _getAllChirpsGateway = getAllChirpsGateway;
        }

        public GetTimelineResponse Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}