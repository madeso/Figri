using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace SeriesNamer
{
    public static class Web
    {
        public static bool PageExist(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.ReadWriteTimeout = 1000;
            request.AllowAutoRedirect = true;

            // execute the request
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // we will read data via the response stream
                    using (Stream s = response.GetResponseStream())
                    {
                        return true;
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    return false;
                }
                else throw ex;
            }
        }

        public static bool IsUrl(string text)
        {
            Uri.IsWellFormedUriString(text, UriKind.Absolute);
            return true;
        }

        public static string FetchString(string url)
        {
            // used to build entire input
            StringBuilder sb = new StringBuilder();
            string tempString = null;
            int count = 0;

            byte[] buf = new byte[8192];

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ReadWriteTimeout = 1000;

            // execute the request
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // we will read data via the response stream
                using (Stream resStream = response.GetResponseStream())
                {

                    do
                    {
                        count = resStream.Read(buf, 0, buf.Length);

                        if (count != 0)
                        {
                            tempString = Encoding.ASCII.GetString(buf, 0, count);
                            sb.Append(tempString);
                        }
                    }
                    while (count > 0);
                }
            }

            return sb.ToString();
        }

        public static void OpenUrl(string url)
        {
            Process.Start(url);
        }

        internal static void DownloadTo(string url, string zipfile)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ReadWriteTimeout = 1000;

            // execute the request
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // we will read data via the response stream
                using (Stream resStream = response.GetResponseStream())
                {
                    using (FileStream outs = File.OpenWrite(zipfile))
                    {
                        byte[] buf = new byte[8192];
                        int count;
                        do
                        {
                            count = resStream.Read(buf, 0, buf.Length);

                            if (count != 0)
                            {
                                outs.Write(buf, 0, count);
                            }
                        }
                        while (count > 0);
                    }
                }
            }
        }
    }
}
