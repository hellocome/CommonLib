using System;
using System.Text;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using CommonLib.Logging;

namespace CommonLib.Utilities
{
    public static class XMLValidator
    {
        public static bool ValidateXMLString(string xmlString, string xsdFilename)
        {
            StringBuilder logBuilder = new StringBuilder();
            bool errors = false;

            try
            {
                logBuilder.AppendLine("Attempting to validate");

                XmlSchemaSet schemas = new XmlSchemaSet();
                schemas.Add("", xsdFilename);

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas = schemas;
                settings.ValidationType = ValidationType.Schema;

                settings.ValidationEventHandler += (sender, e) =>
                {
                    logBuilder.AppendLine(string.Format("Lines: {0}  Position: {1} Message: {2}",
                        e.Exception.LineNumber,
                        e.Exception.LinePosition,
                        e.Message));

                    errors = true;
                };

                XmlReader reader = XmlReader.Create(new StringReader(xmlString), settings);
                
                XDocument.Load(reader);
                logBuilder.AppendLine(string.Format("Result: {0}", errors ? "did not validate" : "validated"));
            }
            catch (Exception ex)
            {
                Logger.Instance.Error("Failed to validate xml file: ", ex);
                errors = true;
            }
            finally
            {
                Logger.Instance.Info("XML Parse Log: " + logBuilder.ToString());
            }

            return !errors;
        }

        public static bool ValidateXMLFile(String filename, string xsdFilename)
        {
            StringBuilder logBuilder = new StringBuilder();
            bool errors = false;

            try
            {
                XmlSchemaSet schemas = new XmlSchemaSet();
                schemas.Add("", xsdFilename);
                logBuilder.AppendLine("Attempting to validate");
                XDocument custOrdDoc = XDocument.Load(filename);

                custOrdDoc.Validate(schemas, (o, e) =>
                {
                    logBuilder.AppendLine(string.Format("{0}", e.Message));
                    errors = true;
                });

                logBuilder.AppendLine(string.Format("Result: {0}", errors ? "did not validate" : "validated"));
            }
            catch (Exception ex)
            {
                Logger.Instance.Error("Failed to validate xml file: ", ex);
                errors = true;
            }
            finally
            {
                Logger.Instance.Info("XML Parse Log: " + logBuilder.ToString());
            }

            return errors;
        }
    }
}
