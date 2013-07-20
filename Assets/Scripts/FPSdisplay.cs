using UnityEngine;
using System.Collections;
[RequireComponent(typeof(GUIText))]

public class FPSdisplay : MonoBehaviour
{
	private float frames = 0;
	private float fps = 0;

	// Use this for initialization
	void Start()
	{
		frames++;
		fps = Mathf.Round(frames / Time.realtimeSinceStartup);
		guiText.text = "Frames Per Second: " + fps;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
