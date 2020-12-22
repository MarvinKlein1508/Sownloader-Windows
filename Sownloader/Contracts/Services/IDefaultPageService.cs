using System;

namespace Sownloader.Contracts.Services
{
    public interface IDefaultPageService
    {
        Uri GetDefaultPage();
        void InitializeDefaultPage();
        void SetDefaultPage(string defaultPage);
    }
}