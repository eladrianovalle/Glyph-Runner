using UnityEngine;
using System.Collections;

public class ChangeSizeOnInput : MonoBehaviour {

	public PlayerCharacter player;
	
	void Update () {

		// increase character size
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			
			if (player.charSize < 3) { 
				
				print ("I'm size" + player.charSize + "and pressed up!");
				player.charSize += 1;
				AudioSource.PlayClipAtPoint(player.grow, this.transform.position, player.sfxVolume);

			}

			player.SizeChange();

		}

		// decrease character size
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			
			if (player.charSize > 1) { 
				
				print ("I'm size" + player.charSize + "and pressed down!");
				player.charSize -= 1;
				AudioSource.PlayClipAtPoint(player.shrink, this.transform.position, player.sfxVolume);

			}	

			player.SizeChange();

		}

	}

}
