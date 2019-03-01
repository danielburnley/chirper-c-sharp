using Chirper.Domain;
using Chirper.Gateway;
using Chirper.UseCase;
using Chirper.UseCase.Request;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UseCase
{
    public class CreateChirpTest
    {
        private ICreateChirp _classUnderTest;
        private ChirpCreatorSpy _chirpCreatorSpy;

        [SetUp]
        public void SetUp()
        {
            _chirpCreatorSpy = new ChirpCreatorSpy();
            _classUnderTest = new CreateChirpUseCase(_chirpCreatorSpy);
        }

        [TestCase("cat")]
        [TestCase("Rabbit")]
        public void ItPassesTheUsernameToTheChirpCreator(string username)
        {
            CreateChirpRequest request = new CreateChirpRequest {Username = username};
            _classUnderTest.Execute(request);

            _chirpCreatorSpy.CreatedChirp.Username.Should().Be(username);
        }
    }

    internal class ChirpCreatorSpy : IChirpCreator
    {
        public Chirp CreatedChirp;

        public void CreateChirp(Chirp chirp)
        {
            CreatedChirp = chirp;
        }
    }
}