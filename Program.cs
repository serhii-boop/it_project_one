using lab4_films.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_films
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           /*using (EFDbcontext context = new EFDbcontext())
            {
                Actor actor = new Actor();
                actor.name = "Джекі Чан";
                actor.age = 60;
                actor.nationality = "Китай";

            
                context.Actors.Add(actor);
                context.SaveChanges();
            }*/


           
        }

        
    }
}
