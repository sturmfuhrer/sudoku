using System;
using System.IO;

public class SaveLoad
{
	public SaveLoad()
	{
	}

    void save()
    { 
        FileStream fs =  new FileStream("save.dat", FileMode.Create);
        BinaryWriter bw = new BinaryWriter(fs);
        for (int i=0; i<81; i++)
            bw.Write(mas[i]);
        fs.Close();
    }

    void load()
    {
        FileStream fs =  new FileStream("save.dat", FileMode.Open);
        BinaryReader br = new BinaryReader(fs);
        for (int i=0; i<81; i++)
            mas[i]=br.ReadInt32();
        fs.Close();
    }

}
