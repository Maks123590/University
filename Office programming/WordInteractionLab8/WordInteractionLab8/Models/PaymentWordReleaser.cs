namespace WordInteractionLab8.Models
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    using Word = Microsoft.Office.Interop.Word;

    public class WordReleaser : IReleaser
    {
        private const string TemplateName = @"PaymentOrderTemplate.rtf";

        private readonly string templateDirectory;
        private readonly Word.Application wordApplication;

        private string templatePath;

        public WordReleaser(string templatesDirectory)
        {
            if (!Directory.Exists(templatesDirectory))
            {
                Directory.CreateDirectory(templatesDirectory);
            }

            this.templateDirectory = templatesDirectory;

            this.templatePath = @"\" + templatesDirectory + TemplateName;

            this.wordApplication = new Word.Application();
        }

        public event EventHandler<InfoMessageEventsArgs> ShowInfoMessage;

        public void ReleasePayment(PaymentView payment, string savePath = "SaivedPayments")
        {
            try
            {
                var doc = this.CreateDoc(Application.StartupPath + this.templatePath);

                doc = this.FillPaymentDoc(doc, payment);

                this.DeleteBookmarks(doc);

                this.SaveDoc(doc, savePath + @"\Payment" + payment.Number);
            }
            catch (Exception e)
            {
                this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Внутренняя ошибка!", Type = MessageType.InfoMessage });
            }   
        }

        public void Dispose()
        {
            this.wordApplication.Quit();
        }

        protected virtual void OnShowInfoMessage(InfoMessageEventsArgs e)
        {
            EventHandler<InfoMessageEventsArgs> handler = this.ShowInfoMessage;

            handler?.Invoke(this, e);
        }

        private Word.Document CreateDoc(string templatePath)
        {
            var doc = this.wordApplication.Documents.Add(templatePath);

            return doc;
        }

        private Word.Document FillPaymentDoc(Word.Document document, PaymentView payment)
        {
            document.Bookmarks["PayNumber"].Range.Text = payment.Number;

            document.Bookmarks["PayNumber"].Range.Text = payment.Number;
            document.Bookmarks["Date"].Range.Text = payment.Date;
            document.Bookmarks["PayType"].Range.Text = payment.PaymentType;
            document.Bookmarks["PayAmount"].Range.Text = payment.PaymentAmount;
            document.Bookmarks["PayAmountInWords"].Range.Text = payment.PaymentAmountInWords;
            document.Bookmarks["PayDescription"].Range.Text = payment.Description;
            document.Bookmarks["PayQueue"].Range.Text = payment.PayQueue;

            document.Bookmarks["PayerInn"].Range.Text = payment.Payer.INN;
            document.Bookmarks["PayerCpp"].Range.Text = payment.Payer.CPP;
            document.Bookmarks["PayerName"].Range.Text = payment.Payer.Name;
            document.Bookmarks["PayerBankAcc"].Range.Text = payment.Payer.BankAccount.BankInfo.CorrespondentAccount;
            document.Bookmarks["PayerBankBic"].Range.Text = payment.Payer.BankAccount.BankInfo.Bic;
            document.Bookmarks["PayerBankName"].Range.Text = payment.Payer.BankAccount.BankInfo.FullName + payment.Payer.BankAccount.BankInfo.Locality;
            document.Bookmarks["PayerCorrespAcc"].Range.Text = payment.Payer.BankAccount.CurrentAccount;

            document.Bookmarks["PayeeInn"].Range.Text = payment.Payee.INN;
            document.Bookmarks["PayeeCpp"].Range.Text = payment.Payee.CPP;
            document.Bookmarks["PayeeName"].Range.Text = payment.Payee.Name;
            document.Bookmarks["PayeeBankCorrespAcc"].Range.Text = payment.Payee.BankAccount.BankInfo.CorrespondentAccount;
            document.Bookmarks["PayeeBankBic"].Range.Text = payment.Payee.BankAccount.BankInfo.Bic;
            document.Bookmarks["PayeeBankName"].Range.Text = payment.Payee.BankAccount.BankInfo.FullName + payment.Payee.BankAccount.BankInfo.Locality;
            document.Bookmarks["PayeeBankAcc"].Range.Text = payment.Payee.BankAccount.CurrentAccount;


            return document;
        }

        private void SaveDoc(Word.Document document, string fileName)
        {
            document.SaveAs(fileName);

            this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Готово.", Type = MessageType.InfoMessage });
        }

        private void DeleteBookmarks(Word.Document document)
        {
            foreach (Word.Bookmark bookmark in document.Bookmarks)
            {
                bookmark.Delete();
            }
        }
    }
}