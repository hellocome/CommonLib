using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CommonLib.XML
{
    public class AttributeGrammarObject
    {
        private static readonly char START_SYMBOL = '<';
        private static readonly char END_SYMBOL = '>';
        private static readonly char VALUE_SYMBOL = ':';
        private static readonly char AND_SYMBOL = '&';
        private static readonly char XOR_SYMBOL = '~';
        private static readonly string GT_SYMBOL = "~076";
        private static readonly string LT_SYMBOL = "~074";
        private readonly string mAGString;
        protected XmlDocument xmlDoc = new XmlDocument();

        public static XmlDocument ParseToXML(string agString)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(ParseToXMLString(agString));

            return doc;
        }

        public static string ParseToXMLString(string agString)
        {
            if (string.IsNullOrEmpty(agString))
            {
                throw new FormatException("Invalid format of Attribute Grammar Object! string is empty");
            }

            if(agString.TrimStart()[0] != '<')
            {
                throw new FormatException("Invalid format of Attribute Grammar Object! not valid format '<' ");
            }

            Stack<string> attributeStack = new Stack<string>();
            StringBuilder xml = new StringBuilder();

            StringBuilder attribute = new StringBuilder();
            bool attributeStart = false;

            for (int i = 0; i < agString.Length; i++)
            {
                char ch = agString[i];

                if (ch == START_SYMBOL)
                {
                    xml.Append(START_SYMBOL);

                    attributeStart = true;
                    attribute = new StringBuilder();
                }
                else if(ch == VALUE_SYMBOL && attributeStart)
                {
                    string att = attribute.ToString();

                    if (string.IsNullOrEmpty(agString))
                    {
                        throw new FormatException("Invalid format of Attribute Grammar Object! empty attribute");
                    }
                    
                    xml.Append(END_SYMBOL);
                    attributeStack.Push(att);

                    attributeStart = false;
                }
                else if (ch == END_SYMBOL)
                {
                    if(attributeStack.Count == 0)
                    {
                        throw new FormatException("Invalid format of Attribute Grammar Object! not valid format");
                    }

                    string str = attributeStack.Pop();

                    xml.Append(START_SYMBOL);
                    xml.Append('/');
                    xml.Append(str);
                    xml.Append(END_SYMBOL);
                }
                else if (ch == AND_SYMBOL)
                {
                    xml.Append("&amp;");
                }
                // only in value
                else if (ch == XOR_SYMBOL)
                {
                    string special = agString.Substring(i, 4);

                    if (special.Equals(GT_SYMBOL))
                    {
                        xml.Append("&gt;");
                        i = i + 3;
                    }
                    else if (special.Equals(LT_SYMBOL))
                    {
                        xml.Append("&lt;");
                        i = i + 3;
                    }
                    else
                    {
                        xml.Append(ch);
                    }
                }
                else
                {
                    if (attributeStart)
                    {
                        if (attribute.Length == 0 && !(Char.IsLetter(ch) || ch == '_'))
                        {
                            attribute.Append("Att_");
                            xml.Append("Att_");
                        }

                        attribute.Append(ch);
                    }

                    xml.Append(ch);
                }
            }

            return xml.ToString();
        }

        public AttributeGrammarObject(string agString)
        {
            mAGString = agString;
            xmlDoc = ParseToXML(agString);
        }

        public AttributeGrammarObject(XmlDocument xml)
        {
            xmlDoc = xml;
        }

        public override string ToString()
        {
            return mAGString;
        }
    }
}
