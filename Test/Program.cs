using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            DateTime t = DateTime.Now;
            Console.WriteLine(t.Second + " , " + t.Millisecond);
                string s = @"C:\Users\egois\Desktop\Yeni Metin Belgesi.txt";
            for (int i = 0; i < 9999; i++)
            {
                if (File.Exists(s))
                {
                    foreach (var item in File.ReadLines(s))
                    {
                        if (byte.TryParse(item, out byte b))
                            Console.WriteLine(b);
                    }
                }
            }


            t = DateTime.Now;
            Console.WriteLine(t.Second + " , " + t.Millisecond);
            Console.ReadKey();
            //  return;

            Console.WriteLine(File.Exists(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Form1.cs"));
            Console.WriteLine(File.ReadLines(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Form1.cs").First());

            Console.WriteLine(File.Exists(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Form1.Designer.cs"));
            Console.WriteLine(File.ReadLines(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Form1.Designer.cs").First());
            Console.WriteLine(File.Exists(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Form1.resx"));
            Console.WriteLine(File.ReadLines(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Form1.resx").First());
            Console.WriteLine(File.Exists(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Program.cs"));
            Console.WriteLine(File.ReadLines(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Program.cs").First());
            Console.WriteLine(File.Exists(@"E:\Project\convertSusle Py süslü ekle\convertSusle\App.config"));
            Console.WriteLine(File.ReadLines(@"E:\Project\convertSusle Py süslü ekle\convertSusle\App.config").First());
            Console.WriteLine(File.Exists(@"E:\Project\convertSusle Py süslü ekle\convertSusle\convertSusle.csproj"));
            Console.WriteLine(File.ReadLines(@"E:\Project\convertSusle Py süslü ekle\convertSusle\convertSusle.csproj").First());

            t = DateTime.Now;
            Console.WriteLine(t.Second + " , " + t.Millisecond);

            Console.WriteLine(File.Exists(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Windows Kits\Application Verifier (X86)\Application Verifier (WOW).lnk"));
            Console.WriteLine(File.ReadLines(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Windows Kits\Application Verifier (X86)\Application Verifier (WOW).lnk").First());
            t = DateTime.Now;
            Console.WriteLine(t.Second + " , " + t.Millisecond);



            // Dosyanın 5. satırını (yani 4. indeksini) okur
            Console.WriteLine(File.ReadLines(@"E:\Project\convertSusle Py süslü ekle\convertSusle\Form1.cs").ElementAt(4));

            t = DateTime.Now;
            Console.WriteLine(t.Second + " , " + t.Millisecond);
            Console.ReadKey();
        }
    }
}
