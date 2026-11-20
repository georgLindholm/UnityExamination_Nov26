using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] collectionSounds;
    [SerializeField] private AudioClip damageSound;

    public void PlayHitSound()
    {
        audioSource.PlayOneShot(damageSound);
    }

    public void PlayCollectionSounds()
    {
        audioSource.PlayOneShot(collectionSounds[Random.Range(0, collectionSounds.Length)]);
    }
}
