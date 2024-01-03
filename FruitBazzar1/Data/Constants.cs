using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.Data
{
    public static class Constants
    {
        /// </summary>
        public static string ServiceUri = "https://demo-datasync-quickstart.azurewebsites.net";

        /// <summary>
        /// The application (client) ID for the native app within Microsoft Entra ID
        /// </summary>
        public static string ApplicationId = "<eddca0d7-6d74-4653-864f-2d95116100a1>";

        /// <summary>
        /// The list of scopes to request
        /// </summary>
        public static string[] Scopes = new[]
        {
          "<api://920bb91a-fdcd-40ac-9d95-c4ca6e02c28c/access_as_user>"
      };
    }
}
