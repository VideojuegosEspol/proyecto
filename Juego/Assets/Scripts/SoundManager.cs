using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip choqueFuego, DisparoFuego, INFERNAL, MuerteBoss, PowerUp,Vida;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        choqueFuego = Resources.Load<AudioClip>("ChoqueFuego");
        DisparoFuego = Resources.Load<AudioClip>("DisparoFuego");
        INFERNAL = Resources.Load<AudioClip>("INFERNAL");
        MuerteBoss = Resources.Load<AudioClip>("MuerteBoss");
        PowerUp = Resources.Load<AudioClip>("PowerUpMedallon");
        Vida = Resources.Load<AudioClip>("Vida");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip){
            case "ChoqueFuego":
                audioSrc.PlayOneShot(choqueFuego);
                break;
            case "DisparoFuego":
                audioSrc.PlayOneShot(DisparoFuego);
                break;
            case "INFERNAL":
                audioSrc.PlayOneShot(INFERNAL);
                break;
            case "MuerteBoss":
                audioSrc.PlayOneShot(MuerteBoss);
                break;
            case "PowerUpMedallon":
                audioSrc.PlayOneShot(PowerUp);
                break;
            case "Vida":
                audioSrc.PlayOneShot(Vida);
                break;
        }
    }
}
