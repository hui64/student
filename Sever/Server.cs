using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using System.Collections;
using System.Threading; 


public class Server : MonoBehaviour
{  
		public  Socket socket;

		public   string words;
		public UITextList myTextList;

		Dictionary<string,Socket> dic = new Dictionary<string, Socket> ();

		public void showMSG ()
		{
				myTextList.Add (words);
		}
		void ReceiveMsg (object o)
		{
				//yield return new WaitForSeconds (0.5f);
				//object o = new object ();
				Socket client = o as Socket;
				while (true) {
						try {
								
								byte[] buffer = new byte[1024 * 1024];
								int n = client.Receive (buffer);
								print ("服务器接收消息");
								string words = Encoding.UTF8.GetString (buffer, 0, n);
								//showMSG ();
								SendMsgToClinet (client.RemoteEndPoint.ToString (), "服务器收到：" + words);
								print (client.RemoteEndPoint.ToString () + ":" + words);
						} catch (Exception ex) {
								print (ex.Message);
								break;
						}
				}
		}
		public void SendMsgToClinet (string ip, string mySting)
		{
				try {
						byte[] buffer = Encoding.UTF8.GetBytes (mySting);
						dic [ip].Send (buffer);
				} catch (Exception ex) {
						print (ex.Message);
				}
		}
		//Thread thread = new Thread (AcceptInfo); 
		public 	void ServerStart ()
		{

				IPAddress ip = IPAddress.Parse ("127.0.0.1");
				print (ip);
				int port = 1050;
				IPEndPoint point = new IPEndPoint (ip, port);
				socket = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				try {
						socket.Bind (point);
						socket.Listen (10);
						print ("服务器开始监听");
						//AcceptInfo (socket);
						Thread thread = new Thread (AcceptInfo); 
						thread.IsBackground = true;
						thread.Start (socket);
				} catch (Exception ex) {
						print (ex.Message);
				}
		}
		void  AcceptInfo (object o)
		{
				//yield return new WaitForSeconds (0.5f);
				//object o = new object ();
				Socket socket = o as Socket;
				while (true) {
						try {
								Socket tSocket = socket.Accept ();
								string point = tSocket.RemoteEndPoint.ToString ();
								print (point + "连接成功");
								dic.Add (point, tSocket);
								//ReceiveMsg (tSocket);
								Thread th = new Thread (ReceiveMsg);
								th.Start (tSocket);
						} catch (Exception ex) {
								print (ex);
								break;
						}
				}
		}

		public 	void OnDisable ()
		{
				socket.Close ();
				//StopAllCoroutines ();
				//tSocket.Close ();
				print ("关闭服务器");
		}
		void Update ()
		{
		}


}
