namespace WordInteractionLab8.Models.Interfaces
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public interface IDbDownloader
    {
        event EventHandler<InfoMessageEventsArgs> ShowInfoMessage;

        DataTable GetBankInfoTable();

        void UploadDb(ProgressBar progress);

        string GetCurrentDbVeresion();

        string GetActualDbVersion();
    }
}