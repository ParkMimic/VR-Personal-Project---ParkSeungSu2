using UnityEngine;

public class TrashTrigged : MonoBehaviour
{
    public GameObject trashType;
    public AudioClip audioClip;
    private AudioSource audioSource;

    private void Start()
    {
        AudioClip audioClip = GetComponent<AudioClip>();
        AudioSource audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            Rigidbody trash = other.GetComponent<Rigidbody>();

            if (other.gameObject == trashType)
            {
                other.gameObject.SetActive(false);
            }
            else
            {
                trash.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
        }
    }
}
