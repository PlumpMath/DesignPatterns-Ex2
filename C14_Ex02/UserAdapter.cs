using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C14_Ex02
{
    public class UserAdapter : ISmartPostStatus
    {
        private User m_Adaptee;

        public UserAdapter(User i_User)
        {
            m_Adaptee = i_User;
        }

        public void PostAndBackupStatus(string i_StatusText, string i_PrivacyParameterValue = null)
        {
            m_Adaptee.PostStatus(i_StatusText, i_PrivacyParameterValue);
            LogFacebookPostByUser.Instance.WriteToLogFileSuccessfullPost(i_StatusText);
        }
    }
}
