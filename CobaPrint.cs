using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sfs2X.Entities.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;

public class CobaPrint : MonoBehaviour
{
	public GameObject cobaMarker;
	
    string path = null;
    
    void Start()
    {
        path = Application.dataPath + "/Marker.pdf";  
       
    }

    public void GenerateFile() {
        if (File.Exists(path))
            File.Delete(path);
        using (var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
        {
            var document = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            var writer = PdfWriter.GetInstance(document, fileStream);

            document.Open();

            document.NewPage();
          
            document.Add(cobaMarker);

            document.Close();
            writer.Close();
        }
        PrintFiles();
    }

    void PrintFiles()
    {
        Debug.Log(path);
        if (path == null)
            return;

        if (File.Exists(path))
        {
            Debug.Log("file found");
        }
        else
        {
            Debug.Log("file not found");
            return;
        }
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
        process.StartInfo.UseShellExecute = true;
        process.StartInfo.FileName = path;

        process.Start();
    }
}
