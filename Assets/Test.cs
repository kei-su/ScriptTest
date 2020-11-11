using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
	void Start()
	{
		int[] array = {10, 20, 30, 40, 50};

		for(int i = 0; i < array.Length; i++)
		{
			Debug.Log(array [i]);
		}
	}

	void Update()
	{

	}
}