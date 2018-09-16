using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;					// The player's score.


	private PlayerControl playerControl;	// Reference to the player control script.
	private int previousScore = 0;			// The score in the previous frame.

    public AudioSource m_MyBasicAudioSource; //"Sayı1'e ulaştınız" sesi için Score adlı gameobject'in kendi öz audio source componenti

    public int position = 0;
    public int samplerate = 44100;
    public float frequency = 440;

    void Awake ()
	{
		// Setting up the reference.
		playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();

    }


    void Update()
    {
        // Set the score text.
        GetComponent<GUIText>().text = "Sayı: " + score;

        // If the score has changed...
        if (previousScore != score)
            // ... play a taunt.
            playerControl.StartCoroutine(playerControl.Taunt());

        // Set the previous score to this frame's score.
        previousScore = score;

        if ((previousScore + 1) == 1)
        {
            m_MyBasicAudioSource = GetComponent<AudioSource>(); 
            m_MyBasicAudioSource.Play();
        }

        if ((previousScore + 1) == 2)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 2");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }

        }

        if ((previousScore + 1) == 3)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 3");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }

        if ((previousScore + 1) == 4)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 4");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }

        if ((previousScore + 1) == 5)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 5");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }

        if ((previousScore + 1) == 6)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 6");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }


        if ((previousScore + 1) == 7)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 7");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }


        if ((previousScore + 1) == 8)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 8");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }


        if ((previousScore + 1) == 9)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 9");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }


        if ((previousScore + 1) == 10)
        {
            var temp = GameObject.FindGameObjectsWithTag("Sayı 10");
            AudioSource[] _audioSources;
            _audioSources = new AudioSource[temp.Length];
            for (int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i] = temp[i].GetComponent<AudioSource>();
            }
            foreach (AudioSource aS in _audioSources)
            {
                aS.Play();
            }
        }

        /*   m_MyAudioSource = GetComponent<AudioSource>();
           AudioClip myClip = AudioClip.Create("sayi2", samplerate * 2, 1, samplerate, true, OnAudioRead, OnAudioSetPosition);
           myClip = (AudioClip)Resources.Load("sayi2");
           m_MyAudioSource.PlayOneShot(myClip);
       }

       void OnAudioRead(float[] data)
       {
           int count = 0;
           while (count < data.Length)
           {
               data[count] = Mathf.Sign(Mathf.Sin(2 * Mathf.PI * frequency * position / samplerate));
               position++;
               count++;
           }
       }

       void OnAudioSetPosition(int newPosition)
       {
           position = newPosition;
       }

       */
    }


}
