using UnityEngine;
using System.Collections;

public class ThrowTrigger : MonoBehaviour
{
	public GUITexture crosshair;
	public GUIText textHints;

	void OnTriggerEnter( Collider col )
	{		
		if( col.gameObject.tag == "Player" )
		{
			if( !CoconutWin.haveWon )
			{
				textHints.SendMessage( "ShowHint", 
					"\n\n\n\n\nThere's a power cell attached in this game \nmaybe I'll win it if I can knock down all the targets...");
			}
			CoconutThrower.canThrow = true;
			crosshair.enabled = true;

		}
	}

	void OnTriggerExit( Collider col )
	{
		if( col.gameObject.tag == "Player" )
		{
			CoconutThrower.canThrow = false;
			crosshair.enabled = false;
		}
	}

}
