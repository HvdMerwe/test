using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Another_Text_File_Example
{
    
    public partial class Form1 : Form
    {
        //object to save as string
        private Guy SomeGuy { get; set; }
        //Main form
        public Form1()
        {
            InitializeComponent();
        }

        //Save function
        private static void Save()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\Doc.txt");

                //Write a line of text
                sw.WriteLine();

                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Dasta sucessfully written to file.");
                Console.ReadLine();
            }
        }
    }

    //class to save
    public class Guy
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Guy(string Name, int Age)
        {

        }
    }
}
