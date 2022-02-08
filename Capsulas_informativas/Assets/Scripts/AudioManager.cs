using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource fire1Effect;
    public AudioSource fire2Effect;
    public AudioSource fire3Effect;
    public AudioSource jumpEffect;
    public AudioSource backgroundEffect;
    public static AudioManager Instance;
    public void Awake()
    {
        Instance = this;

    }
    public enum SoundEffect
    {
        Fire1,
        Fire2,
        Fire3,
        Jump
    }
    public enum BackgroundEffect{
        background
    }

   public void PlaySoundEffects(SoundEffect type)
    {
        switch(type)
        {
            case SoundEffect.Fire1:
                fire1Effect.Play();
                break;
            case SoundEffect.Fire2:
                fire2Effect.Play();
                break;
            case SoundEffect.Fire3:
                fire3Effect.Play();
                break;
            case SoundEffect.Jump:
                jumpEffect.Play();
                break;
        }
    }

    public void PlayBackgroundEffect(BackgroundEffect type)
    {
        switch(type)
        {
            case BackgroundEffect.background:
                backgroundEffect.Play();
                break;
        }
    }
}
