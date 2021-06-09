
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;


namespace PizzaLab.Data.Common.Helpers
{
    public class FileHelper
    {
        //podavam mu direktoriqta dataDir na syrvyra v koqto shte se syzdade papka za elementite ot byte array vyv json ot json vyv obekt na syrvera 
        // servera otiva v kontrolera i mi prevryshta json obekta v kartinka 
        public static string ConvertByteArrayToFile(string dataDir, MediaItemDto mediaFile)
           
        {
            if (mediaFile == null || mediaFile.Data == null
                || mediaFile.MediaType.Length == 0 || mediaFile.Data == null)
            {
                return String.Empty;
            }

            if (!File.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }

            StringBuilder fileName = new StringBuilder();
            fileName.Append(dataDir);
            fileName.Append("\\");
            fileName.Append(mediaFile.Name);
            fileName.Append(".");
            fileName.Append(mediaFile.MediaType);

            using (FileStream fs = File.Create(fileName.ToString()))
            {
                fs.Write(mediaFile.Data, 0, mediaFile.Data.Length);
            }

            return (fileName.ToString());
        }


		public static byte[] GetBytesFromFile(string fullFilePath)
		{
			// this method is limited to 2^32 byte files (4.2 GB)

			FileStream fs = File.OpenRead(fullFilePath);
			byte[] bytes = new byte[fs.Length];
			try
			{

				fs.Read(bytes, 0, Convert.ToInt32(fs.Length));

			}
			finally
			{
				fs.Close();
			}
			return bytes;

		}
	}
}
