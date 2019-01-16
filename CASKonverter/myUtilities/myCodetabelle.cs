using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CASKonverter.myUtilities
{
    public sealed class myCodetabelle
    {
        private static volatile myCodetabelle instance;
        private static object syncRoot = new object();

        private myUtilities.myRegistry m_objRegistry = myUtilities.myRegistry.Instance;
        private Dictionary<string, string> m_dicCodetabelle = new Dictionary<string, string>();
        private bool m_bCode;
        private string m_Codetabelle;

        //Konstruktor
        public myCodetabelle()
        {
            readCodeTable();
        }

        //Properties
        public bool Codetabelle
        {
            get 
            {
               return m_bCode; 
            }
        }

        //Methoden
        public void readCodeTable()
        {
            m_bCode = Convert.ToBoolean(m_objRegistry.readValue("chk Codetabelle"));
            m_Codetabelle = (string)m_objRegistry.readValue("Codetabelle");

            if (m_bCode)
            {
                StreamReader sr = new StreamReader(m_Codetabelle, Encoding.Default);
                string Text = sr.ReadToEnd();
                sr.Close();

                string[] arText = Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                //Zeilen von Codes in Array einfügen
                string[] arZeile;
                foreach (string Zeile in arText)
                {
                    arZeile = Zeile.Split(new char[] { ';' }, StringSplitOptions.None);
                    m_dicCodetabelle.Add(arZeile[0], arZeile[1]);
                }
            }
        }

        public string getText(string Code)
        {
            string Text = String.Empty;
            
            try 
            {
                string[] MC;
                MC = Code.Split(new char[] { ':' });
                m_dicCodetabelle.TryGetValue(MC[0], out Text);

                if (MC.Length > 1)
                    Text += ":" + MC[1];
            }
            catch { Text = "*"; }

            return Text;
        }

        public static myCodetabelle Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new myCodetabelle();
                    }
                }
                return instance;
            }
        }
    }
}
