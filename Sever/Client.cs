using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using System.Collections;
using System.Threading; 

public class Client : MonoBehaviour
{
		public UIInput myInput;
		public UITextList myTextList;
		Socket client = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		/// <summary>
		/// Cons the server.连接到服务器
		/// </summary>
		public	void ConServer ()
		{
			
				IPAddress ip = IPAddress.Parse ("127.0.0.1");
				int port = 1050;
				IPEndPoint point = new IPEndPoint (ip, port);
				try {
						//连接到服务器
						client.Connect (point);
						print ("连接成功");
						print ("服务器" + client.RemoteEndPoint.ToString ());
						print ("客户端:" + client.LocalEndPoint.ToString ());
						//连接成功后，就可以接收服务器发送的信息了
						Thread th = new Thread (ReceiveMsg);
						th.IsBackground = true;
						th.Start ();
				} catch (Exception ex) {
						print (ex.Message);
				}
		}
		/// <summary>
		/// Receives the message.接收服务器消息
		/// </summary>
		public 	void ReceiveMsg ()
		{
				while (true) {
						try {
								byte[] buffer = new byte[1024 * 1024];
								int n = client.Receive (buffer);
								string s = Encoding.UTF8.GetString (buffer, 0, n);
								//myTextList.Add (client.RemoteEndPoint.ToString () + ":" + s);
								print (client.RemoteEndPoint.ToString () + ":" + s);
						} catch (Exception ex) {
								print (ex.Message);
								break;
						}

				}
		}


		/// <summary>
		/// Sends the message.发送消息到服务器
		/// </summary>
		public 	void SendMsg ()
		{

				string msg = "你好";
				//myInput.value = "";
				try {
						byte[] buffer = Encoding.UTF8.GetBytes (msg);
						client.Send (buffer);
						print ("客户发送");
				} catch (Exception ex) {
						print (ex.Message);
				}
		}

		/// <summary>
		/// Raises the disable event.断开连接
		/// </summary>
		public void OnDisable ()
		{
				client.Close ();
		}
}
