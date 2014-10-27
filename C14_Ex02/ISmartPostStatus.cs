using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C14_Ex02
{
    public interface ISmartPostStatus
    {
        void PostAndBackupStatus(string i_StatusText, string i_PrivacyParameterValue = null);
    }
}
