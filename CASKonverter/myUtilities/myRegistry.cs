using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace CASKonverter.myUtilities
{
    public sealed class myRegistry
    {
        private static volatile myRegistry instance;
        private static object syncRoot = new object();

        private RegistryKey m_key;
        
        //Konstruktor
        private myRegistry() 
        {
            RegistryKey keySoftware = Registry.CurrentUser.OpenSubKey("Software", true);
            m_key = keySoftware.CreateSubKey("CASKonverter", RegistryKeyPermissionCheck.ReadWriteSubTree);        
        }

        //Methoden
        public void regValue(string Name, string Wert)
        {
            try
            {
                m_key.SetValue(Name, Wert);
            }
            catch { }
        }
        
        public void regValue(string Name, bool Wert)
        {
            try
            {
                m_key.SetValue(Name, Wert);
            }
            catch { }
        }

        public object readValue(string Name)
        {
            object Wert = m_key.GetValue(Name);

            return Wert;
        }

        public static myRegistry Instance
        {
            get 
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new myRegistry();
                    }
                }
                return instance;
            }
        }
    }
}
