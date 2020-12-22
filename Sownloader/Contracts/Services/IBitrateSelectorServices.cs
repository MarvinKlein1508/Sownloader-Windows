namespace Sownloader.Contracts.Services
{
    public interface IBitrateSelectorServices
    {
        string GetCurrentBitrate();
        void InitializeBitrate();
        bool IsValidBitrate(string bitrate);
        void SetBitrate(string bitrate);
    }
}