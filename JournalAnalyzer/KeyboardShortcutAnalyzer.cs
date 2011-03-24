using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace JournalAnalyzer
{
    /// <summary>
    /// Analyzes a journal fine to get the most popular keyboard shortcuts and commands 
    /// Author: Rod Howarth http://www.rodhowarth.com 
    /// </summary>
    class KeyboardShortcutAnalyzer
    {
        private string _shortcutDir;
        private string _keyboardShortcutsFile;
        private const int TOP_LIMIT = 20;

        public KeyboardShortcutAnalyzer(string shortcutDir, string keyboardShortcutsFile)
        {
            if (!Directory.Exists(shortcutDir))
                throw new ArgumentException("That directory does not exist");
            _shortcutDir = shortcutDir;
            _keyboardShortcutsFile = keyboardShortcutsFile;

        }

        public IEnumerable<string> GetTopShortcutsUsed()
        {
            IEnumerable<string> topShortcuts = GetTopEntries(TOP_LIMIT, new List<string>{"KeyboardShortcut"});

            if (!File.Exists(_keyboardShortcutsFile))
                return topShortcuts;

            //replace the ID's with the actual Keys
            List<string> topShortcutsReplaced = new List<string>();
            foreach (string shortcut in topShortcuts)
            {
                topShortcutsReplaced.Add(ReplaceIdWithShortcut(shortcut));
            }
            return topShortcutsReplaced;
        }

        private string ReplaceIdWithShortcut(string lineToModify)
        {

            //get the ID to look for 
            string id = lineToModify.Substring(lineToModify.IndexOf("ID_"));
            id = id.Substring(0, id.IndexOf(" - ")).Replace("\"", "");
            FileStream file = File.Open(_keyboardShortcutsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(file);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!line.Contains(id))
                    continue;

                //its got the ID, extract the Shortcuts
                string shortCutsText = "\" Shortcuts=";
                int indexOfShortcuts = line.IndexOf(shortCutsText);
                int indexOfPaths = line.IndexOf("Paths=\"");
                string shortcuts = line.Substring(indexOfShortcuts + shortCutsText.Length, indexOfPaths - (indexOfShortcuts + shortCutsText.Length));
                shortcuts = shortcuts.Replace("\"", "");
                lineToModify = lineToModify.Replace(id, shortcuts).Replace("\"", "");
            }
            return lineToModify;
        }

        public IEnumerable<string> GetTopRibbonCommandsUsed(bool includeContextMenu)
        {
            List<string> searchCommands = new List<string> {"Internal"};

            if (includeContextMenu)
                searchCommands.Add("ContextMenu");

            return GetTopEntries(TOP_LIMIT, searchCommands);
        }


        /// <summary>
        /// Parses the documents and looks for the top entryLimit amount of lines with Jrn.Command "commandName"
        /// </summary>
        public IEnumerable<string> GetTopEntries(int entryLimit, IEnumerable<string > commandNameSearches)
        {
            //dictionary to hold counts of entries
            IDictionary<string, int> entries = new Dictionary<string, int>();

            //loop through 
            foreach (string filePath in Directory.GetFiles(_shortcutDir, "journal*.txt"))
            {
                FileStream file = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(file);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //search through each command name ption
                    foreach (string commandName in commandNameSearches)
                    {
                        string linePrefix = "Jrn.Command \"" + commandName + "\" ,";
                        if (line.Contains(linePrefix))
                        {
                            string entry = line.Replace(linePrefix, "");
                            if (entries.ContainsKey(entry))
                                entries[entry]++;
                            else
                                entries.Add(entry, 1);
                        }
                    }
                }
            }

            //done looping, now sort the top entries
            var sortedDict = (from entry in entries
                              orderby entry.Value descending
                              select entry).ToList();

            for (int i = 0; i < entryLimit && i < sortedDict.Count; i++)
            {
                yield return sortedDict[i].Key + " - " + sortedDict[i].Value + " times";
            }
        }

    }
}
