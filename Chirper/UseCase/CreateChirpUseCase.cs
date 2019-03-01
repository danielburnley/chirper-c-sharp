using Chirper.Domain;
using Chirper.Gateway;
using Chirper.UseCase.Request;

namespace Chirper.UseCase
{
    public class CreateChirpUseCase : ICreateChirp
    {
        private IChirpCreator _chirpCreator;
        
        public CreateChirpUseCase(IChirpCreator chirpCreator)
        {
            _chirpCreator = chirpCreator;
        }

        public void Execute(CreateChirpRequest request)
        {
            Chirp chirp = new Chirp{Username = request.Username};
            _chirpCreator.CreateChirp(chirp);
        }
    }
}