using System;
using System.Collections.Generic;
using System.IO;

namespace DocFile_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePart = @"E:\CodeGym\bai tap CodeGym\File\DocFile CSV\csv.txt";
            List<string> listReader = new List<string>();
            try
            {
                FileStream file = new FileStream(filePart, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string temp = "";
                while((temp = reader.ReadLine())!= null)
                {
                    listReader.Add(temp);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("khong tim thay file");
            }
            List<string> listNational = new List<string>();

            for (int i = 0; i < listReader.Count; i++)
            {
                string[] tachchuoi = listReader[i].Split(',');
                
                if (CheckExisted(tachchuoi[tachchuoi.Length - 1], listNational))
                {
                    listNational.Add(tachchuoi[tachchuoi.Length - 1]);
                }
            }
            Console.WriteLine("cac quoc gia trong file la ");
            foreach (string national in listNational)
            {
                Console.Write(national + " ");
            }
        }
        static bool CheckExisted(string temp , List<string> list)
        {
            foreach(string national in list)
            {
                if (temp == national)
                    return false;
            }
            return true;
        }
    }
}
