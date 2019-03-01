using Chirper.Domain;

namespace Chirper.Gateway
{
    public interface IChirpCreator
    {
        void CreateChirp(Chirp chirp);
    }
}