using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class getText : MonoBehaviour
{
    public int length = 5;
    public string str = "a";
    // Start is called before the first frame update
    void Start()
    {
        //in this we store path
        string path = @"C:/Users/pares/Desktop/Unity/task2/Assets/File/task2.txt";
        // in this list we store our data line by lene
        List<string> fileData = File.ReadAllLines(path).ToList();
        //in this foreach loop we print our data from list
        foreach (string line in fileData)
        {
            if (line.Length == length && line.Substring(0, 1).Equals(str))
            {
                Debug.Log(line);
            }
           
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
