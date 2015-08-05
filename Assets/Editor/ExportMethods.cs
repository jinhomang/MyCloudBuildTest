using UnityEditor;
using UnityEngine;
using System.Collections;


public class ExportMethods {

	[MenuItem ("MyMenu/ChangeRed")]
	public static void ChangeRed() {
		Material myMat = AssetDatabase.LoadAssetAtPath("Assets/matCube.mat", typeof(Material)) as Material;
		myMat.color = Color.red;
	}

	[MenuItem ("MyMenu/ChangeGreen")]
	public static void ChangeGreen() {
		Material myMat = AssetDatabase.LoadAssetAtPath("Assets/matCube.mat", typeof(Material)) as Material;
		myMat.color = Color.green;
	}

	
	public static void Post(string path) {
	
	}
}
