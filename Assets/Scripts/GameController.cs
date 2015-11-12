using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	// the hazards that will come down the right left and middle
	public GameObject hazard1;
	public GameObject hazard2;
	public GameObject hazard3;
	public GameObject hazard4;
	public GameObject hazard5;
	public GameObject hazard6;

	
	public Vector3 spawnValues;
	public float startWait;
	public float waveWait;

	void Start()
	{
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);

		//row 1
		Vector3 spawnPosition1 = new Vector3 (-6.0f, spawnValues.y, spawnValues.z);
		Vector3 spawnPosition2 = new Vector3 (-4.0f, spawnValues.y, spawnValues.z);
		Vector3 spawnPosition3 = new Vector3 (-2.0f, spawnValues.y, spawnValues.z);
		Vector3 spawnPosition4 = new Vector3 (0.0f, spawnValues.y, spawnValues.z);
		Vector3 spawnPosition5 = new Vector3 (2.0f, spawnValues.y, spawnValues.z);
		Vector3 spawnPosition6 = new Vector3 (4.0f, spawnValues.y, spawnValues.z);
		Vector3 spawnPosition7 = new Vector3 (6.0f, spawnValues.y, spawnValues.z);

		Quaternion spawnRotation = Quaternion.identity;

		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);


		yield return new WaitForSeconds (waveWait);

		// row 2

		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 3
	
		Instantiate (hazard1, spawnPosition2, spawnRotation);
		Instantiate (hazard2, spawnPosition3, spawnRotation);
		Instantiate (hazard3, spawnPosition4, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 4

		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 5
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition5, spawnRotation);
		Instantiate (hazard6, spawnPosition6, spawnRotation);

		yield return new WaitForSeconds (waveWait);


		// row 6
		
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 7
		
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition3, spawnRotation);
		Instantiate (hazard3, spawnPosition4, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 8

		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition5, spawnRotation);
		Instantiate (hazard6, spawnPosition6, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 9

		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition4, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 10

		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 11
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition5, spawnRotation);
		Instantiate (hazard6, spawnPosition6, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 12
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 13
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition3, spawnRotation);
		Instantiate (hazard3, spawnPosition4, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 14
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition3, spawnRotation);
		Instantiate (hazard3, spawnPosition4, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 15
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition4, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 16
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition5, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 17
			
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition5, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 18
		
		Instantiate (hazard1, spawnPosition2, spawnRotation);
		Instantiate (hazard2, spawnPosition3, spawnRotation);
		Instantiate (hazard3, spawnPosition4, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 19
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition4, spawnRotation);
		Instantiate (hazard5, spawnPosition5, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

		// row 20
		
		Instantiate (hazard1, spawnPosition1, spawnRotation);
		Instantiate (hazard2, spawnPosition2, spawnRotation);
		Instantiate (hazard3, spawnPosition3, spawnRotation);
		Instantiate (hazard4, spawnPosition5, spawnRotation);
		Instantiate (hazard5, spawnPosition6, spawnRotation);
		Instantiate (hazard6, spawnPosition7, spawnRotation);

		yield return new WaitForSeconds (waveWait);

	}





	

}
