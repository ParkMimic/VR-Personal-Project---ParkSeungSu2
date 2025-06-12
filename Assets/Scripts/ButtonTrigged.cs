using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonTrigged : MonoBehaviour
{
    private Renderer ori_mat;

    private void Start()
    {
        ori_mat = gameObject.GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("rightHand"))
        {
            ori_mat.material.color = Color.yellow;
        }
    }
}