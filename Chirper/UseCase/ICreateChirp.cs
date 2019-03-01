using Chirper.UseCase.Request;

namespace Chirper.UseCase
{
    public interface ICreateChirp
    {
        void Execute(CreateChirpRequest request);
    }
}