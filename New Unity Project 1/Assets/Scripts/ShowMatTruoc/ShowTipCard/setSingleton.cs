using UnityEngine;
using System.Collections;

namespace MatTruoc {
	public class setSingleton {
	
		static private setSingleton _instance;
		private string text;
		
		private setSingleton() {
			text = "dskljldkjs";
		}
		
		public string getText() {
			return text;
		}
		
		public void setText(string t) {
			text = t;
		}
			
		static public setSingleton Instance {
			get{
				if (_instance != null) {
					return _instance;
				}
				else {
					return new setSingleton();
				}
			}
		}
	}
}