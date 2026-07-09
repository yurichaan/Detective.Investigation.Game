using System;
using System.Collections.Generic;

namespace DetectiveInvestigationSystem.Models
{
    public class Notebook
    {
        private List<string> notes = new List<string>();

        public void AddNote(string note)
        {
            if (!notes.Contains(note))
            {
                notes.Add(note);
            }
        }

        public int NotesCount()
        {
            return notes.Count;
        }

        public void ShowNotes()
        {
            Console.Clear();

            Console.WriteLine("========== DETECTIVE NOTEBOOK ==========\n");

            if (notes.Count == 0)
            {
                Console.WriteLine("No evidence collected yet.");
            }
            else
            {
                foreach (string note in notes)
                {
                    Console.WriteLine("✔ " + note);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}