using Chirper.Gateway;
using Chirper.UseCase;
using Chirper.UseCase.Request;
using Chirper.UseCase.Response;
using NUnit.Framework;

namespace Tests
{
    public class ChirpTests
    {
        [Test]
        public void ItAllowsTheUserToPostSomeChirps()
        {
            IChirpCreator createGateway = new ChirpGateway();
//            IChirpGetter getAllChirpsGateway = new ChirpGateway();
//            IGetTimeline getTimelineUseCase = new GetTimelineUseCase(getAllChirpsGateway);
            ICreateChirp createChirpUseCase = new CreateChirpUseCase(createGateway);
            
            
            CreateChirpRequest request = new CreateChirpRequest
            {
                Username = "Cats",
                Body = "Im a cat"
            };

            createChirpUseCase.Execute(request);

//            GetTimelineResponse response = getTimelineUseCase.Execute();
        }
    }
}