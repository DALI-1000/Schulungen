using SageAufbaukursCSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SageAufbaukursCSharp.ServiceImplementations
{
    public class SaveFilesUtil : ISaveFileUtil
    {
        public Exception Fault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Message { get; private set; }

        public string FaultPath { get; private set; }

        public bool Save(object beleg, string path)
        {
            throw new NotImplementedException();
        }
        public bool Save(object beleg)
        {
            try
            {
                using (var sw = new StreamWriter(""))
                {
                    sw.Write("hello - all is good");
                }
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                Message = ex.Message;
                Fault = ex;
                return false;
            }
            catch (ArgumentException ex)
            {
                FaultPath = Path.Combine(Environment.GetEnvironmentVariable("PROGRAMDATA"), "Fehler.txt");
                using (var sw = new StreamWriter(FaultPath))
                {
                    sw.Write("Fehlerspeicher");
                }
            }

            catch (PathTooLongException ex)
            {
                Message = ex.Message;
                try
                {
                    FaultPath = Path.Combine(Environment.GetEnvironmentVariable("PROGRAMDATA"), "Errorfile.log");
                    using (var sw = new StreamWriter(FaultPath))
                    {
                        sw.Write("huhu");
                    }
                    return true;
                }
            }
            catch (Exception exa)
            {
                //Jetzt geben wir auf!
                Fault = exa;
                return false;
            }

            catch (PathTooLongException ex)
            {
                Fault = ex;
                return false;
            }

    }
}
