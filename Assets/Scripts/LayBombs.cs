using System.Collections;
    using UnityEngine;

public class LayBombs : MonoBehaviour
{
	[HideInInspector]
	public bool bombLaid = false;		// Whether or not a bomb has currently been laid.
	public static int bombCount = 0;			// How many bombs the player has.
	public AudioClip bombsAway;			// Sound for when the player lays a bomb.
	public GameObject bomb;				// Prefab of the bomb.
    public static int HUDcount = 1;

	private GUITexture bombHUD;			// Heads up display of whether the player has a bomb or not.


	void Awake ()
	{
        // Setting up the reference.
        bombHUD = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
    }


	void Update ()
	{
		// If the bomb laying button is pressed, the bomb hasn't been laid and there's a bomb to lay...
		if(Input.GetButtonDown("Fire2") && !bombLaid && bombCount > 0)
		{
			// Decrement the number of bombs.
			bombCount=0;

			// Set bombLaid to true.
			bombLaid = true;

			// Play the bomb laying sound.
			AudioSource.PlayClipAtPoint(bombsAway,transform.position);

			// Instantiate the bomb prefab.
			Instantiate(bomb, transform.position, transform.rotation);
		}

        GUITexture _GUITexture;
        switch (HUDcount)
        {
            case 2:
                {
                    Texture number2 = Resources.Load<Texture>("number2");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number2;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 3:
                {
                    Texture number3 = Resources.Load<Texture>("number3");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number3;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 4:
                {
                    Texture number4 = Resources.Load<Texture>("number4");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number4;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 5:
                {
                    Texture number5 = Resources.Load<Texture>("number5");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number5;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 6:
                {
                    Texture number6 = Resources.Load<Texture>("number6");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number6;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 7:
                {
                    Texture number7 = Resources.Load<Texture>("number7");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number7;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 8:
                {
                    Texture number8 = Resources.Load<Texture>("number8");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number8;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 9:
                {
                    Texture number9 = Resources.Load<Texture>("number9");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number9;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            case 10:
                {
                    Texture number10 = Resources.Load<Texture>("number10");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number10;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
            default:
                {
                    Texture number1 = Resources.Load<Texture>("number1");
                    _GUITexture = GameObject.Find("ui_bombHUD").GetComponent<GUITexture>();
                    _GUITexture.texture = number1;
                    bombHUD.enabled = bombCount > 0;
                    break;
                }
        }

        // The bomb heads up display should be enabled if the player has bombs, other it should be disabled.
        //bombHUD.enabled = bombCount > 0;
	}
}
