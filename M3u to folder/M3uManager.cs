using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace M3u_to_folder
{
    public class M3uManager
    {
        private string m3uFile;
        private StringDictionary list;

        public StringDictionary List
        {
            get { return list; }
        }

        public M3uManager(string path)
        {
            m3uFile = path;
            Load();
        }

        private void Load()
        {
            if (File.Exists(m3uFile))
            {
                try
                {
                    FileInfo fi = new FileInfo(m3uFile);
                    
                    //Check if is unicode
                    if (fi.Extension == ".m3u")
                    {
                        AnsitoUnicode();
                    }
                    list = Fill_List();
                }
                catch
                {
                    list = null;
                }
            }
            else
            {
                list = null;
            }
        }

        private StringDictionary Fill_List()
        {
            StringDictionary l = null;
            StreamReader reader = new StreamReader(m3uFile);
            string text;

            try
            {
                text = reader.ReadLine();
                if ((!String.IsNullOrEmpty(text)) && (text == "#EXTM3U"))
                {
                    l = new StringDictionary();
                    text = reader.ReadLine();
                    while( (!reader.EndOfStream) || (!String.IsNullOrEmpty(text)) )
                    {
                        //Get the title
                        string title = null;
                        int i = text.IndexOf(",") + 1;

                        if( (text.IndexOf("#EXTINF:") != -1) && (i != 0)) //Exists #EXTINF
                        {
                            title = text.Substring(i);

                            //Get the path
                            text = reader.ReadLine();
                        }
                        else
                        {
                            FileInfo fi = new FileInfo(text);
                            title = fi.Name;
                        }

                        //Add to dictionary
                        if(!l.ContainsKey(title))
                        {
                            l.Add(title, text);
                        }
                        text = reader.ReadLine();
                    }
                }
            }
            catch
            {
                l = null;
            }
            return l;
        }

        public bool Copy_File(string title, string folder)
        {
            bool result = true;
            string path = list[title];
            string target = Path.Combine(folder, Path.GetFileName(path));

            try
            {
                File.Copy(path, target, true);
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public long Get_File_size(string title)
        {
            long result = 0;
            string path = list[title];

            if (File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
                result = fi.Length / 1024;
            }
            return result;
        }

        private void AnsitoUnicode()
        {
            StreamReader sr = new StreamReader(m3uFile, Encoding.Default);
            StreamWriter sw = new StreamWriter("temp.m3u8", false, Encoding.Unicode);

            sw.Write(sr.ReadToEnd());
            sw.Close();
            sr.Close();

            m3uFile = "temp.m3u8";
        }
    }
}
