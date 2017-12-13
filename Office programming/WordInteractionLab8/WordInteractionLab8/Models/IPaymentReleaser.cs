namespace WordInteractionLab8.Models
{
    using System;

    public interface IReleaser : IDisposable
    {
        void ReleasePayment(PaymentView payment, string savePath);
    }
}