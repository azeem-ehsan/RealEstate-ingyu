using UnityEngine;

public class Door : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player entered the trigger");
            LeanTween.rotateY(gameObject, -17, 1f).setEase(LeanTweenType.easeOutQuad).setOnComplete(() => {
                Invoke("CloseDoor", 2f);
            });
        }
    }

    void CloseDoor()
        {
                LeanTween.rotateY(gameObject, 85, 1f).setEase(LeanTweenType.easeOutQuad);

        }
}
