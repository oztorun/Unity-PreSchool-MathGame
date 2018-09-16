using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour
{
	public GameObject[] pickups;				// Array of pickup prefabs with the bomb pickup first and health second.
	public float pickupDeliveryTime = 5f;		// Delay on delivery.
	public float dropRangeLeft;					// Smallest value of x in world coordinates the delivery can happen at.
	public float dropRangeRight;				// Largest value of x in world coordinates the delivery can happen at.
	public float highHealthThreshold = 75f;		// The health of the player, above which only bomb crates will be delivered.
	public float lowHealthThreshold = 25f;		// The health of the player, below which only health crates will be delivered.
    public static int bmbCount=1;

	private PlayerHealth playerHealth;			// Reference to the PlayerHealth script.
    Bomb explodeCount = new Bomb();

    void Awake ()
	{
        Sprite number1 = Resources.Load<Sprite>("number1"); //pickup spawner'ın 1 görselinden başlatır.
        SpriteRenderer _spriteRenderer;
        _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
        _spriteRenderer.sprite = number1;
        // Setting up the reference.
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
	}


	void Start ()
	{
        // Start the first delivery.
        StartCoroutine(DeliverPickup());

      
	}


    public IEnumerator DeliverPickup()
    {
        if (LayBombs.bombCount == 0)
        {
            // Wait for the delivery delay.
            yield return new WaitForSeconds(pickupDeliveryTime);

            // Create a random x coordinate for the delivery in the drop range.
            float dropPosX = Random.Range(dropRangeLeft, dropRangeRight);

            // Create a position with the random x coordinate.
            Vector3 dropPos = new Vector3(dropPosX, 15f, 1f);

            // If the player's health is above the high threshold...
            if (playerHealth.health >= highHealthThreshold)
            // ... instantiate a bomb pickup at the drop position.
            {
                SpriteRenderer _spriteRenderer;
                switch (bmbCount)
                {
                    case 2:
                        {
                            Sprite number2 = Resources.Load<Sprite>("number2");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number2;
                            break;
                        }
                    case 3:
                        {
                            Sprite number3 = Resources.Load<Sprite>("number3");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number3;
                            break;
                        }
                    case 4:
                        {
                            Sprite number4 = Resources.Load<Sprite>("number4");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number4;
                            break;
                        }
                    case 5:
                        {
                            Sprite number5 = Resources.Load<Sprite>("number5");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number5;
                            break;
                        }
                    case 6:
                        {
                            Sprite number6 = Resources.Load<Sprite>("number6");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number6;
                            break;
                        }
                    case 7:
                        {
                            Sprite number7 = Resources.Load<Sprite>("number7");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number7;
                            break;
                        }
                    case 8:
                        {
                            Sprite number8 = Resources.Load<Sprite>("number8");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number8;
                            break;
                        }
                    case 9:
                        {
                            Sprite number9 = Resources.Load<Sprite>("number9");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number9;
                            break;
                        }
                    case 10:
                        {
                            Sprite number10 = Resources.Load<Sprite>("number10");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number10;
                            break;
                        }
                    default:
                        {
                            Sprite number1 = Resources.Load<Sprite>("number1");
                            _spriteRenderer = pickups[0].GetComponentInChildren<SpriteRenderer>();
                            _spriteRenderer.sprite = number1;
                            break;
                        }
                }

                Instantiate(pickups[0], dropPos, Quaternion.identity);
            }
            // Otherwise if the player's health is below the low threshold...
            else if (playerHealth.health <= lowHealthThreshold)
                // ... instantiate a health pickup at the drop position.
                Instantiate(pickups[1], dropPos, Quaternion.identity);
            // Otherwise...
            else
            {
                // ... instantiate a random pickup at the drop position.
                int pickupIndex = Random.Range(0, pickups.Length);
                //renderer.sprite = Resources.Load<Sprite>("Sprites/MySprite");
                Instantiate(pickups[pickupIndex], dropPos, Quaternion.identity);
            }
        }

    }
}
