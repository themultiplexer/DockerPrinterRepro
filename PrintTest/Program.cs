using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;

namespace PrintTest
{
    class Program
    {
       
        static void Main(string[] args)
        {

            string directory = System.IO.Directory.GetCurrentDirectory();
            PrintDocument printDocument1 = new PrintDocument() {
                PrinterSettings = new PrinterSettings() {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = Path.Combine(directory, "out.pdf"),
                },
                PrintController = new StandardPrintController()
            };
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printDocument1.Print();

        }

        private static void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hello World", new Font("Arial", 12), Brushes.Black,e.MarginBounds, StringFormat.GenericTypographic);
            e.HasMorePages = false;
        }
    }
}
