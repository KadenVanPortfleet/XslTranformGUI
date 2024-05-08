using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using Fonet;
using Fonet.Pdf;
//using KLoggerTool;

namespace XslTransformGUI
{
    public static class XSLTransform
    {
        public static string pathToXsl = @"";
        public static string pathToXml = @"";
        public static string pathToDebug = @"";
        public static string outPdf = @"";
        public static FileSystemWatcher fwatcher;
        public static void RunXslTransform(string xslPath, string xmlPath)
        {
            //KLogger.ClearLog();
            //KLogger.Info("Starting VSCode!");
            pathToXsl = xslPath;
            pathToXml = xmlPath;
            pathToDebug = pathToXsl + @"\..\XslT_TempOutput.xml";
            outPdf = pathToXml + @"\..\TransformedPDF.pdf";

            if (!File.Exists(outPdf))
            {
                File.Create(outPdf).Dispose();
            }

            Process.Start($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe", $"-n \"{pathToXsl}\" \"{pathToXml}\"");
            //Wait for VSCode to load extensions before opening PDF.
            Thread.Sleep(2000);
            Process.Start($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe", $"\"{outPdf}\"");

            
            fwatcher = new FileSystemWatcher();
            fwatcher.Path = pathToXsl + @"\..\";
            fwatcher.Filter = pathToXsl.Split('\\').Last();
            fwatcher.EnableRaisingEvents = true;
            fwatcher.Changed += RunPdfTransform;
            
            //Only needed if not running with GUI. Keeps program open so thread can watch file. KEEP HERE
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //}
        }

        public static void RunPdfTransform(Object sender, FileSystemEventArgs e)
        {
            //DO NOT REMOVE. Prevent file from deleting itself. Dunno why...
            Thread.Sleep(50);
            try
            {
                //KLogger.Info("Transforming!");
                fwatcher.EnableRaisingEvents = false;
                XslCompiledTransform xForm = new XslCompiledTransform();
                XslTransform xTransform = new XslTransform();

                xForm.Load(pathToXsl);

                MemoryStream xmlOutput = new MemoryStream();

                MemoryStream pdfOutput = new MemoryStream();

                XPathDocument mydata = new XPathDocument(pathToXml);

                XmlReader reader = XmlReader.Create(pathToXml);

                xForm.Transform(pathToXml, pathToDebug);

                FonetDriver fo = FonetDriver.Make();
                fo.CloseOnExit = true;
                fo.Render(pathToDebug, outPdf);

            }
            catch (Exception ex)
            {
                //KLogger.Error("---ERROR---\n" + ex.ToString);
                fwatcher.EnableRaisingEvents = true;
            }
            finally
            {
                fwatcher.EnableRaisingEvents = true;
            }
        }
    }
}
