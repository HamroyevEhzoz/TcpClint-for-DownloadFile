using System.Net.Sockets;

TcpClient client = new TcpClient("192.168.4.169", 2222);

NetworkStream stream = client.GetStream();


FileStream newFile = new FileStream("D://DownloadedNewFile.mp3", FileMode.CreateNew);

FileCopyTo(newFile, stream);

newFile.Close();


void FileCopyTo(Stream Dstream , Stream Sstream)
{
    int i = 0;

    while((i = Sstream.ReadByte())!=-1)
    {
          Dstream.WriteByte((byte)i);  
    }
}


