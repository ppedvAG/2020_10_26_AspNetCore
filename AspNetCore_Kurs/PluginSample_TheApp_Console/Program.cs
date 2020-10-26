using PluginSample_PluginDLL;
using PluginSample_ThePlugin;
using System;

namespace PluginSample_TheApp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Eigentliche Variante
            //Entweder Lese alle PlugIn-Dlls aus einem Verzeichnis. Und lasse jedes einzelne danach starten. 
            //Zum Beispiel TheApp/PluginFolder -> hier befinden sich alle PlugIns in Form einer DLL 




            //Zauberhafter kurzer. PlugIn wurde gefunden und eingelesen und liegt so in etwas vor: 

            IMyPlugin myPlugin = new MySpecialPlugIn(); //Eigentlich sollte dieses Plugin wie in der Eigentlichen Variante vorhanden sein. 

            RunPlugin(myPlugin);
        }


        static void RunPlugin(IMyPlugin myPlugin)
        {
            myPlugin.Execute();
        }
    }
}
