
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


    public class takebox : MonoBehaviour
    {
  
    public GameObject boxx1;
    public GameObject boxx2;
    public GameObject boxx3;
    public GameObject boxx4;
    public GameObject boxx5;
    int count = 0;
    public GameObject complitelevelUI;
    public GameObject ppp;
    public GameObject a;
    public GameObject b;
    private void OnTriggerEnter(Collider other)
    {
        Cursor.visible = false;
        if (other.gameObject.CompareTag("box1"))
        {

            count += 1;
            Debug.Log(count);
            boxx1.SetActive(false);

        }
        if (other.gameObject.CompareTag("box2"))
        {

            count += 1;
            Debug.Log(count);
            boxx2.SetActive(false);
        }
        if (other.gameObject.CompareTag("box3"))
        {

            count += 1;
            Debug.Log(count);
            boxx3.SetActive(false);
        }
        if (other.gameObject.CompareTag("box4"))
        {

            count += 1;
            Debug.Log(count);
            boxx4.SetActive(false);
        }
        if (other.gameObject.CompareTag("box5"))
        {

            count += 1;
            Debug.Log(count);
            boxx5.SetActive(false);
        }
        if (count == 5)
        {
           // Time.timeScale = 1f;
           // SceneManager.LoadScene("Menu");
           // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            complitelevelUI.SetActive(true);
            ppp.SetActive(false);
           a.SetActive(false);
           b.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        }

    }
