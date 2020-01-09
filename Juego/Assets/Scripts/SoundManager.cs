using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip choqueFuego, DisparoFuego, INFERNAL, 
                            MuerteBoss, PowerUp,Vida, aplastar,
                            tornado, Save, hurt, lava;
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
        aplastar = Resources.Load<AudioClip>("Aplastar");
        tornado = Resources.Load<AudioClip>("Tornado");
        Save = Resources.Load<AudioClip>("Save");
        hurt = Resources.Load<AudioClip>("classic_hurt");
        lava = Resources.Load<AudioClip>("lava");

        audioSrc = GetComponent<AudioSource>();
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
            case "Aplastar":
                audioSrc.PlayOneShot(aplastar);
                break;
            case "Tornado":
                audioSrc.PlayOneShot(tornado);
                break;
            case "Save":
                audioSrc.PlayOneShot(Save);
                break;
            case "classic_hurt":
                audioSrc.PlayOneShot(hurt);
                break;
            case "lava":
                audioSrc.PlayOneShot(lava);
                break;
        }
    }
}
