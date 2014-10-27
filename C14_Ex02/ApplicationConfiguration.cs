using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C14_Ex02
{
    public class ApplicationConfiguration
    {
        private const string k_ApplicationId = "1520908384805603";
        private static ApplicationConfiguration s_ApplicationConfiguration;
        private List<string> m_AccessPremission;

        private ApplicationConfiguration()
        {
            buildApplicationPermissionsList();
        }

        private void buildApplicationPermissionsList()
        {
            m_AccessPremission = new List<string>();
            m_AccessPremission.Add("user_friends");
            m_AccessPremission.Add("user_events");
            m_AccessPremission.Add("user_photos");
            m_AccessPremission.Add("read_stream");
            m_AccessPremission.Add("user_likes");
            m_AccessPremission.Add("publish_actions");
            m_AccessPremission.Add("user_relationship_details");
            m_AccessPremission.Add("user_relationships");
            m_AccessPremission.Add("user_events");
            m_AccessPremission.Add("email");
            m_AccessPremission.Add("user_birthday");
            m_AccessPremission.Add("user_about_me");
            m_AccessPremission.Add("user_religion_politics");
       }

        public static ApplicationConfiguration GetConfiguration
        {
            get
            {
                if (s_ApplicationConfiguration == null)
                {
                    s_ApplicationConfiguration = new ApplicationConfiguration();
                }

                return s_ApplicationConfiguration;
            }
        }

        public List<string> GetCopyOfAccessPermission()
        {
            List<string> copyOfAccessPermission = new List<string>();

            foreach(string permission in m_AccessPremission)
            {
                copyOfAccessPermission.Add(permission);
            }

            return copyOfAccessPermission;
        }

        public string GetApplicationId
        {
            get
            {
                return k_ApplicationId;
            }
        }
    }
}
