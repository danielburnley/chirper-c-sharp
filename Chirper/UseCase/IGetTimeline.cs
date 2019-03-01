using Chirper.UseCase.Response;

namespace Chirper.UseCase
{
    public interface IGetTimeline
    {
        GetTimelineResponse Execute();
    }
}