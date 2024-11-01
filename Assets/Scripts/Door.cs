using UnityEngine;

public class Door : MonoBehaviour
{
    public bool openInside = true;  // True = open inside, False = open outside

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player entered the trigger");

            // Decide rotation angle based on the direction of opening
            float targetRotation = openInside ? -17f : 17f;

            LeanTween.rotateY(gameObject, targetRotation, 1f).setEase(LeanTweenType.easeOutQuad).setOnComplete(() => {
                Invoke("CloseDoor", 2f);
            });
        }
    }
    

    // void CloseDoor()
    // {
    //     LeanTween.rotateY(gameObject, 85, 1f).setEase(LeanTweenType.easeOutQuad);
    // }
}
