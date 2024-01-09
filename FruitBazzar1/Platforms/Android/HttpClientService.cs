using Java.Interop;
using Javax.Net.Ssl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Android.Net;
using Object = Java.Lang.Object;

namespace FruitBazzar1
{
    public partial class HttpClientService
    {

        public partial HttpMessageHandler GetPlatformSpecificHttpMessageHandler()
        {
#if ANDROID
            var handler = new Xamarin.Android.Net.AndroidMessageHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert != null && cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
#elif IOS
                    var handler = new NSUrlSessionHandler
                    {
                        TrustOverrideForUrl = IsHttpsLocalhost
                    };
                    return handler;
#else
                 throw new PlatformNotSupportedException("Only Android and iOS supported.");
#endif
            //public Func<HttpRequestMessage, X509Certificate2?, X509Chain?, SslPolicyErrors, bool>? ServerCertificateCustomValidationCallback
            //    var androidHttpHandler = new LocalhostAndroidMessagehandler()
            //    {
            //        ServerCertificateCustomValidationCallback = (httpRequestMessage, certificate, chain, sslPolicyErrors) =>
            //        {
            //            if (certificate?.Issuer == "CN=localhost" || sslPolicyErrors == SslPolicyErrors.None)
            //                return true;
            //            return false;
            //        },
            //    };

            //    return androidHttpHandler;
            //}
            //class LocalhostAndroidMessagehandler : AndroidMessageHandler
            //{
            //    protected override IHostnameVerifier GetSSLHostnameVerifier(HttpsURLConnection connection) => new LocalhostHostNameVerifier();

            //}
            //class LocalhostHostNameVerifier : Object, IHostnameVerifier
            //{
            //    public bool Verify(string hostname, ISSLSession session)
            //    {

            //        if (HttpsURLConnection.DefaultHostnameVerifier.Verify(hostname, session) || hostname == "10.0.2.2")
            //        {
            //            return true;
            //        }
            //        return false;
            //    }
            //}


        }
    }
}

