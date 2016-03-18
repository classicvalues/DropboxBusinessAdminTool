﻿namespace DfBAdminToolkit.View
{
    using System;

    public interface IMainView
        : IView
    {
        event EventHandler CommandQuitApplication;

        void EnableLoadingSpinner(bool enable);

        void EnableView(bool enable);

        void UpdateProgressText(string text);

        void ShowErrorMessage(string message, string title);

        void ShowInfoMessage(string message);
    }
}