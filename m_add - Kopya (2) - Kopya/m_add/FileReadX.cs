using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;


namespace m_add
{
    internal class FileReadX : IRead, ICoord, IWriteCoord
    {
        private string _atomId;
        private double _coord;
        private string _filePath;
        private string _atomName;
        private double _x;
        private double _y;
        private double _z;
        private double[,,] _data;



        private double[,,] New_ch4Coord = new double[5, 1, 3];



        public string AtomName
        {
            get { return _atomName; }
            set => throw new NotImplementedException();
        }

        public double X 
        {
            get { return _x; }
            set {  _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }



        public string AtomId
        {
            get { return _atomId; }
            set { _atomId = value; }
        }
        public double Coord
        {
            set { _coord = value; }
            get { return _coord; }
        }
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }



        public object[] CoordView { get; set; }


        public void ReadCifFile()
        {
            List<ICoord> coordinatesList = new List<ICoord>();
            string[] lines = File.ReadAllLines(FilePath);
            Regex r = new Regex(" +");
            foreach (string line in lines)
            {
                //string[] parts = line.Split(" ");
                String[] parts = Regex.Split(line, @" +");
                if (parts.Length >= 4 &&
                    double.TryParse(parts[1], out double x) &&
                    double.TryParse(parts[2], out double y) &&
                    double.TryParse(parts[3], out double z))
                {
                    string atomName = parts[0];
                    ICoord coordinates = new Coordinates(atomName, x, y, z);
                    coordinatesList.Add(coordinates);
                    CoordView = coordinatesList.ToArray();
                    //dataGridView1.DataSource = coordinatesList;
                }
            }

        }
        private double tmpX;
        private double tmpY;
        private double tmpZ;
        private double dX;
        private double dY;
        private double dZ;
        private double[,,] ch4Coord = new double[5, 1, 3]
        {
                { {2.469023652424, 7.075873630981, 12.626259030454 } }, // CH4 ün C'si
                { {3.364370652424, 7.588981630981, 12.256353030454 } },
                { {1.575548652424, 7.592829630981, 12.257182030454 } },
                { {2.469528652424, 7.079751630981, 13.721809030454 } },
                { {2.466623652424, 6.041793630981, 12.262319030454 } }
        };
        public void MoveCoordCalcul()   // CH4 ün kordinatlarını seçili atoma göre yeniden düzenle
        {
            // z Kordinatı
            tmpZ = ch4Coord[0, 0, 2];
            New_ch4Coord[0, 0, 2] = _z + 2.5;   // CH4 ün C sini seçili atomun z kordiantını 2.6 angstom üzerine taşı
            dZ = New_ch4Coord[0, 0, 2] - tmpZ;

            for (int i = 1; i < 5; i++)
            {
                New_ch4Coord[i, 0, 2] = ch4Coord[i, 0, 2] + dZ;
                
            }

            // x koridnatı
            tmpX = ch4Coord[0, 0, 0];
            New_ch4Coord[0, 0, 0] = _x;
            dX = New_ch4Coord[0, 0, 0] - tmpX;

            for (int i = 1; i < 5; i++)
            {
                New_ch4Coord[i, 0, 0] = ch4Coord[i, 0, 0] + dX;
            }

            // y kordinatı
            tmpY = ch4Coord[0, 0, 1];
            New_ch4Coord[0, 0, 1] = _y;
            dY = New_ch4Coord[0, 0, 1] - tmpY;

            for (int i = 1; i < 5; i++)
            {
                New_ch4Coord[i, 0, 1] = ch4Coord[i, 0, 1] + dY;
            }
        }
        public void WriteCoord()    
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Mustafa\Desktop\CH4.txt"))
            {


                for (int x = 0; x < 5; x++)
                {

                    for (int z = 0; z < 3; z++)
                    {
                        double value = New_ch4Coord[x, 0, z];
                        sw.Write($"{value} ");
                    }
                    sw.WriteLine("");


                }

            }
            Array.Clear(New_ch4Coord);

        }
    }
}
